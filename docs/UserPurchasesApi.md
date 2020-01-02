# NO.Everyday.GmodStoreSDK.Api.UserPurchasesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdPurchasesGet**](UserPurchasesApi.md#usersuseridpurchasesget) | **GET** /users/{user_id}/purchases | Fetch all purchases a user has made

<a name="usersuseridpurchasesget"></a>
# **UsersUserIdPurchasesGet**
> InlineResponse2004 UsersUserIdPurchasesGet (string userId, List<string> with = null)

Fetch all purchases a user has made

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdPurchasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserPurchasesApi();
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Fetch all purchases a user has made
                InlineResponse2004 result = apiInstance.UsersUserIdPurchasesGet(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserPurchasesApi.UsersUserIdPurchasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
