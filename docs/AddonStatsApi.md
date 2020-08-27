# Everyday.GmodStore.Sdk.Api.AddonStatsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddonStats**](AddonStatsApi.md#getaddonstats) | **GET** /addons/{addon_id}/stats | Fetch all the stats for an addon

<a name="getaddonstats"></a>
# **GetAddonStats**
> AddonStatsListResponse GetAddonStats (long? addonId)

Fetch all the stats for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

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
                AddonStatsListResponse result = apiInstance.GetAddonStats(addonId);
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

[**AddonStatsListResponse**](AddonStatsListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
