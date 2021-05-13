# Everyday.GmodStore.Sdk.Api.AddonReviewsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddonReview**](AddonReviewsApi.md#getaddonreview) | **GET** /addons/{addon_id}/reviews/{review_id} | Fetch a review of an addon
[**ListAddonReviews**](AddonReviewsApi.md#listaddonreviews) | **GET** /addons/{addon_id}/reviews | Fetch all the reviews of an addon


<a name="getaddonreview"></a>
# **GetAddonReview**
> AddonReviewResponse GetAddonReview (long addonId, long reviewId, List<string> with = null)

Fetch a review of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonReviewsApi(config);
            var addonId = 789;  // long | Id of the addon
            var reviewId = 789;  // long | Id of the review
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonReview` (optional) 

            try
            {
                // Fetch a review of an addon
                AddonReviewResponse result = apiInstance.GetAddonReview(addonId, reviewId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.GetAddonReview: " + e.Message );
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
 **reviewId** | **long**| Id of the review | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonReview&#x60; | [optional] 

### Return type

[**AddonReviewResponse**](AddonReviewResponse.md)

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

<a name="listaddonreviews"></a>
# **ListAddonReviews**
> AddonReviewListResponse ListAddonReviews (long addonId, List<string> with = null)

Fetch all the reviews of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonReviewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonReviewsApi(config);
            var addonId = 789;  // long | Id of the addon
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonReview` (optional) 

            try
            {
                // Fetch all the reviews of an addon
                AddonReviewListResponse result = apiInstance.ListAddonReviews(addonId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.ListAddonReviews: " + e.Message );
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
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonReview&#x60; | [optional] 

### Return type

[**AddonReviewListResponse**](AddonReviewListResponse.md)

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

