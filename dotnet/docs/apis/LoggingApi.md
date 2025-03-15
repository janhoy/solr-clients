# Org.OpenAPITools.Api.LoggingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchLocalLogMessages**](LoggingApi.md#fetchlocallogmessages) | **GET** /node/logging/messages | Fetch recent log messages on the targeted node. |
| [**ListAllLoggersAndLevels**](LoggingApi.md#listallloggersandlevels) | **GET** /node/logging/levels | List all log-levels for the target node. |
| [**ModifyLocalLogLevel**](LoggingApi.md#modifylocalloglevel) | **PUT** /node/logging/levels | Set one or more logger levels on the target node. |
| [**SetMessageThreshold**](LoggingApi.md#setmessagethreshold) | **PUT** /node/logging/messages/threshold | Set a threshold level for the targeted node&#39;s log message watcher. |

<a id="fetchlocallogmessages"></a>
# **FetchLocalLogMessages**
> LogMessagesResponse FetchLocalLogMessages (long since = null)

Fetch recent log messages on the targeted node.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FetchLocalLogMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoggingApi(config);
            var since = 789L;  // long |  (optional) 

            try
            {
                // Fetch recent log messages on the targeted node.
                LogMessagesResponse result = apiInstance.FetchLocalLogMessages(since);
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
    ApiResponse<LogMessagesResponse> response = apiInstance.FetchLocalLogMessagesWithHttpInfo(since);
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
| **since** | **long** |  | [optional]  |

### Return type

[**LogMessagesResponse**](LogMessagesResponse.md)

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

<a id="listallloggersandlevels"></a>
# **ListAllLoggersAndLevels**
> ListLevelsResponse ListAllLoggersAndLevels ()

List all log-levels for the target node.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllLoggersAndLevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoggingApi(config);

            try
            {
                // List all log-levels for the target node.
                ListLevelsResponse result = apiInstance.ListAllLoggersAndLevels();
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
    ApiResponse<ListLevelsResponse> response = apiInstance.ListAllLoggersAndLevelsWithHttpInfo();
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

[**ListLevelsResponse**](ListLevelsResponse.md)

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

<a id="modifylocalloglevel"></a>
# **ModifyLocalLogLevel**
> LoggingResponse ModifyLocalLogLevel (List<LogLevelChange> logLevelChange = null)

Set one or more logger levels on the target node.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModifyLocalLogLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoggingApi(config);
            var logLevelChange = new List<LogLevelChange>(); // List<LogLevelChange> |  (optional) 

            try
            {
                // Set one or more logger levels on the target node.
                LoggingResponse result = apiInstance.ModifyLocalLogLevel(logLevelChange);
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
    ApiResponse<LoggingResponse> response = apiInstance.ModifyLocalLogLevelWithHttpInfo(logLevelChange);
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
| **logLevelChange** | [**List&lt;LogLevelChange&gt;**](LogLevelChange.md) |  | [optional]  |

### Return type

[**LoggingResponse**](LoggingResponse.md)

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

<a id="setmessagethreshold"></a>
# **SetMessageThreshold**
> LoggingResponse SetMessageThreshold (SetThresholdRequestBody setThresholdRequestBody = null)

Set a threshold level for the targeted node's log message watcher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetMessageThresholdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoggingApi(config);
            var setThresholdRequestBody = new SetThresholdRequestBody(); // SetThresholdRequestBody |  (optional) 

            try
            {
                // Set a threshold level for the targeted node's log message watcher.
                LoggingResponse result = apiInstance.SetMessageThreshold(setThresholdRequestBody);
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
    ApiResponse<LoggingResponse> response = apiInstance.SetMessageThresholdWithHttpInfo(setThresholdRequestBody);
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
| **setThresholdRequestBody** | [**SetThresholdRequestBody**](SetThresholdRequestBody.md) |  | [optional]  |

### Return type

[**LoggingResponse**](LoggingResponse.md)

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

