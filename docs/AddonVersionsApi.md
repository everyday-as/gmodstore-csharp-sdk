# Everyday.GmodStore.Sdk.Api.AddonVersionsApi

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
> AddonVersionResponse CreateAddonVersion (long addonId, NewAddonVersion newAddonVersion, List<string> with = null)

Create a new version for an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateAddonVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonVersionsApi(config);
            var addonId = 789;  // long | Id of the addon
            var newAddonVersion = new NewAddonVersion(); // NewAddonVersion | 
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonVersion` (optional) 

            try
            {
                // Create a new version for an addon
                AddonVersionResponse result = apiInstance.CreateAddonVersion(addonId, newAddonVersion, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.CreateAddonVersion: " + e.Message );
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
 **newAddonVersion** | [**NewAddonVersion**](NewAddonVersion.md)|  | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonVersion&#x60; | [optional] 

### Return type

[**AddonVersionResponse**](AddonVersionResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadaddonversion"></a>
# **DownloadAddonVersion**
> AddonDownloadResponse DownloadAddonVersion (long addonId, long versionId)

Generate a download token for a specific version of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class DownloadAddonVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonVersionsApi(config);
            var addonId = 789;  // long | Id of the addon
            var versionId = 789;  // long | Id of the version

            try
            {
                // Generate a download token for a specific version of an addon
                AddonDownloadResponse result = apiInstance.DownloadAddonVersion(addonId, versionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.DownloadAddonVersion: " + e.Message );
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
 **versionId** | **long**| Id of the version | 

### Return type

[**AddonDownloadResponse**](AddonDownloadResponse.md)

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

<a name="getaddonversion"></a>
# **GetAddonVersion**
> AddonVersionResponse GetAddonVersion (long addonId, long versionId, List<string> with = null)

Fetch a specific version of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetAddonVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonVersionsApi(config);
            var addonId = 789;  // long | Id of the addon
            var versionId = 789;  // long | Id of the version
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonVersion` (optional) 

            try
            {
                // Fetch a specific version of an addon
                AddonVersionResponse result = apiInstance.GetAddonVersion(addonId, versionId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.GetAddonVersion: " + e.Message );
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
 **versionId** | **long**| Id of the version | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonVersion&#x60; | [optional] 

### Return type

[**AddonVersionResponse**](AddonVersionResponse.md)

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

<a name="listaddonversions"></a>
# **ListAddonVersions**
> AddonVersionListResponse ListAddonVersions (long addonId, List<string> with = null)

Fetch all the versions of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListAddonVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonVersionsApi(config);
            var addonId = 789;  // long | Id of the addon
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonVersion` (optional) 

            try
            {
                // Fetch all the versions of an addon
                AddonVersionListResponse result = apiInstance.ListAddonVersions(addonId, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.ListAddonVersions: " + e.Message );
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
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonVersion&#x60; | [optional] 

### Return type

[**AddonVersionListResponse**](AddonVersionListResponse.md)

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

<a name="updateaddonversion"></a>
# **UpdateAddonVersion**
> AddonVersionResponse UpdateAddonVersion (long addonId, long versionId, AddonVersion addonVersion, List<string> with = null)

Update a version of an addon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateAddonVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonVersionsApi(config);
            var addonId = 789;  // long | Id of the addon
            var versionId = 789;  // long | Id of the version
            var addonVersion = new AddonVersion(); // AddonVersion | 
            var with = with_example;  // List<string> | The relations you want to fetch with the `AddonVersion` (optional) 

            try
            {
                // Update a version of an addon
                AddonVersionResponse result = apiInstance.UpdateAddonVersion(addonId, versionId, addonVersion, with);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddonVersionsApi.UpdateAddonVersion: " + e.Message );
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
 **versionId** | **long**| Id of the version | 
 **addonVersion** | [**AddonVersion**](AddonVersion.md)|  | 
 **with** | **List&lt;string&gt;**| The relations you want to fetch with the &#x60;AddonVersion&#x60; | [optional] 

### Return type

[**AddonVersionResponse**](AddonVersionResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the request. |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |
| **429** | Too many requests |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset - The UNIX timestamp at which your rate limit quota will reset. <br>  |
| **0** | Something went wrong |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

