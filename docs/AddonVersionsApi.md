# NO.Everyday.GmodStoreSDK.Api.AddonVersionsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddonsAddonIdVersionsGet**](AddonVersionsApi.md#addonsaddonidversionsget) | **GET** /addons/{addon_id}/versions | Fetch all the versions of an addon
[**AddonsAddonIdVersionsPost**](AddonVersionsApi.md#addonsaddonidversionspost) | **POST** /addons/{addon_id}/versions | Create a new version for an addon
[**AddonsAddonIdVersionsVersionIdDownloadGet**](AddonVersionsApi.md#addonsaddonidversionsversioniddownloadget) | **GET** /addons/{addon_id}/versions/{version_id}/download | Generate a download token for a specific version of an addon
[**AddonsAddonIdVersionsVersionIdGet**](AddonVersionsApi.md#addonsaddonidversionsversionidget) | **GET** /addons/{addon_id}/versions/{version_id} | Fetch a specific version of an addon
[**AddonsAddonIdVersionsVersionIdPut**](AddonVersionsApi.md#addonsaddonidversionsversionidput) | **PUT** /addons/{addon_id}/versions/{version_id} | Update a version of an addon

<a name="addonsaddonidversionsget"></a>
# **AddonsAddonIdVersionsGet**
> InlineResponse2007 AddonsAddonIdVersionsGet (long? addonId, List<string> with = null)

Fetch all the versions of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdVersionsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Fetch all the versions of an addon
                InlineResponse2007 result = apiInstance.AddonsAddonIdVersionsGet(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.AddonsAddonIdVersionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidversionspost"></a>
# **AddonsAddonIdVersionsPost**
> InlineResponse2012 AddonsAddonIdVersionsPost (string name, string changelog, byte[] _file, long? addonId, List<string> with = null)

Create a new version for an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdVersionsPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonVersionsApi();
            var name = name_example;  // string | 
            var changelog = changelog_example;  // string | 
            var _file = _file_example;  // byte[] | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Create a new version for an addon
                InlineResponse2012 result = apiInstance.AddonsAddonIdVersionsPost(name, changelog, _file, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.AddonsAddonIdVersionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **changelog** | **string**|  | 
 **_file** | **byte[]****byte[]**|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidversionsversioniddownloadget"></a>
# **AddonsAddonIdVersionsVersionIdDownloadGet**
> InlineResponse2008 AddonsAddonIdVersionsVersionIdDownloadGet (long? addonId, long? versionId)

Generate a download token for a specific version of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdVersionsVersionIdDownloadGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version

            try
            {
                // Generate a download token for a specific version of an addon
                InlineResponse2008 result = apiInstance.AddonsAddonIdVersionsVersionIdDownloadGet(addonId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.AddonsAddonIdVersionsVersionIdDownloadGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **versionId** | **long?**| Id of the version | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidversionsversionidget"></a>
# **AddonsAddonIdVersionsVersionIdGet**
> InlineResponse2012 AddonsAddonIdVersionsVersionIdGet (long? addonId, long? versionId, List<string> with = null)

Fetch a specific version of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdVersionsVersionIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Fetch a specific version of an addon
                InlineResponse2012 result = apiInstance.AddonsAddonIdVersionsVersionIdGet(addonId, versionId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.AddonsAddonIdVersionsVersionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addonId** | **long?**| Id of the addon | 
 **versionId** | **long?**| Id of the version | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addonsaddonidversionsversionidput"></a>
# **AddonsAddonIdVersionsVersionIdPut**
> InlineResponse2012 AddonsAddonIdVersionsVersionIdPut (string name, string changelog, byte[] _file, long? addonId, long? versionId, List<string> with = null)

Update a version of an addon

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class AddonsAddonIdVersionsVersionIdPutExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddonVersionsApi();
            var name = name_example;  // string | 
            var changelog = changelog_example;  // string | 
            var _file = _file_example;  // byte[] | 
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Update a version of an addon
                InlineResponse2012 result = apiInstance.AddonsAddonIdVersionsVersionIdPut(name, changelog, _file, addonId, versionId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.AddonsAddonIdVersionsVersionIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **changelog** | **string**|  | 
 **_file** | **byte[]****byte[]**|  | 
 **addonId** | **long?**| Id of the addon | 
 **versionId** | **long?**| Id of the version | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
