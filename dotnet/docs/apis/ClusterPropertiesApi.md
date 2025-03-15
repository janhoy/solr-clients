# Org.OpenAPITools.Api.ClusterPropertiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrUpdateClusterProperty**](ClusterPropertiesApi.md#createorupdateclusterproperty) | **PUT** /cluster/properties/{propertyName} | Set a single new or existing cluster property in this Solr cluster. |
| [**CreateOrUpdateNestedClusterProperty**](ClusterPropertiesApi.md#createorupdatenestedclusterproperty) | **PUT** /cluster/properties | Set nested cluster properties in this Solr cluster. |
| [**DeleteClusterProperty**](ClusterPropertiesApi.md#deleteclusterproperty) | **DELETE** /cluster/properties/{propertyName} | Delete a cluster property in this Solr cluster. |
| [**GetClusterProperty**](ClusterPropertiesApi.md#getclusterproperty) | **GET** /cluster/properties/{propertyName} | Get a cluster property in this Solr cluster. |
| [**ListClusterProperties**](ClusterPropertiesApi.md#listclusterproperties) | **GET** /cluster/properties | List all cluster properties in this Solr cluster. |

<a id="createorupdateclusterproperty"></a>
# **CreateOrUpdateClusterProperty**
> SolrJerseyResponse CreateOrUpdateClusterProperty (string propertyName, SetClusterPropertyRequestBody setClusterPropertyRequestBody)

Set a single new or existing cluster property in this Solr cluster.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdateClusterPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterPropertiesApi(config);
            var propertyName = "propertyName_example";  // string | The name of the property being set.
            var setClusterPropertyRequestBody = new SetClusterPropertyRequestBody(); // SetClusterPropertyRequestBody | Value to set for the property

            try
            {
                // Set a single new or existing cluster property in this Solr cluster.
                SolrJerseyResponse result = apiInstance.CreateOrUpdateClusterProperty(propertyName, setClusterPropertyRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterPropertiesApi.CreateOrUpdateClusterProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateClusterPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a single new or existing cluster property in this Solr cluster.
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateOrUpdateClusterPropertyWithHttpInfo(propertyName, setClusterPropertyRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterPropertiesApi.CreateOrUpdateClusterPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **propertyName** | **string** | The name of the property being set. |  |
| **setClusterPropertyRequestBody** | [**SetClusterPropertyRequestBody**](SetClusterPropertyRequestBody.md) | Value to set for the property |  |

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

<a id="createorupdatenestedclusterproperty"></a>
# **CreateOrUpdateNestedClusterProperty**
> SolrJerseyResponse CreateOrUpdateNestedClusterProperty (Dictionary<string, Object> requestBody)

Set nested cluster properties in this Solr cluster.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdateNestedClusterPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterPropertiesApi(config);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | Property/ies to be set

            try
            {
                // Set nested cluster properties in this Solr cluster.
                SolrJerseyResponse result = apiInstance.CreateOrUpdateNestedClusterProperty(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterPropertiesApi.CreateOrUpdateNestedClusterProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateNestedClusterPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set nested cluster properties in this Solr cluster.
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateOrUpdateNestedClusterPropertyWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterPropertiesApi.CreateOrUpdateNestedClusterPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) | Property/ies to be set |  |

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

<a id="deleteclusterproperty"></a>
# **DeleteClusterProperty**
> SolrJerseyResponse DeleteClusterProperty (string propertyName)

Delete a cluster property in this Solr cluster.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteClusterPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterPropertiesApi(config);
            var propertyName = "propertyName_example";  // string | The name of the property being deleted.

            try
            {
                // Delete a cluster property in this Solr cluster.
                SolrJerseyResponse result = apiInstance.DeleteClusterProperty(propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterPropertiesApi.DeleteClusterProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteClusterPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a cluster property in this Solr cluster.
    ApiResponse<SolrJerseyResponse> response = apiInstance.DeleteClusterPropertyWithHttpInfo(propertyName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterPropertiesApi.DeleteClusterPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **propertyName** | **string** | The name of the property being deleted. |  |

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

<a id="getclusterproperty"></a>
# **GetClusterProperty**
> SolrJerseyResponse GetClusterProperty (string propertyName)

Get a cluster property in this Solr cluster.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterPropertiesApi(config);
            var propertyName = "propertyName_example";  // string | The name of the property being retrieved.

            try
            {
                // Get a cluster property in this Solr cluster.
                SolrJerseyResponse result = apiInstance.GetClusterProperty(propertyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterPropertiesApi.GetClusterProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClusterPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a cluster property in this Solr cluster.
    ApiResponse<SolrJerseyResponse> response = apiInstance.GetClusterPropertyWithHttpInfo(propertyName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterPropertiesApi.GetClusterPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **propertyName** | **string** | The name of the property being retrieved. |  |

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

<a id="listclusterproperties"></a>
# **ListClusterProperties**
> ListClusterPropertiesResponse ListClusterProperties ()

List all cluster properties in this Solr cluster.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListClusterPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterPropertiesApi(config);

            try
            {
                // List all cluster properties in this Solr cluster.
                ListClusterPropertiesResponse result = apiInstance.ListClusterProperties();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterPropertiesApi.ListClusterProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListClusterPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all cluster properties in this Solr cluster.
    ApiResponse<ListClusterPropertiesResponse> response = apiInstance.ListClusterPropertiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterPropertiesApi.ListClusterPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListClusterPropertiesResponse**](ListClusterPropertiesResponse.md)

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

