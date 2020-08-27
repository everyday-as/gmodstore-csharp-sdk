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
> AddonCouponResponse CreateAddonCoupon (AddonCoupon body, long? addonId, List<string> with = null)

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
            var body = new AddonCoupon(); // AddonCoupon | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Create an addon coupon
                AddonCouponResponse result = apiInstance.CreateAddonCoupon(body, addonId, with);
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
 **body** | [**AddonCoupon**](AddonCoupon.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

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
> AddonCouponResponse GetAddonCoupon (long? addonId, long? couponId, List<string> with = null)

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
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Fetch an addon's coupon
                AddonCouponResponse result = apiInstance.GetAddonCoupon(addonId, couponId, with);
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
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddoncoupons"></a>
# **ListAddonCoupons**
> AddonCouponListResponse ListAddonCoupons (long? addonId, List<string> with = null)

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
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Fetch all the coupons for an addon
                AddonCouponListResponse result = apiInstance.ListAddonCoupons(addonId, with);
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
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponListResponse**](AddonCouponListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaddoncoupon"></a>
# **UpdateAddonCoupon**
> AddonCouponResponse UpdateAddonCoupon (AddonCoupon body, long? addonId, long? couponId, List<string> with = null)

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
            var body = new AddonCoupon(); // AddonCoupon | 
            var addonId = 789;  // long? | Id of the addon
            var couponId = 789;  // long? | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Update an addon's coupon
                AddonCouponResponse result = apiInstance.UpdateAddonCoupon(body, addonId, couponId, with);
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
 **body** | [**AddonCoupon**](AddonCoupon.md)|  | 
 **addonId** | **long?**| Id of the addon | 
 **couponId** | **long?**| Id of the coupon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
