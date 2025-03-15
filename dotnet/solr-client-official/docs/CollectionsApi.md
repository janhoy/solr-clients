# SolrClient.Api.CollectionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalanceShardUnique**](CollectionsApi.md#balanceshardunique) | **POST** /collections/{collectionName}/balance-shard-unique | Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection |
| [**CreateCollection**](CollectionsApi.md#createcollection) | **POST** /collections | Creates a new SolrCloud collection. |
| [**DeleteCollection**](CollectionsApi.md#deletecollection) | **DELETE** /collections/{collectionName} | Deletes a collection from SolrCloud |
| [**ListCollections**](CollectionsApi.md#listcollections) | **GET** /collections | List all collections in this Solr cluster |
| [**ReloadCollection**](CollectionsApi.md#reloadcollection) | **POST** /collections/{collectionName}/reload | Reload all cores in the specified collection. |
| [**RenameCollection**](CollectionsApi.md#renamecollection) | **POST** /collections/{collectionName}/rename | Rename a SolrCloud collection |

<a id="balanceshardunique"></a>
# **BalanceShardUnique**
> SubResponseAccumulatingJerseyResponseModel BalanceShardUnique (string collectionName, BalanceShardUniqueRequestBodyModel? balanceShardUniqueRequestBodyModel = null)

Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection

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
    public class BalanceShardUniqueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var balanceShardUniqueRequestBodyModel = new BalanceShardUniqueRequestBodyModel?(); // BalanceShardUniqueRequestBodyModel? |  (optional) 

            try
            {
                // Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.BalanceShardUnique(collectionName, balanceShardUniqueRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.BalanceShardUnique: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalanceShardUniqueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.BalanceShardUniqueWithHttpInfo(collectionName, balanceShardUniqueRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.BalanceShardUniqueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **balanceShardUniqueRequestBodyModel** | [**BalanceShardUniqueRequestBodyModel?**](BalanceShardUniqueRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

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

<a id="createcollection"></a>
# **CreateCollection**
> SubResponseAccumulatingJerseyResponseModel CreateCollection (CreateCollectionRequestBodyModel? createCollectionRequestBodyModel = null)

Creates a new SolrCloud collection.

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
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var createCollectionRequestBodyModel = new CreateCollectionRequestBodyModel?(); // CreateCollectionRequestBodyModel? |  (optional) 

            try
            {
                // Creates a new SolrCloud collection.
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.CreateCollection(createCollectionRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new SolrCloud collection.
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.CreateCollectionWithHttpInfo(createCollectionRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.CreateCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCollectionRequestBodyModel** | [**CreateCollectionRequestBodyModel?**](CreateCollectionRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

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

<a id="deletecollection"></a>
# **DeleteCollection**
> SubResponseAccumulatingJerseyResponseModel DeleteCollection (string collectionName, bool? followAliases = null, string? async = null)

Deletes a collection from SolrCloud

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
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | The name of the collection to be deleted.
            var followAliases = true;  // bool? |  (optional) 
            var async = "async_example";  // string? | An ID to track the request asynchronously (optional) 

            try
            {
                // Deletes a collection from SolrCloud
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.DeleteCollection(collectionName, followAliases, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a collection from SolrCloud
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.DeleteCollectionWithHttpInfo(collectionName, followAliases, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.DeleteCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** | The name of the collection to be deleted. |  |
| **followAliases** | **bool?** |  | [optional]  |
| **async** | **string?** | An ID to track the request asynchronously | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

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

<a id="listcollections"></a>
# **ListCollections**
> ListCollectionsResponseModel ListCollections ()

List all collections in this Solr cluster

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
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);

            try
            {
                // List all collections in this Solr cluster
                ListCollectionsResponseModel result = apiInstance.ListCollections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all collections in this Solr cluster
    ApiResponse<ListCollectionsResponseModel> response = apiInstance.ListCollectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.ListCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCollectionsResponseModel**](ListCollectionsResponseModel.md)

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

<a id="reloadcollection"></a>
# **ReloadCollection**
> SubResponseAccumulatingJerseyResponseModel ReloadCollection (string collectionName, ReloadCollectionRequestBodyModel? reloadCollectionRequestBodyModel = null)

Reload all cores in the specified collection.

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
    public class ReloadCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var reloadCollectionRequestBodyModel = new ReloadCollectionRequestBodyModel?(); // ReloadCollectionRequestBodyModel? |  (optional) 

            try
            {
                // Reload all cores in the specified collection.
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.ReloadCollection(collectionName, reloadCollectionRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.ReloadCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReloadCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reload all cores in the specified collection.
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.ReloadCollectionWithHttpInfo(collectionName, reloadCollectionRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.ReloadCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **reloadCollectionRequestBodyModel** | [**ReloadCollectionRequestBodyModel?**](ReloadCollectionRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

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

<a id="renamecollection"></a>
# **RenameCollection**
> SubResponseAccumulatingJerseyResponseModel RenameCollection (string collectionName, RenameCollectionRequestBodyModel? renameCollectionRequestBodyModel = null)

Rename a SolrCloud collection

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
    public class RenameCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionsApi(httpClient, config, httpClientHandler);
            var collectionName = "collectionName_example";  // string | 
            var renameCollectionRequestBodyModel = new RenameCollectionRequestBodyModel?(); // RenameCollectionRequestBodyModel? |  (optional) 

            try
            {
                // Rename a SolrCloud collection
                SubResponseAccumulatingJerseyResponseModel result = apiInstance.RenameCollection(collectionName, renameCollectionRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionsApi.RenameCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename a SolrCloud collection
    ApiResponse<SubResponseAccumulatingJerseyResponseModel> response = apiInstance.RenameCollectionWithHttpInfo(collectionName, renameCollectionRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionsApi.RenameCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **renameCollectionRequestBodyModel** | [**RenameCollectionRequestBodyModel?**](RenameCollectionRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponseModel**](SubResponseAccumulatingJerseyResponseModel.md)

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

