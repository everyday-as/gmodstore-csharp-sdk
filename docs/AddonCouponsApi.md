# NO.Everyday.GmodStoreSDK.Api.AddonCouponsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonsAddonIdCouponsCouponIdDelete**](AddonCouponsApi.md#addonsaddonidcouponscouponiddelete) | **DELETE** /addons/{addon_id}/coupons/{coupon_id} | Destroy an addon&#x27;s coupon
[**AddonsAddonIdCouponsCouponIdGet**](AddonCouponsApi.md#addonsaddonidcouponscouponidget) | **GET** /addons/{addon_id}/coupons/{coupon_id} | Fetch an addon&#x27;s coupon
[**AddonsAddonIdCouponsCouponIdPut**](AddonCouponsApi.md#addonsaddonidcouponscouponidput) | **PUT** /addons/{addon_id}/coupons/{coupon_id} | Update an addon&#x27;s coupon
[**AddonsAddonIdCouponsGet**](AddonCouponsApi.md#addonsaddonidcouponsget) | **GET** /addons/{addon_id}/coupons | Fetch all the coupons for an addon
[**AddonsAddonIdCouponsPost**](AddonCouponsApi.md#addonsaddonidcouponspost) | **POST** /addons/{addon_id}/coupons | Create an addon coupon

<a name="addonsaddonidcouponscouponiddelete"></a>
# **AddonsAddonIdCouponsCouponIdDelete**
> void AddonsAddonIdCouponsCouponIdDelete (long? addonId, long? couponId)

Destroy an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdCouponsCouponIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon

            try
            {
                // Destroy an addon's coupon
                apiInstance.AddonsAddonIdCouponsCouponIdDelete(addonId, couponId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.AddonsAddonIdCouponsCouponIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **couponId** | **long?**| Id of the coupon | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidcouponscouponidget"></a>
# **AddonsAddonIdCouponsCouponIdGet**
> InlineResponse201 AddonsAddonIdCouponsCouponIdGet (long? addonId, long? couponId, List<string> with = null)

Fetch an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdCouponsCouponIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Fetch an addon's coupon
                InlineResponse201 result = apiInstance.AddonsAddonIdCouponsCouponIdGet(addonId, couponId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.AddonsAddonIdCouponsCouponIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **couponId** | **long?**| Id of the coupon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidcouponscouponidput"></a>
# **AddonsAddonIdCouponsCouponIdPut**
> InlineResponse201 AddonsAddonIdCouponsCouponIdPut (Object body, long? addonId, long? couponId, List<string> with = null)

Update an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdCouponsCouponIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonCouponsApi();
            var body = new Object(); // Object | 
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Update an addon's coupon
                InlineResponse201 result = apiInstance.AddonsAddonIdCouponsCouponIdPut(body, addonId, couponId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.AddonsAddonIdCouponsCouponIdPut: " + e.Message );
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
 **couponId** | **long?**| Id of the coupon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidcouponsget"></a>
# **AddonsAddonIdCouponsGet**
> InlineResponse2002 AddonsAddonIdCouponsGet (long? addonId, List<string> with = null)

Fetch all the coupons for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdCouponsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Fetch all the coupons for an addon
                InlineResponse2002 result = apiInstance.AddonsAddonIdCouponsGet(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.AddonsAddonIdCouponsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidcouponspost"></a>
# **AddonsAddonIdCouponsPost**
> InlineResponse201 AddonsAddonIdCouponsPost (Object body, long? addonId, List<string> with = null)

Create an addon coupon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdCouponsPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonCouponsApi();
            var body = new Object(); // Object | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Create an addon coupon
                InlineResponse201 result = apiInstance.AddonsAddonIdCouponsPost(body, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.AddonsAddonIdCouponsPost: " + e.Message );
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
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
