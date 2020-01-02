# NO.Everyday.GmodStoreSDK.Api.TeamsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsTeamIdGet**](TeamsApi.md#teamsteamidget) | **GET** /teams/{team_id} | Fetch a single team

<a name="teamsteamidget"></a>
# **TeamsTeamIdGet**
> InlineResponse2009 TeamsTeamIdGet (long? teamId, List<string> with = null)

Fetch a single team

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class TeamsTeamIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamsApi();
            var teamId = 789;  // long? | Id of the team
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Team schema (optional) 

            try
            {
                // Fetch a single team
                InlineResponse2009 result = apiInstance.TeamsTeamIdGet(teamId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **long?**| Id of the team | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the Team schema | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
