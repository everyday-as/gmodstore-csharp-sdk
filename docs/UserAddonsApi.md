# NO.Everyday.GmodStoreSDK.Api.UserAddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserAddons**](UserAddonsApi.md#listuseraddons) | **GET** /users/{user_id}/addons | Fetch all the addons authored / co-authored by a user

<a name="listuseraddons"></a>
# **ListUserAddons**
> InlineResponse200 ListUserAddons (string userId, List<string> with = null)

Fetch all the addons authored / co-authored by a user

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class ListUserAddonsExample
    {
        public void main()
        {

            var apiInstance = new UserAddonsApi();
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Addon schema (optional) 

            try
            {
                // Fetch all the addons authored / co-authored by a user
                InlineResponse200 result = apiInstance.ListUserAddons(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAddonsApi.ListUserAddons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the Addon schema | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
