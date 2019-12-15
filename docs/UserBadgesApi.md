# NO.Everyday.GmodStoreSDK.Api.UserBadgesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdBadgesBadgeIdDelete**](UserBadgesApi.md#usersuseridbadgesbadgeiddelete) | **DELETE** /users/{user_id}/badges/{badge_id} | Destroy a users&#x27;s badge
[**UsersUserIdBadgesGet**](UserBadgesApi.md#usersuseridbadgesget) | **GET** /users/{user_id}/badges | Fetch all the badges a user has
[**UsersUserIdBadgesPost**](UserBadgesApi.md#usersuseridbadgespost) | **POST** /users/{user_id}/badges | Give a user a badge

<a name="usersuseridbadgesbadgeiddelete"></a>
# **UsersUserIdBadgesBadgeIdDelete**
> void UsersUserIdBadgesBadgeIdDelete (string userId, long? badgeId)

Destroy a users's badge

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdBadgesBadgeIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserBadgesApi();
            var userId = userId_example;  // string | Id of the user
            var badgeId = 789;  // long? | Id of the badge

            try
            {
                // Destroy a users's badge
                apiInstance.UsersUserIdBadgesBadgeIdDelete(userId, badgeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.UsersUserIdBadgesBadgeIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 
 **badgeId** | **long?**| Id of the badge | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersuseridbadgesget"></a>
# **UsersUserIdBadgesGet**
> InlineResponse20013 UsersUserIdBadgesGet (string userId)

Fetch all the badges a user has

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdBadgesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserBadgesApi();
            var userId = userId_example;  // string | Id of the user

            try
            {
                // Fetch all the badges a user has
                InlineResponse20013 result = apiInstance.UsersUserIdBadgesGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.UsersUserIdBadgesGet: " + e.Message );
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
<a name="usersuseridbadgespost"></a>
# **UsersUserIdBadgesPost**
> InlineResponse2013 UsersUserIdBadgesPost (Object body, string userId)

Give a user a badge

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdBadgesPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserBadgesApi();
            var body = new Object(); // Object | 
            var userId = userId_example;  // string | Id of the user

            try
            {
                // Give a user a badge
                InlineResponse2013 result = apiInstance.UsersUserIdBadgesPost(body, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.UsersUserIdBadgesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | 
 **userId** | **string**| Id of the user | 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
