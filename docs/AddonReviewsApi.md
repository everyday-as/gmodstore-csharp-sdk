# NO.Everyday.GmodStoreSDK.Api.AddonReviewsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonsAddonIdReviewsGet**](AddonReviewsApi.md#addonsaddonidreviewsget) | **GET** /addons/{addon_id}/reviews | Fetch all the reviews of an addon
[**AddonsAddonIdReviewsReviewIdGet**](AddonReviewsApi.md#addonsaddonidreviewsreviewidget) | **GET** /addons/{addon_id}/reviews/{review_id} | Fetch a review of an addon

<a name="addonsaddonidreviewsget"></a>
# **AddonsAddonIdReviewsGet**
> InlineResponse2005 AddonsAddonIdReviewsGet (long? addonId, List<string> with = null)

Fetch all the reviews of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdReviewsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonReviewsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonReview schema (optional) 

            try
            {
                // Fetch all the reviews of an addon
                InlineResponse2005 result = apiInstance.AddonsAddonIdReviewsGet(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.AddonsAddonIdReviewsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonReview schema | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidreviewsreviewidget"></a>
# **AddonsAddonIdReviewsReviewIdGet**
> InlineResponse2006 AddonsAddonIdReviewsReviewIdGet (long? addonId, long? reviewId, List<string> with = null)

Fetch a review of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdReviewsReviewIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonReviewsApi();
            var addonId = 789;  // long? | Id of the addon
            var reviewId = 789;  // long? | Id of the review
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonReview schema (optional) 

            try
            {
                // Fetch a review of an addon
                InlineResponse2006 result = apiInstance.AddonsAddonIdReviewsReviewIdGet(addonId, reviewId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.AddonsAddonIdReviewsReviewIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **reviewId** | **long?**| Id of the review | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonReview schema | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
