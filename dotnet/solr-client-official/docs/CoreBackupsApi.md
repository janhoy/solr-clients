# SolrClient.Api.CoreBackupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBackup**](CoreBackupsApi.md#createbackup) | **POST** /cores/{coreName}/backups | Creates a core-level backup |

<a id="createbackup"></a>
# **CreateBackup**
> SolrJerseyResponseModel CreateBackup (string coreName, CreateCoreBackupRequestBodyModel? createCoreBackupRequestBodyModel = null)

Creates a core-level backup

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
    public class CreateBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CoreBackupsApi(httpClient, config, httpClientHandler);
            var coreName = "coreName_example";  // string | The name of the core.
            var createCoreBackupRequestBodyModel = new CreateCoreBackupRequestBodyModel?(); // CreateCoreBackupRequestBodyModel? |  (optional) 

            try
            {
                // Creates a core-level backup
                SolrJerseyResponseModel result = apiInstance.CreateBackup(coreName, createCoreBackupRequestBodyModel);
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
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.CreateBackupWithHttpInfo(coreName, createCoreBackupRequestBodyModel);
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
| **createCoreBackupRequestBodyModel** | [**CreateCoreBackupRequestBodyModel?**](CreateCoreBackupRequestBodyModel?.md) |  | [optional]  |

### Return type

[**SolrJerseyResponseModel**](SolrJerseyResponseModel.md)

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

