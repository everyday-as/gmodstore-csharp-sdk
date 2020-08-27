# Everyday.GmodStore.Sdk.Api.AddonCouponsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddonCoupon**](AddonCouponsApi.md#createaddoncoupon) | **POST** /addons/{addon_id}/coupons | Create an addon coupon
[**DeleteAddonCoupon**](AddonCouponsApi.md#deleteaddoncoupon) | **DELETE** /addons/{addon_id}/coupons/{coupon_id} | Destroy an addon&#x27;s coupon
[**GetAddonCoupon**](AddonCouponsApi.md#getaddoncoupon) | **GET** /addons/{addon_id}/coupons/{coupon_id} | Fetch an addon&#x27;s coupon
[**ListAddonCoupons**](AddonCouponsApi.md#listaddoncoupons) | **GET** /addons/{addon_id}/coupons | Fetch all the coupons for an addon
[**UpdateAddonCoupon**](AddonCouponsApi.md#updateaddoncoupon) | **PUT** /addons/{addon_id}/coupons/{coupon_id} | Update an addon&#x27;s coupon

<a name="createaddoncoupon"></a>
# **CreateAddonCoupon**
> InlineResponse201 CreateAddonCoupon (AddonCouponBody body, long? addonId, List<string> with = null)

Create an addon coupon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateAddonCouponExample
    {
        public void main()
        {

            var apiInstance = new AddonCouponsApi();
            var body = new AddonCouponBody(); // AddonCouponBody | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Create an addon coupon
                InlineResponse201 result = apiInstance.CreateAddonCoupon(body, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.CreateAddonCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddonCouponBody**](AddonCouponBody.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteaddoncoupon"></a>
# **DeleteAddonCoupon**
> void DeleteAddonCoupon (long? addonId, long? couponId)

Destroy an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class DeleteAddonCouponExample
    {
        public void main()
        {

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon

            try
            {
                // Destroy an addon's coupon
                apiInstance.DeleteAddonCoupon(addonId, couponId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.DeleteAddonCoupon: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddoncoupon"></a>
# **GetAddonCoupon**
> InlineResponse201 GetAddonCoupon (long? addonId, long? couponId, List<string> with = null)

Fetch an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonCouponExample
    {
        public void main()
        {

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Fetch an addon's coupon
                InlineResponse201 result = apiInstance.GetAddonCoupon(addonId, couponId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.GetAddonCoupon: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddoncoupons"></a>
# **ListAddonCoupons**
> InlineResponse2003 ListAddonCoupons (long? addonId, List<string> with = null)

Fetch all the coupons for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonCouponsExample
    {
        public void main()
        {

            var apiInstance = new AddonCouponsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Fetch all the coupons for an addon
                InlineResponse2003 result = apiInstance.ListAddonCoupons(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.ListAddonCoupons: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaddoncoupon"></a>
# **UpdateAddonCoupon**
> InlineResponse201 UpdateAddonCoupon (AddonCouponBody body, long? addonId, long? couponId, List<string> with = null)

Update an addon's coupon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateAddonCouponExample
    {
        public void main()
        {

            var apiInstance = new AddonCouponsApi();
            var body = new AddonCouponBody(); // AddonCouponBody | 
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonCoupon schema (optional) 

            try
            {
                // Update an addon's coupon
                InlineResponse201 result = apiInstance.UpdateAddonCoupon(body, addonId, couponId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.UpdateAddonCoupon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AddonCouponBody**](AddonCouponBody.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **couponId** | **long?**| Id of the coupon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonCoupon schema | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
