# ApacheSolr.Api.CollectionPropertiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrUpdateCollectionProperty**](CollectionPropertiesApi.md#createorupdatecollectionproperty) | **PUT** /collections/{collName}/properties/{propName} | Create or update a collection property |
| [**DeleteCollectionProperty**](CollectionPropertiesApi.md#deletecollectionproperty) | **DELETE** /collections/{collName}/properties/{propName} | Delete the specified collection property from the collection |

<a id="createorupdatecollectionproperty"></a>
# **CreateOrUpdateCollectionProperty**
> SolrJerseyResponseModel CreateOrUpdateCollectionProperty (string collName, string propName, UpdateCollectionPropertyRequestBodyModel? updateCollectionPropertyRequestBodyModel = null)

Create or update a collection property

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
    public class CreateOrUpdateCollectionPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionPropertiesApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | 
            var propName = "propName_example";  // string | 
            var updateCollectionPropertyRequestBodyModel = new UpdateCollectionPropertyRequestBodyModel?(); // UpdateCollectionPropertyRequestBodyModel? |  (optional) 

            try
            {
                // Create or update a collection property
                SolrJerseyResponseModel result = apiInstance.CreateOrUpdateCollectionProperty(collName, propName, updateCollectionPropertyRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionPropertiesApi.CreateOrUpdateCollectionProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateCollectionPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or update a collection property
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.CreateOrUpdateCollectionPropertyWithHttpInfo(collName, propName, updateCollectionPropertyRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionPropertiesApi.CreateOrUpdateCollectionPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** |  |  |
| **propName** | **string** |  |  |
| **updateCollectionPropertyRequestBodyModel** | [**UpdateCollectionPropertyRequestBodyModel?**](UpdateCollectionPropertyRequestBodyModel?.md) |  | [optional]  |

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

<a id="deletecollectionproperty"></a>
# **DeleteCollectionProperty**
> SolrJerseyResponseModel DeleteCollectionProperty (string collName, string propName)

Delete the specified collection property from the collection

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
    public class DeleteCollectionPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CollectionPropertiesApi(httpClient, config, httpClientHandler);
            var collName = "collName_example";  // string | 
            var propName = "propName_example";  // string | 

            try
            {
                // Delete the specified collection property from the collection
                SolrJerseyResponseModel result = apiInstance.DeleteCollectionProperty(collName, propName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionPropertiesApi.DeleteCollectionProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCollectionPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the specified collection property from the collection
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.DeleteCollectionPropertyWithHttpInfo(collName, propName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionPropertiesApi.DeleteCollectionPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collName** | **string** |  |  |
| **propName** | **string** |  |  |

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

