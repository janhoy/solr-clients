# Org.OpenAPITools.Api.AliasPropertiesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrUpdateAliasProperty**](AliasPropertiesApi.md#createorupdatealiasproperty) | **PUT** /aliases/{aliasName}/properties/{propName} | Update a specific property for a collection alias. |
| [**DeleteAliasProperty**](AliasPropertiesApi.md#deletealiasproperty) | **DELETE** /aliases/{aliasName}/properties/{propName} | Delete a specific property for a collection alias. |
| [**GetAliasProperty**](AliasPropertiesApi.md#getaliasproperty) | **GET** /aliases/{aliasName}/properties/{propName} | Get a specific property for a collection alias. |
| [**GetAllAliasProperties**](AliasPropertiesApi.md#getallaliasproperties) | **GET** /aliases/{aliasName}/properties | Get properties for a collection alias. |
| [**UpdateAliasProperties**](AliasPropertiesApi.md#updatealiasproperties) | **PUT** /aliases/{aliasName}/properties | Update properties for a collection alias. |

<a id="createorupdatealiasproperty"></a>
# **CreateOrUpdateAliasProperty**
> SolrJerseyResponse CreateOrUpdateAliasProperty (string aliasName, string propName, UpdateAliasPropertyRequestBody updateAliasPropertyRequestBody)

Update a specific property for a collection alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateOrUpdateAliasPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasPropertiesApi(config);
            var aliasName = "aliasName_example";  // string | Alias Name
            var propName = "propName_example";  // string | Property Name
            var updateAliasPropertyRequestBody = new UpdateAliasPropertyRequestBody(); // UpdateAliasPropertyRequestBody | Property value that needs to be updated

            try
            {
                // Update a specific property for a collection alias.
                SolrJerseyResponse result = apiInstance.CreateOrUpdateAliasProperty(aliasName, propName, updateAliasPropertyRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasPropertiesApi.CreateOrUpdateAliasProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateAliasPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a specific property for a collection alias.
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateOrUpdateAliasPropertyWithHttpInfo(aliasName, propName, updateAliasPropertyRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasPropertiesApi.CreateOrUpdateAliasPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aliasName** | **string** | Alias Name |  |
| **propName** | **string** | Property Name |  |
| **updateAliasPropertyRequestBody** | [**UpdateAliasPropertyRequestBody**](UpdateAliasPropertyRequestBody.md) | Property value that needs to be updated |  |

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

<a id="deletealiasproperty"></a>
# **DeleteAliasProperty**
> SolrJerseyResponse DeleteAliasProperty (string aliasName, string propName)

Delete a specific property for a collection alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteAliasPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasPropertiesApi(config);
            var aliasName = "aliasName_example";  // string | Alias Name
            var propName = "propName_example";  // string | Property Name

            try
            {
                // Delete a specific property for a collection alias.
                SolrJerseyResponse result = apiInstance.DeleteAliasProperty(aliasName, propName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasPropertiesApi.DeleteAliasProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAliasPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific property for a collection alias.
    ApiResponse<SolrJerseyResponse> response = apiInstance.DeleteAliasPropertyWithHttpInfo(aliasName, propName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasPropertiesApi.DeleteAliasPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aliasName** | **string** | Alias Name |  |
| **propName** | **string** | Property Name |  |

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

<a id="getaliasproperty"></a>
# **GetAliasProperty**
> GetAliasPropertyResponse GetAliasProperty (string aliasName, string propName)

Get a specific property for a collection alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAliasPropertyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasPropertiesApi(config);
            var aliasName = "aliasName_example";  // string | Alias Name
            var propName = "propName_example";  // string | Property Name

            try
            {
                // Get a specific property for a collection alias.
                GetAliasPropertyResponse result = apiInstance.GetAliasProperty(aliasName, propName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasPropertiesApi.GetAliasProperty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAliasPropertyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific property for a collection alias.
    ApiResponse<GetAliasPropertyResponse> response = apiInstance.GetAliasPropertyWithHttpInfo(aliasName, propName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasPropertiesApi.GetAliasPropertyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aliasName** | **string** | Alias Name |  |
| **propName** | **string** | Property Name |  |

### Return type

[**GetAliasPropertyResponse**](GetAliasPropertyResponse.md)

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

<a id="getallaliasproperties"></a>
# **GetAllAliasProperties**
> GetAllAliasPropertiesResponse GetAllAliasProperties (string aliasName)

Get properties for a collection alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAllAliasPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasPropertiesApi(config);
            var aliasName = "aliasName_example";  // string | Alias Name

            try
            {
                // Get properties for a collection alias.
                GetAllAliasPropertiesResponse result = apiInstance.GetAllAliasProperties(aliasName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasPropertiesApi.GetAllAliasProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllAliasPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get properties for a collection alias.
    ApiResponse<GetAllAliasPropertiesResponse> response = apiInstance.GetAllAliasPropertiesWithHttpInfo(aliasName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasPropertiesApi.GetAllAliasPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aliasName** | **string** | Alias Name |  |

### Return type

[**GetAllAliasPropertiesResponse**](GetAllAliasPropertiesResponse.md)

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

<a id="updatealiasproperties"></a>
# **UpdateAliasProperties**
> SolrJerseyResponse UpdateAliasProperties (string aliasName, UpdateAliasPropertiesRequestBody updateAliasPropertiesRequestBody)

Update properties for a collection alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateAliasPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasPropertiesApi(config);
            var aliasName = "aliasName_example";  // string | Alias Name
            var updateAliasPropertiesRequestBody = new UpdateAliasPropertiesRequestBody(); // UpdateAliasPropertiesRequestBody | Properties that need to be updated

            try
            {
                // Update properties for a collection alias.
                SolrJerseyResponse result = apiInstance.UpdateAliasProperties(aliasName, updateAliasPropertiesRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasPropertiesApi.UpdateAliasProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAliasPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update properties for a collection alias.
    ApiResponse<SolrJerseyResponse> response = apiInstance.UpdateAliasPropertiesWithHttpInfo(aliasName, updateAliasPropertiesRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasPropertiesApi.UpdateAliasPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aliasName** | **string** | Alias Name |  |
| **updateAliasPropertiesRequestBody** | [**UpdateAliasPropertiesRequestBody**](UpdateAliasPropertiesRequestBody.md) | Properties that need to be updated |  |

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

