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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamsApiTests
    {
        private TeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamsApi
            //Assert.IsInstanceOfType(typeof(TeamsApi), instance, "instance is a TeamsApi");
        }

        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Test]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? teamId = null;
            //List<string> with = null;
            //var response = instance.GetTeam(teamId, with);
            //Assert.IsInstanceOf<TeamResponse> (response, "response is TeamResponse");
        }
    }

}
