# NO.Everyday.GmodStoreSDK.Api.AddonStatsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddonStats**](AddonStatsApi.md#getaddonstats) | **GET** /addons/{addon_id}/stats | Fetch all the stats for an addon

<a name="getaddonstats"></a>
# **GetAddonStats**
> InlineResponse2002 GetAddonStats (long? addonId)

Fetch all the stats for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class GetAddonStatsExample
    {
        public void main()
        {

            var apiInstance = new AddonStatsApi();
            var addonId = 789;  // long? | Id of the addon

            try
            {
                // Fetch all the stats for an addon
                InlineResponse2002 result = apiInstance.GetAddonStats(addonId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonStatsApi.GetAddonStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
