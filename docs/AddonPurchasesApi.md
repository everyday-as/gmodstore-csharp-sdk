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
> AddonPurchaseResponse CreateAddonPurchase (long addonId, NewAddonPurchase newAddonPurchase, List<string> with = null)

Create a purchase for an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateAddonPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonPurchasesApi(config);
            var addonId = 789;  // long | Id of the addon
            var newAddonPurchase = new NewAddonPurchase(); // NewAddonPurchase | 
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Create a purchase for an addon
                AddonPurchaseResponse result = apiInstance.CreateAddonPurchase(addonId, newAddonPurchase, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.CreateAddonPurchase: " + e.Message );
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
 **newAddonPurchase** | [**NewAddonPurchase**](NewAddonPurchase.md)|  | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

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

<a name="getaddonpurchase"></a>
# **GetAddonPurchase**
> AddonPurchaseResponse GetAddonPurchase (long addonId, long userId, List<string> with = null)

Get a purchase of an addon by user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonPurchasesApi(config);
            var addonId = 789;  // long | Id of the addon
            var userId = 789;  // long | Id of the user
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Get a purchase of an addon by user
                AddonPurchaseResponse result = apiInstance.GetAddonPurchase(addonId, userId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.GetAddonPurchase: " + e.Message );
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
 **userId** | **long**| Id of the user | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

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

<a name="listaddonpurchases"></a>
# **ListAddonPurchases**
> AddonPurchaseListResponse ListAddonPurchases (long addonId, List<string> with = null)

Fetch all purchases of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonPurchasesApi(config);
            var addonId = 789;  // long | Id of the addon
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Fetch all purchases of an addon
                AddonPurchaseListResponse result = apiInstance.ListAddonPurchases(addonId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.ListAddonPurchases: " + e.Message );
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
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseListResponse**](AddonPurchaseListResponse.md)

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

<a name="updateaddonpurchase"></a>
# **UpdateAddonPurchase**
> AddonPurchaseResponse UpdateAddonPurchase (long addonId, long userId, AddonPurchase addonPurchase, List<string> with = null)

Update a purchase for an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateAddonPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonPurchasesApi(config);
            var addonId = 789;  // long | Id of the addon
            var userId = 789;  // long | Id of the user
            var addonPurchase = new AddonPurchase(); // AddonPurchase | 
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonPurchase` (optional) 

            try
            {
                // Update a purchase for an addon
                AddonPurchaseResponse result = apiInstance.UpdateAddonPurchase(addonId, userId, addonPurchase, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonPurchasesApi.UpdateAddonPurchase: " + e.Message );
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
 **userId** | **long**| Id of the user | 
 **addonPurchase** | [**AddonPurchase**](AddonPurchase.md)|  | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonPurchase&#x60; | [optional] 

### Return type

[**AddonPurchaseResponse**](AddonPurchaseResponse.md)

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

