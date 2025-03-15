# Org.OpenAPITools.Api.CoreSnapshotsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSnapshot**](CoreSnapshotsApi.md#createsnapshot) | **POST** /cores/{coreName}/snapshots/{snapshotName} | Create a new snapshot of the specified core. |
| [**DeleteSnapshot**](CoreSnapshotsApi.md#deletesnapshot) | **DELETE** /cores/{coreName}/snapshots/{snapshotName} | Delete a single snapshot from the specified core. |
| [**ListSnapshots1**](CoreSnapshotsApi.md#listsnapshots1) | **GET** /cores/{coreName}/snapshots | List existing snapshots for the specified core. |

<a id="createsnapshot"></a>
# **CreateSnapshot**
> CreateCoreSnapshotResponse CreateSnapshot (string coreName, string snapshotName, string async = null)

Create a new snapshot of the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoreSnapshotsApi(config);
            var coreName = "coreName_example";  // string | The name of the core to snapshot.
            var snapshotName = "snapshotName_example";  // string | The name to associate with the core snapshot.
            var async = "async_example";  // string | The id to associate with the async task. (optional) 

            try
            {
                // Create a new snapshot of the specified core.
                CreateCoreSnapshotResponse result = apiInstance.CreateSnapshot(coreName, snapshotName, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreSnapshotsApi.CreateSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new snapshot of the specified core.
    ApiResponse<CreateCoreSnapshotResponse> response = apiInstance.CreateSnapshotWithHttpInfo(coreName, snapshotName, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreSnapshotsApi.CreateSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core to snapshot. |  |
| **snapshotName** | **string** | The name to associate with the core snapshot. |  |
| **async** | **string** | The id to associate with the async task. | [optional]  |

### Return type

[**CreateCoreSnapshotResponse**](CreateCoreSnapshotResponse.md)

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

<a id="deletesnapshot"></a>
# **DeleteSnapshot**
> DeleteSnapshotResponse DeleteSnapshot (string coreName, string snapshotName, string async = null)

Delete a single snapshot from the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteSnapshotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoreSnapshotsApi(config);
            var coreName = "coreName_example";  // string | The name of the core for which to delete a snapshot.
            var snapshotName = "snapshotName_example";  // string | The name of the core snapshot to delete.
            var async = "async_example";  // string | The id to associate with the async task. (optional) 

            try
            {
                // Delete a single snapshot from the specified core.
                DeleteSnapshotResponse result = apiInstance.DeleteSnapshot(coreName, snapshotName, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreSnapshotsApi.DeleteSnapshot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSnapshotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a single snapshot from the specified core.
    ApiResponse<DeleteSnapshotResponse> response = apiInstance.DeleteSnapshotWithHttpInfo(coreName, snapshotName, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreSnapshotsApi.DeleteSnapshotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core for which to delete a snapshot. |  |
| **snapshotName** | **string** | The name of the core snapshot to delete. |  |
| **async** | **string** | The id to associate with the async task. | [optional]  |

### Return type

[**DeleteSnapshotResponse**](DeleteSnapshotResponse.md)

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

<a id="listsnapshots1"></a>
# **ListSnapshots1**
> ListCoreSnapshotsResponse ListSnapshots1 (string coreName)

List existing snapshots for the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListSnapshots1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoreSnapshotsApi(config);
            var coreName = "coreName_example";  // string | The name of the core for which to retrieve snapshots.

            try
            {
                // List existing snapshots for the specified core.
                ListCoreSnapshotsResponse result = apiInstance.ListSnapshots1(coreName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreSnapshotsApi.ListSnapshots1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSnapshots1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing snapshots for the specified core.
    ApiResponse<ListCoreSnapshotsResponse> response = apiInstance.ListSnapshots1WithHttpInfo(coreName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreSnapshotsApi.ListSnapshots1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core for which to retrieve snapshots. |  |

### Return type

[**ListCoreSnapshotsResponse**](ListCoreSnapshotsResponse.md)

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

