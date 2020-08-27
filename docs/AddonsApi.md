# NO.Everyday.GmodStoreSDK.Api.AddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddon**](AddonsApi.md#getaddon) | **GET** /addons/{addon_id} | Fetch a single addon
[**ListSelfAddons**](AddonsApi.md#listselfaddons) | **GET** /addons | Fetch all the addons that you have access to

<a name="getaddon"></a>
# **GetAddon**
> InlineResponse2001 GetAddon (long? addonId, List<string> with = null)

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
    public class GetAddonExample
    {
        public void main()
        {

            var apiInstance = new AddonsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Addon schema (optional) 

            try
            {
                // Fetch a single addon
                InlineResponse2001 result = apiInstance.GetAddon(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonsApi.GetAddon: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listselfaddons"></a>
# **ListSelfAddons**
> InlineResponse200 ListSelfAddons (List<string> with = null)

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
    public class ListSelfAddonsExample
    {
        public void main()
        {

            var apiInstance = new AddonsApi();
            var with = new List<string>(); // List<string> | The relations you want to fetch with the Addon schema (optional) 

            try
            {
                // Fetch all the addons that you have access to
                InlineResponse200 result = apiInstance.ListSelfAddons(with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonsApi.ListSelfAddons: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
