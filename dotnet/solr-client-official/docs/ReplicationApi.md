# SolrClient.Api.ReplicationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchFileList**](ReplicationApi.md#fetchfilelist) | **GET** /cores/{coreName}/replication/files | Return the list of index file that make up the specified core. |
| [**FetchIndexVersion**](ReplicationApi.md#fetchindexversion) | **GET** /cores/{coreName}/replication/indexversion | Return the index version of the specified core. |

<a id="fetchfilelist"></a>
# **FetchFileList**
> FileListResponseModel FetchFileList (string coreName, long generation)

Return the list of index file that make up the specified core.

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
    public class FetchFileListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicationApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var generation = 789L;  // long | The generation number of the index

            try
            {
                // Return the list of index file that make up the specified core.
                FileListResponseModel result = apiInstance.FetchFileList(coreName, generation);
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
    ApiResponse<FileListResponseModel> response = apiInstance.FetchFileListWithHttpInfo(coreName, generation);
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

[**FileListResponseModel**](FileListResponseModel.md)

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

<a id="fetchindexversion"></a>
# **FetchIndexVersion**
> IndexVersionResponseModel FetchIndexVersion (string coreName)

Return the index version of the specified core.

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
    public class FetchIndexVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ReplicationApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 

            try
            {
                // Return the index version of the specified core.
                IndexVersionResponseModel result = apiInstance.FetchIndexVersion(coreName);
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
    ApiResponse<IndexVersionResponseModel> response = apiInstance.FetchIndexVersionWithHttpInfo(coreName);
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

[**IndexVersionResponseModel**](IndexVersionResponseModel.md)

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

