# Everyday.GmodStore.Sdk.Api.ProductVersionsApi

All URIs are relative to *https://www.gmodstore.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductVersion**](ProductVersionsApi.md#createproductversion) | **POST** /api/v3/products/{product}/versions | Create a version for a product
[**GetProductDownloadToken**](ProductVersionsApi.md#getproductdownloadtoken) | **POST** /api/v3/products/{product}/versions/{version}/download | Get a one time use url for downloading a product
[**GetProductVersion**](ProductVersionsApi.md#getproductversion) | **GET** /api/v3/products/{product}/versions/{version} | Show the specified version for a product
[**ListProductVersions**](ProductVersionsApi.md#listproductversions) | **GET** /api/v3/products/{product}/versions | List all versions for a product
[**UpdateProductVersion**](ProductVersionsApi.md#updateproductversion) | **PUT** /api/v3/products/{product}/versions/{version} | Update the specified version for a product


<a name="createproductversion"></a>
# **CreateProductVersion**
> CreateProductVersionResponse CreateProductVersion (string product, string name, string changelog, System.IO.Stream file, string releaseType)

Create a version for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateProductVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductVersionsApi(config);
            var product = product_example;  // string | 
            var name = name_example;  // string | 
            var changelog = changelog_example;  // string | 
            var file = BINARY_DATA_HERE;  // System.IO.Stream | 
            var releaseType = releaseType_example;  // string | 

            try
            {
                // Create a version for a product
                CreateProductVersionResponse result = apiInstance.CreateProductVersion(product, name, changelog, file, releaseType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductVersionsApi.CreateProductVersion: " + e.Message );
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
 **product** | **string**|  | 
 **name** | **string**|  | 
 **changelog** | **string**|  | 
 **file** | **System.IO.Stream****System.IO.Stream**|  | 
 **releaseType** | **string**|  | 

### Return type

[**CreateProductVersionResponse**](CreateProductVersionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response containing the newly created product version |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductdownloadtoken"></a>
# **GetProductDownloadToken**
> DownloadProductVersionResponse GetProductDownloadToken (string product, string version)

Get a one time use url for downloading a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetProductDownloadTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductVersionsApi(config);
            var product = product_example;  // string | 
            var version = version_example;  // string | 

            try
            {
                // Get a one time use url for downloading a product
                DownloadProductVersionResponse result = apiInstance.GetProductDownloadToken(product, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductVersionsApi.GetProductDownloadToken: " + e.Message );
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
 **product** | **string**|  | 
 **version** | **string**|  | 

### Return type

[**DownloadProductVersionResponse**](DownloadProductVersionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing a download url |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductversion"></a>
# **GetProductVersion**
> GetProductVersionResponse GetProductVersion (string product, string version, ProductVersionFilter filter = null)

Show the specified version for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetProductVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductVersionsApi(config);
            var product = product_example;  // string | 
            var version = version_example;  // string | 
            var filter = new ProductVersionFilter(); // ProductVersionFilter | Filter the results (optional) 

            try
            {
                // Show the specified version for a product
                GetProductVersionResponse result = apiInstance.GetProductVersion(product, version, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductVersionsApi.GetProductVersion: " + e.Message );
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
 **product** | **string**|  | 
 **version** | **string**|  | 
 **filter** | [**ProductVersionFilter**](ProductVersionFilter.md)| Filter the results | [optional] 

### Return type

[**GetProductVersionResponse**](GetProductVersionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing a single product version |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listproductversions"></a>
# **ListProductVersions**
> Object ListProductVersions (string product, int? perPage = null, string cursor = null, ProductVersionFilter filter = null)

List all versions for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListProductVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductVersionsApi(config);
            var product = product_example;  // string | 
            var perPage = 56;  // int? |  (optional)  (default to 24)
            var cursor = cursor_example;  // string | The cursor from which to return paginated results starting after (optional) 
            var filter = new ProductVersionFilter(); // ProductVersionFilter | Filter the results (optional) 

            try
            {
                // List all versions for a product
                Object result = apiInstance.ListProductVersions(product, perPage, cursor, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductVersionsApi.ListProductVersions: " + e.Message );
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
 **product** | **string**|  | 
 **perPage** | **int?**|  | [optional] [default to 24]
 **cursor** | **string**| The cursor from which to return paginated results starting after | [optional] 
 **filter** | [**ProductVersionFilter**](ProductVersionFilter.md)| Filter the results | [optional] 

### Return type

**Object**

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing a list of product versions |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductversion"></a>
# **UpdateProductVersion**
> UpdateProductVersionResponse UpdateProductVersion (string product, string version, UpdateProductVersionPayload updateProductVersionPayload = null)

Update the specified version for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateProductVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductVersionsApi(config);
            var product = product_example;  // string | 
            var version = version_example;  // string | 
            var updateProductVersionPayload = new UpdateProductVersionPayload(); // UpdateProductVersionPayload |  (optional) 

            try
            {
                // Update the specified version for a product
                UpdateProductVersionResponse result = apiInstance.UpdateProductVersion(product, version, updateProductVersionPayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductVersionsApi.UpdateProductVersion: " + e.Message );
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
 **product** | **string**|  | 
 **version** | **string**|  | 
 **updateProductVersionPayload** | [**UpdateProductVersionPayload**](UpdateProductVersionPayload.md)|  | [optional] 

### Return type

[**UpdateProductVersionResponse**](UpdateProductVersionResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing the product version with changes applied |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

