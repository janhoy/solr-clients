# Org.OpenAPITools.Api.ReplicationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchFileList**](ReplicationApi.md#fetchfilelist) | **GET** /cores/{coreName}/replication/files | Return the list of index file that make up the specified core. |
| [**FetchIndexVersion**](ReplicationApi.md#fetchindexversion) | **GET** /cores/{coreName}/replication/indexversion | Return the index version of the specified core. |

<a id="fetchfilelist"></a>
# **FetchFileList**
> FileListResponse FetchFileList (string coreName, long generation)

Return the list of index file that make up the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FetchFileListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicationApi(config);
            var coreName = "coreName_example";  // string | 
            var generation = 789L;  // long | The generation number of the index

            try
            {
                // Return the list of index file that make up the specified core.
                FileListResponse result = apiInstance.FetchFileList(coreName, generation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicationApi.FetchFileList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchFileListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the list of index file that make up the specified core.
    ApiResponse<FileListResponse> response = apiInstance.FetchFileListWithHttpInfo(coreName, generation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicationApi.FetchFileListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **generation** | **long** | The generation number of the index |  |

### Return type

[**FileListResponse**](FileListResponse.md)

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

<a id="fetchindexversion"></a>
# **FetchIndexVersion**
> IndexVersionResponse FetchIndexVersion (string coreName)

Return the index version of the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FetchIndexVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicationApi(config);
            var coreName = "coreName_example";  // string | 

            try
            {
                // Return the index version of the specified core.
                IndexVersionResponse result = apiInstance.FetchIndexVersion(coreName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicationApi.FetchIndexVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchIndexVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the index version of the specified core.
    ApiResponse<IndexVersionResponse> response = apiInstance.FetchIndexVersionWithHttpInfo(coreName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicationApi.FetchIndexVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |

### Return type

[**IndexVersionResponse**](IndexVersionResponse.md)

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

