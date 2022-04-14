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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductsApiTests : IDisposable
    {
        private ProductsApi instance;

        public ProductsApiTests()
        {
            instance = new ProductsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductsApi
            //Assert.IsType<ProductsApi>(instance);
        }

        /// <summary>
        /// Test GetProduct
        /// </summary>
        [Fact]
        public void GetProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //ProductFilter filter = null;
            //var response = instance.GetProduct(product, filter);
            //Assert.IsType<GetProductResponse>(response);
        }

        /// <summary>
        /// Test GetProducts
        /// </summary>
        [Fact]
        public void GetProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> ids = null;
            //ProductFilter filter = null;
            //var response = instance.GetProducts(ids, filter);
            //Assert.IsType<GetProductsResponse>(response);
        }

        /// <summary>
        /// Test ListProducts
        /// </summary>
        [Fact]
        public void ListProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string team = null;
            //int? perPage = null;
            //string cursor = null;
            //ProductFilter filter = null;
            //var response = instance.ListProducts(team, perPage, cursor, filter);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateProduct
        /// </summary>
        [Fact]
        public void UpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //instance.UpdateProduct(product);
        }
    }
}