/*
 * gmodstore
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.  # Rate limits Every request you make to the GmodStore API will count against your rate limit, which at the time of writing this, is 60 requests / minute. An up-to-date value will always provided in the `X-RateLimit-Limit` header The number of requests you have remaining before you must wait is provided in the `X-RateLimit-Remaining` header.  # API SDKs For a list of available API SDKs check the README here: https://github.com/everyday-as/gmodstore-api-docs#client-libraries
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Everyday.GmodStore.Sdk.Api;
using Everyday.GmodStore.Sdk.Model;
using Everyday.GmodStore.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Everyday.GmodStore.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing GetPersonalAccessTokenResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetPersonalAccessTokenResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetPersonalAccessTokenResponse
        //private GetPersonalAccessTokenResponse instance;

        public GetPersonalAccessTokenResponseTests()
        {
            // TODO uncomment below to create an instance of GetPersonalAccessTokenResponse
            //instance = new GetPersonalAccessTokenResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetPersonalAccessTokenResponse
        /// </summary>
        [Fact]
        public void GetPersonalAccessTokenResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetPersonalAccessTokenResponse
            //Assert.IsType<GetPersonalAccessTokenResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
