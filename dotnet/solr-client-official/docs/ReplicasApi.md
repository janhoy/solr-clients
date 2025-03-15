# SolrClient.Api.ReplicasApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReplica**](ReplicasApi.md#createreplica) | **POST** /collections/{collectionName}/shards/{shardName}/replicas | Creates a new replica of an existing shard. |
| [**DeleteReplicaByName**](ReplicasApi.md#deletereplicabyname) | **DELETE** /collections/{collectionName}/shards/{shardName}/replicas/{replicaName} | Delete an single replica by name |
| [**DeleteReplicasByCount**](ReplicasApi.md#deletereplicasbycount) | **DELETE** /collections/{collectionName}/shards/{shardName}/replicas | Delete one or more replicas from the specified collection and shard |
| [**DeleteReplicasByCountAllShards**](ReplicasApi.md#deletereplicasbycountallshards) | **PUT** /collections/{collectionName}/scale | Scale the replica count for all shards in the specified collection |

<a id="createreplica"></a>
# **CreateReplica**
> SubResponseAccumulatingJerseyResponseModel CreateReplica (string collectionName, string shardName, CreateReplicaRequestBodyModel? createReplicaRequestBodyModel = null)

Creates a new replica of an existing shard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SolrClient.Api;
using SolrClient.Client;
using SolrClient.Model;

namespace Example
{
    public class CreateReplicaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicasApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var createReplicaRequestBodyModel = new CreateReplicaRequestBodyModel?(); // CreateReplicaRequestBodyModel? |  (optional) 

            try
            {
                // Creates a new replica of an existing shard.
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.CreateReplica(collectionName, shardName, createReplicaRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicasApi.CreateReplica: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReplicaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new replica of an existing shard.
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.CreateReplicaWithHttpInfo(collectionName, shardName, createReplicaRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicasApi.CreateReplicaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |
| **createReplicaRequestBodyModel** | [**CreateReplicaRequestBodyModel?**](CreateReplicaRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereplicabyname"></a>
# **DeleteReplicaByName**
> SubResponseAccumulatingJerseyResponseModel DeleteReplicaByName (string collectionName, string shardName, string replicaName, bool? followAliases = null, bool? deleteInstanceDir = null, bool? deleteDataDir = null, bool? deleteIndex = null, bool? onlyIfDown = null, string? async = null)

Delete an single replica by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SolrClient.Api;
using SolrClient.Client;
using SolrClient.Model;

namespace Example
{
    public class DeleteReplicaByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicasApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var replicaName = "replicaName_example";  // string | 
            var followAliases = true;  // bool? |  (optional) 
            var deleteInstanceDir = true;  // bool? |  (optional) 
            var deleteDataDir = true;  // bool? |  (optional) 
            var deleteIndex = true;  // bool? |  (optional) 
            var onlyIfDown = true;  // bool? |  (optional) 
            var async = "async_example";  // string? |  (optional) 

            try
            {
                // Delete an single replica by name
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.DeleteReplicaByName(collectionName, shardName, replicaName, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicasApi.DeleteReplicaByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReplicaByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an single replica by name
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.DeleteReplicaByNameWithHttpInfo(collectionName, shardName, replicaName, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicasApi.DeleteReplicaByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |
| **replicaName** | **string** |  |  |
| **followAliases** | **bool?** |  | [optional]  |
| **deleteInstanceDir** | **bool?** |  | [optional]  |
| **deleteDataDir** | **bool?** |  | [optional]  |
| **deleteIndex** | **bool?** |  | [optional]  |
| **onlyIfDown** | **bool?** |  | [optional]  |
| **async** | **string?** |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereplicasbycount"></a>
# **DeleteReplicasByCount**
> SubResponseAccumulatingJerseyResponseModel DeleteReplicasByCount (string collectionName, string shardName, int? count = null, bool? followAliases = null, bool? deleteInstanceDir = null, bool? deleteDataDir = null, bool? deleteIndex = null, bool? onlyIfDown = null, string? async = null)

Delete one or more replicas from the specified collection and shard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SolrClient.Api;
using SolrClient.Client;
using SolrClient.Model;

namespace Example
{
    public class DeleteReplicasByCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicasApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var count = 56;  // int? |  (optional) 
            var followAliases = true;  // bool? |  (optional) 
            var deleteInstanceDir = true;  // bool? |  (optional) 
            var deleteDataDir = true;  // bool? |  (optional) 
            var deleteIndex = true;  // bool? |  (optional) 
            var onlyIfDown = true;  // bool? |  (optional) 
            var async = "async_example";  // string? |  (optional) 

            try
            {
                // Delete one or more replicas from the specified collection and shard
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.DeleteReplicasByCount(collectionName, shardName, count, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicasApi.DeleteReplicasByCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReplicasByCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete one or more replicas from the specified collection and shard
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.DeleteReplicasByCountWithHttpInfo(collectionName, shardName, count, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicasApi.DeleteReplicasByCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |
| **count** | **int?** |  | [optional]  |
| **followAliases** | **bool?** |  | [optional]  |
| **deleteInstanceDir** | **bool?** |  | [optional]  |
| **deleteDataDir** | **bool?** |  | [optional]  |
| **deleteIndex** | **bool?** |  | [optional]  |
| **onlyIfDown** | **bool?** |  | [optional]  |
| **async** | **string?** |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletereplicasbycountallshards"></a>
# **DeleteReplicasByCountAllShards**
> SubResponseAccumulatingJerseyResponseModel DeleteReplicasByCountAllShards (string collectionName, ScaleCollectionRequestBodyModel? scaleCollectionRequestBodyModel = null)

Scale the replica count for all shards in the specified collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SolrClient.Api;
using SolrClient.Client;
using SolrClient.Model;

namespace Example
{
    public class DeleteReplicasByCountAllShardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicasApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var scaleCollectionRequestBodyModel = new ScaleCollectionRequestBodyModel?(); // ScaleCollectionRequestBodyModel? |  (optional) 

            try
            {
                // Scale the replica count for all shards in the specified collection
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.DeleteReplicasByCountAllShards(collectionName, scaleCollectionRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicasApi.DeleteReplicasByCountAllShards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReplicasByCountAllShardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scale the replica count for all shards in the specified collection
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.DeleteReplicasByCountAllShardsWithHttpInfo(collectionName, scaleCollectionRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicasApi.DeleteReplicasByCountAllShardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **scaleCollectionRequestBodyModel** | [**ScaleCollectionRequestBodyModel?**](ScaleCollectionRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

