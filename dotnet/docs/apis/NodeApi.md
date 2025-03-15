# Org.OpenAPITools.Api.NodeApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteNode**](NodeApi.md#deletenode) | **POST** /cluster/nodes/{nodeName}/clear | Delete all replicas off of the specified SolrCloud node |
| [**GetCommandStatus**](NodeApi.md#getcommandstatus) | **GET** /node/commands/{requestId} | Request the status of an already submitted asynchronous CoreAdmin API call. |
| [**GetPublicKey**](NodeApi.md#getpublickey) | **GET** /node/key | Retrieve the public key of the receiving Solr node. |
| [**ReplaceNode**](NodeApi.md#replacenode) | **POST** /cluster/nodes/{sourceNodeName}/replace | &#39;Replace&#39; a specified node by moving all replicas elsewhere |

<a id="deletenode"></a>
# **DeleteNode**
> SolrJerseyResponse DeleteNode (string nodeName, DeleteNodeRequestBody deleteNodeRequestBody)

Delete all replicas off of the specified SolrCloud node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NodeApi(config);
            var nodeName = "nodeName_example";  // string | The name of the node to be cleared.  Usually of the form 'host:1234_solr'.
            var deleteNodeRequestBody = new DeleteNodeRequestBody(); // DeleteNodeRequestBody | Contains user provided parameters

            try
            {
                // Delete all replicas off of the specified SolrCloud node
                SolrJerseyResponse result = apiInstance.DeleteNode(nodeName, deleteNodeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NodeApi.DeleteNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all replicas off of the specified SolrCloud node
    ApiResponse<SolrJerseyResponse> response = apiInstance.DeleteNodeWithHttpInfo(nodeName, deleteNodeRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NodeApi.DeleteNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nodeName** | **string** | The name of the node to be cleared.  Usually of the form &#39;host:1234_solr&#39;. |  |
| **deleteNodeRequestBody** | [**DeleteNodeRequestBody**](DeleteNodeRequestBody.md) | Contains user provided parameters |  |

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

<a id="getcommandstatus"></a>
# **GetCommandStatus**
> GetNodeCommandStatusResponse GetCommandStatus (string requestId)

Request the status of an already submitted asynchronous CoreAdmin API call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCommandStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NodeApi(config);
            var requestId = "requestId_example";  // string | The user defined request-id for the asynchronous request.

            try
            {
                // Request the status of an already submitted asynchronous CoreAdmin API call.
                GetNodeCommandStatusResponse result = apiInstance.GetCommandStatus(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NodeApi.GetCommandStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommandStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request the status of an already submitted asynchronous CoreAdmin API call.
    ApiResponse<GetNodeCommandStatusResponse> response = apiInstance.GetCommandStatusWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NodeApi.GetCommandStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | The user defined request-id for the asynchronous request. |  |

### Return type

[**GetNodeCommandStatusResponse**](GetNodeCommandStatusResponse.md)

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

<a id="getpublickey"></a>
# **GetPublicKey**
> PublicKeyResponse GetPublicKey ()

Retrieve the public key of the receiving Solr node.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NodeApi(config);

            try
            {
                // Retrieve the public key of the receiving Solr node.
                PublicKeyResponse result = apiInstance.GetPublicKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NodeApi.GetPublicKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the public key of the receiving Solr node.
    ApiResponse<PublicKeyResponse> response = apiInstance.GetPublicKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NodeApi.GetPublicKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PublicKeyResponse**](PublicKeyResponse.md)

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

<a id="replacenode"></a>
# **ReplaceNode**
> SolrJerseyResponse ReplaceNode (string sourceNodeName, ReplaceNodeRequestBody replaceNodeRequestBody)

'Replace' a specified node by moving all replicas elsewhere

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NodeApi(config);
            var sourceNodeName = "sourceNodeName_example";  // string | The name of the node to be replaced.
            var replaceNodeRequestBody = new ReplaceNodeRequestBody(); // ReplaceNodeRequestBody | Contains user provided parameters

            try
            {
                // 'Replace' a specified node by moving all replicas elsewhere
                SolrJerseyResponse result = apiInstance.ReplaceNode(sourceNodeName, replaceNodeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NodeApi.ReplaceNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 'Replace' a specified node by moving all replicas elsewhere
    ApiResponse<SolrJerseyResponse> response = apiInstance.ReplaceNodeWithHttpInfo(sourceNodeName, replaceNodeRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NodeApi.ReplaceNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceNodeName** | **string** | The name of the node to be replaced. |  |
| **replaceNodeRequestBody** | [**ReplaceNodeRequestBody**](ReplaceNodeRequestBody.md) | Contains user provided parameters |  |

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

