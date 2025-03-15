using System.Net.Http;
using System.Threading.Tasks;
using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using Xunit;
using Xunit.Abstractions;

namespace ExampleApp.Tests;

public class ProgramTest(ITestOutputHelper testOutputHelper) : IAsyncLifetime
{
    private IContainer _solrContainer;
    private int _solrPort;

    public async Task InitializeAsync()
    {
        _solrContainer = new ContainerBuilder()
            .WithImage("solr:9.8.1-slim")
            .WithCommand("-c")
            .WithPortBinding(8983, true)  // Bind port dynamically
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(8983))
            .Build();

        await _solrContainer.StartAsync();
        _solrPort = _solrContainer.GetMappedPublicPort(8983);
    }

    public async Task DisposeAsync() => await _solrContainer.StopAsync();

    [Fact]
    public async Task DemonstrateSolrClientUsage()
    {
        Configuration config = new Configuration
        {
            BasePath = $"http://localhost:{_solrPort}/api"
        };
        HttpClient httpClient = new HttpClient();
        HttpClientHandler httpClientHandler = new HttpClientHandler();

        // List config sets and confirm that the '_default' config set is present
        var configSetsApi = new ConfigsetsApi(httpClient, config, httpClientHandler);
        var configSets = await configSetsApi.ListConfigSetAsync();
        Assert.Contains("_default", configSets.ConfigSets);

        // Create a collection
        var collectionsApi = new CollectionsApi(httpClient, config, httpClientHandler);
        var createCollectionRequest = new CreateCollectionRequestBodyModel
        {
            Name = "mycollection",
            Config = "_default",
            NumShards = 1,
            ReplicationFactor = 1
        };
        await collectionsApi.CreateCollectionAsync(createCollectionRequest);
        Assert.Contains("mycollection", (await collectionsApi.ListCollectionsAsync()).Collections);

        // Create alias 'myalias' for collection 'mycollection'
        var aliasApi = new AliasesApi(config);
        await aliasApi.CreateAliasAsync(new CreateAliasRequestBodyModel("myalias", ["mycollection"]));

        // List aliases
        Assert.Contains("myalias", (await aliasApi.GetAliasesAsync()).Aliases.Keys);

        // Delete alias 'myalias'
        await aliasApi.DeleteAliasAsync("myalias");
        Assert.DoesNotContain("myalias", (await aliasApi.GetAliasesAsync()).Aliases.Keys);

        // Delete the collection
        await collectionsApi.DeleteCollectionAsync("mycollection");
        Assert.DoesNotContain("mycollection", (await collectionsApi.ListCollectionsAsync()).Collections);
        
        // Print to console
        testOutputHelper.WriteLine("Success!");
    }
}