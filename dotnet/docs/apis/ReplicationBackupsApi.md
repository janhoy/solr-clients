# Org.OpenAPITools.Api.ReplicationBackupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBackup1**](ReplicationBackupsApi.md#createbackup1) | **POST** /cores/{coreName}/replication/backups | Create a backup of a single core using Solr&#39;s &#39;Replication Handler&#39; |

<a id="createbackup1"></a>
# **CreateBackup1**
> ReplicationBackupResponse CreateBackup1 (string coreName)

Create a backup of a single core using Solr's 'Replication Handler'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBackup1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReplicationBackupsApi(config);
            var coreName = "coreName_example";  // string | 

            try
            {
                // Create a backup of a single core using Solr's 'Replication Handler'
                ReplicationBackupResponse result = apiInstance.CreateBackup1(coreName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReplicationBackupsApi.CreateBackup1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBackup1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a backup of a single core using Solr's 'Replication Handler'
    ApiResponse<ReplicationBackupResponse> response = apiInstance.CreateBackup1WithHttpInfo(coreName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReplicationBackupsApi.CreateBackup1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **coreName** | **string** |  |  |

### Return type

[**ReplicationBackupResponse**](ReplicationBackupResponse.md)

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

