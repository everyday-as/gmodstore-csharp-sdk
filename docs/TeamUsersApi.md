# NO.Everyday.GmodStoreSDK.Api.TeamUsersApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsTeamIdUsersGet**](TeamUsersApi.md#teamsteamidusersget) | **GET** /teams/{team_id}/users | Fetch all the users in the given team

<a name="teamsteamidusersget"></a>
# **TeamsTeamIdUsersGet**
> InlineResponse20010 TeamsTeamIdUsersGet (long? teamId, List<string> with = null)

Fetch all the users in the given team

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class TeamsTeamIdUsersGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamUsersApi();
            var teamId = 789;  // long? | Id of the team
            var with = new List<string>(); // List<string> | The relations you want to fetch with the TeamUser schema (optional) 

            try
            {
                // Fetch all the users in the given team
                InlineResponse20010 result = apiInstance.TeamsTeamIdUsersGet(teamId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamUsersApi.TeamsTeamIdUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **long?**| Id of the team | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the TeamUser schema | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
