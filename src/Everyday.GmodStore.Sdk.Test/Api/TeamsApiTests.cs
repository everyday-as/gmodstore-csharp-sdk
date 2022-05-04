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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamsApiTests : IDisposable
    {
        private TeamsApi instance;

        public TeamsApiTests()
        {
            instance = new TeamsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TeamsApi
            //Assert.IsType<TeamsApi>(instance);
        }

        /// <summary>
        /// Test CreateTeam
        /// </summary>
        [Fact]
        public void CreateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewTeamPayload newTeamPayload = null;
            //var response = instance.CreateTeam(newTeamPayload);
            //Assert.IsType<CreateTeamResponse>(response);
        }

        /// <summary>
        /// Test DeleteTeam
        /// </summary>
        [Fact]
        public void DeleteTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string team = null;
            //var response = instance.DeleteTeam(team);
            //Assert.IsType<DeleteTeamResponse>(response);
        }

        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Fact]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string team = null;
            //var response = instance.GetTeam(team);
            //Assert.IsType<GetTeamResponse>(response);
        }

        /// <summary>
        /// Test GetTeams
        /// </summary>
        [Fact]
        public void GetTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> ids = null;
            //var response = instance.GetTeams(ids);
            //Assert.IsType<GetTeamsResponse>(response);
        }

        /// <summary>
        /// Test ListTeams
        /// </summary>
        [Fact]
        public void ListTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? perPage = null;
            //string cursor = null;
            //var response = instance.ListTeams(perPage, cursor);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateTeam
        /// </summary>
        [Fact]
        public void UpdateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string team = null;
            //UpdateTeamPayload updateTeamPayload = null;
            //var response = instance.UpdateTeam(team, updateTeamPayload);
            //Assert.IsType<UpdateTeamResponse>(response);
        }
    }
}
