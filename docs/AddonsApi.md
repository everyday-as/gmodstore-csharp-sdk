# NO.Everyday.GmodStoreSDK.Api.AddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonsAddonIdGet**](AddonsApi.md#addonsaddonidget) | **GET** /addons/{addon_id} | Fetch a single addon
[**AddonsGet**](AddonsApi.md#addonsget) | **GET** /addons | Fetch all the addons that you have access to

<a name="addonsaddonidget"></a>
# **AddonsAddonIdGet**
> InlineResponse2001 AddonsAddonIdGet (long? addonId, List<string> with = null)

Fetch a single addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Addon schema (optional) 

            try
            {
                // Fetch a single addon
                InlineResponse2001 result = apiInstance.AddonsAddonIdGet(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonsApi.AddonsAddonIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the Addon schema | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsget"></a>
# **AddonsGet**
> InlineResponse200 AddonsGet (List<string> with = null)

Fetch all the addons that you have access to

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonsApi();
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Addon schema (optional) 

            try
            {
                // Fetch all the addons that you have access to
                InlineResponse200 result = apiInstance.AddonsGet(with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonsApi.AddonsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the Addon schema | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
