# ApacheSolr.Api.ConfigsetsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListConfigSet**](ConfigsetsApi.md#listconfigset) | **GET** /cluster/configs | List the configsets available to Solr. |

<a id="listconfigset"></a>
# **ListConfigSet**
> ListConfigsetsResponseModel ListConfigSet ()

List the configsets available to Solr.

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
    public class ListConfigSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConfigsetsApi(httpClient, config, httpClientHandler);

            try
            {
                // List the configsets available to Solr.
                ListConfigsetsResponseModel result = apiInstance.ListConfigSet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsetsApi.ListConfigSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConfigSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the configsets available to Solr.
    ApiResponse<ListConfigsetsResponseModel> response = apiInstance.ListConfigSetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsetsApi.ListConfigSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListConfigsetsResponseModel**](ListConfigsetsResponseModel.md)

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

