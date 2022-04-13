# Everyday.GmodStore.Sdk.Api.ProductPurchasesApi

All URIs are relative to *https://www.gmodstore.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductPurchase**](ProductPurchasesApi.md#createproductpurchase) | **POST** /api/v3/products/{product}/purchases | Create a purchase for a product
[**GetProductPurchase**](ProductPurchasesApi.md#getproductpurchase) | **GET** /api/v3/products/{product}/purchases/{purchase} | Show the specified purchase for a product
[**ListProductPurchases**](ProductPurchasesApi.md#listproductpurchases) | **GET** /api/v3/products/{product}/purchases | List all purchases for a product
[**UpdateProductPurchase**](ProductPurchasesApi.md#updateproductpurchase) | **PUT** /api/v3/products/{product}/purchases/{purchase} | Update the specified purchase for a product


<a name="createproductpurchase"></a>
# **CreateProductPurchase**
> CreateProductPurchaseResponse CreateProductPurchase (string product, NewProductPurchasePayload newProductPurchasePayload = null)

Create a purchase for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class CreateProductPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductPurchasesApi(config);
            var product = product_example;  // string | 
            var newProductPurchasePayload = new NewProductPurchasePayload(); // NewProductPurchasePayload |  (optional) 

            try
            {
                // Create a purchase for a product
                CreateProductPurchaseResponse result = apiInstance.CreateProductPurchase(product, newProductPurchasePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductPurchasesApi.CreateProductPurchase: " + e.Message );
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
 **newProductPurchasePayload** | [**NewProductPurchasePayload**](NewProductPurchasePayload.md)|  | [optional] 

### Return type

[**CreateProductPurchaseResponse**](CreateProductPurchaseResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response containing the newly created product purchase |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductpurchase"></a>
# **GetProductPurchase**
> GetProductPurchaseResponse GetProductPurchase (string product, string purchase, ProductPurchaseFilter filter = null)

Show the specified purchase for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetProductPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductPurchasesApi(config);
            var product = product_example;  // string | 
            var purchase = purchase_example;  // string | 
            var filter = new ProductPurchaseFilter(); // ProductPurchaseFilter | Filter the results (optional) 

            try
            {
                // Show the specified purchase for a product
                GetProductPurchaseResponse result = apiInstance.GetProductPurchase(product, purchase, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductPurchasesApi.GetProductPurchase: " + e.Message );
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
 **purchase** | **string**|  | 
 **filter** | [**ProductPurchaseFilter**](ProductPurchaseFilter.md)| Filter the results | [optional] 

### Return type

[**GetProductPurchaseResponse**](GetProductPurchaseResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing a single product purchase |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listproductpurchases"></a>
# **ListProductPurchases**
> Object ListProductPurchases (string product, int? perPage = null, string cursor = null, ProductPurchaseFilter filter = null)

List all purchases for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListProductPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductPurchasesApi(config);
            var product = product_example;  // string | 
            var perPage = 56;  // int? |  (optional)  (default to 24)
            var cursor = cursor_example;  // string | The cursor from which to return paginated results starting after (optional) 
            var filter = new ProductPurchaseFilter(); // ProductPurchaseFilter | Filter the results (optional) 

            try
            {
                // List all purchases for a product
                Object result = apiInstance.ListProductPurchases(product, perPage, cursor, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductPurchasesApi.ListProductPurchases: " + e.Message );
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
 **filter** | [**ProductPurchaseFilter**](ProductPurchaseFilter.md)| Filter the results | [optional] 

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
| **200** | Successful response containing a list of product purchases |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductpurchase"></a>
# **UpdateProductPurchase**
> UpdateProductPurchaseResponse UpdateProductPurchase (string product, string purchase, UpdateProductPurchasePayload updateProductPurchasePayload = null)

Update the specified purchase for a product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class UpdateProductPurchaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductPurchasesApi(config);
            var product = product_example;  // string | 
            var purchase = purchase_example;  // string | 
            var updateProductPurchasePayload = new UpdateProductPurchasePayload(); // UpdateProductPurchasePayload |  (optional) 

            try
            {
                // Update the specified purchase for a product
                UpdateProductPurchaseResponse result = apiInstance.UpdateProductPurchase(product, purchase, updateProductPurchasePayload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductPurchasesApi.UpdateProductPurchase: " + e.Message );
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
 **purchase** | **string**|  | 
 **updateProductPurchasePayload** | [**UpdateProductPurchasePayload**](UpdateProductPurchasePayload.md)|  | [optional] 

### Return type

[**UpdateProductPurchaseResponse**](UpdateProductPurchaseResponse.md)

### Authorization

[PersonalAccessToken](../README.md#PersonalAccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response containing the product purchase with changes applied |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Improperly formatted request passed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | The passed bearer token is missing or invalid |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The passed bearer token does not have the right scopes |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

