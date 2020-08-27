# Everyday.GmodStore.Sdk.Api.TeamUsersApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListTeamUsers**](TeamUsersApi.md#listteamusers) | **GET** /teams/{team_id}/users | Fetch all the users in the given team

<a name="listteamusers"></a>
# **ListTeamUsers**
> TeamUserListResponse ListTeamUsers (long? teamId, List<string> with = null)

Fetch all the users in the given team

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListTeamUsersExample
    {
        public void main()
        {

            var apiInstance = new TeamUsersApi();
            var teamId = 789;  // long? | Id of the team
            var with = new List<string>(); // List<string> | The relations you want to fetch with the TeamUser schema (optional) 

            try
            {
                // Fetch all the users in the given team
                TeamUserListResponse result = apiInstance.ListTeamUsers(teamId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamUsersApi.ListTeamUsers: " + e.Message );
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

[**TeamUserListResponse**](TeamUserListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
