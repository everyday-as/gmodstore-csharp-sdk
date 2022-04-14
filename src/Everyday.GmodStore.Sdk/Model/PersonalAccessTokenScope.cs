/*
 * gmodstore
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.  # Rate limits Every request you make to the GmodStore API will count against your rate limit, which at the time of writing this, is 60 requests / minute. An up-to-date value will always provided in the `X-RateLimit-Limit` header The number of requests you have remaining before you must wait is provided in the `X-RateLimit-Remaining` header.  # API SDKs For a list of available API SDKs check the README here: https://github.com/everyday-as/gmodstore-api-docs#client-libraries
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Everyday.GmodStore.Sdk.Client.OpenAPIDateConverter;

namespace Everyday.GmodStore.Sdk.Model
{
    /// <summary>
    /// Defines PersonalAccessTokenScope
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonalAccessTokenScope
    {
        /// <summary>
        /// Enum PermissionGroupsread for value: permission-groups:read
        /// </summary>
        [EnumMember(Value = "permission-groups:read")]
        PermissionGroupsread = 1,

        /// <summary>
        /// Enum PermissionGroupswrite for value: permission-groups:write
        /// </summary>
        [EnumMember(Value = "permission-groups:write")]
        PermissionGroupswrite = 2,

        /// <summary>
        /// Enum Teamsread for value: teams:read
        /// </summary>
        [EnumMember(Value = "teams:read")]
        Teamsread = 3,

        /// <summary>
        /// Enum Teamswrite for value: teams:write
        /// </summary>
        [EnumMember(Value = "teams:write")]
        Teamswrite = 4,

        /// <summary>
        /// Enum TeamUsersread for value: team-users:read
        /// </summary>
        [EnumMember(Value = "team-users:read")]
        TeamUsersread = 5,

        /// <summary>
        /// Enum TeamUserswrite for value: team-users:write
        /// </summary>
        [EnumMember(Value = "team-users:write")]
        TeamUserswrite = 6,

        /// <summary>
        /// Enum Productsread for value: products:read
        /// </summary>
        [EnumMember(Value = "products:read")]
        Productsread = 7,

        /// <summary>
        /// Enum Productswrite for value: products:write
        /// </summary>
        [EnumMember(Value = "products:write")]
        Productswrite = 8,

        /// <summary>
        /// Enum ProductCouponsread for value: product-coupons:read
        /// </summary>
        [EnumMember(Value = "product-coupons:read")]
        ProductCouponsread = 9,

        /// <summary>
        /// Enum ProductCouponswrite for value: product-coupons:write
        /// </summary>
        [EnumMember(Value = "product-coupons:write")]
        ProductCouponswrite = 10,

        /// <summary>
        /// Enum ProductPurchasesread for value: product-purchases:read
        /// </summary>
        [EnumMember(Value = "product-purchases:read")]
        ProductPurchasesread = 11,

        /// <summary>
        /// Enum ProductPurchaseswrite for value: product-purchases:write
        /// </summary>
        [EnumMember(Value = "product-purchases:write")]
        ProductPurchaseswrite = 12,

        /// <summary>
        /// Enum ProductReviewsread for value: product-reviews:read
        /// </summary>
        [EnumMember(Value = "product-reviews:read")]
        ProductReviewsread = 13,

        /// <summary>
        /// Enum ProductReviewswrite for value: product-reviews:write
        /// </summary>
        [EnumMember(Value = "product-reviews:write")]
        ProductReviewswrite = 14,

        /// <summary>
        /// Enum ProductVersionsread for value: product-versions:read
        /// </summary>
        [EnumMember(Value = "product-versions:read")]
        ProductVersionsread = 15,

        /// <summary>
        /// Enum ProductVersionswrite for value: product-versions:write
        /// </summary>
        [EnumMember(Value = "product-versions:write")]
        ProductVersionswrite = 16,

        /// <summary>
        /// Enum ProductVersionsdownload for value: product-versions:download
        /// </summary>
        [EnumMember(Value = "product-versions:download")]
        ProductVersionsdownload = 17,

        /// <summary>
        /// Enum Usersread for value: users:read
        /// </summary>
        [EnumMember(Value = "users:read")]
        Usersread = 18,

        /// <summary>
        /// Enum Userswrite for value: users:write
        /// </summary>
        [EnumMember(Value = "users:write")]
        Userswrite = 19,

        /// <summary>
        /// Enum UserBadgesread for value: user-badges:read
        /// </summary>
        [EnumMember(Value = "user-badges:read")]
        UserBadgesread = 20,

        /// <summary>
        /// Enum UserBadgeswrite for value: user-badges:write
        /// </summary>
        [EnumMember(Value = "user-badges:write")]
        UserBadgeswrite = 21,

        /// <summary>
        /// Enum UserBansread for value: user-bans:read
        /// </summary>
        [EnumMember(Value = "user-bans:read")]
        UserBansread = 22,

        /// <summary>
        /// Enum UserPurchasesread for value: user-purchases:read
        /// </summary>
        [EnumMember(Value = "user-purchases:read")]
        UserPurchasesread = 23,

        /// <summary>
        /// Enum Star for value: *
        /// </summary>
        [EnumMember(Value = "*")]
        Star = 24

    }

}