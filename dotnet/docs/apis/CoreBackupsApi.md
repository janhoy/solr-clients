# Org.OpenAPITools.Api.CoreBackupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBackup**](CoreBackupsApi.md#createbackup) | **POST** /cores/{coreName}/backups | Creates a core-level backup |

<a id="createbackup"></a>
# **CreateBackup**
> SolrJerseyResponse CreateBackup (string coreName, CreateCoreBackupRequestBody createCoreBackupRequestBody = null)

Creates a core-level backup

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CoreBackupsApi(config);
            var coreName = "coreName_example";  // string | The name of the core.
            var createCoreBackupRequestBody = new CreateCoreBackupRequestBody(); // CreateCoreBackupRequestBody |  (optional) 

            try
            {
                // Creates a core-level backup
                SolrJerseyResponse result = apiInstance.CreateBackup(coreName, createCoreBackupRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CoreBackupsApi.CreateBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a core-level backup
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateBackupWithHttpInfo(coreName, createCoreBackupRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CoreBackupsApi.CreateBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** | The name of the core. |  |
| **createCoreBackupRequestBody** | [**CreateCoreBackupRequestBody**](CreateCoreBackupRequestBody.md) |  | [optional]  |

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

