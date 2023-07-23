using anisync.Models.Kitsu;
using anisync.Models.Kitsu.StructuredModels;
using AnySync.Brazor.Data;
using AnySync.Brazor.Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using AnySync.Brazor.Mappers;

namespace AnySync.Brazor.Services;

public class KitsuService
{
    private readonly DatabaseContext _databaseContext;
    public KitsuService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;

    }
    public async Task<(List<AnimeEntryDto> animes, List<MangaEntryDto> mangas)> GetEntries(string kitsuUserName)
    {
        var nomeUsuario = kitsuUserName;
        var httpClient = new HttpClient();
        var urlPegarNomeUsuario = $"https://kitsu.io/api/edge/users?filter[name]={nomeUsuario}&fields[users]=id";


        var usuario = await httpClient.GetFromJsonAsync<ResponseKitsu<GetUserByNicknameResponse>>(urlPegarNomeUsuario);

        var proximaPaginaLink = $"https://kitsu.io/api/edge/users/{usuario?.Data!.First().Id}/library-entries/?fields%5BlibraryEntries%5D=status,progress,volumesOwned,reconsuming,reconsumeCount,notes,private,progressedAt,startedAt,finishedAt,rating,ratingTwenty,anime,manga&filter%5Bkind%5D=anime,manga&page%5Boffset%5D=0&page%5Blimit%5D=500&include=anime,manga";

        var animeEntries = new List<AnimeEntryDto>();
        var mangaEntries = new List<MangaEntryDto>();

        var ultimaPaginaRodou = false;
        while (ultimaPaginaRodou == false)
        {
            var libraryEntries = await httpClient.GetFromJsonAsync<ResponseKitsu<GetLibraryEntriesReponse>>(proximaPaginaLink);

            if (libraryEntries == null)
            {
                throw new ApplicationException("Erro ao obter biblioteca");
            }

            var newAnimeEntries = libraryEntries.Data!.Where(e => e.relationships.anime.Data != null).Select(a => new AnimeEntryDto
            {
                EntryId = a.id,
                EntryAttribute = a.attributes,
                AnimeAttribute = libraryEntries.included.Single(x => a.relationships.anime.Data?.id == x.id).attributes
            }).ToList();

            if (newAnimeEntries.Any())
            {
                animeEntries.AddRange(newAnimeEntries);
            }

            var newMangaEntries = libraryEntries.Data!.Where(e => e.relationships.manga.Data != null).Select(m => new MangaEntryDto
            {
                EntryId = m.id,
                EntryAttribute = m.attributes,
                MangaAttribute = libraryEntries.included.Single(x => m.relationships.manga.Data?.id == x.id).attributes
            }).ToList();

            if (newMangaEntries.Any())
            {
                mangaEntries.AddRange(newMangaEntries);
            }

            if (libraryEntries.Links.Next != null)
            {
                proximaPaginaLink = libraryEntries.Links.Next;
                continue;
            }

            if (libraryEntries.Links.Next == null)
            {
                proximaPaginaLink = libraryEntries.Links.Last;
                ultimaPaginaRodou = true;
            }
        }
        await UpdateDatabase(kitsuUserName, animeEntries, mangaEntries);
        return (animeEntries, mangaEntries);
    }

    public async Task UpdateDatabase(string kitsuUserName, List<AnimeEntryDto> animesDto, List<MangaEntryDto> mangasDto)
    {
        var user = await _databaseContext.Users
        .Include(e => e.Library).ThenInclude(e => e.AnimesEntries)
        .Include(e => e.Library).ThenInclude(e => e.MangaEntries)
        .SingleOrDefaultAsync(u => u.KitsuUserName == kitsuUserName);

        if (user == default)
        {
            user = new User
            {
                KitsuUserName = kitsuUserName,
                Library = new Library
                {
                    AnimesEntries = new List<AnimeEntry>(),
                    MangaEntries = new List<MangaEntry>()
                }
            };

            _databaseContext.Add(user);
        }

        foreach (var animeDto in animesDto)
        {
            var entry = user.Library.AnimesEntries.SingleOrDefault(e => e.KitsuId == animeDto.EntryId);
            if (entry == default)
            {
                user.Library.AnimesEntries.Add(animeDto.MapNewAnimeEntry());
            }
            else
            {
                entry.MapOver(animeDto);
            }
        }

        await _databaseContext.SaveChangesAsync();
    }
}
