using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8983/api";
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();

            // List config sets and confirm that the '_default' config set is present
            var configSetsApi = new ConfigsetsApi(httpClient, config, httpClientHandler);
            try
            {
                var configSets = configSetsApi.ListConfigSetAsync();
                Console.WriteLine("Config sets:");
                foreach (var configSet in configSets.Result.ConfigSets)
                {
                    Console.WriteLine(configSet);
                }
                if (configSets.Result.ConfigSets.Contains("_default"))
                {
                    Console.WriteLine("Config set '_default' is present.");
                }
                else
                {
                    Console.WriteLine("Config set '_default' is not present.");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigsetsApi.ListConfigSets: " + e.Message);
            }

            // Create a collection
            var collectionsApi = new CollectionsApi(httpClient, config, httpClientHandler);
            var createCollectionRequest = new CreateCollectionRequestBodyModel
            {
                Name = "mycollection",
                Config = "_default", 
                NumShards = 1,
                ReplicationFactor = 1
            };
            try
            {
                collectionsApi.CreateCollection(createCollectionRequest);
                Console.WriteLine("Collection 'mycollection' created successfully.");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollectionsApi.CreateCollection: " + e.Message);
            }

            // List collections
            try
            {
                var collections = collectionsApi.ListCollections();
                Console.WriteLine("Collections:");
                foreach (var collection in collections.Collections)
                {
                    Console.WriteLine(collection);
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollectionsApi.ListCollections: " + e.Message);
            }

            // Create alias 'myalias' for collection 'mycollection'
            var aliasApi = new AliasesApi(config);
            try
            {
                aliasApi.CreateAlias(new CreateAliasRequestBodyModel("myalias", ["mycollection"]));
                Console.WriteLine("Alias 'myalias' created successfully.");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AliasesApi.CreateAlias: " + e.Message);
            }
            
            // List aliases
            try
            {
                var aliases = aliasApi.GetAliases();
                Console.WriteLine("Aliases:");
                foreach (var alias in aliases.Aliases)
                {
                    Console.WriteLine("  " + alias);
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AliasesApi.ListAliases: " + e.Message);
            }
            
            // Delete alias 'myalias'
            try
            {
                aliasApi.DeleteAlias("myalias");
                Console.WriteLine("Alias 'myalias' deleted successfully.");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AliasesApi.DeleteAlias: " + e.Message);
            }
            
            // Confirm the collection is present
            try
            {
                var collections = collectionsApi.ListCollections();
                if (collections.Collections.Contains("mycollection"))
                {
                    Console.WriteLine("Collection 'mycollection' is present.");
                }
                else
                {
                    Console.WriteLine("Collection 'mycollection' is not present.");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollectionsApi.ListCollections: " + e.Message);
            }

            // Delete the collection
            try
            {
                collectionsApi.DeleteCollection("mycollection");
                Console.WriteLine("Collection deleted successfully.");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollectionsApi.DeleteCollection: " + e.Message);
            }
        }
    }
}