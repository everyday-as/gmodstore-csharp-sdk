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
> AddonPurchaseResponse CreateAddonPurchase (NewAddonPurchase body, long? addonId, List<string> with = null)

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
            var body = new NewAddonPurchase(); // NewAddonPurchase | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Create a purchase for an addon
                AddonPurchaseResponse result = apiInstance.CreateAddonPurchase(body, addonId, with);
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
 **body** | [**NewAddonPurchase**](NewAddonPurchase.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddonpurchase"></a>
# **GetAddonPurchase**
> AddonPurchaseResponse GetAddonPurchase (long? addonId, long? userId, List<string> with = null)

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
            var userId = 789;  // long? | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Get a purchase of an addon by user
                AddonPurchaseResponse result = apiInstance.GetAddonPurchase(addonId, userId, with);
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
 **userId** | **long?**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddonpurchases"></a>
# **ListAddonPurchases**
> AddonPurchaseListResponse ListAddonPurchases (long? addonId, List<string> with = null)

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
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Fetch all purchases of an addon
                AddonPurchaseListResponse result = apiInstance.ListAddonPurchases(addonId, with);
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
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseListResponse**](AddonPurchaseListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaddonpurchase"></a>
# **UpdateAddonPurchase**
> AddonPurchaseResponse UpdateAddonPurchase (AddonPurchase body, long? addonId, long? userId, List<string> with = null)

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
            var body = new AddonPurchase(); // AddonPurchase | 
            var addonId = 789;  // long? | Id of the addon
            var userId = 789;  // long? | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Update a purchase for an addon
                AddonPurchaseResponse result = apiInstance.UpdateAddonPurchase(body, addonId, userId, with);
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
 **body** | [**AddonPurchase**](AddonPurchase.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **userId** | **long?**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
