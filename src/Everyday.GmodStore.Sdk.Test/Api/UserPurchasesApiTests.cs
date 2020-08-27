/* 
 * GmodStore
 *
 * Welcome to the Gmodstore API! You can use our API to access Gmodstore API endpoints, which can be used interact with Gmodstore programmatically.
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Model;

namespace Everyday.GmodStore.Sdk.Test
{
    /// <summary>
    ///  Class for testing UserPurchasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserPurchasesApiTests
    {
        private UserPurchasesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserPurchasesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserPurchasesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserPurchasesApi
            //Assert.IsInstanceOfType(typeof(UserPurchasesApi), instance, "instance is a UserPurchasesApi");
        }

        /// <summary>
        /// Test ListUserPurchases
        /// </summary>
        [Test]
        public void ListUserPurchasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //List<string> with = null;
            //var response = instance.ListUserPurchases(userId, with);
            //Assert.IsInstanceOf<AddonPurchaseListResponse> (response, "response is AddonPurchaseListResponse");
        }
    }

}
