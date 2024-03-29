/*
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
 *
 * The version of the OpenAPI document: 1.2.0
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
    public interface IUserAddonsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch all the addons authored / co-authored by a user
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonListResponse</returns>
        AddonListResponse ListUserAddons(long userId, List<string> with = default(List<string>));

        /// <summary>
        /// Fetch all the addons authored / co-authored by a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonListResponse</returns>
        ApiResponse<AddonListResponse> ListUserAddonsWithHttpInfo(long userId, List<string> with = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserAddonsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Fetch all the addons authored / co-authored by a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddonListResponse</returns>
        System.Threading.Tasks.Task<AddonListResponse> ListUserAddonsAsync(long userId, List<string> with = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetch all the addons authored / co-authored by a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddonListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddonListResponse>> ListUserAddonsWithHttpInfoAsync(long userId, List<string> with = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserAddonsApi : IUserAddonsApiSync, IUserAddonsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserAddonsApi : IUserAddonsApi
    {
        private Everyday.GmodStore.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAddonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserAddonsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAddonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserAddonsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserAddonsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserAddonsApi(Everyday.GmodStore.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UserAddonsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserAddonsApi(Everyday.GmodStore.Sdk.Client.ISynchronousClient client, Everyday.GmodStore.Sdk.Client.IAsynchronousClient asyncClient, Everyday.GmodStore.Sdk.Client.IReadableConfiguration configuration)
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
        /// Fetch all the addons authored / co-authored by a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonListResponse</returns>
        public AddonListResponse ListUserAddons(long userId, List<string> with = default(List<string>))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse> localVarResponse = ListUserAddonsWithHttpInfo(userId, with);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all the addons authored / co-authored by a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonListResponse</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse> ListUserAddonsWithHttpInfo(long userId, List<string> with = default(List<string>))
        {
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

            localVarRequestOptions.PathParameters.Add("user_id", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AddonListResponse>("/users/{user_id}/addons", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserAddons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch all the addons authored / co-authored by a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddonListResponse</returns>
        public async System.Threading.Tasks.Task<AddonListResponse> ListUserAddonsAsync(long userId, List<string> with = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse> localVarResponse = await ListUserAddonsWithHttpInfoAsync(userId, with, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all the addons authored / co-authored by a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddonListResponse)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse>> ListUserAddonsWithHttpInfoAsync(long userId, List<string> with = default(List<string>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("user_id", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AddonListResponse>("/users/{user_id}/addons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserAddons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
