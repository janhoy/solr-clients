# ApacheSolr.Api.SchemaApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDynamicFieldInfo**](SchemaApi.md#getdynamicfieldinfo) | **GET** /{indexType}/{indexName}/schema/dynamicfields/{fieldName} | Get detailed info about a single dynamic field |
| [**GetFieldInfo**](SchemaApi.md#getfieldinfo) | **GET** /{indexType}/{indexName}/schema/fields/{fieldName} | Get detailed info about a single non-dynamic field |
| [**GetFieldTypeInfo**](SchemaApi.md#getfieldtypeinfo) | **GET** /{indexType}/{indexName}/schema/fieldtypes/{fieldTypeName} | Get detailed info about a single field type |
| [**GetSchemaInfo**](SchemaApi.md#getschemainfo) | **GET** /{indexType}/{indexName}/schema | Fetch the entire schema of the specified core or collection |
| [**GetSchemaName**](SchemaApi.md#getschemaname) | **GET** /{indexType}/{indexName}/schema/name | Get the name of the schema used by the specified core or collection |
| [**GetSchemaSimilarity**](SchemaApi.md#getschemasimilarity) | **GET** /{indexType}/{indexName}/schema/similarity | Get the default similarity configuration used by the specified core or collection |
| [**GetSchemaUniqueKey**](SchemaApi.md#getschemauniquekey) | **GET** /{indexType}/{indexName}/schema/uniquekey | Fetch the uniquekey of the specified core or collection |
| [**GetSchemaVersion**](SchemaApi.md#getschemaversion) | **GET** /{indexType}/{indexName}/schema/version | Fetch the schema version currently used by the specified core or collection |
| [**GetSchemaZkVersion**](SchemaApi.md#getschemazkversion) | **GET** /{indexType}/{indexName}/schema/zkversion | Fetch the schema version currently used by the specified core or collection |
| [**ListCopyFields**](SchemaApi.md#listcopyfields) | **GET** /{indexType}/{indexName}/schema/copyfields | List all copy-fields in the schema of the specified core or collection |
| [**ListDynamicFields**](SchemaApi.md#listdynamicfields) | **GET** /{indexType}/{indexName}/schema/dynamicfields | List all dynamic-fields in the schema of the specified core or collection |
| [**ListSchemaFieldTypes**](SchemaApi.md#listschemafieldtypes) | **GET** /{indexType}/{indexName}/schema/fieldtypes | List all field types in the schema used by the specified core or collection |
| [**ListSchemaFields**](SchemaApi.md#listschemafields) | **GET** /{indexType}/{indexName}/schema/fields | List all non-dynamic fields in the schema of the specified core or collection |

<a id="getdynamicfieldinfo"></a>
# **GetDynamicFieldInfo**
> SchemaGetDynamicFieldInfoResponseModel GetDynamicFieldInfo (IndexTypeModel indexType, string indexName, string fieldName)

Get detailed info about a single dynamic field

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
    public class GetDynamicFieldInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 
            var fieldName = "fieldName_example";  // string | 

            try
            {
                // Get detailed info about a single dynamic field
                SchemaGetDynamicFieldInfoResponseModel result = apiInstance.GetDynamicFieldInfo(indexType, indexName, fieldName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetDynamicFieldInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDynamicFieldInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get detailed info about a single dynamic field
    ApiResponse<SchemaGetDynamicFieldInfoResponseModel> response = apiInstance.GetDynamicFieldInfoWithHttpInfo(indexType, indexName, fieldName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetDynamicFieldInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |
| **fieldName** | **string** |  |  |

### Return type

[**SchemaGetDynamicFieldInfoResponseModel**](SchemaGetDynamicFieldInfoResponseModel.md)

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

<a id="getfieldinfo"></a>
# **GetFieldInfo**
> SchemaGetFieldInfoResponseModel GetFieldInfo (IndexTypeModel indexType, string indexName, string fieldName)

Get detailed info about a single non-dynamic field

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
    public class GetFieldInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 
            var fieldName = "fieldName_example";  // string | 

            try
            {
                // Get detailed info about a single non-dynamic field
                SchemaGetFieldInfoResponseModel result = apiInstance.GetFieldInfo(indexType, indexName, fieldName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetFieldInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get detailed info about a single non-dynamic field
    ApiResponse<SchemaGetFieldInfoResponseModel> response = apiInstance.GetFieldInfoWithHttpInfo(indexType, indexName, fieldName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetFieldInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |
| **fieldName** | **string** |  |  |

### Return type

[**SchemaGetFieldInfoResponseModel**](SchemaGetFieldInfoResponseModel.md)

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

<a id="getfieldtypeinfo"></a>
# **GetFieldTypeInfo**
> SchemaGetFieldTypeInfoResponseModel GetFieldTypeInfo (IndexTypeModel indexType, string indexName, string fieldTypeName)

Get detailed info about a single field type

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
    public class GetFieldTypeInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 
            var fieldTypeName = "fieldTypeName_example";  // string | 

            try
            {
                // Get detailed info about a single field type
                SchemaGetFieldTypeInfoResponseModel result = apiInstance.GetFieldTypeInfo(indexType, indexName, fieldTypeName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetFieldTypeInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFieldTypeInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get detailed info about a single field type
    ApiResponse<SchemaGetFieldTypeInfoResponseModel> response = apiInstance.GetFieldTypeInfoWithHttpInfo(indexType, indexName, fieldTypeName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetFieldTypeInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |
| **fieldTypeName** | **string** |  |  |

### Return type

[**SchemaGetFieldTypeInfoResponseModel**](SchemaGetFieldTypeInfoResponseModel.md)

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

<a id="getschemainfo"></a>
# **GetSchemaInfo**
> SchemaInfoResponseModel GetSchemaInfo (IndexTypeModel indexType, string indexName)

Fetch the entire schema of the specified core or collection

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
    public class GetSchemaInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // Fetch the entire schema of the specified core or collection
                SchemaInfoResponseModel result = apiInstance.GetSchemaInfo(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the entire schema of the specified core or collection
    ApiResponse<SchemaInfoResponseModel> response = apiInstance.GetSchemaInfoWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaInfoResponseModel**](SchemaInfoResponseModel.md)

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

<a id="getschemaname"></a>
# **GetSchemaName**
> SchemaNameResponseModel GetSchemaName (IndexTypeModel indexType, string indexName)

Get the name of the schema used by the specified core or collection

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
    public class GetSchemaNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // Get the name of the schema used by the specified core or collection
                SchemaNameResponseModel result = apiInstance.GetSchemaName(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the name of the schema used by the specified core or collection
    ApiResponse<SchemaNameResponseModel> response = apiInstance.GetSchemaNameWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaNameResponseModel**](SchemaNameResponseModel.md)

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

<a id="getschemasimilarity"></a>
# **GetSchemaSimilarity**
> SchemaSimilarityResponseModel GetSchemaSimilarity (IndexTypeModel indexType, string indexName)

Get the default similarity configuration used by the specified core or collection

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
    public class GetSchemaSimilarityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // Get the default similarity configuration used by the specified core or collection
                SchemaSimilarityResponseModel result = apiInstance.GetSchemaSimilarity(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaSimilarity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaSimilarityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the default similarity configuration used by the specified core or collection
    ApiResponse<SchemaSimilarityResponseModel> response = apiInstance.GetSchemaSimilarityWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaSimilarityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaSimilarityResponseModel**](SchemaSimilarityResponseModel.md)

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

<a id="getschemauniquekey"></a>
# **GetSchemaUniqueKey**
> SchemaUniqueKeyResponseModel GetSchemaUniqueKey (IndexTypeModel indexType, string indexName)

Fetch the uniquekey of the specified core or collection

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
    public class GetSchemaUniqueKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // Fetch the uniquekey of the specified core or collection
                SchemaUniqueKeyResponseModel result = apiInstance.GetSchemaUniqueKey(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaUniqueKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaUniqueKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the uniquekey of the specified core or collection
    ApiResponse<SchemaUniqueKeyResponseModel> response = apiInstance.GetSchemaUniqueKeyWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaUniqueKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaUniqueKeyResponseModel**](SchemaUniqueKeyResponseModel.md)

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

<a id="getschemaversion"></a>
# **GetSchemaVersion**
> SchemaVersionResponseModel GetSchemaVersion (IndexTypeModel indexType, string indexName)

Fetch the schema version currently used by the specified core or collection

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
    public class GetSchemaVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // Fetch the schema version currently used by the specified core or collection
                SchemaVersionResponseModel result = apiInstance.GetSchemaVersion(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the schema version currently used by the specified core or collection
    ApiResponse<SchemaVersionResponseModel> response = apiInstance.GetSchemaVersionWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaVersionResponseModel**](SchemaVersionResponseModel.md)

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

<a id="getschemazkversion"></a>
# **GetSchemaZkVersion**
> SchemaZkVersionResponseModel GetSchemaZkVersion (IndexTypeModel indexType, string indexName, int? refreshIfBelowVersion = null)

Fetch the schema version currently used by the specified core or collection

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
    public class GetSchemaZkVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 
            var refreshIfBelowVersion = 56;  // int? |  (optional) 

            try
            {
                // Fetch the schema version currently used by the specified core or collection
                SchemaZkVersionResponseModel result = apiInstance.GetSchemaZkVersion(indexType, indexName, refreshIfBelowVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaZkVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchemaZkVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch the schema version currently used by the specified core or collection
    ApiResponse<SchemaZkVersionResponseModel> response = apiInstance.GetSchemaZkVersionWithHttpInfo(indexType, indexName, refreshIfBelowVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.GetSchemaZkVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |
| **refreshIfBelowVersion** | **int?** |  | [optional]  |

### Return type

[**SchemaZkVersionResponseModel**](SchemaZkVersionResponseModel.md)

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

<a id="listcopyfields"></a>
# **ListCopyFields**
> SchemaListCopyFieldsResponseModel ListCopyFields (IndexTypeModel indexType, string indexName)

List all copy-fields in the schema of the specified core or collection

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
    public class ListCopyFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // List all copy-fields in the schema of the specified core or collection
                SchemaListCopyFieldsResponseModel result = apiInstance.ListCopyFields(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListCopyFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCopyFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all copy-fields in the schema of the specified core or collection
    ApiResponse<SchemaListCopyFieldsResponseModel> response = apiInstance.ListCopyFieldsWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.ListCopyFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaListCopyFieldsResponseModel**](SchemaListCopyFieldsResponseModel.md)

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

<a id="listdynamicfields"></a>
# **ListDynamicFields**
> SchemaListDynamicFieldsResponseModel ListDynamicFields (IndexTypeModel indexType, string indexName)

List all dynamic-fields in the schema of the specified core or collection

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
    public class ListDynamicFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // List all dynamic-fields in the schema of the specified core or collection
                SchemaListDynamicFieldsResponseModel result = apiInstance.ListDynamicFields(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListDynamicFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDynamicFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all dynamic-fields in the schema of the specified core or collection
    ApiResponse<SchemaListDynamicFieldsResponseModel> response = apiInstance.ListDynamicFieldsWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.ListDynamicFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaListDynamicFieldsResponseModel**](SchemaListDynamicFieldsResponseModel.md)

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

<a id="listschemafieldtypes"></a>
# **ListSchemaFieldTypes**
> SchemaListFieldTypesResponseModel ListSchemaFieldTypes (IndexTypeModel indexType, string indexName)

List all field types in the schema used by the specified core or collection

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
    public class ListSchemaFieldTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // List all field types in the schema used by the specified core or collection
                SchemaListFieldTypesResponseModel result = apiInstance.ListSchemaFieldTypes(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListSchemaFieldTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSchemaFieldTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all field types in the schema used by the specified core or collection
    ApiResponse<SchemaListFieldTypesResponseModel> response = apiInstance.ListSchemaFieldTypesWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.ListSchemaFieldTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaListFieldTypesResponseModel**](SchemaListFieldTypesResponseModel.md)

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

<a id="listschemafields"></a>
# **ListSchemaFields**
> SchemaListFieldsResponseModel ListSchemaFields (IndexTypeModel indexType, string indexName)

List all non-dynamic fields in the schema of the specified core or collection

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
    public class ListSchemaFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SchemaApi(httpClient, config, httpClientHandler);
            var indexType = (IndexTypeModel) "collections";  // IndexTypeModel | 
            var indexName = "indexName_example";  // string | 

            try
            {
                // List all non-dynamic fields in the schema of the specified core or collection
                SchemaListFieldsResponseModel result = apiInstance.ListSchemaFields(indexType, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ListSchemaFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSchemaFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all non-dynamic fields in the schema of the specified core or collection
    ApiResponse<SchemaListFieldsResponseModel> response = apiInstance.ListSchemaFieldsWithHttpInfo(indexType, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.ListSchemaFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexTypeModel** |  |  |
| **indexName** | **string** |  |  |

### Return type

[**SchemaListFieldsResponseModel**](SchemaListFieldsResponseModel.md)

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

