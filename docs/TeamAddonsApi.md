# Everyday.GmodStore.Sdk.Api.TeamAddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListTeamAddons**](TeamAddonsApi.md#listteamaddons) | **GET** /teams/{team_id}/addons | Fetch all the addons in the given team


<a name="listteamaddons"></a>
# **ListTeamAddons**
> TeamUserListResponse ListTeamAddons (long teamId)

Fetch all the addons in the given team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListTeamAddonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TeamAddonsApi(config);
            var teamId = 789;  // long | Id of the team

            try
            {
                // Fetch all the addons in the given team
                TeamUserListResponse result = apiInstance.ListTeamAddons(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamAddonsApi.ListTeamAddons: " + e.Message );
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
 **teamId** | **long**| Id of the team | 

### Return type

[**TeamUserListResponse**](TeamUserListResponse.md)

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

