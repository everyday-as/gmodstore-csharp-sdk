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
        public interface IUserBansApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch all active bans associated with this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 UsersUserIdBansGet (string userId);

        /// <summary>
        /// Fetch all active bans associated with this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        ApiResponse<InlineResponse20013> UsersUserIdBansGetWithHttpInfo (string userId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch all active bans associated with this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>Task of InlineResponse20013</returns>
        System.Threading.Tasks.Task<InlineResponse20013> UsersUserIdBansGetAsync (string userId);

        /// <summary>
        /// Fetch all active bans associated with this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> UsersUserIdBansGetAsyncWithHttpInfo (string userId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class UserBansApi : IUserBansApi
    {
        private NO.Everyday.GmodStoreSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserBansApi(String basePath)
        {
            this.Configuration = new NO.Everyday.GmodStoreSDK.Client.Configuration { BasePath = basePath };

            ExceptionFactory = NO.Everyday.GmodStoreSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBansApi"/> class
        /// </summary>
        /// <returns></returns>
        public UserBansApi()
        {
            this.Configuration = NO.Everyday.GmodStoreSDK.Client.Configuration.Default;

            ExceptionFactory = NO.Everyday.GmodStoreSDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBansApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserBansApi(NO.Everyday.GmodStoreSDK.Client.Configuration configuration = null)
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
        /// Fetch all active bans associated with this user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>InlineResponse20013</returns>
        public InlineResponse20013 UsersUserIdBansGet (string userId)
        {
             ApiResponse<InlineResponse20013> localVarResponse = UsersUserIdBansGetWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all active bans associated with this user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>ApiResponse of InlineResponse20013</returns>
        public ApiResponse< InlineResponse20013 > UsersUserIdBansGetWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserBansApi->UsersUserIdBansGet");

            var localVarPath = "/users/{user_id}/bans";
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
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersUserIdBansGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20013) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20013)));
        }

        /// <summary>
        /// Fetch all active bans associated with this user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>Task of InlineResponse20013</returns>
        public async System.Threading.Tasks.Task<InlineResponse20013> UsersUserIdBansGetAsync (string userId)
        {
             ApiResponse<InlineResponse20013> localVarResponse = await UsersUserIdBansGetAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch all active bans associated with this user 
        /// </summary>
        /// <exception cref="NO.Everyday.GmodStoreSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id of the user</param>
        /// <returns>Task of ApiResponse (InlineResponse20013)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20013>> UsersUserIdBansGetAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UserBansApi->UsersUserIdBansGet");

            var localVarPath = "/users/{user_id}/bans";
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
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsersUserIdBansGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20013>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20013) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20013)));
        }

    }
}
