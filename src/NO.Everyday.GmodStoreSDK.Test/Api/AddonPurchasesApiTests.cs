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

using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Api;
using NO.Everyday.GmodStoreSDK.Model;

namespace NO.Everyday.GmodStoreSDK.Test
{
    /// <summary>
    ///  Class for testing AddonPurchasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddonPurchasesApiTests
    {
        private AddonPurchasesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddonPurchasesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddonPurchasesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AddonPurchasesApi
            //Assert.IsInstanceOfType(typeof(AddonPurchasesApi), instance, "instance is a AddonPurchasesApi");
        }

        /// <summary>
        /// Test CreateAddonPurchase
        /// </summary>
        [Test]
        public void CreateAddonPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddonPurchaseCreateBody body = null;
            //long? addonId = null;
            //List<string> with = null;
            //var response = instance.CreateAddonPurchase(body, addonId, with);
            //Assert.IsInstanceOf<InlineResponse2011> (response, "response is InlineResponse2011");
        }
        /// <summary>
        /// Test GetAddonPurchase
        /// </summary>
        [Test]
        public void GetAddonPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? addonId = null;
            //string userId = null;
            //List<string> with = null;
            //var response = instance.GetAddonPurchase(addonId, userId, with);
            //Assert.IsInstanceOf<InlineResponse2011> (response, "response is InlineResponse2011");
        }
        /// <summary>
        /// Test ListAddonPurchases
        /// </summary>
        [Test]
        public void ListAddonPurchasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? addonId = null;
            //List<string> with = null;
            //var response = instance.ListAddonPurchases(addonId, with);
            //Assert.IsInstanceOf<InlineResponse2004> (response, "response is InlineResponse2004");
        }
        /// <summary>
        /// Test UpdateAddonPurchase
        /// </summary>
        [Test]
        public void UpdateAddonPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddonPurchaseUpdateBody body = null;
            //long? addonId = null;
            //string userId = null;
            //List<string> with = null;
            //var response = instance.UpdateAddonPurchase(body, addonId, userId, with);
            //Assert.IsInstanceOf<InlineResponse2011> (response, "response is InlineResponse2011");
        }
    }

}
