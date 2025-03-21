# ApacheSolr.Api.ZookeeperReadApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListNodes**](ZookeeperReadApi.md#listnodes) | **GET** /cluster/zookeeper/children{zkPath} | List and stat all children of a specified ZooKeeper node |
| [**ReadNode**](ZookeeperReadApi.md#readnode) | **GET** /cluster/zookeeper/data{zkPath} | Return the data stored in a specified ZooKeeper node |

<a id="listnodes"></a>
# **ListNodes**
> ZooKeeperListChildrenResponseModel ListNodes (string zkPath, bool? children = null)

List and stat all children of a specified ZooKeeper node

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
    public class ListNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ZookeeperReadApi(httpClient, config, httpClientHandler);
            var zkPath = "zkPath_example";  // string | The path of the ZooKeeper node to stat and list children of
            var children = true;  // bool? | Controls whether stat information for child nodes is included in the response. 'true' by default. (optional) 

            try
            {
                // List and stat all children of a specified ZooKeeper node
                ZooKeeperListChildrenResponseModel result = apiInstance.ListNodes(zkPath, children);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZookeeperReadApi.ListNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List and stat all children of a specified ZooKeeper node
    ApiResponse<ZooKeeperListChildrenResponseModel> response = apiInstance.ListNodesWithHttpInfo(zkPath, children);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZookeeperReadApi.ListNodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zkPath** | **string** | The path of the ZooKeeper node to stat and list children of |  |
| **children** | **bool?** | Controls whether stat information for child nodes is included in the response. &#39;true&#39; by default. | [optional]  |

### Return type

[**ZooKeeperListChildrenResponseModel**](ZooKeeperListChildrenResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/javabin


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readnode"></a>
# **ReadNode**
> ZooKeeperFileResponseModel ReadNode (string zkPath)

Return the data stored in a specified ZooKeeper node

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
    public class ReadNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ZookeeperReadApi(httpClient, config, httpClientHandler);
            var zkPath = "zkPath_example";  // string | The path of the node to read from ZooKeeper

            try
            {
                // Return the data stored in a specified ZooKeeper node
                ZooKeeperFileResponseModel result = apiInstance.ReadNode(zkPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ZookeeperReadApi.ReadNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return the data stored in a specified ZooKeeper node
    ApiResponse<ZooKeeperFileResponseModel> response = apiInstance.ReadNodeWithHttpInfo(zkPath);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ZookeeperReadApi.ReadNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zkPath** | **string** | The path of the node to read from ZooKeeper |  |

### Return type

[**ZooKeeperFileResponseModel**](ZooKeeperFileResponseModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.apache.solr.raw, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

