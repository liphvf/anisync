using System.Net.Http.Json;
using anisync.Models.Kitsu;
using anisync.Models.Kitsu.AnimeData;
using anisync.Models.Kitsu.AnimeMangaGenericReponse;
using anisync.Models.Kitsu.StructuredModels;
using Anisync.GraphQL;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

public class Program
{
    private static async Task Main(string[] args)
    {
        // Console.WriteLine("Olá esse aplicativo é utilizado para sincronizar seus animes do kitsu para anilist");
        // Console.WriteLine("Para começar primeiro precisamos de autorização para acessar sua biblioteca. Para isso acesse:");
        // Console.WriteLine("https://anilist.co/api/v2/oauth/authorize?client_id=7703&redirect_uri=https://anilist.co/api/v2/oauth/pin&response_type=code");
        // Console.WriteLine("Após autenticar, copie o código e cole abaixo:");

        // var anilistCode = Console.ReadLine();
        // Console.WriteLine("Nome do usuário: ");

        // var nomeUsuario = Console.ReadLine();
        var nomeUsuario = "liphvf";




        var serviceCollection = new ServiceCollection();

        serviceCollection
            .AddAnisyncClient()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://graphql.anilist.co/"));

        IServiceProvider services = serviceCollection.BuildServiceProvider();

        var client = services.GetRequiredService<IAnisyncClient>();


        // var result = await client.GetAnimeByName.ExecuteAsync("Naruto");

        // foreach (var item in result)
        // {

        // }

        // var xu = await client.GetSessions.ExecuteAsync();
        // xu.EnsureNoErrors();

        // foreach (var session in xu.Data.Sessions.Nodes)
        // {
        //     Console.WriteLine(session.Title);
        // }


        var urlPegarNomeUsuario = $"https://kitsu.io/api/edge/users?filter[name]={nomeUsuario}&fields[users]=id";

        var httpClient = new HttpClient();

        var usuario = await httpClient.GetFromJsonAsync<ResponseKitsu<GetUserByNicknameResponse>>(urlPegarNomeUsuario);

        Console.WriteLine("");


        // var libraryEntriesDatas = new List<GetLibraryEntriesReponse>();

        // var proximaPaginaLink = $"https://kitsu.io/api/edge/users/{usuario?.Data!.First().Id}/library-entries/?fields%5Banime%5D=slug%2CcanonicalTitle%2Ctitles&fields%5BlibraryEntries%5D=createdAt,updatedAt,status,progress,volumesOwned,reconsuming,reconsumeCount,notes,private,reactionSkipped,progressedAt,startedAt,finishedAt,rating,ratingTwenty,anime,manga&fields%5Bmanga%5D=slug%2CcanonicalTitle%2Ctitles&filter%5Bkind%5D=anime,manga&page%5Boffset%5D=0&page%5Blimit%5D=500&include=anime,manga";
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
            // libraryEntriesDatas.AddRange(libraryEntries.Data!);

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

        // var animesEntries = libraryEntriesDatas.Where(e => e.relationships.anime.Data != null).Select(a => new AnimeEntry
        // {
        //     EntryId = a.id,
        //     EntryAttribute = a.attributes,
        //     AnimeAttribute = a.included.Single(x => a.relationships.anime.Data.id == a.id).attributes
        // }).ToList();

        // var mangasEntries = libraryEntriesDatas.Where(e => e.relationships.manga.Data != null).Select(m => new MangaEntry
        // {
        //     EntryId = m.id,
        //     EntryAttribute = m.attributes,
        //     MangaAttribute = m.included.Single(x => m.relationships.manga.Data.id == m.id).attributes
        // }).ToList();

        // animesEntries.First().attributes.canonicalTitle.con

        Console.WriteLine($"animes total: {animeEntries.Count}");
        Console.WriteLine($"manga total: {mangaEntries.Count}");
    }
}

// Console.WriteLine("hello");