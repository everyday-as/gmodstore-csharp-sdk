# Everyday.GmodStore.Sdk.Api.UserBansApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserBans**](UserBansApi.md#listuserbans) | **GET** /users/{user_id}/bans | Fetch all active bans associated with this user

<a name="listuserbans"></a>
# **ListUserBans**
> UserBanListResponse ListUserBans (long? userId)

Fetch all active bans associated with this user

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserBansExample
    {
        public void main()
        {

            var apiInstance = new UserBansApi();
            var userId = 789;  // long? | Id of the user

            try
            {
                // Fetch all active bans associated with this user
                UserBanListResponse result = apiInstance.ListUserBans(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserBansApi.ListUserBans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the user | 

### Return type

[**UserBanListResponse**](UserBanListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
