# SolrClient.Api.CoreReplicationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchFile**](CoreReplicationApi.md#fetchfile) | **GET** /cores/{coreName}/replication/files/{filePath} | Get a stream of a specific file path of a core |

<a id="fetchfile"></a>
# **FetchFile**
> void FetchFile (string coreName, string filePath, string dirType, string? offset = null, string? len = null, bool? compression = null, bool? checksum = null, double? maxWriteMBPerSec = null, long? generation = null)

Get a stream of a specific file path of a core

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
    public class FetchFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoreReplicationApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var filePath = "filePath_example";  // string | 
            var dirType = "dirType_example";  // string | Directory type for specific filePath (cf or tlogFile). Defaults to Lucene index (file) directory if empty
            var offset = "offset_example";  // string? | Output stream read/write offset (optional) 
            var len = "len_example";  // string? |  (optional) 
            var compression = false;  // bool? | Compress file output (optional)  (default to false)
            var checksum = false;  // bool? | Write checksum with output stream (optional)  (default to false)
            var maxWriteMBPerSec = 1.2D;  // double? | Limit data write per seconds. Defaults to no throttling (optional) 
            var generation = 789L;  // long? | The generation number of the index (optional) 

            try
            {
                // Get a stream of a specific file path of a core
                apiInstance.FetchFile(coreName, filePath, dirType, offset, len, compression, checksum, maxWriteMBPerSec, generation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreReplicationApi.FetchFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a stream of a specific file path of a core
    apiInstance.FetchFileWithHttpInfo(coreName, filePath, dirType, offset, len, compression, checksum, maxWriteMBPerSec, generation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreReplicationApi.FetchFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **filePath** | **string** |  |  |
| **dirType** | **string** | Directory type for specific filePath (cf or tlogFile). Defaults to Lucene index (file) directory if empty |  |
| **offset** | **string?** | Output stream read/write offset | [optional]  |
| **len** | **string?** |  | [optional]  |
| **compression** | **bool?** | Compress file output | [optional] [default to false] |
| **checksum** | **bool?** | Write checksum with output stream | [optional] [default to false] |
| **maxWriteMBPerSec** | **double?** | Limit data write per seconds. Defaults to no throttling | [optional]  |
| **generation** | **long?** | The generation number of the index | [optional]  |

### Return type

void (empty response body)

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

