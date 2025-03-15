# SolrClient.Api.ShardsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateShard**](ShardsApi.md#createshard) | **POST** /collections/{collectionName}/shards | Create a new shard in an existing collection |
| [**DeleteShard**](ShardsApi.md#deleteshard) | **DELETE** /collections/{collectionName}/shards/{shardName} | Delete an existing shard |
| [**ForceShardLeader**](ShardsApi.md#forceshardleader) | **POST** /collections/{collectionName}/shards/{shardName}/force-leader | Force leader election to occur on the specified collection and shard |
| [**InstallShardData**](ShardsApi.md#installsharddata) | **POST** /collections/{collName}/shards/{shardName}/install | Install offline index into an existing shard |
| [**SyncShard**](ShardsApi.md#syncshard) | **POST** /collections/{collectionName}/shards/{shardName}/sync | Trigger a &#39;sync&#39; operation for the specified shard |

<a id="createshard"></a>
# **CreateShard**
> SubResponseAccumulatingJerseyResponseModel CreateShard (string collectionName, CreateShardRequestBodyModel? createShardRequestBodyModel = null)

Create a new shard in an existing collection

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
    public class CreateShardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShardsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var createShardRequestBodyModel = new CreateShardRequestBodyModel?(); // CreateShardRequestBodyModel? |  (optional) 

            try
            {
                // Create a new shard in an existing collection
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.CreateShard(collectionName, createShardRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShardsApi.CreateShard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new shard in an existing collection
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.CreateShardWithHttpInfo(collectionName, createShardRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShardsApi.CreateShardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **createShardRequestBodyModel** | [**CreateShardRequestBodyModel?**](CreateShardRequestBodyModel?.md) |  | [optional]  |

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

<a id="deleteshard"></a>
# **DeleteShard**
> SubResponseAccumulatingJerseyResponseModel DeleteShard (string collectionName, string shardName, bool? deleteInstanceDir = null, bool? deleteDataDir = null, bool? deleteIndex = null, bool? followAliases = null, string? async = null)

Delete an existing shard

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
    public class DeleteShardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShardsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var deleteInstanceDir = true;  // bool? |  (optional) 
            var deleteDataDir = true;  // bool? |  (optional) 
            var deleteIndex = true;  // bool? |  (optional) 
            var followAliases = true;  // bool? |  (optional) 
            var async = "async_example";  // string? |  (optional) 

            try
            {
                // Delete an existing shard
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.DeleteShard(collectionName, shardName, deleteInstanceDir, deleteDataDir, deleteIndex, followAliases, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShardsApi.DeleteShard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteShardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing shard
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.DeleteShardWithHttpInfo(collectionName, shardName, deleteInstanceDir, deleteDataDir, deleteIndex, followAliases, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShardsApi.DeleteShardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |
| **deleteInstanceDir** | **bool?** |  | [optional]  |
| **deleteDataDir** | **bool?** |  | [optional]  |
| **deleteIndex** | **bool?** |  | [optional]  |
| **followAliases** | **bool?** |  | [optional]  |
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

<a id="forceshardleader"></a>
# **ForceShardLeader**
> SolrJerseyResponseModel ForceShardLeader (string collectionName, string shardName)

Force leader election to occur on the specified collection and shard

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
    public class ForceShardLeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShardsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 

            try
            {
                // Force leader election to occur on the specified collection and shard
                SolrJerseyResponseModel result = apiInstance.ForceShardLeader(collectionName, shardName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShardsApi.ForceShardLeader: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForceShardLeaderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Force leader election to occur on the specified collection and shard
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.ForceShardLeaderWithHttpInfo(collectionName, shardName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShardsApi.ForceShardLeaderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |

### Return type

[**SolrJerseyResponseModel**](SolrJerseyResponseModel.md)

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

<a id="installsharddata"></a>
# **InstallShardData**
> SolrJerseyResponseModel InstallShardData (string collName, string shardName, InstallShardDataRequestBodyModel? installShardDataRequestBodyModel = null)

Install offline index into an existing shard

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
    public class InstallShardDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShardsApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var installShardDataRequestBodyModel = new InstallShardDataRequestBodyModel?(); // InstallShardDataRequestBodyModel? |  (optional) 

            try
            {
                // Install offline index into an existing shard
                SolrJerseyResponseModel result = apiInstance.InstallShardData(collName, shardName, installShardDataRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShardsApi.InstallShardData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallShardDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install offline index into an existing shard
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.InstallShardDataWithHttpInfo(collName, shardName, installShardDataRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShardsApi.InstallShardDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** |  |  |
| **shardName** | **string** |  |  |
| **installShardDataRequestBodyModel** | [**InstallShardDataRequestBodyModel?**](InstallShardDataRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SolrJerseyResponseModel**](SolrJerseyResponseModel.md)

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

<a id="syncshard"></a>
# **SyncShard**
> SolrJerseyResponseModel SyncShard (string collectionName, string shardName)

Trigger a 'sync' operation for the specified shard

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
    public class SyncShardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ShardsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 

            try
            {
                // Trigger a 'sync' operation for the specified shard
                SolrJerseyResponseModel result = apiInstance.SyncShard(collectionName, shardName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShardsApi.SyncShard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SyncShardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trigger a 'sync' operation for the specified shard
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.SyncShardWithHttpInfo(collectionName, shardName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShardsApi.SyncShardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **shardName** | **string** |  |  |

### Return type

[**SolrJerseyResponseModel**](SolrJerseyResponseModel.md)

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

