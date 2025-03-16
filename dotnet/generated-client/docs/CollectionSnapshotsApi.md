# ApacheSolr.Api.CollectionSnapshotsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCollectionSnapshot**](CollectionSnapshotsApi.md#createcollectionsnapshot) | **POST** /collections/{collName}/snapshots/{snapshotName} | Creates a new snapshot of the specified collection. |
| [**DeleteCollectionSnapshot**](CollectionSnapshotsApi.md#deletecollectionsnapshot) | **DELETE** /collections/{collName}/snapshots/{snapshotName} | Delete an existing collection-snapshot by name. |
| [**ListSnapshots**](CollectionSnapshotsApi.md#listsnapshots) | **GET** /collections/{collName}/snapshots | List the snapshots available for a specified collection. |

<a id="createcollectionsnapshot"></a>
# **CreateCollectionSnapshot**
> CreateCollectionSnapshotResponseModel CreateCollectionSnapshot (string collName, string snapshotName, CreateCollectionSnapshotRequestBodyModel createCollectionSnapshotRequestBodyModel)

Creates a new snapshot of the specified collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;

namespace Example
{
    public class CreateCollectionSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionSnapshotsApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | The name of the collection.
            var snapshotName = "snapshotName_example";  // string | The name of the snapshot to be created.
            var createCollectionSnapshotRequestBodyModel = new CreateCollectionSnapshotRequestBodyModel(); // CreateCollectionSnapshotRequestBodyModel | Contains user provided parameters

            try
            {
                // Creates a new snapshot of the specified collection.
                CreateCollectionSnapshotResponseModel result = apiInstance.CreateCollectionSnapshot(collName, snapshotName, createCollectionSnapshotRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionSnapshotsApi.CreateCollectionSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCollectionSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new snapshot of the specified collection.
    ApiResponse<CreateCollectionSnapshotResponseModel> response = apiInstance.CreateCollectionSnapshotWithHttpInfo(collName, snapshotName, createCollectionSnapshotRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionSnapshotsApi.CreateCollectionSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** | The name of the collection. |  |
| **snapshotName** | **string** | The name of the snapshot to be created. |  |
| **createCollectionSnapshotRequestBodyModel** | [**CreateCollectionSnapshotRequestBodyModel**](CreateCollectionSnapshotRequestBodyModel.md) | Contains user provided parameters |  |

### Return type

[**CreateCollectionSnapshotResponseModel**](CreateCollectionSnapshotResponseModel.md)

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

<a id="deletecollectionsnapshot"></a>
# **DeleteCollectionSnapshot**
> DeleteCollectionSnapshotResponseModel DeleteCollectionSnapshot (string collName, string snapshotName, bool? followAliases = null, string? async = null)

Delete an existing collection-snapshot by name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;

namespace Example
{
    public class DeleteCollectionSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionSnapshotsApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | The name of the collection.
            var snapshotName = "snapshotName_example";  // string | The name of the snapshot to be deleted.
            var followAliases = false;  // bool? | A flag that treats the collName parameter as a collection alias. (optional)  (default to false)
            var async = "async_example";  // string? |  (optional) 

            try
            {
                // Delete an existing collection-snapshot by name.
                DeleteCollectionSnapshotResponseModel result = apiInstance.DeleteCollectionSnapshot(collName, snapshotName, followAliases, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionSnapshotsApi.DeleteCollectionSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCollectionSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing collection-snapshot by name.
    ApiResponse<DeleteCollectionSnapshotResponseModel> response = apiInstance.DeleteCollectionSnapshotWithHttpInfo(collName, snapshotName, followAliases, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionSnapshotsApi.DeleteCollectionSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** | The name of the collection. |  |
| **snapshotName** | **string** | The name of the snapshot to be deleted. |  |
| **followAliases** | **bool?** | A flag that treats the collName parameter as a collection alias. | [optional] [default to false] |
| **async** | **string?** |  | [optional]  |

### Return type

[**DeleteCollectionSnapshotResponseModel**](DeleteCollectionSnapshotResponseModel.md)

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

<a id="listsnapshots"></a>
# **ListSnapshots**
> ListCollectionSnapshotsResponseModel ListSnapshots (string collName)

List the snapshots available for a specified collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ApacheSolr.Api;
using ApacheSolr.Client;
using ApacheSolr.Model;

namespace Example
{
    public class ListSnapshotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionSnapshotsApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | The name of the collection.

            try
            {
                // List the snapshots available for a specified collection.
                ListCollectionSnapshotsResponseModel result = apiInstance.ListSnapshots(collName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionSnapshotsApi.ListSnapshots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSnapshotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the snapshots available for a specified collection.
    ApiResponse<ListCollectionSnapshotsResponseModel> response = apiInstance.ListSnapshotsWithHttpInfo(collName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionSnapshotsApi.ListSnapshotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** | The name of the collection. |  |

### Return type

[**ListCollectionSnapshotsResponseModel**](ListCollectionSnapshotsResponseModel.md)

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

