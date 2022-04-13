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
    ///  Class for testing ProductPurchasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductPurchasesApiTests : IDisposable
    {
        private ProductPurchasesApi instance;

        public ProductPurchasesApiTests()
        {
            instance = new ProductPurchasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductPurchasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductPurchasesApi
            //Assert.IsType<ProductPurchasesApi>(instance);
        }

        /// <summary>
        /// Test CreateProductPurchase
        /// </summary>
        [Fact]
        public void CreateProductPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //NewProductPurchasePayload newProductPurchasePayload = null;
            //var response = instance.CreateProductPurchase(product, newProductPurchasePayload);
            //Assert.IsType<CreateProductPurchaseResponse>(response);
        }

        /// <summary>
        /// Test GetProductPurchase
        /// </summary>
        [Fact]
        public void GetProductPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //string purchase = null;
            //ProductPurchaseFilter filter = null;
            //var response = instance.GetProductPurchase(product, purchase, filter);
            //Assert.IsType<GetProductPurchaseResponse>(response);
        }

        /// <summary>
        /// Test ListProductPurchases
        /// </summary>
        [Fact]
        public void ListProductPurchasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //int? perPage = null;
            //string cursor = null;
            //ProductPurchaseFilter filter = null;
            //var response = instance.ListProductPurchases(product, perPage, cursor, filter);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateProductPurchase
        /// </summary>
        [Fact]
        public void UpdateProductPurchaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string product = null;
            //string purchase = null;
            //UpdateProductPurchasePayload updateProductPurchasePayload = null;
            //var response = instance.UpdateProductPurchase(product, purchase, updateProductPurchasePayload);
            //Assert.IsType<UpdateProductPurchaseResponse>(response);
        }
    }
}
