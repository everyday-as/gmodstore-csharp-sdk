/*
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
 *
 * The version of the OpenAPI document: 1.2.0
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
    ///  Class for testing TeamUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamUsersApiTests : IDisposable
    {
        private TeamUsersApi instance;

        public TeamUsersApiTests()
        {
            instance = new TeamUsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TeamUsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TeamUsersApi
            //Assert.IsType<TeamUsersApi>(instance);
        }

        /// <summary>
        /// Test ListTeamUsers
        /// </summary>
        [Fact]
        public void ListTeamUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long teamId = null;
            //List<string> with = null;
            //var response = instance.ListTeamUsers(teamId, with);
            //Assert.IsType<TeamUserListResponse>(response);
        }
    }
}
