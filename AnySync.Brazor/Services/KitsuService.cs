using anisync.Models.Kitsu;
using anisync.Models.Kitsu.StructuredModels;

namespace AnySync.Brazor.Services;

public class KitsuService
{
    public async Task<(List<AnimeEntry> animes, List<MangaEntry> mangas)> GetEntries(string kitsuUserName)
    {
        var nomeUsuario = kitsuUserName;
        var httpClient = new HttpClient();
        var urlPegarNomeUsuario = $"https://kitsu.io/api/edge/users?filter[name]={nomeUsuario}&fields[users]=id";


        var usuario = await httpClient.GetFromJsonAsync<ResponseKitsu<GetUserByNicknameResponse>>(urlPegarNomeUsuario);

        var proximaPaginaLink = $"https://kitsu.io/api/edge/users/{usuario?.Data!.First().Id}/library-entries/?fields%5BlibraryEntries%5D=status,progress,volumesOwned,reconsuming,reconsumeCount,notes,private,progressedAt,startedAt,finishedAt,rating,ratingTwenty,anime,manga&filter%5Bkind%5D=anime,manga&page%5Boffset%5D=0&page%5Blimit%5D=500&include=anime,manga";

        var animeEntries = new List<AnimeEntry>();
        var mangaEntries = new List<MangaEntry>();

        var ultimaPaginaRodou = false;
        while (ultimaPaginaRodou == false)
        {
            var libraryEntries = await httpClient.GetFromJsonAsync<ResponseKitsu<GetLibraryEntriesReponse>>(proximaPaginaLink);

            if (libraryEntries == null)
            {
                throw new ApplicationException("Erro ao obter biblioteca");
            }

            var newAnimeEntries = libraryEntries.Data!.Where(e => e.relationships.anime.Data != null).Select(a => new AnimeEntry
            {
                EntryId = a.id,
                EntryAttribute = a.attributes,
                AnimeAttribute = libraryEntries.included.Single(x => a.relationships.anime.Data.id == x.id).attributes
            }).ToList();

            if (newAnimeEntries.Any())
            {
                animeEntries.AddRange(newAnimeEntries);
            }

            var newMangaEntries = libraryEntries.Data!.Where(e => e.relationships.manga.Data != null).Select(m => new MangaEntry
            {
                EntryId = m.id,
                EntryAttribute = m.attributes,
                MangaAttribute = libraryEntries.included.Single(x => m.relationships.manga.Data.id == x.id).attributes
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
        return (animeEntries, mangaEntries);
    }
}
