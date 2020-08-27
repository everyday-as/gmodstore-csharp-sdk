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
    ///  Class for testing AddonVersionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddonVersionsApiTests
    {
        private AddonVersionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddonVersionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddonVersionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AddonVersionsApi
            //Assert.IsInstanceOfType(typeof(AddonVersionsApi), instance, "instance is a AddonVersionsApi");
        }

        /// <summary>
        /// Test CreateAddonVersion
        /// </summary>
        [Test]
        public void CreateAddonVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string changelog = null;
            //byte[] _file = null;
            //string releaseType = null;
            //long? addonId = null;
            //List<string> with = null;
            //var response = instance.CreateAddonVersion(name, changelog, _file, releaseType, addonId, with);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
        /// <summary>
        /// Test DownloadAddonVersion
        /// </summary>
        [Test]
        public void DownloadAddonVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? addonId = null;
            //long? versionId = null;
            //var response = instance.DownloadAddonVersion(addonId, versionId);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        /// <summary>
        /// Test GetAddonVersion
        /// </summary>
        [Test]
        public void GetAddonVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? addonId = null;
            //long? versionId = null;
            //List<string> with = null;
            //var response = instance.GetAddonVersion(addonId, versionId, with);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
        /// <summary>
        /// Test ListAddonVersions
        /// </summary>
        [Test]
        public void ListAddonVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? addonId = null;
            //List<string> with = null;
            //var response = instance.ListAddonVersions(addonId, with);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        /// <summary>
        /// Test UpdateAddonVersion
        /// </summary>
        [Test]
        public void UpdateAddonVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string changelog = null;
            //string releaseType = null;
            //long? addonId = null;
            //long? versionId = null;
            //List<string> with = null;
            //var response = instance.UpdateAddonVersion(name, changelog, releaseType, addonId, versionId, with);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
    }

}
