# NO.Everyday.GmodStoreSDK.Api.AddonPurchasesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonsAddonIdPurchasesGet**](AddonPurchasesApi.md#addonsaddonidpurchasesget) | **GET** /addons/{addon_id}/purchases | Fetch all purchases of an addon
[**AddonsAddonIdPurchasesPost**](AddonPurchasesApi.md#addonsaddonidpurchasespost) | **POST** /addons/{addon_id}/purchases | Create a purchase for an addon
[**AddonsAddonIdPurchasesUserIdGet**](AddonPurchasesApi.md#addonsaddonidpurchasesuseridget) | **GET** /addons/{addon_id}/purchases/{user_id} | Get a purchase of an addon by user
[**AddonsAddonIdPurchasesUserIdPut**](AddonPurchasesApi.md#addonsaddonidpurchasesuseridput) | **PUT** /addons/{addon_id}/purchases/{user_id} | Update a purchase for an addon

<a name="addonsaddonidpurchasesget"></a>
# **AddonsAddonIdPurchasesGet**
> InlineResponse2003 AddonsAddonIdPurchasesGet (long? addonId, List<string> with = null)

Fetch all purchases of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdPurchasesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonPurchasesApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Fetch all purchases of an addon
                InlineResponse2003 result = apiInstance.AddonsAddonIdPurchasesGet(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.AddonsAddonIdPurchasesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidpurchasespost"></a>
# **AddonsAddonIdPurchasesPost**
> InlineResponse2011 AddonsAddonIdPurchasesPost (Object body, long? addonId, List<string> with = null)

Create a purchase for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdPurchasesPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonPurchasesApi();
            var body = new Object(); // Object | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Create a purchase for an addon
                InlineResponse2011 result = apiInstance.AddonsAddonIdPurchasesPost(body, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.AddonsAddonIdPurchasesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidpurchasesuseridget"></a>
# **AddonsAddonIdPurchasesUserIdGet**
> InlineResponse2011 AddonsAddonIdPurchasesUserIdGet (long? addonId, string userId, List<string> with = null)

Get a purchase of an addon by user

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdPurchasesUserIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonPurchasesApi();
            var addonId = 789;  // long? | Id of the addon
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Get a purchase of an addon by user
                InlineResponse2011 result = apiInstance.AddonsAddonIdPurchasesUserIdGet(addonId, userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.AddonsAddonIdPurchasesUserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidpurchasesuseridput"></a>
# **AddonsAddonIdPurchasesUserIdPut**
> InlineResponse2011 AddonsAddonIdPurchasesUserIdPut (Object body, long? addonId, string userId, List<string> with = null)

Update a purchase for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdPurchasesUserIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonPurchasesApi();
            var body = new Object(); // Object | 
            var addonId = 789;  // long? | Id of the addon
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Update a purchase for an addon
                InlineResponse2011 result = apiInstance.AddonsAddonIdPurchasesUserIdPut(body, addonId, userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.AddonsAddonIdPurchasesUserIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Object**](Object.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
