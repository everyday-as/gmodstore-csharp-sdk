# Everyday.GmodStore.Sdk - the C# library for the GmodStore API

Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.2.0
- SDK version: 3.1.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://docs.gmodstore.com](https://docs.gmodstore.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.gmodstore.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddonCouponsApi(config);
            var addonId = 789;  // long | Id of the addon
            var addonCoupon = new AddonCoupon(); // AddonCoupon | 
            var with = new List<string>(); // List<string> | The relations you want to fetch with the `AddonCoupon` (optional) 

            try
            {
                // Create an addon coupon
                AddonCouponResponse result = apiInstance.CreateAddonCoupon(addonId, addonCoupon, with);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddonCouponsApi.CreateAddonCoupon: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.gmodstore.com/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddonCouponsApi* | [**CreateAddonCoupon**](docs/AddonCouponsApi.md#createaddoncoupon) | **POST** /addons/{addon_id}/coupons | Create an addon coupon
*AddonCouponsApi* | [**DeleteAddonCoupon**](docs/AddonCouponsApi.md#deleteaddoncoupon) | **DELETE** /addons/{addon_id}/coupons/{coupon_id} | Destroy an addon's coupon
*AddonCouponsApi* | [**GetAddonCoupon**](docs/AddonCouponsApi.md#getaddoncoupon) | **GET** /addons/{addon_id}/coupons/{coupon_id} | Fetch an addon's coupon
*AddonCouponsApi* | [**ListAddonCoupons**](docs/AddonCouponsApi.md#listaddoncoupons) | **GET** /addons/{addon_id}/coupons | Fetch all the coupons for an addon
*AddonCouponsApi* | [**UpdateAddonCoupon**](docs/AddonCouponsApi.md#updateaddoncoupon) | **PUT** /addons/{addon_id}/coupons/{coupon_id} | Update an addon's coupon
*AddonPurchasesApi* | [**CreateAddonPurchase**](docs/AddonPurchasesApi.md#createaddonpurchase) | **POST** /addons/{addon_id}/purchases | Create a purchase for an addon
*AddonPurchasesApi* | [**GetAddonPurchase**](docs/AddonPurchasesApi.md#getaddonpurchase) | **GET** /addons/{addon_id}/purchases/{user_id} | Get a purchase of an addon by user
*AddonPurchasesApi* | [**ListAddonPurchases**](docs/AddonPurchasesApi.md#listaddonpurchases) | **GET** /addons/{addon_id}/purchases | Fetch all purchases of an addon
*AddonPurchasesApi* | [**UpdateAddonPurchase**](docs/AddonPurchasesApi.md#updateaddonpurchase) | **PUT** /addons/{addon_id}/purchases/{user_id} | Update a purchase for an addon
*AddonReviewsApi* | [**GetAddonReview**](docs/AddonReviewsApi.md#getaddonreview) | **GET** /addons/{addon_id}/reviews/{review_id} | Fetch a review of an addon
*AddonReviewsApi* | [**ListAddonReviews**](docs/AddonReviewsApi.md#listaddonreviews) | **GET** /addons/{addon_id}/reviews | Fetch all the reviews of an addon
*AddonStatsApi* | [**GetAddonStats**](docs/AddonStatsApi.md#getaddonstats) | **GET** /addons/{addon_id}/stats | Fetch all the stats for an addon
*AddonVersionsApi* | [**CreateAddonVersion**](docs/AddonVersionsApi.md#createaddonversion) | **POST** /addons/{addon_id}/versions | Create a new version for an addon
*AddonVersionsApi* | [**DownloadAddonVersion**](docs/AddonVersionsApi.md#downloadaddonversion) | **GET** /addons/{addon_id}/versions/{version_id}/download | Generate a download token for a specific version of an addon
*AddonVersionsApi* | [**GetAddonVersion**](docs/AddonVersionsApi.md#getaddonversion) | **GET** /addons/{addon_id}/versions/{version_id} | Fetch a specific version of an addon
*AddonVersionsApi* | [**ListAddonVersions**](docs/AddonVersionsApi.md#listaddonversions) | **GET** /addons/{addon_id}/versions | Fetch all the versions of an addon
*AddonVersionsApi* | [**UpdateAddonVersion**](docs/AddonVersionsApi.md#updateaddonversion) | **PUT** /addons/{addon_id}/versions/{version_id} | Update a version of an addon
*AddonsApi* | [**GetAddon**](docs/AddonsApi.md#getaddon) | **GET** /addons/{addon_id} | Fetch a single addon
*AddonsApi* | [**ListSelfAddons**](docs/AddonsApi.md#listselfaddons) | **GET** /addons | Fetch all the addons that you have access to
*AdventCalendarApi* | [**GetAdventCalendarStats**](docs/AdventCalendarApi.md#getadventcalendarstats) | **GET** /events/advent-calendar/stats | Fetch statistics relating to the advent calendar event
*CurrentAPIKeyApi* | [**GetCurrentApiKey**](docs/CurrentAPIKeyApi.md#getcurrentapikey) | **GET** /me | Get meta information about the current API key
*PermissionGroupsApi* | [**ListPermissionGroups**](docs/PermissionGroupsApi.md#listpermissiongroups) | **GET** /permission-groups | Fetches all available permission groups
*TeamAddonsApi* | [**ListTeamAddons**](docs/TeamAddonsApi.md#listteamaddons) | **GET** /teams/{team_id}/addons | Fetch all the addons in the given team
*TeamUsersApi* | [**ListTeamUsers**](docs/TeamUsersApi.md#listteamusers) | **GET** /teams/{team_id}/users | Fetch all the users in the given team
*TeamsApi* | [**GetTeam**](docs/TeamsApi.md#getteam) | **GET** /teams/{team_id} | Fetch a single team
*UserAddonsApi* | [**ListUserAddons**](docs/UserAddonsApi.md#listuseraddons) | **GET** /users/{user_id}/addons | Fetch all the addons authored / co-authored by a user
*UserBadgesApi* | [**CreateUserBadge**](docs/UserBadgesApi.md#createuserbadge) | **POST** /users/{user_id}/badges | Give a user a badge
*UserBadgesApi* | [**DeleteUserBadge**](docs/UserBadgesApi.md#deleteuserbadge) | **DELETE** /users/{user_id}/badges/{badge_id} | Destroy a users's badge
*UserBadgesApi* | [**ListUserBadges**](docs/UserBadgesApi.md#listuserbadges) | **GET** /users/{user_id}/badges | Fetch all the badges a user has
*UserBansApi* | [**ListUserBans**](docs/UserBansApi.md#listuserbans) | **GET** /users/{user_id}/bans | Fetch all active bans associated with this user
*UserPurchasesApi* | [**ListUserPurchases**](docs/UserPurchasesApi.md#listuserpurchases) | **GET** /users/{user_id}/purchases | Fetch all purchases a user has made
*UserTeamsApi* | [**ListUserTeams**](docs/UserTeamsApi.md#listuserteams) | **GET** /users/{user_id}/teams | Fetch all the teams of a user
*UsersApi* | [**GetSelfUser**](docs/UsersApi.md#getselfuser) | **GET** /users/me | Fetches the current user (API Key Owner)
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{user_id} | Fetch a single user


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Addon](docs/Addon.md)
 - [Model.AddonCoupon](docs/AddonCoupon.md)
 - [Model.AddonCouponListResponse](docs/AddonCouponListResponse.md)
 - [Model.AddonCouponResponse](docs/AddonCouponResponse.md)
 - [Model.AddonDownload](docs/AddonDownload.md)
 - [Model.AddonDownloadResponse](docs/AddonDownloadResponse.md)
 - [Model.AddonImages](docs/AddonImages.md)
 - [Model.AddonListResponse](docs/AddonListResponse.md)
 - [Model.AddonPrice](docs/AddonPrice.md)
 - [Model.AddonPurchase](docs/AddonPurchase.md)
 - [Model.AddonPurchaseListResponse](docs/AddonPurchaseListResponse.md)
 - [Model.AddonPurchaseResponse](docs/AddonPurchaseResponse.md)
 - [Model.AddonResponse](docs/AddonResponse.md)
 - [Model.AddonReview](docs/AddonReview.md)
 - [Model.AddonReviewListResponse](docs/AddonReviewListResponse.md)
 - [Model.AddonReviewResponse](docs/AddonReviewResponse.md)
 - [Model.AddonStats](docs/AddonStats.md)
 - [Model.AddonStatsResponse](docs/AddonStatsResponse.md)
 - [Model.AddonStatsRevenue](docs/AddonStatsRevenue.md)
 - [Model.AddonStatsRevenueCurrent](docs/AddonStatsRevenueCurrent.md)
 - [Model.AddonStatsSales](docs/AddonStatsSales.md)
 - [Model.AddonStatsSalesCurrent](docs/AddonStatsSalesCurrent.md)
 - [Model.AddonStatsViews](docs/AddonStatsViews.md)
 - [Model.AddonStatsViewsCurrent](docs/AddonStatsViewsCurrent.md)
 - [Model.AddonVersion](docs/AddonVersion.md)
 - [Model.AddonVersionListResponse](docs/AddonVersionListResponse.md)
 - [Model.AddonVersionReleaseType](docs/AddonVersionReleaseType.md)
 - [Model.AddonVersionResponse](docs/AddonVersionResponse.md)
 - [Model.AdventCalendarStats](docs/AdventCalendarStats.md)
 - [Model.AdventCalendarStatsResponse](docs/AdventCalendarStatsResponse.md)
 - [Model.ApiKey](docs/ApiKey.md)
 - [Model.ApiKeyResponse](docs/ApiKeyResponse.md)
 - [Model.BadgeListResponse](docs/BadgeListResponse.md)
 - [Model.BadgeResponse](docs/BadgeResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Money](docs/Money.md)
 - [Model.NewAddonPurchase](docs/NewAddonPurchase.md)
 - [Model.OrderItem](docs/OrderItem.md)
 - [Model.PermissionGroup](docs/PermissionGroup.md)
 - [Model.PermissionGroupListResponse](docs/PermissionGroupListResponse.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamAddon](docs/TeamAddon.md)
 - [Model.TeamAddonListResponse](docs/TeamAddonListResponse.md)
 - [Model.TeamListResponse](docs/TeamListResponse.md)
 - [Model.TeamResponse](docs/TeamResponse.md)
 - [Model.TeamUser](docs/TeamUser.md)
 - [Model.TeamUserListResponse](docs/TeamUserListResponse.md)
 - [Model.User](docs/User.md)
 - [Model.UserBadge](docs/UserBadge.md)
 - [Model.UserBadgeLegend](docs/UserBadgeLegend.md)
 - [Model.UserBan](docs/UserBan.md)
 - [Model.UserBanListResponse](docs/UserBanListResponse.md)
 - [Model.UserResponse](docs/UserResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: Bearer Authentication

