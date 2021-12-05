# Everyday.GmodStore.Sdk.Api.AddonCouponsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddonCoupon**](AddonCouponsApi.md#createaddoncoupon) | **POST** /addons/{addon_id}/coupons | Create an addon coupon
[**DeleteAddonCoupon**](AddonCouponsApi.md#deleteaddoncoupon) | **DELETE** /addons/{addon_id}/coupons/{coupon_id} | Destroy an addon&#39;s coupon
[**GetAddonCoupon**](AddonCouponsApi.md#getaddoncoupon) | **GET** /addons/{addon_id}/coupons/{coupon_id} | Fetch an addon&#39;s coupon
[**ListAddonCoupons**](AddonCouponsApi.md#listaddoncoupons) | **GET** /addons/{addon_id}/coupons | Fetch all the coupons for an addon
[**UpdateAddonCoupon**](AddonCouponsApi.md#updateaddoncoupon) | **PUT** /addons/{addon_id}/coupons/{coupon_id} | Update an addon&#39;s coupon


<a name="createaddoncoupon"></a>
# **CreateAddonCoupon**
> AddonCouponResponse CreateAddonCoupon (long addonId, AddonCoupon addonCoupon, List<string> with = null)

Create an addon coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateAddonCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var addonCoupon = new AddonCoupon(); // AddonCoupon | 
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Create an addon coupon
                AddonCouponResponse result = apiInstance.CreateAddonCoupon(addonId, addonCoupon, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.CreateAddonCoupon: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long**| Id of the addon | 
 **addonCoupon** | [**AddonCoupon**](AddonCoupon.md)|  | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaddoncoupon"></a>
# **DeleteAddonCoupon**
> void DeleteAddonCoupon (long addonId, long couponId)

Destroy an addon's coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class DeleteAddonCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var couponId = 789;  // long | Id of the coupon

            try
            {
                // Destroy an addon's coupon
                apiInstance.DeleteAddonCoupon(addonId, couponId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.DeleteAddonCoupon: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long**| Id of the addon | 
 **couponId** | **long**| Id of the coupon | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaddoncoupon"></a>
# **GetAddonCoupon**
> AddonCouponResponse GetAddonCoupon (long addonId, long couponId, List<string> with = null)

Fetch an addon's coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var couponId = 789;  // long | Id of the coupon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Fetch an addon's coupon
                AddonCouponResponse result = apiInstance.GetAddonCoupon(addonId, couponId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.GetAddonCoupon: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long**| Id of the addon | 
 **couponId** | **long**| Id of the coupon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaddoncoupons"></a>
# **ListAddonCoupons**
> AddonCouponListResponse ListAddonCoupons (long addonId, List<string> with = null)

Fetch all the coupons for an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Fetch all the coupons for an addon
                AddonCouponListResponse result = apiInstance.ListAddonCoupons(addonId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.ListAddonCoupons: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponListResponse**](AddonCouponListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaddoncoupon"></a>
# **UpdateAddonCoupon**
> AddonCouponResponse UpdateAddonCoupon (long addonId, long couponId, AddonCoupon addonCoupon, List<string> with = null)

Update an addon's coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateAddonCouponExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var couponId = 789;  // long | Id of the coupon
            var addonCoupon = new AddonCoupon(); // AddonCoupon | 
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Update an addon's coupon
                AddonCouponResponse result = apiInstance.UpdateAddonCoupon(addonId, couponId, addonCoupon, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.UpdateAddonCoupon: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long**| Id of the addon | 
 **couponId** | **long**| Id of the coupon | 
 **addonCoupon** | [**AddonCoupon**](AddonCoupon.md)|  | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;AddonCoupon&#x60; | [optional] 

### Return type

[**AddonCouponResponse**](AddonCouponResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

