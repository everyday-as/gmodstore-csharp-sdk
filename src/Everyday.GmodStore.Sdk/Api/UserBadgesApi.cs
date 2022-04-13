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
    public interface IUserBadgesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Attach a badge to a user
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <returns>CreateUserBadgeResponse</returns>
        CreateUserBadgeResponse CreateUserBadge(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload));

        /// <summary>
        /// Attach a badge to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <returns>ApiResponse of CreateUserBadgeResponse</returns>
        ApiResponse<CreateUserBadgeResponse> CreateUserBadgeWithHttpInfo(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload));
        /// <summary>
        /// Detach a badge from a user
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <returns>DeleteUserBadgeResponse</returns>
        DeleteUserBadgeResponse DeleteUserBadge(string user, string badge);

        /// <summary>
        /// Detach a badge from a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <returns>ApiResponse of DeleteUserBadgeResponse</returns>
        ApiResponse<DeleteUserBadgeResponse> DeleteUserBadgeWithHttpInfo(string user, string badge);
        /// <summary>
        /// List all the specified user&#39;s badges
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <returns>Object</returns>
        Object ListUserBadges(string user, int? perPage = default(int?), string cursor = default(string));

        /// <summary>
        /// List all the specified user&#39;s badges
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ListUserBadgesWithHttpInfo(string user, int? perPage = default(int?), string cursor = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserBadgesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Attach a badge to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateUserBadgeResponse</returns>
        System.Threading.Tasks.Task<CreateUserBadgeResponse> CreateUserBadgeAsync(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Attach a badge to a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateUserBadgeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateUserBadgeResponse>> CreateUserBadgeWithHttpInfoAsync(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Detach a badge from a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeleteUserBadgeResponse</returns>
        System.Threading.Tasks.Task<DeleteUserBadgeResponse> DeleteUserBadgeAsync(string user, string badge, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Detach a badge from a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeleteUserBadgeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteUserBadgeResponse>> DeleteUserBadgeWithHttpInfoAsync(string user, string badge, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all the specified user&#39;s badges
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ListUserBadgesAsync(string user, int? perPage = default(int?), string cursor = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all the specified user&#39;s badges
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ListUserBadgesWithHttpInfoAsync(string user, int? perPage = default(int?), string cursor = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserBadgesApi : IUserBadgesApiSync, IUserBadgesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserBadgesApi : IUserBadgesApi
    {
        private Everyday.GmodStore.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBadgesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserBadgesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBadgesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserBadgesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="UserBadgesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserBadgesApi(Everyday.GmodStore.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="UserBadgesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserBadgesApi(Everyday.GmodStore.Sdk.Client.ISynchronousClient client, Everyday.GmodStore.Sdk.Client.IAsynchronousClient asyncClient, Everyday.GmodStore.Sdk.Client.IReadableConfiguration configuration)
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
        /// Attach a badge to a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <returns>CreateUserBadgeResponse</returns>
        public CreateUserBadgeResponse CreateUserBadge(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<CreateUserBadgeResponse> localVarResponse = CreateUserBadgeWithHttpInfo(user, newUserBadgePayload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Attach a badge to a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <returns>ApiResponse of CreateUserBadgeResponse</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse<CreateUserBadgeResponse> CreateUserBadgeWithHttpInfo(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->CreateUserBadge");

            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = newUserBadgePayload;

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CreateUserBadgeResponse>("/api/v3/users/{user}/badges", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUserBadge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Attach a badge to a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CreateUserBadgeResponse</returns>
        public async System.Threading.Tasks.Task<CreateUserBadgeResponse> CreateUserBadgeAsync(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<CreateUserBadgeResponse> localVarResponse = await CreateUserBadgeWithHttpInfoAsync(user, newUserBadgePayload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Attach a badge to a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="newUserBadgePayload"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CreateUserBadgeResponse)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<CreateUserBadgeResponse>> CreateUserBadgeWithHttpInfoAsync(string user, NewUserBadgePayload newUserBadgePayload = default(NewUserBadgePayload), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->CreateUserBadge");


            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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
            localVarRequestOptions.Data = newUserBadgePayload;

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<CreateUserBadgeResponse>("/api/v3/users/{user}/badges", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUserBadge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Detach a badge from a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <returns>DeleteUserBadgeResponse</returns>
        public DeleteUserBadgeResponse DeleteUserBadge(string user, string badge)
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<DeleteUserBadgeResponse> localVarResponse = DeleteUserBadgeWithHttpInfo(user, badge);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Detach a badge from a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <returns>ApiResponse of DeleteUserBadgeResponse</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse<DeleteUserBadgeResponse> DeleteUserBadgeWithHttpInfo(string user, string badge)
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->DeleteUserBadge");

            // verify the required parameter 'badge' is set
            if (badge == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'badge' when calling UserBadgesApi->DeleteUserBadge");

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
            localVarRequestOptions.PathParameters.Add("badge", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(badge)); // path parameter

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<DeleteUserBadgeResponse>("/api/v3/users/{user}/badges/{badge}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteUserBadge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Detach a badge from a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeleteUserBadgeResponse</returns>
        public async System.Threading.Tasks.Task<DeleteUserBadgeResponse> DeleteUserBadgeAsync(string user, string badge, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<DeleteUserBadgeResponse> localVarResponse = await DeleteUserBadgeWithHttpInfoAsync(user, badge, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Detach a badge from a user 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="badge"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeleteUserBadgeResponse)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<DeleteUserBadgeResponse>> DeleteUserBadgeWithHttpInfoAsync(string user, string badge, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->DeleteUserBadge");

            // verify the required parameter 'badge' is set
            if (badge == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'badge' when calling UserBadgesApi->DeleteUserBadge");


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
            localVarRequestOptions.PathParameters.Add("badge", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(badge)); // path parameter

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<DeleteUserBadgeResponse>("/api/v3/users/{user}/badges/{badge}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteUserBadge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all the specified user&#39;s badges 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <returns>Object</returns>
        public Object ListUserBadges(string user, int? perPage = default(int?), string cursor = default(string))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<Object> localVarResponse = ListUserBadgesWithHttpInfo(user, perPage, cursor);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all the specified user&#39;s badges 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse<Object> ListUserBadgesWithHttpInfo(string user, int? perPage = default(int?), string cursor = default(string))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->ListUserBadges");

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
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "perPage", perPage));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/api/v3/users/{user}/badges", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserBadges", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all the specified user&#39;s badges 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ListUserBadgesAsync(string user, int? perPage = default(int?), string cursor = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Everyday.GmodStore.Sdk.Client.ApiResponse<Object> localVarResponse = await ListUserBadgesWithHttpInfoAsync(user, perPage, cursor, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all the specified user&#39;s badges 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user"></param>
        /// <param name="perPage"> (optional, default to 24)</param>
        /// <param name="cursor">The cursor from which to return paginated results starting after (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<Object>> ListUserBadgesWithHttpInfoAsync(string user, int? perPage = default(int?), string cursor = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'user' is set
            if (user == null)
                throw new Everyday.GmodStore.Sdk.Client.ApiException(400, "Missing required parameter 'user' when calling UserBadgesApi->ListUserBadges");


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
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "perPage", perPage));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }

            // authentication (PersonalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/api/v3/users/{user}/badges", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUserBadges", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
