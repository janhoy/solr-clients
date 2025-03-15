# SolrClient.Api.CoresApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InstallCoreData**](CoresApi.md#installcoredata) | **POST** /cores/{coreName}/install | Install an offline index to a specified core |
| [**MergeIndexes**](CoresApi.md#mergeindexes) | **POST** /cores/{coreName}/merge-indices | The MERGEINDEXES action merges one or more indexes to another index. |
| [**ReloadCore**](CoresApi.md#reloadcore) | **POST** /cores/{coreName}/reload | Reload the specified core. |
| [**RenameCore**](CoresApi.md#renamecore) | **POST** /cores/{coreName}/rename | The RENAME action changes the name of a Solr core |
| [**RestoreCore**](CoresApi.md#restorecore) | **POST** /cores/{coreName}/restore | Restore a previously-taken backup to the specified core |
| [**SwapCores**](CoresApi.md#swapcores) | **POST** /cores/{coreName}/swap | SWAP atomically swaps the names used to access two existing Solr cores. |
| [**UnloadCore**](CoresApi.md#unloadcore) | **POST** /cores/{coreName}/unload | Unloads a single core specified by name |

<a id="installcoredata"></a>
# **InstallCoreData**
> SolrJerseyResponseModel InstallCoreData (string coreName, InstallCoreDataRequestBodyModel? installCoreDataRequestBodyModel = null)

Install an offline index to a specified core

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
    public class InstallCoreDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var installCoreDataRequestBodyModel = new InstallCoreDataRequestBodyModel?(); // InstallCoreDataRequestBodyModel? |  (optional) 

            try
            {
                // Install an offline index to a specified core
                SolrJerseyResponseModel result = apiInstance.InstallCoreData(coreName, installCoreDataRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.InstallCoreData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallCoreDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install an offline index to a specified core
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.InstallCoreDataWithHttpInfo(coreName, installCoreDataRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.InstallCoreDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **installCoreDataRequestBodyModel** | [**InstallCoreDataRequestBodyModel?**](InstallCoreDataRequestBodyModel?.md) |  | [optional]  |

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

<a id="mergeindexes"></a>
# **MergeIndexes**
> SolrJerseyResponseModel MergeIndexes (string coreName, MergeIndexesRequestBodyModel? mergeIndexesRequestBodyModel = null)

The MERGEINDEXES action merges one or more indexes to another index.

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
    public class MergeIndexesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | The core that the specified indices are merged into.
            var mergeIndexesRequestBodyModel = new MergeIndexesRequestBodyModel?(); // MergeIndexesRequestBodyModel? | Additional properties for merge indexes. (optional) 

            try
            {
                // The MERGEINDEXES action merges one or more indexes to another index.
                SolrJerseyResponseModel result = apiInstance.MergeIndexes(coreName, mergeIndexesRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.MergeIndexes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergeIndexesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The MERGEINDEXES action merges one or more indexes to another index.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.MergeIndexesWithHttpInfo(coreName, mergeIndexesRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.MergeIndexesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The core that the specified indices are merged into. |  |
| **mergeIndexesRequestBodyModel** | [**MergeIndexesRequestBodyModel?**](MergeIndexesRequestBodyModel?.md) | Additional properties for merge indexes. | [optional]  |

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

<a id="reloadcore"></a>
# **ReloadCore**
> SolrJerseyResponseModel ReloadCore (string coreName)

Reload the specified core.

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
    public class ReloadCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | The name of the core to reload.

            try
            {
                // Reload the specified core.
                SolrJerseyResponseModel result = apiInstance.ReloadCore(coreName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.ReloadCore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReloadCoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reload the specified core.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.ReloadCoreWithHttpInfo(coreName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.ReloadCoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core to reload. |  |

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

<a id="renamecore"></a>
# **RenameCore**
> SolrJerseyResponseModel RenameCore (string coreName, RenameCoreRequestBodyModel? renameCoreRequestBodyModel = null)

The RENAME action changes the name of a Solr core

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
    public class RenameCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var renameCoreRequestBodyModel = new RenameCoreRequestBodyModel?(); // RenameCoreRequestBodyModel? | Additional properties related to the core renaming (optional) 

            try
            {
                // The RENAME action changes the name of a Solr core
                SolrJerseyResponseModel result = apiInstance.RenameCore(coreName, renameCoreRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.RenameCore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameCoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The RENAME action changes the name of a Solr core
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.RenameCoreWithHttpInfo(coreName, renameCoreRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.RenameCoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **renameCoreRequestBodyModel** | [**RenameCoreRequestBodyModel?**](RenameCoreRequestBodyModel?.md) | Additional properties related to the core renaming | [optional]  |

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

<a id="restorecore"></a>
# **RestoreCore**
> SolrJerseyResponseModel RestoreCore (string coreName, RestoreCoreRequestBodyModel? restoreCoreRequestBodyModel = null)

Restore a previously-taken backup to the specified core

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
    public class RestoreCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | The name of the core to be restored
            var restoreCoreRequestBodyModel = new RestoreCoreRequestBodyModel?(); // RestoreCoreRequestBodyModel? |  (optional) 

            try
            {
                // Restore a previously-taken backup to the specified core
                SolrJerseyResponseModel result = apiInstance.RestoreCore(coreName, restoreCoreRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.RestoreCore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreCoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a previously-taken backup to the specified core
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.RestoreCoreWithHttpInfo(coreName, restoreCoreRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.RestoreCoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core to be restored |  |
| **restoreCoreRequestBodyModel** | [**RestoreCoreRequestBodyModel?**](RestoreCoreRequestBodyModel?.md) |  | [optional]  |

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

<a id="swapcores"></a>
# **SwapCores**
> SolrJerseyResponseModel SwapCores (string coreName, SwapCoresRequestBodyModel? swapCoresRequestBodyModel = null)

SWAP atomically swaps the names used to access two existing Solr cores.

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
    public class SwapCoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var swapCoresRequestBodyModel = new SwapCoresRequestBodyModel?(); // SwapCoresRequestBodyModel? | Additional properties related to core swapping. (optional) 

            try
            {
                // SWAP atomically swaps the names used to access two existing Solr cores.
                SolrJerseyResponseModel result = apiInstance.SwapCores(coreName, swapCoresRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.SwapCores: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SwapCoresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SWAP atomically swaps the names used to access two existing Solr cores.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.SwapCoresWithHttpInfo(coreName, swapCoresRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.SwapCoresWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **swapCoresRequestBodyModel** | [**SwapCoresRequestBodyModel?**](SwapCoresRequestBodyModel?.md) | Additional properties related to core swapping. | [optional]  |

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

<a id="unloadcore"></a>
# **UnloadCore**
> SolrJerseyResponseModel UnloadCore (string coreName, UnloadCoreRequestBodyModel? unloadCoreRequestBodyModel = null)

Unloads a single core specified by name

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
    public class UnloadCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoresApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | 
            var unloadCoreRequestBodyModel = new UnloadCoreRequestBodyModel?(); // UnloadCoreRequestBodyModel? | Additional properties related to the core unloading (optional) 

            try
            {
                // Unloads a single core specified by name
                SolrJerseyResponseModel result = apiInstance.UnloadCore(coreName, unloadCoreRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoresApi.UnloadCore: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnloadCoreWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unloads a single core specified by name
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.UnloadCoreWithHttpInfo(coreName, unloadCoreRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoresApi.UnloadCoreWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |
| **unloadCoreRequestBodyModel** | [**UnloadCoreRequestBodyModel?**](UnloadCoreRequestBodyModel?.md) | Additional properties related to the core unloading | [optional]  |

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

