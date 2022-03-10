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

// var anilistCode = "def502005021d1c21d41985dc026a28adac184d40aee822d550c6f4f171dbd9457e03b0064174e749b0b739b82418640996086246bae730daeda9024b9f48d0e1ece4a54e3786d9270b58620e0a63c73a5cae3a24722c57c16a12392f2467a7b5ad96d2f04f9ec30d4e39bd38a7ba8b454e08da0eb847af2adbf01bc05432270f73d9827b270b3eb7d95fc4f7e89ec0b9b3e9153c624486d23b27284988637b4550685c2a371d052301b19a0d2e372753791c63a8fe07127bcafeb5a7c5d8fe5d5dc47b1846ef091a684b0a9473abc0cb3b6f5c065f4a97032dc6aac412aa7e0073ae0093528e34af51c0f987db94fd4384242c3d90661f79ad8d349efffe231df09e12fb95889d94ffcdaa2ee6dd5ac62b40b9eb9b107aa2a104c62b0d261777b285d9d054113e4ead94db5810022fcdc74e4d0ea636e313ff3466f15fca14d4067a90c3088d2fbb3367061c91040124d83cef591702843a472c03d1a51b6758986dd58c64de1e2bb1e7dfadfaf440c89";


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
