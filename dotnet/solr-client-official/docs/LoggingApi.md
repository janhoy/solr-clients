# SolrClient.Api.LoggingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchLocalLogMessages**](LoggingApi.md#fetchlocallogmessages) | **GET** /node/logging/messages | Fetch recent log messages on the targeted node. |
| [**ListAllLoggersAndLevels**](LoggingApi.md#listallloggersandlevels) | **GET** /node/logging/levels | List all log-levels for the target node. |
| [**ModifyLocalLogLevel**](LoggingApi.md#modifylocalloglevel) | **PUT** /node/logging/levels | Set one or more logger levels on the target node. |
| [**SetMessageThreshold**](LoggingApi.md#setmessagethreshold) | **PUT** /node/logging/messages/threshold | Set a threshold level for the targeted node&#39;s log message watcher. |

<a id="fetchlocallogmessages"></a>
# **FetchLocalLogMessages**
> LogMessagesResponseModel FetchLocalLogMessages (long? since = null)

Fetch recent log messages on the targeted node.

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
    public class FetchLocalLogMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LoggingApi(httpClient, config, httpClientHandler);
            var since = 789L;  // long? |  (optional) 

            try
            {
                // Fetch recent log messages on the targeted node.
                LogMessagesResponseModel result = apiInstance.FetchLocalLogMessages(since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.FetchLocalLogMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchLocalLogMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch recent log messages on the targeted node.
    ApiResponse<LogMessagesResponseModel> response = apiInstance.FetchLocalLogMessagesWithHttpInfo(since);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.FetchLocalLogMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **since** | **long?** |  | [optional]  |

### Return type

[**LogMessagesResponseModel**](LogMessagesResponseModel.md)

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

<a id="listallloggersandlevels"></a>
# **ListAllLoggersAndLevels**
> ListLevelsResponseModel ListAllLoggersAndLevels ()

List all log-levels for the target node.

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
    public class ListAllLoggersAndLevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LoggingApi(httpClient, config, httpClientHandler);

            try
            {
                // List all log-levels for the target node.
                ListLevelsResponseModel result = apiInstance.ListAllLoggersAndLevels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.ListAllLoggersAndLevels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllLoggersAndLevelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all log-levels for the target node.
    ApiResponse<ListLevelsResponseModel> response = apiInstance.ListAllLoggersAndLevelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.ListAllLoggersAndLevelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListLevelsResponseModel**](ListLevelsResponseModel.md)

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

<a id="modifylocalloglevel"></a>
# **ModifyLocalLogLevel**
> LoggingResponseModel ModifyLocalLogLevel (Collection<LogLevelChangeModel>? logLevelChangeModel = null)

Set one or more logger levels on the target node.

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
    public class ModifyLocalLogLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LoggingApi(httpClient, config, httpClientHandler);
            var logLevelChangeModel = new Collection<LogLevelChangeModel>?(); // Collection<LogLevelChangeModel>? |  (optional) 

            try
            {
                // Set one or more logger levels on the target node.
                LoggingResponseModel result = apiInstance.ModifyLocalLogLevel(logLevelChangeModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.ModifyLocalLogLevel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifyLocalLogLevelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set one or more logger levels on the target node.
    ApiResponse<LoggingResponseModel> response = apiInstance.ModifyLocalLogLevelWithHttpInfo(logLevelChangeModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.ModifyLocalLogLevelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logLevelChangeModel** | [**Collection&lt;LogLevelChangeModel&gt;?**](LogLevelChangeModel.md) |  | [optional]  |

### Return type

[**LoggingResponseModel**](LoggingResponseModel.md)

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

<a id="setmessagethreshold"></a>
# **SetMessageThreshold**
> LoggingResponseModel SetMessageThreshold (SetThresholdRequestBodyModel? setThresholdRequestBodyModel = null)

Set a threshold level for the targeted node's log message watcher.

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
    public class SetMessageThresholdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LoggingApi(httpClient, config, httpClientHandler);
            var setThresholdRequestBodyModel = new SetThresholdRequestBodyModel?(); // SetThresholdRequestBodyModel? |  (optional) 

            try
            {
                // Set a threshold level for the targeted node's log message watcher.
                LoggingResponseModel result = apiInstance.SetMessageThreshold(setThresholdRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.SetMessageThreshold: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMessageThresholdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a threshold level for the targeted node's log message watcher.
    ApiResponse<LoggingResponseModel> response = apiInstance.SetMessageThresholdWithHttpInfo(setThresholdRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.SetMessageThresholdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setThresholdRequestBodyModel** | [**SetThresholdRequestBodyModel?**](SetThresholdRequestBodyModel?.md) |  | [optional]  |

### Return type

[**LoggingResponseModel**](LoggingResponseModel.md)

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

