/*
 * gmodstore
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.  # Rate limits Every request you make to the GmodStore API will count against your rate limit, which at the time of writing this, is 60 requests / minute. An up-to-date value will always provided in the `X-RateLimit-Limit` header The number of requests you have remaining before you must wait is provided in the `X-RateLimit-Remaining` header.  # API SDKs For a list of available API SDKs check the README here: https://github.com/everyday-as/gmodstore-api-docs#client-libraries
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Everyday.GmodStore.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserProductsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List all the specified user&#39;s products
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <returns>Object</returns>
        Object ListUserProducts(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter));

        /// <summary>
        /// List all the specified user&#39;s products
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ListUserProductsWithHttpInfo(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserProductsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List all the specified user&#39;s products
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ListUserProductsAsync(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all the specified user&#39;s products
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ListUserProductsWithHttpInfoAsync(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserProductsApi : IUserProductsApiSync, IUserProductsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserProductsApi : IUserProductsApi
    {
        private Everyday.GmodStore.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserProductsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserProductsApi(string basePath)
        {
            this.Configuration = Everyday.GmodStore.Sdk.Client.Configuration.MergeConfigurations(
                Everyday.GmodStore.Sdk.Client.GlobalConfiguration.Instance,
                new Everyday.GmodStore.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Everyday.GmodStore.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Everyday.GmodStore.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserProductsApi(Everyday.GmodStore.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Everyday.GmodStore.Sdk.Client.Configuration.MergeConfigurations(
                Everyday.GmodStore.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Everyday.GmodStore.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Everyday.GmodStore.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProductsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserProductsApi(Everyday.GmodStore.Sdk.Client.ISynchronousClient client, Everyday.GmodStore.Sdk.Client.IAsynchronousClient asyncClient, Everyday.GmodStore.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Everyday.GmodStore.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Everyday.GmodStore.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Everyday.GmodStore.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Everyday.GmodStore.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// List all the specified user&#39;s products 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <returns>Object</returns>
        public Object ListUserProducts(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<Object> localVarResponse = ListUserProductsWithHttpInfo(user, cursor, filter);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all the specified user&#39;s products 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse<Object> ListUserProductsWithHttpInfo(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserProductsApi->ListUserProducts");

            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("user", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(user)); // path parameter
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/api/v3/users/{user}/products", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserProducts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all the specified user&#39;s products 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ListUserProductsAsync(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<Object> localVarResponse = await ListUserProductsWithHttpInfoAsync(user, cursor, filter, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all the specified user&#39;s products 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="filter">Filter the results (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<Object>> ListUserProductsWithHttpInfoAsync(string user, string cursor = default(string), ProductFilter filter = default(ProductFilter), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserProductsApi->ListUserProducts");


            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("user", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(user)); // path parameter
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/api/v3/users/{user}/products", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserProducts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}