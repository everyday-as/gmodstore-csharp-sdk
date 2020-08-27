# Everyday.GmodStore.Sdk.Api.UsersApi

All URIs are relative to *https://api.gmodstore.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSelfUser**](UsersApi.md#getselfuser) | **GET** /users/me | Fetches the current user (API Key Owner)
[**GetUser**](UsersApi.md#getuser) | **GET** /users/{user_id} | Fetch a single user

<a name="getselfuser"></a>
# **GetSelfUser**
> UserResponse GetSelfUser (List<string> with = null)

Fetches the current user (API Key Owner)

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetSelfUserExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `User` (optional) 

            try
            {
                // Fetches the current user (API Key Owner)
                UserResponse result = apiInstance.GetSelfUser(with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSelfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;User&#x60; | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getuser"></a>
# **GetUser**
> UserResponse GetUser (long? userId, List<string> with = null)

Fetch a single user

### Example
```csharp
using System;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {

            var apiInstance = new UsersApi();
            var userId = 789;  // long? | Id of the user
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `User` (optional) 

            try
            {
                // Fetch a single user
                UserResponse result = apiInstance.GetUser(userId, with);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **long?**| Id of the user | 
 **with** | [**List&lt;string&gt;**](string.md)| The relations you want to fetch with the &#x60;User&#x60; | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
