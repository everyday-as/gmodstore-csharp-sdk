# Everyday.GmodStore.Sdk.Api.UserPurchasesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserPurchases**](UserPurchasesApi.md#listuserpurchases) | **GET** /users/{user_id}/purchases | Fetch all purchases a user has made

<a name="listuserpurchases"></a>
# **ListUserPurchases**
> AddonPurchaseListResponse ListUserPurchases (long? userId, List<string> with = null)

Fetch all purchases a user has made

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserPurchasesExample
    {
        public void main()
        {

            var apiInstance = new UserPurchasesApi();
            var userId = 789;  // long? | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Fetch all purchases a user has made
                AddonPurchaseListResponse result = apiInstance.ListUserPurchases(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserPurchasesApi.ListUserPurchases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseListResponse**](AddonPurchaseListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
