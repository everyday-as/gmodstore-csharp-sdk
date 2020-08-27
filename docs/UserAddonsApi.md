# Everyday.GmodStore.Sdk.Api.UserAddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserAddons**](UserAddonsApi.md#listuseraddons) | **GET** /users/{user_id}/addons | Fetch all the addons authored / co-authored by a user

<a name="listuseraddons"></a>
# **ListUserAddons**
> AddonListResponse ListUserAddons (long? userId, List<string> with = null)

Fetch all the addons authored / co-authored by a user

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserAddonsExample
    {
        public void main()
        {

            var apiInstance = new UserAddonsApi();
            var userId = 789;  // long? | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `Addon` (optional) 

            try
            {
                // Fetch all the addons authored / co-authored by a user
                AddonListResponse result = apiInstance.ListUserAddons(userId, with);
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
 **userId** | **long?**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;Addon&#x60; | [optional] 

### Return type

[**AddonListResponse**](AddonListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
