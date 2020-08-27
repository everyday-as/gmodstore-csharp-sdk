/* 
 * GmodStore
 *
 * Welcome to the Gmodstore API! You can use our API to access Gmodstore API endpoints, which can be used interact with Gmodstore programmatically.
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using NO.Everyday.GmodStoreSDK.Client;
using NO.Everyday.GmodStoreSDK.Model;

namespace NO.Everyday.GmodStoreSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IUserTeamsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch all the teams of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 ListUserTeams (string userId, List<string> with = null);

        /// <summary>
        /// Fetch all the teams of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> ListUserTeamsWithHttpInfo (string userId, List<string> with = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch all the teams of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> ListUserTeamsAsync (string userId, List<string> with = null);

        /// <summary>
        /// Fetch all the teams of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> ListUserTeamsAsyncWithHttpInfo (string userId, List<string> with = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class UserTeamsApi : IUserTeamsApi
    {
        private NO.Everyday.GmodStoreSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTeamsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserTeamsApi(String basePath)
        {
            this.Configuration = new NO.Everyday.GmodStoreSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = NO.Everyday.GmodStoreSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTeamsApi"/> class
        /// </summary>
        /// <returns></returns>
        public UserTeamsApi()
        {
            this.Configuration = NO.Everyday.GmodStoreSDK.Client.Configuration.Default;

            ExceptionFactory = NO.Everyday.GmodStoreSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTeamsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserTeamsApi(NO.Everyday.GmodStoreSDK.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = NO.Everyday.GmodStoreSDK.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = NO.Everyday.GmodStoreSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public NO.Everyday.GmodStoreSDK.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public NO.Everyday.GmodStoreSDK.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Fetch all the teams of a user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 ListUserTeams (string userId, List<string> with = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = ListUserTeamsWithHttpInfo(userId, with);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all the teams of a user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public ApiResponse< InlineResponse20012 > ListUserTeamsWithHttpInfo (string userId, List<string> with = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserTeamsApi->ListUserTeams");

            var localVarPath = "/users/{user_id}/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUserTeams", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20012) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
        }

        /// <summary>
        /// Fetch all the teams of a user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> ListUserTeamsAsync (string userId, List<string> with = null)
        {
             ApiResponse<InlineResponse20012> localVarResponse = await ListUserTeamsAsyncWithHttpInfo(userId, with);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch all the teams of a user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <param name="with">The relations you want to fetch with the Team schema (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> ListUserTeamsAsyncWithHttpInfo (string userId, List<string> with = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserTeamsApi->ListUserTeams");

            var localVarPath = "/users/{user_id}/teams";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListUserTeams", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20012) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20012)));
        }

    }
}
