using System.Linq;
using System.Net.Http.Json;
using anisync.Models.Kitsu;
using GraphQL.Client;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;
using System.Net;

Console.WriteLine("Olá esse aplicativo é utilizado para sincronizar seus animes do kitsu para anilist");
Console.WriteLine("Para começar primeiro precisamos de autorização para acessar sua biblioteca. Para isso acesse:");
Console.WriteLine("https://anilist.co/api/v2/oauth/authorize?client_id=7703&redirect_uri=https://anilist.co/api/v2/oauth/pin&response_type=code");
Console.WriteLine("Após autenticar, copie o código e cole abaixo:");

// var anilistCode = Console.ReadLine();

var anilistCode = "def502002156abde6b81b087501ecfcd1e3af007ecb372e528dda30f3a004592d8254c8d9b75d61fe51e4dccf696b17c3b75622ea76d510eb66bee42072b0a487c645bfaec2271d18b3b5223cf8889e89e347fcde3b003f1d288d3b9b700fa26af0fd9c22748d6e3f556b04dd0d69270c619991437606af254e4056c23a2d54fe3e61c2858b671a69d5ec750f3a6a7ac0ca32e97847fca847b8cb6bf05a82eb88b72a29fb8d00c75d4e969b521fd134fde27033104ff12e0baedfe3e88e894236d715c24fc0bc1d14238c7913605aa8577821b5f76b833f8db9a21f8afd30c0553fe3c51812b9de3e1a42ed6eaaafc3b3ec5ece420c2bfbf0fb0c9b0600736879321f92ce3abccf82bc34eae3f29290852516ecc01d883a17570808d59a14171c2d4cb38cc5e61638cba64117c12bf3985ff575f4e711d597e8bd46252a434ede19bda82cdbf26c288769c79a08ee026aa2109fb6b2614f884b55a0b145b6554d82847528717aa078ab25998bea7608e4d";


IServiceCollection serviceCollection = new ServiceCollection();

serviceCollection.AddGraphQlClient(StrawberryShake.ExecutionStrategy.NetworkOnly).ConfigureHttpClient(e => e.BaseAddress = new Uri("https://graphql.anilist.co/"));

IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

IGraphQlClient client = serviceProvider.GetRequiredService<IGraphQlClient>();

IOperationResult<IGetUserIdResult> result = await client.GetUserId.ExecuteAsync("liphvf");

if (result.IsErrorResult())
{
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
