using System;
using GraphQL.Anilist;
using Microsoft.Extensions.DependencyInjection;
using StrawberryShake;

IServiceCollection serviceCollection = new ServiceCollection();

serviceCollection.AddGraphQlClient(StrawberryShake.ExecutionStrategy.NetworkOnly).ConfigureHttpClient(e => e.BaseAddress = new Uri("https://graphql.anilist.co/"));

IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

IGraphQlClient client = serviceProvider.GetRequiredService<IGraphQlClient>();

IOperationResult<IGetUserIdResult> result = await client.GetUserId.ExecuteAsync();

if (result.IsErrorResult())
{
    Console.WriteLine("falou");
}
else
{
    Console.WriteLine(result.Data?.User?.Id);
}