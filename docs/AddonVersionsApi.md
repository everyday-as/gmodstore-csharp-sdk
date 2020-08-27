# NO.Everyday.GmodStoreSDK.Api.AddonVersionsApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAddonVersion**](AddonVersionsApi.md#createaddonversion) | **POST** /addons/{addon_id}/versions | Create a new version for an addon
[**DownloadAddonVersion**](AddonVersionsApi.md#downloadaddonversion) | **GET** /addons/{addon_id}/versions/{version_id}/download | Generate a download token for a specific version of an addon
[**GetAddonVersion**](AddonVersionsApi.md#getaddonversion) | **GET** /addons/{addon_id}/versions/{version_id} | Fetch a specific version of an addon
[**ListAddonVersions**](AddonVersionsApi.md#listaddonversions) | **GET** /addons/{addon_id}/versions | Fetch all the versions of an addon
[**UpdateAddonVersion**](AddonVersionsApi.md#updateaddonversion) | **PUT** /addons/{addon_id}/versions/{version_id} | Update a version of an addon

<a name="createaddonversion"></a>
# **CreateAddonVersion**
> InlineResponse2012 CreateAddonVersion (string name, string changelog, byte[] _file, string releaseType, long? addonId, List<string> with = null)

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
    public class CreateAddonVersionExample
    {
        public void main()
        {

            var apiInstance = new AddonVersionsApi();
            var name = name_example;  // string | 
            var changelog = changelog_example;  // string | 
            var _file = _file_example;  // byte[] | 
            var releaseType = releaseType_example;  // string | 
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Create a new version for an addon
                InlineResponse2012 result = apiInstance.CreateAddonVersion(name, changelog, _file, releaseType, addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.CreateAddonVersion: " + e.Message );
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
 **releaseType** | **string**|  | 
 **addonId** | **long?**| Id of the addon | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadaddonversion"></a>
# **DownloadAddonVersion**
> InlineResponse2008 DownloadAddonVersion (long? addonId, long? versionId)

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
    public class DownloadAddonVersionExample
    {
        public void main()
        {

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version

            try
            {
                // Generate a download token for a specific version of an addon
                InlineResponse2008 result = apiInstance.DownloadAddonVersion(addonId, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.DownloadAddonVersion: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getaddonversion"></a>
# **GetAddonVersion**
> InlineResponse2012 GetAddonVersion (long? addonId, long? versionId, List<string> with = null)

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
    public class GetAddonVersionExample
    {
        public void main()
        {

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Fetch a specific version of an addon
                InlineResponse2012 result = apiInstance.GetAddonVersion(addonId, versionId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.GetAddonVersion: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listaddonversions"></a>
# **ListAddonVersions**
> InlineResponse2007 ListAddonVersions (long? addonId, List<string> with = null)

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
    public class ListAddonVersionsExample
    {
        public void main()
        {

            var apiInstance = new AddonVersionsApi();
            var addonId = 789;  // long? | Id of the addon
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Fetch all the versions of an addon
                InlineResponse2007 result = apiInstance.ListAddonVersions(addonId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.ListAddonVersions: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateaddonversion"></a>
# **UpdateAddonVersion**
> InlineResponse2012 UpdateAddonVersion (string name, string changelog, string releaseType, long? addonId, long? versionId, List<string> with = null)

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
    public class UpdateAddonVersionExample
    {
        public void main()
        {

            var apiInstance = new AddonVersionsApi();
            var name = name_example;  // string | 
            var changelog = changelog_example;  // string | 
            var releaseType = releaseType_example;  // string | 
            var addonId = 789;  // long? | Id of the addon
            var versionId = 789;  // long? | Id of the version
            var with = new List<string>(); // List<string> | The relations you want to fetch with the AddonVersion schema (optional) 

            try
            {
                // Update a version of an addon
                InlineResponse2012 result = apiInstance.UpdateAddonVersion(name, changelog, releaseType, addonId, versionId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.UpdateAddonVersion: " + e.Message );
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
 **releaseType** | **string**|  | 
 **addonId** | **long?**| Id of the addon | 
 **versionId** | **long?**| Id of the version | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the AddonVersion schema | [optional] 

### Return type

[**InlineResponse2012**](InlineResponse2012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
