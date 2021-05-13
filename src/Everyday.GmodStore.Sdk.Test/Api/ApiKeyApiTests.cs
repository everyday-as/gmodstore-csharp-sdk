/* 
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
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
using Everyday.GmodStore.Sdk.Model;

namespace Everyday.GmodStore.Sdk.Test
{
    /// <summary>
    ///  Class for testing ApiKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApiKeyApiTests : IDisposable
    {
        private ApiKeyApi instance;

        public ApiKeyApiTests()
        {
            instance = new ApiKeyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApiKeyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ApiKeyApi
            //Assert.IsType(typeof(ApiKeyApi), instance, "instance is a ApiKeyApi");
        }

        
        /// <summary>
        /// Test GetCurrentApiKey
        /// </summary>
        [Fact]
        public void GetCurrentApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> with = null;
            //var response = instance.GetCurrentApiKey(with);
            //Assert.IsType<AddonListResponse> (response, "response is AddonListResponse");
        }
        
    }

}