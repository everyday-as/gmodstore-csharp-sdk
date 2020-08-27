# Everyday.GmodStore.Sdk.Api.UserPurchasesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserPurchases**](UserPurchasesApi.md#listuserpurchases) | **GET** /users/{user_id}/purchases | Fetch all purchases a user has made


<a name="listuserpurchases"></a>
# **ListUserPurchases**
> AddonPurchaseListResponse ListUserPurchases (long userId, List<string> with = null)

Fetch all purchases a user has made

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserPurchasesApi(config);
            var userId = 789;  // long | Id of the user
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Fetch all purchases a user has made
                AddonPurchaseListResponse result = apiInstance.ListUserPurchases(userId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPurchasesApi.ListUserPurchases: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long**| Id of the user | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseListResponse**](AddonPurchaseListResponse.md)

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

