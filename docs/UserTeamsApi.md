# NO.Everyday.GmodStoreSDK.Api.UserTeamsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdTeamsGet**](UserTeamsApi.md#usersuseridteamsget) | **GET** /users/{user_id}/teams | Fetch all the teams of a user

<a name="usersuseridteamsget"></a>
# **UsersUserIdTeamsGet**
> InlineResponse20012 UsersUserIdTeamsGet (string userId, List<string> with = null)

Fetch all the teams of a user

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdTeamsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserTeamsApi();
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Team schema (optional) 

            try
            {
                // Fetch all the teams of a user
                InlineResponse20012 result = apiInstance.UsersUserIdTeamsGet(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserTeamsApi.UsersUserIdTeamsGet: " + e.Message );
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

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
