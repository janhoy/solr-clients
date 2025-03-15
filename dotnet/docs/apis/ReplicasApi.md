# Org.OpenAPITools.Api.ReplicasApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReplica**](ReplicasApi.md#createreplica) | **POST** /collections/{collectionName}/shards/{shardName}/replicas | Creates a new replica of an existing shard. |
| [**DeleteReplicaByName**](ReplicasApi.md#deletereplicabyname) | **DELETE** /collections/{collectionName}/shards/{shardName}/replicas/{replicaName} | Delete an single replica by name |
| [**DeleteReplicasByCount**](ReplicasApi.md#deletereplicasbycount) | **DELETE** /collections/{collectionName}/shards/{shardName}/replicas | Delete one or more replicas from the specified collection and shard |
| [**DeleteReplicasByCountAllShards**](ReplicasApi.md#deletereplicasbycountallshards) | **PUT** /collections/{collectionName}/scale | Scale the replica count for all shards in the specified collection |

<a id="createreplica"></a>
# **CreateReplica**
> SubResponseAccumulatingJerseyResponse CreateReplica (string collectionName, string shardName, CreateReplicaRequestBody createReplicaRequestBody = null)

Creates a new replica of an existing shard.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateReplicaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicasApi(config);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var createReplicaRequestBody = new CreateReplicaRequestBody(); // CreateReplicaRequestBody |  (optional) 

            try
            {
                // Creates a new replica of an existing shard.
                SubResponseAccumulatingJerseyResponse result = apiInstance.CreateReplica(collectionName, shardName, createReplicaRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.CreateReplicaWithHttpInfo(collectionName, shardName, createReplicaRequestBody);
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
| **createReplicaRequestBody** | [**CreateReplicaRequestBody**](CreateReplicaRequestBody.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponse**](SubResponseAccumulatingJerseyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereplicabyname"></a>
# **DeleteReplicaByName**
> SubResponseAccumulatingJerseyResponse DeleteReplicaByName (string collectionName, string shardName, string replicaName, bool followAliases = null, bool deleteInstanceDir = null, bool deleteDataDir = null, bool deleteIndex = null, bool onlyIfDown = null, string async = null)

Delete an single replica by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteReplicaByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicasApi(config);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var replicaName = "replicaName_example";  // string | 
            var followAliases = true;  // bool |  (optional) 
            var deleteInstanceDir = true;  // bool |  (optional) 
            var deleteDataDir = true;  // bool |  (optional) 
            var deleteIndex = true;  // bool |  (optional) 
            var onlyIfDown = true;  // bool |  (optional) 
            var async = "async_example";  // string |  (optional) 

            try
            {
                // Delete an single replica by name
                SubResponseAccumulatingJerseyResponse result = apiInstance.DeleteReplicaByName(collectionName, shardName, replicaName, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.DeleteReplicaByNameWithHttpInfo(collectionName, shardName, replicaName, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
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
| **followAliases** | **bool** |  | [optional]  |
| **deleteInstanceDir** | **bool** |  | [optional]  |
| **deleteDataDir** | **bool** |  | [optional]  |
| **deleteIndex** | **bool** |  | [optional]  |
| **onlyIfDown** | **bool** |  | [optional]  |
| **async** | **string** |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponse**](SubResponseAccumulatingJerseyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereplicasbycount"></a>
# **DeleteReplicasByCount**
> SubResponseAccumulatingJerseyResponse DeleteReplicasByCount (string collectionName, string shardName, int count = null, bool followAliases = null, bool deleteInstanceDir = null, bool deleteDataDir = null, bool deleteIndex = null, bool onlyIfDown = null, string async = null)

Delete one or more replicas from the specified collection and shard

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteReplicasByCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicasApi(config);
            var collectionName = "collectionName_example";  // string | 
            var shardName = "shardName_example";  // string | 
            var count = 56;  // int |  (optional) 
            var followAliases = true;  // bool |  (optional) 
            var deleteInstanceDir = true;  // bool |  (optional) 
            var deleteDataDir = true;  // bool |  (optional) 
            var deleteIndex = true;  // bool |  (optional) 
            var onlyIfDown = true;  // bool |  (optional) 
            var async = "async_example";  // string |  (optional) 

            try
            {
                // Delete one or more replicas from the specified collection and shard
                SubResponseAccumulatingJerseyResponse result = apiInstance.DeleteReplicasByCount(collectionName, shardName, count, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.DeleteReplicasByCountWithHttpInfo(collectionName, shardName, count, followAliases, deleteInstanceDir, deleteDataDir, deleteIndex, onlyIfDown, async);
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
| **count** | **int** |  | [optional]  |
| **followAliases** | **bool** |  | [optional]  |
| **deleteInstanceDir** | **bool** |  | [optional]  |
| **deleteDataDir** | **bool** |  | [optional]  |
| **deleteIndex** | **bool** |  | [optional]  |
| **onlyIfDown** | **bool** |  | [optional]  |
| **async** | **string** |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponse**](SubResponseAccumulatingJerseyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereplicasbycountallshards"></a>
# **DeleteReplicasByCountAllShards**
> SubResponseAccumulatingJerseyResponse DeleteReplicasByCountAllShards (string collectionName, ScaleCollectionRequestBody scaleCollectionRequestBody = null)

Scale the replica count for all shards in the specified collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteReplicasByCountAllShardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicasApi(config);
            var collectionName = "collectionName_example";  // string | 
            var scaleCollectionRequestBody = new ScaleCollectionRequestBody(); // ScaleCollectionRequestBody |  (optional) 

            try
            {
                // Scale the replica count for all shards in the specified collection
                SubResponseAccumulatingJerseyResponse result = apiInstance.DeleteReplicasByCountAllShards(collectionName, scaleCollectionRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.DeleteReplicasByCountAllShardsWithHttpInfo(collectionName, scaleCollectionRequestBody);
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
| **scaleCollectionRequestBody** | [**ScaleCollectionRequestBody**](ScaleCollectionRequestBody.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponse**](SubResponseAccumulatingJerseyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

