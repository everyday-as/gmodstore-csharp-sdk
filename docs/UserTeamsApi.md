# Everyday.GmodStore.Sdk.Api.UserTeamsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserTeams**](UserTeamsApi.md#listuserteams) | **GET** /users/{user_id}/teams | Fetch all the teams of a user


<a name="listuserteams"></a>
# **ListUserTeams**
> TeamListResponse ListUserTeams (long userId, List<string> with = null)

Fetch all the teams of a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserTeamsApi(config);
            var userId = 789;  // long | Id of the user
            var with = with_example;  // List<string> | The relations you want to fetch with the `Team` (optional) 

            try
            {
                // Fetch all the teams of a user
                TeamListResponse result = apiInstance.ListUserTeams(userId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserTeamsApi.ListUserTeams: " + e.Message );
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
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;Team&#x60; | [optional] 

### Return type

[**TeamListResponse**](TeamListResponse.md)

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

