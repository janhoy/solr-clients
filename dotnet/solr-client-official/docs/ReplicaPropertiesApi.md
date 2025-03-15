# SolrClient.Api.ReplicaPropertiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddReplicaProperty**](ReplicaPropertiesApi.md#addreplicaproperty) | **PUT** /collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName} | Adds a property to the specified replica |
| [**DeleteReplicaProperty**](ReplicaPropertiesApi.md#deletereplicaproperty) | **DELETE** /collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName} | Delete an existing replica property |

<a id="addreplicaproperty"></a>
# **AddReplicaProperty**
> SolrJerseyResponseModel AddReplicaProperty (string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBodyModel addReplicaPropertyRequestBodyModel)

Adds a property to the specified replica

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
    public class AddReplicaPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicaPropertiesApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | The name of the collection the replica belongs to.
            var shardName = "shardName_example";  // string | The name of the shard the replica belongs to.
            var replicaName = "replicaName_example";  // string | The replica, e.g., `core_node1`.
            var propName = "propName_example";  // string | The name of the property to add.
            var addReplicaPropertyRequestBodyModel = new AddReplicaPropertyRequestBodyModel(); // AddReplicaPropertyRequestBodyModel | The value of the replica property to create or update

            try
            {
                // Adds a property to the specified replica
                SolrJerseyResponseModel result = apiInstance.AddReplicaProperty(collName, shardName, replicaName, propName, addReplicaPropertyRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicaPropertiesApi.AddReplicaProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddReplicaPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a property to the specified replica
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.AddReplicaPropertyWithHttpInfo(collName, shardName, replicaName, propName, addReplicaPropertyRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicaPropertiesApi.AddReplicaPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** | The name of the collection the replica belongs to. |  |
| **shardName** | **string** | The name of the shard the replica belongs to. |  |
| **replicaName** | **string** | The replica, e.g., &#x60;core_node1&#x60;. |  |
| **propName** | **string** | The name of the property to add. |  |
| **addReplicaPropertyRequestBodyModel** | [**AddReplicaPropertyRequestBodyModel**](AddReplicaPropertyRequestBodyModel.md) | The value of the replica property to create or update |  |

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

<a id="deletereplicaproperty"></a>
# **DeleteReplicaProperty**
> SolrJerseyResponseModel DeleteReplicaProperty (string collName, string shardName, string replicaName, string propName)

Delete an existing replica property

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
    public class DeleteReplicaPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicaPropertiesApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | The name of the collection the replica belongs to.
            var shardName = "shardName_example";  // string | The name of the shard the replica belongs to.
            var replicaName = "replicaName_example";  // string | The replica, e.g., `core_node1`.
            var propName = "propName_example";  // string | The name of the property to delete.

            try
            {
                // Delete an existing replica property
                SolrJerseyResponseModel result = apiInstance.DeleteReplicaProperty(collName, shardName, replicaName, propName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicaPropertiesApi.DeleteReplicaProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReplicaPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing replica property
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.DeleteReplicaPropertyWithHttpInfo(collName, shardName, replicaName, propName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicaPropertiesApi.DeleteReplicaPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** | The name of the collection the replica belongs to. |  |
| **shardName** | **string** | The name of the shard the replica belongs to. |  |
| **replicaName** | **string** | The replica, e.g., &#x60;core_node1&#x60;. |  |
| **propName** | **string** | The name of the property to delete. |  |

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

