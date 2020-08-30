# Everyday.GmodStore.Sdk.Api.PermissionGroupsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPermissionGroups**](PermissionGroupsApi.md#getpermissiongroups) | **GET** /permission-groups | Fetches all available permission groups


<a name="getpermissiongroups"></a>
# **GetPermissionGroups**
> PermissionGroupListResponse GetPermissionGroups ()

Fetches all available permission groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetPermissionGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PermissionGroupsApi(config);

            try
            {
                // Fetches all available permission groups
                PermissionGroupListResponse result = apiInstance.GetPermissionGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionGroupsApi.GetPermissionGroups: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PermissionGroupListResponse**](PermissionGroupListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

