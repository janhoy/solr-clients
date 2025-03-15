# Org.OpenAPITools.Api.CoresApi

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
> SolrJerseyResponse InstallCoreData (string coreName, InstallCoreDataRequestBody installCoreDataRequestBody = null)

Install an offline index to a specified core

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InstallCoreDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | 
            var installCoreDataRequestBody = new InstallCoreDataRequestBody(); // InstallCoreDataRequestBody |  (optional) 

            try
            {
                // Install an offline index to a specified core
                SolrJerseyResponse result = apiInstance.InstallCoreData(coreName, installCoreDataRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.InstallCoreDataWithHttpInfo(coreName, installCoreDataRequestBody);
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
| **installCoreDataRequestBody** | [**InstallCoreDataRequestBody**](InstallCoreDataRequestBody.md) |  | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="mergeindexes"></a>
# **MergeIndexes**
> SolrJerseyResponse MergeIndexes (string coreName, MergeIndexesRequestBody mergeIndexesRequestBody = null)

The MERGEINDEXES action merges one or more indexes to another index.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MergeIndexesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | The core that the specified indices are merged into.
            var mergeIndexesRequestBody = new MergeIndexesRequestBody(); // MergeIndexesRequestBody | Additional properties for merge indexes. (optional) 

            try
            {
                // The MERGEINDEXES action merges one or more indexes to another index.
                SolrJerseyResponse result = apiInstance.MergeIndexes(coreName, mergeIndexesRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.MergeIndexesWithHttpInfo(coreName, mergeIndexesRequestBody);
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
| **mergeIndexesRequestBody** | [**MergeIndexesRequestBody**](MergeIndexesRequestBody.md) | Additional properties for merge indexes. | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="reloadcore"></a>
# **ReloadCore**
> SolrJerseyResponse ReloadCore (string coreName)

Reload the specified core.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReloadCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | The name of the core to reload.

            try
            {
                // Reload the specified core.
                SolrJerseyResponse result = apiInstance.ReloadCore(coreName);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.ReloadCoreWithHttpInfo(coreName);
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

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="renamecore"></a>
# **RenameCore**
> SolrJerseyResponse RenameCore (string coreName, RenameCoreRequestBody renameCoreRequestBody = null)

The RENAME action changes the name of a Solr core

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenameCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | 
            var renameCoreRequestBody = new RenameCoreRequestBody(); // RenameCoreRequestBody | Additional properties related to the core renaming (optional) 

            try
            {
                // The RENAME action changes the name of a Solr core
                SolrJerseyResponse result = apiInstance.RenameCore(coreName, renameCoreRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.RenameCoreWithHttpInfo(coreName, renameCoreRequestBody);
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
| **renameCoreRequestBody** | [**RenameCoreRequestBody**](RenameCoreRequestBody.md) | Additional properties related to the core renaming | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="restorecore"></a>
# **RestoreCore**
> SolrJerseyResponse RestoreCore (string coreName, RestoreCoreRequestBody restoreCoreRequestBody = null)

Restore a previously-taken backup to the specified core

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RestoreCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | The name of the core to be restored
            var restoreCoreRequestBody = new RestoreCoreRequestBody(); // RestoreCoreRequestBody |  (optional) 

            try
            {
                // Restore a previously-taken backup to the specified core
                SolrJerseyResponse result = apiInstance.RestoreCore(coreName, restoreCoreRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.RestoreCoreWithHttpInfo(coreName, restoreCoreRequestBody);
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
| **restoreCoreRequestBody** | [**RestoreCoreRequestBody**](RestoreCoreRequestBody.md) |  | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="swapcores"></a>
# **SwapCores**
> SolrJerseyResponse SwapCores (string coreName, SwapCoresRequestBody swapCoresRequestBody = null)

SWAP atomically swaps the names used to access two existing Solr cores.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SwapCoresExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | 
            var swapCoresRequestBody = new SwapCoresRequestBody(); // SwapCoresRequestBody | Additional properties related to core swapping. (optional) 

            try
            {
                // SWAP atomically swaps the names used to access two existing Solr cores.
                SolrJerseyResponse result = apiInstance.SwapCores(coreName, swapCoresRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.SwapCoresWithHttpInfo(coreName, swapCoresRequestBody);
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
| **swapCoresRequestBody** | [**SwapCoresRequestBody**](SwapCoresRequestBody.md) | Additional properties related to core swapping. | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

<a id="unloadcore"></a>
# **UnloadCore**
> SolrJerseyResponse UnloadCore (string coreName, UnloadCoreRequestBody unloadCoreRequestBody = null)

Unloads a single core specified by name

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnloadCoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoresApi(config);
            var coreName = "coreName_example";  // string | 
            var unloadCoreRequestBody = new UnloadCoreRequestBody(); // UnloadCoreRequestBody | Additional properties related to the core unloading (optional) 

            try
            {
                // Unloads a single core specified by name
                SolrJerseyResponse result = apiInstance.UnloadCore(coreName, unloadCoreRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.UnloadCoreWithHttpInfo(coreName, unloadCoreRequestBody);
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
| **unloadCoreRequestBody** | [**UnloadCoreRequestBody**](UnloadCoreRequestBody.md) | Additional properties related to the core unloading | [optional]  |

### Return type

[**SolrJerseyResponse**](SolrJerseyResponse.md)

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

