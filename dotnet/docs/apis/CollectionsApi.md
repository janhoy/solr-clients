# Org.OpenAPITools.Api.CollectionsApi

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
> SubResponseAccumulatingJerseyResponse BalanceShardUnique (string collectionName, BalanceShardUniqueRequestBody balanceShardUniqueRequestBody = null)

Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalanceShardUniqueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);
            var collectionName = "collectionName_example";  // string | 
            var balanceShardUniqueRequestBody = new BalanceShardUniqueRequestBody(); // BalanceShardUniqueRequestBody |  (optional) 

            try
            {
                // Ensure a specified per-shard property is distributed evenly amongst physical nodes comprising a collection
                SubResponseAccumulatingJerseyResponse result = apiInstance.BalanceShardUnique(collectionName, balanceShardUniqueRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.BalanceShardUniqueWithHttpInfo(collectionName, balanceShardUniqueRequestBody);
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
| **balanceShardUniqueRequestBody** | [**BalanceShardUniqueRequestBody**](BalanceShardUniqueRequestBody.md) |  | [optional]  |

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

<a id="createcollection"></a>
# **CreateCollection**
> SubResponseAccumulatingJerseyResponse CreateCollection (CreateCollectionRequestBody createCollectionRequestBody = null)

Creates a new SolrCloud collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);
            var createCollectionRequestBody = new CreateCollectionRequestBody(); // CreateCollectionRequestBody |  (optional) 

            try
            {
                // Creates a new SolrCloud collection.
                SubResponseAccumulatingJerseyResponse result = apiInstance.CreateCollection(createCollectionRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.CreateCollectionWithHttpInfo(createCollectionRequestBody);
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
| **createCollectionRequestBody** | [**CreateCollectionRequestBody**](CreateCollectionRequestBody.md) |  | [optional]  |

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

<a id="deletecollection"></a>
# **DeleteCollection**
> SubResponseAccumulatingJerseyResponse DeleteCollection (string collectionName, bool followAliases = null, string async = null)

Deletes a collection from SolrCloud

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);
            var collectionName = "collectionName_example";  // string | The name of the collection to be deleted.
            var followAliases = true;  // bool |  (optional) 
            var async = "async_example";  // string | An ID to track the request asynchronously (optional) 

            try
            {
                // Deletes a collection from SolrCloud
                SubResponseAccumulatingJerseyResponse result = apiInstance.DeleteCollection(collectionName, followAliases, async);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.DeleteCollectionWithHttpInfo(collectionName, followAliases, async);
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
| **followAliases** | **bool** |  | [optional]  |
| **async** | **string** | An ID to track the request asynchronously | [optional]  |

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

<a id="listcollections"></a>
# **ListCollections**
> ListCollectionsResponse ListCollections ()

List all collections in this Solr cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);

            try
            {
                // List all collections in this Solr cluster
                ListCollectionsResponse result = apiInstance.ListCollections();
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
    ApiResponse<ListCollectionsResponse> response = apiInstance.ListCollectionsWithHttpInfo();
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

[**ListCollectionsResponse**](ListCollectionsResponse.md)

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

<a id="reloadcollection"></a>
# **ReloadCollection**
> SubResponseAccumulatingJerseyResponse ReloadCollection (string collectionName, ReloadCollectionRequestBody reloadCollectionRequestBody = null)

Reload all cores in the specified collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReloadCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);
            var collectionName = "collectionName_example";  // string | 
            var reloadCollectionRequestBody = new ReloadCollectionRequestBody(); // ReloadCollectionRequestBody |  (optional) 

            try
            {
                // Reload all cores in the specified collection.
                SubResponseAccumulatingJerseyResponse result = apiInstance.ReloadCollection(collectionName, reloadCollectionRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.ReloadCollectionWithHttpInfo(collectionName, reloadCollectionRequestBody);
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
| **reloadCollectionRequestBody** | [**ReloadCollectionRequestBody**](ReloadCollectionRequestBody.md) |  | [optional]  |

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

<a id="renamecollection"></a>
# **RenameCollection**
> SubResponseAccumulatingJerseyResponse RenameCollection (string collectionName, RenameCollectionRequestBody renameCollectionRequestBody = null)

Rename a SolrCloud collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenameCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionsApi(config);
            var collectionName = "collectionName_example";  // string | 
            var renameCollectionRequestBody = new RenameCollectionRequestBody(); // RenameCollectionRequestBody |  (optional) 

            try
            {
                // Rename a SolrCloud collection
                SubResponseAccumulatingJerseyResponse result = apiInstance.RenameCollection(collectionName, renameCollectionRequestBody);
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
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.RenameCollectionWithHttpInfo(collectionName, renameCollectionRequestBody);
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
| **renameCollectionRequestBody** | [**RenameCollectionRequestBody**](RenameCollectionRequestBody.md) |  | [optional]  |

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

