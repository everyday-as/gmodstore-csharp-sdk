# Everyday.GmodStore.Sdk.Api.UserProductPurchasesApi

All URIs are relative to *https://www.gmodstore.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListUserPurchases**](UserProductPurchasesApi.md#listuserpurchases) | **GET** /api/v3/users/{user}/purchases | List all the specified user&#39;s purchases


<a name="listuserpurchases"></a>
# **ListUserPurchases**
> Object ListUserPurchases (string user, string cursor = null, ProductPurchaseFilter filter = null)

List all the specified user's purchases

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class ListUserPurchasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.gmodstore.com";
            // Configure Bearer token for authorization: PersonalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserProductPurchasesApi(config);
            var user = user_example;  // string | 
            var cursor = cursor_example;  // string | The cursor from which to return paginated results starting after (optional) 
            var filter = new ProductPurchaseFilter(); // ProductPurchaseFilter | Filter the results (optional) 

            try
            {
                // List all the specified user's purchases
                Object result = apiInstance.ListUserPurchases(user, cursor, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserProductPurchasesApi.ListUserPurchases: " + e.Message );
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
 **user** | **string**|  | 
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
| **404** | The requested resource does not exist |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

