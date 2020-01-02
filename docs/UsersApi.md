# NO.Everyday.GmodStoreSDK.Api.UsersApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersMeGet**](UsersApi.md#usersmeget) | **GET** /users/me | Fetches the current user (API Key Owner)
[**UsersUserIdGet**](UsersApi.md#usersuseridget) | **GET** /users/{user_id} | Fetch a single user

<a name="usersmeget"></a>
# **UsersMeGet**
> InlineResponse20011 UsersMeGet (List<string> with = null)

Fetches the current user (API Key Owner)

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersMeGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var with = new List<string>(); // List<string> | The relations you want to fetch with the User schema (optional) 

            try
            {
                // Fetches the current user (API Key Owner)
                InlineResponse20011 result = apiInstance.UsersMeGet(with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the User schema | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="usersuseridget"></a>
# **UsersUserIdGet**
> InlineResponse20011 UsersUserIdGet (string userId, List<string> with = null)

Fetch a single user

### Example
```csharp
using System;
using System.Diagnostics;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace Example
{
    public class UsersUserIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the User schema (optional) 

            try
            {
                // Fetch a single user
                InlineResponse20011 result = apiInstance.UsersUserIdGet(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the User schema | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
