# Everyday.GmodStore.Sdk.Api.UserTeamsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserTeams**](UserTeamsApi.md#listuserteams) | **GET** /users/{user_id}/teams | Fetch all the teams of a user

<a name="listuserteams"></a>
# **ListUserTeams**
> TeamListResponse ListUserTeams (string userId, List<string> with = null)

Fetch all the teams of a user

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserTeamsExample
    {
        public void main()
        {

            var apiInstance = new UserTeamsApi();
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Team schema (optional) 

            try
            {
                // Fetch all the teams of a user
                TeamListResponse result = apiInstance.ListUserTeams(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserTeamsApi.ListUserTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the Team schema | [optional] 

### Return type

[**TeamListResponse**](TeamListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
