# Org.OpenAPITools.Api.CollectionPropertiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrUpdateCollectionProperty**](CollectionPropertiesApi.md#createorupdatecollectionproperty) | **PUT** /collections/{collName}/properties/{propName} | Create or update a collection property |
| [**DeleteCollectionProperty**](CollectionPropertiesApi.md#deletecollectionproperty) | **DELETE** /collections/{collName}/properties/{propName} | Delete the specified collection property from the collection |

<a id="createorupdatecollectionproperty"></a>
# **CreateOrUpdateCollectionProperty**
> SolrJerseyResponse CreateOrUpdateCollectionProperty (string collName, string propName, UpdateCollectionPropertyRequestBody updateCollectionPropertyRequestBody = null)

Create or update a collection property

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdateCollectionPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionPropertiesApi(config);
            var collName = "collName_example";  // string | 
            var propName = "propName_example";  // string | 
            var updateCollectionPropertyRequestBody = new UpdateCollectionPropertyRequestBody(); // UpdateCollectionPropertyRequestBody |  (optional) 

            try
            {
                // Create or update a collection property
                SolrJerseyResponse result = apiInstance.CreateOrUpdateCollectionProperty(collName, propName, updateCollectionPropertyRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateOrUpdateCollectionPropertyWithHttpInfo(collName, propName, updateCollectionPropertyRequestBody);
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
| **updateCollectionPropertyRequestBody** | [**UpdateCollectionPropertyRequestBody**](UpdateCollectionPropertyRequestBody.md) |  | [optional]  |

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

<a id="deletecollectionproperty"></a>
# **DeleteCollectionProperty**
> SolrJerseyResponse DeleteCollectionProperty (string collName, string propName)

Delete the specified collection property from the collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCollectionPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionPropertiesApi(config);
            var collName = "collName_example";  // string | 
            var propName = "propName_example";  // string | 

            try
            {
                // Delete the specified collection property from the collection
                SolrJerseyResponse result = apiInstance.DeleteCollectionProperty(collName, propName);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.DeleteCollectionPropertyWithHttpInfo(collName, propName);
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

