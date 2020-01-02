# NO.Everyday.GmodStoreSDK.Api.UserBansApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdBansGet**](UserBansApi.md#usersuseridbansget) | **GET** /users/{user_id}/bans | Fetch all active bans associated with this user

<a name="usersuseridbansget"></a>
# **UsersUserIdBansGet**
> InlineResponse20013 UsersUserIdBansGet (string userId)

Fetch all active bans associated with this user

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdBansGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserBansApi();
            var userId = userId_example;  // string | Id of the user

            try
            {
                // Fetch all active bans associated with this user
                InlineResponse20013 result = apiInstance.UsersUserIdBansGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBansApi.UsersUserIdBansGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
