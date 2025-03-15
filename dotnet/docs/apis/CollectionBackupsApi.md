# Org.OpenAPITools.Api.CollectionBackupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCollectionBackup**](CollectionBackupsApi.md#createcollectionbackup) | **POST** /collections/{collectionName}/backups/{backupName}/versions | Creates a new backup point for a collection |
| [**DeleteMultipleBackupsByRecency**](CollectionBackupsApi.md#deletemultiplebackupsbyrecency) | **DELETE** /backups/{backupName}/versions | Delete all incremental backup points older than the most recent N |
| [**DeleteSingleBackupById**](CollectionBackupsApi.md#deletesinglebackupbyid) | **DELETE** /backups/{backupName}/versions/{backupId} | Delete incremental backup point by ID |
| [**GarbageCollectUnusedBackupFiles**](CollectionBackupsApi.md#garbagecollectunusedbackupfiles) | **PUT** /backups/{backupName}/purgeUnused | Garbage collect orphaned incremental backup files |
| [**ListBackupsAtLocation**](CollectionBackupsApi.md#listbackupsatlocation) | **GET** /backups/{backupName}/versions | List existing incremental backups at the specified location. |
| [**RestoreCollection**](CollectionBackupsApi.md#restorecollection) | **POST** /backups/{backupName}/restore | Restores an existing backup point to a (potentially new) collection. |

<a id="createcollectionbackup"></a>
# **CreateCollectionBackup**
> SolrJerseyResponse CreateCollectionBackup (string collectionName, string backupName, CreateCollectionBackupRequestBody createCollectionBackupRequestBody = null)

Creates a new backup point for a collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCollectionBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var collectionName = "collectionName_example";  // string | 
            var backupName = "backupName_example";  // string | 
            var createCollectionBackupRequestBody = new CreateCollectionBackupRequestBody(); // CreateCollectionBackupRequestBody |  (optional) 

            try
            {
                // Creates a new backup point for a collection
                SolrJerseyResponse result = apiInstance.CreateCollectionBackup(collectionName, backupName, createCollectionBackupRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.CreateCollectionBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCollectionBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new backup point for a collection
    ApiResponse<SolrJerseyResponse> response = apiInstance.CreateCollectionBackupWithHttpInfo(collectionName, backupName, createCollectionBackupRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.CreateCollectionBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionName** | **string** |  |  |
| **backupName** | **string** |  |  |
| **createCollectionBackupRequestBody** | [**CreateCollectionBackupRequestBody**](CreateCollectionBackupRequestBody.md) |  | [optional]  |

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

<a id="deletemultiplebackupsbyrecency"></a>
# **DeleteMultipleBackupsByRecency**
> BackupDeletionResponseBody DeleteMultipleBackupsByRecency (string backupName, int retainLatest = null, string location = null, string repository = null, string async = null)

Delete all incremental backup points older than the most recent N

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteMultipleBackupsByRecencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var backupName = "backupName_example";  // string | 
            var retainLatest = 56;  // int |  (optional) 
            var location = "location_example";  // string |  (optional) 
            var repository = "repository_example";  // string |  (optional) 
            var async = "async_example";  // string |  (optional) 

            try
            {
                // Delete all incremental backup points older than the most recent N
                BackupDeletionResponseBody result = apiInstance.DeleteMultipleBackupsByRecency(backupName, retainLatest, location, repository, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.DeleteMultipleBackupsByRecency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMultipleBackupsByRecencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all incremental backup points older than the most recent N
    ApiResponse<BackupDeletionResponseBody> response = apiInstance.DeleteMultipleBackupsByRecencyWithHttpInfo(backupName, retainLatest, location, repository, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.DeleteMultipleBackupsByRecencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backupName** | **string** |  |  |
| **retainLatest** | **int** |  | [optional]  |
| **location** | **string** |  | [optional]  |
| **repository** | **string** |  | [optional]  |
| **async** | **string** |  | [optional]  |

### Return type

[**BackupDeletionResponseBody**](BackupDeletionResponseBody.md)

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

<a id="deletesinglebackupbyid"></a>
# **DeleteSingleBackupById**
> BackupDeletionResponseBody DeleteSingleBackupById (string backupName, string backupId, string location = null, string repository = null, string async = null)

Delete incremental backup point by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteSingleBackupByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var backupName = "backupName_example";  // string | 
            var backupId = "backupId_example";  // string | 
            var location = "location_example";  // string |  (optional) 
            var repository = "repository_example";  // string |  (optional) 
            var async = "async_example";  // string |  (optional) 

            try
            {
                // Delete incremental backup point by ID
                BackupDeletionResponseBody result = apiInstance.DeleteSingleBackupById(backupName, backupId, location, repository, async);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.DeleteSingleBackupById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSingleBackupByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete incremental backup point by ID
    ApiResponse<BackupDeletionResponseBody> response = apiInstance.DeleteSingleBackupByIdWithHttpInfo(backupName, backupId, location, repository, async);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.DeleteSingleBackupByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backupName** | **string** |  |  |
| **backupId** | **string** |  |  |
| **location** | **string** |  | [optional]  |
| **repository** | **string** |  | [optional]  |
| **async** | **string** |  | [optional]  |

### Return type

[**BackupDeletionResponseBody**](BackupDeletionResponseBody.md)

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

<a id="garbagecollectunusedbackupfiles"></a>
# **GarbageCollectUnusedBackupFiles**
> PurgeUnusedResponse GarbageCollectUnusedBackupFiles (string backupName, PurgeUnusedFilesRequestBody purgeUnusedFilesRequestBody = null)

Garbage collect orphaned incremental backup files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GarbageCollectUnusedBackupFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var backupName = "backupName_example";  // string | 
            var purgeUnusedFilesRequestBody = new PurgeUnusedFilesRequestBody(); // PurgeUnusedFilesRequestBody | Request body parameters for the orphaned file cleanup (optional) 

            try
            {
                // Garbage collect orphaned incremental backup files
                PurgeUnusedResponse result = apiInstance.GarbageCollectUnusedBackupFiles(backupName, purgeUnusedFilesRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.GarbageCollectUnusedBackupFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GarbageCollectUnusedBackupFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Garbage collect orphaned incremental backup files
    ApiResponse<PurgeUnusedResponse> response = apiInstance.GarbageCollectUnusedBackupFilesWithHttpInfo(backupName, purgeUnusedFilesRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.GarbageCollectUnusedBackupFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backupName** | **string** |  |  |
| **purgeUnusedFilesRequestBody** | [**PurgeUnusedFilesRequestBody**](PurgeUnusedFilesRequestBody.md) | Request body parameters for the orphaned file cleanup | [optional]  |

### Return type

[**PurgeUnusedResponse**](PurgeUnusedResponse.md)

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

<a id="listbackupsatlocation"></a>
# **ListBackupsAtLocation**
> ListCollectionBackupsResponse ListBackupsAtLocation (string backupName, string location = null, string repository = null)

List existing incremental backups at the specified location.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListBackupsAtLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var backupName = "backupName_example";  // string | 
            var location = "location_example";  // string |  (optional) 
            var repository = "repository_example";  // string |  (optional) 

            try
            {
                // List existing incremental backups at the specified location.
                ListCollectionBackupsResponse result = apiInstance.ListBackupsAtLocation(backupName, location, repository);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.ListBackupsAtLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBackupsAtLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List existing incremental backups at the specified location.
    ApiResponse<ListCollectionBackupsResponse> response = apiInstance.ListBackupsAtLocationWithHttpInfo(backupName, location, repository);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.ListBackupsAtLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backupName** | **string** |  |  |
| **location** | **string** |  | [optional]  |
| **repository** | **string** |  | [optional]  |

### Return type

[**ListCollectionBackupsResponse**](ListCollectionBackupsResponse.md)

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

<a id="restorecollection"></a>
# **RestoreCollection**
> SubResponseAccumulatingJerseyResponse RestoreCollection (string backupName, RestoreCollectionRequestBody restoreCollectionRequestBody = null)

Restores an existing backup point to a (potentially new) collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RestoreCollectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CollectionBackupsApi(config);
            var backupName = "backupName_example";  // string | 
            var restoreCollectionRequestBody = new RestoreCollectionRequestBody(); // RestoreCollectionRequestBody |  (optional) 

            try
            {
                // Restores an existing backup point to a (potentially new) collection.
                SubResponseAccumulatingJerseyResponse result = apiInstance.RestoreCollection(backupName, restoreCollectionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionBackupsApi.RestoreCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restores an existing backup point to a (potentially new) collection.
    ApiResponse<SubResponseAccumulatingJerseyResponse> response = apiInstance.RestoreCollectionWithHttpInfo(backupName, restoreCollectionRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionBackupsApi.RestoreCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **backupName** | **string** |  |  |
| **restoreCollectionRequestBody** | [**RestoreCollectionRequestBody**](RestoreCollectionRequestBody.md) |  | [optional]  |

### Return type

[**SubResponseAccumulatingJerseyResponse**](SubResponseAccumulatingJerseyResponse.md)

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

