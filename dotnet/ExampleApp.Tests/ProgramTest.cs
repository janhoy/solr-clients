using System.Net.Http;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;
namespace ExampleApp.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{

    [TestMethod]
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

    }
}