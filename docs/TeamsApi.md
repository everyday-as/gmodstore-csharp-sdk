# Everyday.GmodStore.Sdk.Api.TeamsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTeam**](TeamsApi.md#getteam) | **GET** /teams/{team_id} | Fetch a single team

<a name="getteam"></a>
# **GetTeam**
> TeamResponse GetTeam (long? teamId, List<string> with = null)

Fetch a single team

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetTeamExample
    {
        public void main()
        {

            var apiInstance = new TeamsApi();
            var teamId = 789;  // long? | Id of the team
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `Team` (optional) 

            try
            {
                // Fetch a single team
                TeamResponse result = apiInstance.GetTeam(teamId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **long?**| Id of the team | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;Team&#x60; | [optional] 

### Return type

[**TeamResponse**](TeamResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
