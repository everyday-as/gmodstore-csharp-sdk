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
    ///  Class for testing Product
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProductTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Product
        //private Product instance;

        public ProductTests()
        {
            // TODO uncomment below to create an instance of Product
            //instance = new Product();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Product
        /// </summary>
        [Fact]
        public void ProductInstanceTest()
        {
            // TODO uncomment below to test "IsType" Product
            //Assert.IsType<Product>(instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'TeamId'
        /// </summary>
        [Fact]
        public void TeamIdTest()
        {
            // TODO unit test for the property 'TeamId'
        }
        /// <summary>
        /// Test the property 'Slug'
        /// </summary>
        [Fact]
        public void SlugTest()
        {
            // TODO unit test for the property 'Slug'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ShortDescription'
        /// </summary>
        [Fact]
        public void ShortDescriptionTest()
        {
            // TODO unit test for the property 'ShortDescription'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Fact]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Images'
        /// </summary>
        [Fact]
        public void ImagesTest()
        {
            // TODO unit test for the property 'Images'
        }
        /// <summary>
        /// Test the property 'Views'
        /// </summary>
        [Fact]
        public void ViewsTest()
        {
            // TODO unit test for the property 'Views'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }

    }

}