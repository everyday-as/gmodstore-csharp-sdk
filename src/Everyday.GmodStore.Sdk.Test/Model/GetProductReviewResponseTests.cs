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
    ///  Class for testing GetProductReviewResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetProductReviewResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetProductReviewResponse
        //private GetProductReviewResponse instance;

        public GetProductReviewResponseTests()
        {
            // TODO uncomment below to create an instance of GetProductReviewResponse
            //instance = new GetProductReviewResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetProductReviewResponse
        /// </summary>
        [Fact]
        public void GetProductReviewResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetProductReviewResponse
            //Assert.IsType<GetProductReviewResponse>(instance);
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
