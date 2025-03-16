# ApacheSolr.Api.ClusterApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalanceReplicas**](ClusterApi.md#balancereplicas) | **POST** /cluster/replicas/balance | Balance Replicas across the given set of Nodes. |
| [**MigrateReplicas**](ClusterApi.md#migratereplicas) | **POST** /cluster/replicas/migrate | Migrate Replicas from a given set of nodes. |

<a id="balancereplicas"></a>
# **BalanceReplicas**
> SolrJerseyResponseModel BalanceReplicas (BalanceReplicasRequestBodyModel? balanceReplicasRequestBodyModel = null)

Balance Replicas across the given set of Nodes.

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
    public class BalanceReplicasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClusterApi(httpClient, config, httpClientHandler);
            var balanceReplicasRequestBodyModel = new BalanceReplicasRequestBodyModel?(); // BalanceReplicasRequestBodyModel? | Contains user provided parameters (optional) 

            try
            {
                // Balance Replicas across the given set of Nodes.
                SolrJerseyResponseModel result = apiInstance.BalanceReplicas(balanceReplicasRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.BalanceReplicas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BalanceReplicasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Balance Replicas across the given set of Nodes.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.BalanceReplicasWithHttpInfo(balanceReplicasRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.BalanceReplicasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **balanceReplicasRequestBodyModel** | [**BalanceReplicasRequestBodyModel?**](BalanceReplicasRequestBodyModel?.md) | Contains user provided parameters | [optional]  |

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

<a id="migratereplicas"></a>
# **MigrateReplicas**
> SolrJerseyResponseModel MigrateReplicas (MigrateReplicasRequestBodyModel migrateReplicasRequestBodyModel)

Migrate Replicas from a given set of nodes.

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
    public class MigrateReplicasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ClusterApi(httpClient, config, httpClientHandler);
            var migrateReplicasRequestBodyModel = new MigrateReplicasRequestBodyModel(); // MigrateReplicasRequestBodyModel | Contains user provided parameters

            try
            {
                // Migrate Replicas from a given set of nodes.
                SolrJerseyResponseModel result = apiInstance.MigrateReplicas(migrateReplicasRequestBodyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterApi.MigrateReplicas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MigrateReplicasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Migrate Replicas from a given set of nodes.
    ApiResponse<SolrJerseyResponseModel> response = apiInstance.MigrateReplicasWithHttpInfo(migrateReplicasRequestBodyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterApi.MigrateReplicasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **migrateReplicasRequestBodyModel** | [**MigrateReplicasRequestBodyModel**](MigrateReplicasRequestBodyModel.md) | Contains user provided parameters |  |

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

