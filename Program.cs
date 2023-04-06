using System.Linq;
using System.Net.Http.Json;
using anisync.Models.Kitsu;
// using GraphQL.Client;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;
using System.Net;
using AnilistClient.Graphql;

Console.WriteLine("Olá esse aplicativo é utilizado para sincronizar seus animes do kitsu para anilist");
Console.WriteLine("Para começar primeiro precisamos de autorização para acessar sua biblioteca. Para isso acesse:");
Console.WriteLine("https://anilist.co/api/v2/oauth/authorize?client_id=7703&redirect_uri=https://anilist.co/api/v2/oauth/pin&response_type=code");
Console.WriteLine("Após autenticar, copie o código e cole abaixo:");

// var anilistCode = Console.ReadLine();


IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection
                .AddAnilistClient()
                .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://workshop.chillicream.com/graphql"));

            IServiceProvider services = serviceCollection.BuildServiceProvider();

            IAnilistClient client = services.GetRequiredService<IAnilistClient>();

// IServiceCollection serviceCollection = new ServiceCollection();
//     serviceCollection
//         .AddAnilistClient()
//         .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://workshop.chillicream.com/graphql"));

// serviceCollection.AddAnilistClient(StrawberryShake.ExecutionStrategy.NetworkOnly).ConfigureHttpClient(e => e.BaseAddress = new Uri("https://graphql.anilist.co/"));

// IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

// IGraphQlClient client = serviceProvider.GetRequiredService<IGraphQlClient>();

IOperationResult<IGetUserIdResult> result = await client.GetUserId.ExecuteAsync("liphvf");

if (result.IsErrorResult())
{
    var xuxu = result.Errors;
    Console.WriteLine("falou");
}
else
{
    Console.WriteLine(result.Data?.User?.Id);
}

var x = await client.GetAnimeByName.ExecuteAsync("naruto");

Console.WriteLine("Informe nome do usuário:");
// var nomeUsuario = Console.ReadLine();
var nomeUsuario = "liphvf";


var urlPegarNomeUsuario = $"https://kitsu.io/api/edge/users?filter[name]={nomeUsuario}&fields[users]=id";

var httpClient = new HttpClient();

var usuario = await httpClient.GetFromJsonAsync<ResponseKitsu<GetUserByNicknameResponse>>(urlPegarNomeUsuario);

Console.WriteLine("");



var libraryEntriesDatas = new List<GetLibraryEntriesReponse>();

var proximaPaginaLink = $"https://kitsu.io/api/edge/users/{usuario?.Data!.First().Id}/library-entries/?fields%5Banime%5D=slug%2CcanonicalTitle%2Ctitles&fields%5BlibraryEntries%5D=createdAt,updatedAt,status,progress,volumesOwned,reconsuming,reconsumeCount,notes,private,reactionSkipped,progressedAt,startedAt,finishedAt,rating,ratingTwenty,anime,manga&fields%5Bmanga%5D=slug%2CcanonicalTitle%2Ctitles&filter%5Bkind%5D=anime,manga&page%5Boffset%5D=0&page%5Blimit%5D=500&include=anime,manga";

var ultimaPaginaRodou = false;
while (ultimaPaginaRodou == false)
{
    var libraryEntries = await httpClient.GetFromJsonAsync<ResponseKitsu<GetLibraryEntriesReponse>>(proximaPaginaLink);

    if (libraryEntries == null)
    {
        throw new ApplicationException("Erro ao obter biblioteca");
    }
    libraryEntriesDatas.AddRange(libraryEntries.Data!);

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

var animesEntries = libraryEntriesDatas.Where(e => e.relationships.anime.Data != null).ToList();
var mangasEntries = libraryEntriesDatas.Where(e => e.relationships.manga.Data != null).ToList();

Console.WriteLine($"animes total: {animesEntries.Count}");
Console.WriteLine($"manga total: {mangasEntries.Count}");


// Buscar no anilist (buscar pelos 3 nomes)
// Achou? Atualiza / Insere
// Não achou? Gera uma relatória
