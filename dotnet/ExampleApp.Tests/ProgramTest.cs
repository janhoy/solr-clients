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

public class ProgramTest : IAsyncLifetime
{
    private readonly ITestOutputHelper _testOutputHelper;
    private IContainer _solrContainer;

    public ProgramTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    public async Task InitializeAsync()
    {
        var network = new NetworkBuilder().Build();

        _solrContainer = new ContainerBuilder()
            .WithImage("solr:9.8")
            .WithCommand("-c")
            .WithPortBinding(8983, 8983)
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(8983))
            .Build();

        await _solrContainer.StartAsync();
    }

    public async Task DisposeAsync() => await _solrContainer.StopAsync();

    [Fact]
    public void DemonstrateSolrClientUsage()
    {
        Configuration config = new Configuration();
        config.BasePath = "http://localhost:8983/api";
        HttpClient httpClient = new HttpClient();
        HttpClientHandler httpClientHandler = new HttpClientHandler();

        // List config sets and confirm that the '_default' config set is present
        var configSetsApi = new ConfigsetsApi(httpClient, config, httpClientHandler);
        var configSets = configSetsApi.ListConfigSetAsync();
        Assert.Contains("_default", configSets.Result.ConfigSets);

        // Create a collection
        var collectionsApi = new CollectionsApi(httpClient, config, httpClientHandler);
        var createCollectionRequest = new CreateCollectionRequestBodyModel
        {
            Name = "mycollection",
            Config = "_default",
            NumShards = 1,
            ReplicationFactor = 1
        };
        collectionsApi.CreateCollection(createCollectionRequest);
        Assert.Contains("mycollection", collectionsApi.ListCollections().Collections);

        // Create alias 'myalias' for collection 'mycollection'
        var aliasApi = new AliasesApi(config);
        aliasApi.CreateAlias(new CreateAliasRequestBodyModel("myalias", ["mycollection"]));

        // List aliases
        Assert.Contains("myalias", aliasApi.GetAliases().Aliases.Keys);

        // Delete alias 'myalias'
        aliasApi.DeleteAlias("myalias");
        Assert.DoesNotContain("myalias", aliasApi.GetAliases().Aliases.Keys);

        // Delete the collection
        collectionsApi.DeleteCollection("mycollection");
        Assert.DoesNotContain("mycollection", collectionsApi.ListCollections().Collections);
        
        // Print to console
        _testOutputHelper.WriteLine("Success!");
    }
}