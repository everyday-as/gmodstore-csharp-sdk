/*
 * gmodstore
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.  # Rate limits Every request you make to the GmodStore API will count against your rate limit, which at the time of writing this, is 60 requests / minute. An up-to-date value will always provided in the `X-RateLimit-Limit` header The number of requests you have remaining before you must wait is provided in the `X-RateLimit-Remaining` header.  # API SDKs For a list of available API SDKs check the README here: https://github.com/everyday-as/gmodstore-api-docs#client-libraries
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Api;
// uncomment below to import models
//using Everyday.GmodStore.Sdk.Model;

namespace Everyday.GmodStore.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing UserBansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserBansApiTests : IDisposable
    {
        private UserBansApi instance;

        public UserBansApiTests()
        {
            instance = new UserBansApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserBansApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserBansApi
            //Assert.IsType<UserBansApi>(instance);
        }

        /// <summary>
        /// Test ListUserBans
        /// </summary>
        [Fact]
        public void ListUserBansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string user = null;
            //int? perPage = null;
            //string cursor = null;
            //UserBanFilter filter = null;
            //var response = instance.ListUserBans(user, perPage, cursor, filter);
            //Assert.IsType<Object>(response);
        }
    }
}
