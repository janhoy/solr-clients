# Org.OpenAPITools.Api.ClusterApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BalanceReplicas**](ClusterApi.md#balancereplicas) | **POST** /cluster/replicas/balance | Balance Replicas across the given set of Nodes. |
| [**MigrateReplicas**](ClusterApi.md#migratereplicas) | **POST** /cluster/replicas/migrate | Migrate Replicas from a given set of nodes. |

<a id="balancereplicas"></a>
# **BalanceReplicas**
> SolrJerseyResponse BalanceReplicas (BalanceReplicasRequestBody balanceReplicasRequestBody = null)

Balance Replicas across the given set of Nodes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BalanceReplicasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterApi(config);
            var balanceReplicasRequestBody = new BalanceReplicasRequestBody(); // BalanceReplicasRequestBody | Contains user provided parameters (optional) 

            try
            {
                // Balance Replicas across the given set of Nodes.
                SolrJerseyResponse result = apiInstance.BalanceReplicas(balanceReplicasRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.BalanceReplicasWithHttpInfo(balanceReplicasRequestBody);
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
| **balanceReplicasRequestBody** | [**BalanceReplicasRequestBody**](BalanceReplicasRequestBody.md) | Contains user provided parameters | [optional]  |

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

<a id="migratereplicas"></a>
# **MigrateReplicas**
> SolrJerseyResponse MigrateReplicas (MigrateReplicasRequestBody migrateReplicasRequestBody)

Migrate Replicas from a given set of nodes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MigrateReplicasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterApi(config);
            var migrateReplicasRequestBody = new MigrateReplicasRequestBody(); // MigrateReplicasRequestBody | Contains user provided parameters

            try
            {
                // Migrate Replicas from a given set of nodes.
                SolrJerseyResponse result = apiInstance.MigrateReplicas(migrateReplicasRequestBody);
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
    ApiResponse<SolrJerseyResponse> response = apiInstance.MigrateReplicasWithHttpInfo(migrateReplicasRequestBody);
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
| **migrateReplicasRequestBody** | [**MigrateReplicasRequestBody**](MigrateReplicasRequestBody.md) | Contains user provided parameters |  |

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

