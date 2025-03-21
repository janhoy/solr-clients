# ApacheSolr.Api.FileStoreApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteFile**](FileStoreApi.md#deletefile) | **DELETE** /cluster/files{path} | Delete a file or directory from the filestore. |
| [**GetFile**](FileStoreApi.md#getfile) | **GET** /node/files{path} | Retrieve file contents or metadata from the filestore. |
| [**UploadFile**](FileStoreApi.md#uploadfile) | **PUT** /cluster/files{filePath} | Upload a file to the filestore. |

<a id="deletefile"></a>
# **DeleteFile**
> SolrJerseyResponseModel DeleteFile (string path, bool? localDelete = null)

Delete a file or directory from the filestore.

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
    public class DeleteFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FileStoreApi(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | Path to a file or directory within the filestore
            var localDelete = true;  // bool? | Indicates whether the deletion should only be done on the receiving node.  For internal use only (optional) 

            try
            {
                // Delete a file or directory from the filestore.
                SolrJerseyResponseModel result = apiInstance.DeleteFile(path, localDelete);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStoreApi.DeleteFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a file or directory from the filestore.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.DeleteFileWithHttpInfo(path, localDelete);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileStoreApi.DeleteFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | Path to a file or directory within the filestore |  |
| **localDelete** | **bool?** | Indicates whether the deletion should only be done on the receiving node.  For internal use only | [optional]  |

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

<a id="getfile"></a>
# **GetFile**
> SolrJerseyResponseModel GetFile (string path, bool? sync = null, string? getFrom = null, bool? meta = null)

Retrieve file contents or metadata from the filestore.

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
    public class GetFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FileStoreApi(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | Path to a file or directory within the filestore
            var sync = true;  // bool? | If true, triggers syncing for this file across all nodes in the filestore (optional) 
            var getFrom = "getFrom_example";  // string? | An optional Solr node name to fetch the file from (optional) 
            var meta = true;  // bool? | Indicates that (only) file metadata should be fetched (optional) 

            try
            {
                // Retrieve file contents or metadata from the filestore.
                SolrJerseyResponseModel result = apiInstance.GetFile(path, sync, getFrom, meta);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStoreApi.GetFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve file contents or metadata from the filestore.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.GetFileWithHttpInfo(path, sync, getFrom, meta);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileStoreApi.GetFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | Path to a file or directory within the filestore |  |
| **sync** | **bool?** | If true, triggers syncing for this file across all nodes in the filestore | [optional]  |
| **getFrom** | **string?** | An optional Solr node name to fetch the file from | [optional]  |
| **meta** | **bool?** | Indicates that (only) file metadata should be fetched | [optional]  |

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

<a id="uploadfile"></a>
# **UploadFile**
> UploadToFileStoreResponseModel UploadFile (string filePath, Object body, Collection<string>? sig = null)

Upload a file to the filestore.

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
    public class UploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FileStoreApi(httpClient, config, httpClientHandler);
            var filePath = "filePath_example";  // string | File store path
            var body = null;  // Object | 
            var sig = new Collection<string>?(); // Collection<string>? | Signature(s) for the file being uploaded (optional) 

            try
            {
                // Upload a file to the filestore.
                UploadToFileStoreResponseModel result = apiInstance.UploadFile(filePath, body, sig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileStoreApi.UploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file to the filestore.
    ApiResponse<UploadToFileStoreResponseModel> response = apiInstance.UploadFileWithHttpInfo(filePath, body, sig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileStoreApi.UploadFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filePath** | **string** | File store path |  |
| **body** | **Object** |  |  |
| **sig** | [**Collection&lt;string&gt;?**](string.md) | Signature(s) for the file being uploaded | [optional]  |

### Return type

[**UploadToFileStoreResponseModel**](UploadToFileStoreResponseModel.md)

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

