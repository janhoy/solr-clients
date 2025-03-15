# Org.OpenAPITools.Api.QueryingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**JsonQuery**](QueryingApi.md#jsonquery) | **POST** /{indexType}/{indexName}/select | Query a Solr core or collection using the structured request DSL |
| [**Query**](QueryingApi.md#query) | **GET** /{indexType}/{indexName}/select | Query a Solr core or collection using individual query parameters |

<a id="jsonquery"></a>
# **JsonQuery**
> FlexibleSolrJerseyResponse JsonQuery (IndexType indexType, string indexName, Object body)

Query a Solr core or collection using the structured request DSL

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class JsonQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryingApi(config);
            var indexType = (IndexType) "collections";  // IndexType | 
            var indexName = "indexName_example";  // string | 
            var body = null;  // Object | 

            try
            {
                // Query a Solr core or collection using the structured request DSL
                FlexibleSolrJerseyResponse result = apiInstance.JsonQuery(indexType, indexName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryingApi.JsonQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JsonQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query a Solr core or collection using the structured request DSL
    ApiResponse<FlexibleSolrJerseyResponse> response = apiInstance.JsonQueryWithHttpInfo(indexType, indexName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryingApi.JsonQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexType** |  |  |
| **indexName** | **string** |  |  |
| **body** | **Object** |  |  |

### Return type

[**FlexibleSolrJerseyResponse**](FlexibleSolrJerseyResponse.md)

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

<a id="query"></a>
# **Query**
> FlexibleSolrJerseyResponse Query (IndexType indexType, string indexName, string q = null, List<string> fq = null, string fl = null, int rows = null)

Query a Solr core or collection using individual query parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryingApi(config);
            var indexType = (IndexType) "collections";  // IndexType | 
            var indexName = "indexName_example";  // string | 
            var q = "q_example";  // string |  (optional) 
            var fq = new List<string>(); // List<string> |  (optional) 
            var fl = "fl_example";  // string |  (optional) 
            var rows = 56;  // int |  (optional) 

            try
            {
                // Query a Solr core or collection using individual query parameters
                FlexibleSolrJerseyResponse result = apiInstance.Query(indexType, indexName, q, fq, fl, rows);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryingApi.Query: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query a Solr core or collection using individual query parameters
    ApiResponse<FlexibleSolrJerseyResponse> response = apiInstance.QueryWithHttpInfo(indexType, indexName, q, fq, fl, rows);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryingApi.QueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **indexType** | **IndexType** |  |  |
| **indexName** | **string** |  |  |
| **q** | **string** |  | [optional]  |
| **fq** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **fl** | **string** |  | [optional]  |
| **rows** | **int** |  | [optional]  |

### Return type

[**FlexibleSolrJerseyResponse**](FlexibleSolrJerseyResponse.md)

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

