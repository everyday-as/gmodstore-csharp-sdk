# Everyday.GmodStore.Sdk.Api.AddonReviewsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddonReview**](AddonReviewsApi.md#getaddonreview) | **GET** /addons/{addon_id}/reviews/{review_id} | Fetch a review of an addon
[**ListAddonReviews**](AddonReviewsApi.md#listaddonreviews) | **GET** /addons/{addon_id}/reviews | Fetch all the reviews of an addon

<a name="getaddonreview"></a>
# **GetAddonReview**
> InlineResponse2006 GetAddonReview (long? addonId, long? reviewId, List<string> with = null)

Fetch a review of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonReviewExample
    {
        public void main()
        {

            var apiInstance = new AddonReviewsApi();
            var addonId = 789;  // long? | Id of the addon
            var reviewId = 789;  // long? | Id of the review
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonReview schema (optional) 

            try
            {
                // Fetch a review of an addon
                InlineResponse2006 result = apiInstance.GetAddonReview(addonId, reviewId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.GetAddonReview: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddonreviews"></a>
# **ListAddonReviews**
> InlineResponse2005 ListAddonReviews (long? addonId, List<string> with = null)

Fetch all the reviews of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonReviewsExample
    {
        public void main()
        {

            var apiInstance = new AddonReviewsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonReview schema (optional) 

            try
            {
                // Fetch all the reviews of an addon
                InlineResponse2005 result = apiInstance.ListAddonReviews(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonReviewsApi.ListAddonReviews: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
