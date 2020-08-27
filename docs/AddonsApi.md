# Everyday.GmodStore.Sdk.Api.AddonsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddon**](AddonsApi.md#getaddon) | **GET** /addons/{addon_id} | Fetch a single addon
[**ListSelfAddons**](AddonsApi.md#listselfaddons) | **GET** /addons | Fetch all the addons that you have access to

<a name="getaddon"></a>
# **GetAddon**
> AddonResponse GetAddon (long? addonId, List<string> with = null)

Fetch a single addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

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
                AddonResponse result = apiInstance.GetAddon(addonId, with);
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

[**AddonResponse**](AddonResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listselfaddons"></a>
# **ListSelfAddons**
> AddonListResponse ListSelfAddons (List<string> with = null)

Fetch all the addons that you have access to

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

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
                AddonListResponse result = apiInstance.ListSelfAddons(with);
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

[**AddonListResponse**](AddonListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
