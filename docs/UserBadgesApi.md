# NO.Everyday.GmodStoreSDK.Api.UserBadgesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserBadge**](UserBadgesApi.md#createuserbadge) | **POST** /users/{user_id}/badges | Give a user a badge
[**DeleteUserBadge**](UserBadgesApi.md#deleteuserbadge) | **DELETE** /users/{user_id}/badges/{badge_id} | Destroy a users&#x27;s badge
[**ListUserBadges**](UserBadgesApi.md#listuserbadges) | **GET** /users/{user_id}/badges | Fetch all the badges a user has

<a name="createuserbadge"></a>
# **CreateUserBadge**
> InlineResponse2013 CreateUserBadge (BadgeCreateBody body, string userId)

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
    public class CreateUserBadgeExample
    {
        public void main()
        {

            var apiInstance = new UserBadgesApi();
            var body = new BadgeCreateBody(); // BadgeCreateBody | 
            var userId = userId_example;  // string | Id of the user

            try
            {
                // Give a user a badge
                InlineResponse2013 result = apiInstance.CreateUserBadge(body, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.CreateUserBadge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BadgeCreateBody**](BadgeCreateBody.md)|  | 
 **userId** | **string**| Id of the user | 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteuserbadge"></a>
# **DeleteUserBadge**
> void DeleteUserBadge (string userId, long? badgeId)

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
    public class DeleteUserBadgeExample
    {
        public void main()
        {

            var apiInstance = new UserBadgesApi();
            var userId = userId_example;  // string | Id of the user
            var badgeId = 789;  // long? | Id of the badge

            try
            {
                // Destroy a users's badge
                apiInstance.DeleteUserBadge(userId, badgeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.DeleteUserBadge: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listuserbadges"></a>
# **ListUserBadges**
> InlineResponse20014 ListUserBadges (string userId)

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
    public class ListUserBadgesExample
    {
        public void main()
        {

            var apiInstance = new UserBadgesApi();
            var userId = userId_example;  // string | Id of the user

            try
            {
                // Fetch all the badges a user has
                InlineResponse20014 result = apiInstance.ListUserBadges(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBadgesApi.ListUserBadges: " + e.Message );
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

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
