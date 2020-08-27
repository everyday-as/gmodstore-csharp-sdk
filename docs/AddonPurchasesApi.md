# Everyday.GmodStore.Sdk.Api.AddonPurchasesApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddonPurchase**](AddonPurchasesApi.md#createaddonpurchase) | **POST** /addons/{addon_id}/purchases | Create a purchase for an addon
[**GetAddonPurchase**](AddonPurchasesApi.md#getaddonpurchase) | **GET** /addons/{addon_id}/purchases/{user_id} | Get a purchase of an addon by user
[**ListAddonPurchases**](AddonPurchasesApi.md#listaddonpurchases) | **GET** /addons/{addon_id}/purchases | Fetch all purchases of an addon
[**UpdateAddonPurchase**](AddonPurchasesApi.md#updateaddonpurchase) | **PUT** /addons/{addon_id}/purchases/{user_id} | Update a purchase for an addon

<a name="createaddonpurchase"></a>
# **CreateAddonPurchase**
> InlineResponse2011 CreateAddonPurchase (AddonPurchaseCreateBody body, long? addonId, List<string> with = null)

Create a purchase for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateAddonPurchaseExample
    {
        public void main()
        {

            var apiInstance = new AddonPurchasesApi();
            var body = new AddonPurchaseCreateBody(); // AddonPurchaseCreateBody | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Create a purchase for an addon
                InlineResponse2011 result = apiInstance.CreateAddonPurchase(body, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.CreateAddonPurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddonPurchaseCreateBody**](AddonPurchaseCreateBody.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddonpurchase"></a>
# **GetAddonPurchase**
> InlineResponse2011 GetAddonPurchase (long? addonId, string userId, List<string> with = null)

Get a purchase of an addon by user

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonPurchaseExample
    {
        public void main()
        {

            var apiInstance = new AddonPurchasesApi();
            var addonId = 789;  // long? | Id of the addon
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Get a purchase of an addon by user
                InlineResponse2011 result = apiInstance.GetAddonPurchase(addonId, userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.GetAddonPurchase: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddonpurchases"></a>
# **ListAddonPurchases**
> InlineResponse2004 ListAddonPurchases (long? addonId, List<string> with = null)

Fetch all purchases of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonPurchasesExample
    {
        public void main()
        {

            var apiInstance = new AddonPurchasesApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Fetch all purchases of an addon
                InlineResponse2004 result = apiInstance.ListAddonPurchases(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.ListAddonPurchases: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaddonpurchase"></a>
# **UpdateAddonPurchase**
> InlineResponse2011 UpdateAddonPurchase (AddonPurchaseUpdateBody body, long? addonId, string userId, List<string> with = null)

Update a purchase for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateAddonPurchaseExample
    {
        public void main()
        {

            var apiInstance = new AddonPurchasesApi();
            var body = new AddonPurchaseUpdateBody(); // AddonPurchaseUpdateBody | 
            var addonId = 789;  // long? | Id of the addon
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonPurchase schema (optional) 

            try
            {
                // Update a purchase for an addon
                InlineResponse2011 result = apiInstance.UpdateAddonPurchase(body, addonId, userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.UpdateAddonPurchase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddonPurchaseUpdateBody**](AddonPurchaseUpdateBody.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonPurchase schema | [optional] 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
