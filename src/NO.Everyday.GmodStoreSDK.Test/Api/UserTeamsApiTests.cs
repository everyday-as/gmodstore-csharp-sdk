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
    ///  Class for testing UserTeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserTeamsApiTests
    {
        private UserTeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserTeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserTeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserTeamsApi
            //Assert.IsInstanceOfType(typeof(UserTeamsApi), instance, "instance is a UserTeamsApi");
        }

        /// <summary>
        /// Test UsersUserIdTeamsGet
        /// </summary>
        [Test]
        public void UsersUserIdTeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //List<string> with = null;
            //var response = instance.UsersUserIdTeamsGet(userId, with);
            //Assert.IsInstanceOf<InlineResponse20011> (response, "response is InlineResponse20011");
        }
    }

}
