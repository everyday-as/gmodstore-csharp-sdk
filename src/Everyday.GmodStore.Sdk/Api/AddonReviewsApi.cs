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
using Everyday.GmodStore.Sdk.Client;
using Everyday.GmodStore.Sdk.Model;

namespace Everyday.GmodStore.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IAddonReviewsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch a review of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>AddonReviewResponse</returns>
        AddonReviewResponse GetAddonReview (long? addonId, long? reviewId, List<string> with = null);

        /// <summary>
        /// Fetch a review of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonReviewResponse</returns>
        ApiResponse<AddonReviewResponse> GetAddonReviewWithHttpInfo (long? addonId, long? reviewId, List<string> with = null);
        /// <summary>
        /// Fetch all the reviews of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>AddonReviewListResponse</returns>
        AddonReviewListResponse ListAddonReviews (long? addonId, List<string> with = null);

        /// <summary>
        /// Fetch all the reviews of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonReviewListResponse</returns>
        ApiResponse<AddonReviewListResponse> ListAddonReviewsWithHttpInfo (long? addonId, List<string> with = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Fetch a review of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of AddonReviewResponse</returns>
        System.Threading.Tasks.Task<AddonReviewResponse> GetAddonReviewAsync (long? addonId, long? reviewId, List<string> with = null);

        /// <summary>
        /// Fetch a review of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonReviewResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddonReviewResponse>> GetAddonReviewAsyncWithHttpInfo (long? addonId, long? reviewId, List<string> with = null);
        /// <summary>
        /// Fetch all the reviews of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of AddonReviewListResponse</returns>
        System.Threading.Tasks.Task<AddonReviewListResponse> ListAddonReviewsAsync (long? addonId, List<string> with = null);

        /// <summary>
        /// Fetch all the reviews of an addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonReviewListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddonReviewListResponse>> ListAddonReviewsAsyncWithHttpInfo (long? addonId, List<string> with = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AddonReviewsApi : IAddonReviewsApi
    {
        private Everyday.GmodStore.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonReviewsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddonReviewsApi(String basePath)
        {
            this.Configuration = new Everyday.GmodStore.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonReviewsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AddonReviewsApi()
        {
            this.Configuration = Everyday.GmodStore.Sdk.Client.Configuration.Default;

            ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonReviewsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddonReviewsApi(Everyday.GmodStore.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Everyday.GmodStore.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Everyday.GmodStore.Sdk.Client.Configuration.DefaultExceptionFactory;
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
        public Everyday.GmodStore.Sdk.Client.Configuration Configuration {get; set;}

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
        /// Fetch a review of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>AddonReviewResponse</returns>
        public AddonReviewResponse GetAddonReview (long? addonId, long? reviewId, List<string> with = null)
        {
             ApiResponse<AddonReviewResponse> localVarResponse = GetAddonReviewWithHttpInfo(addonId, reviewId, with);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a review of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonReviewResponse</returns>
        public ApiResponse< AddonReviewResponse > GetAddonReviewWithHttpInfo (long? addonId, long? reviewId, List<string> with = null)
        {
            // verify the required parameter 'addonId' is set
            if (addonId == null)
                throw new ApiException(400, "Missing required parameter 'addonId' when calling AddonReviewsApi->GetAddonReview");
            // verify the required parameter 'reviewId' is set
            if (reviewId == null)
                throw new ApiException(400, "Missing required parameter 'reviewId' when calling AddonReviewsApi->GetAddonReview");

            var localVarPath = "/addons/{addon_id}/reviews/{review_id}";
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

            if (addonId != null) localVarPathParams.Add("addon_id", this.Configuration.ApiClient.ParameterToString(addonId)); // path parameter
            if (reviewId != null) localVarPathParams.Add("review_id", this.Configuration.ApiClient.ParameterToString(reviewId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAddonReview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddonReviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AddonReviewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddonReviewResponse)));
        }

        /// <summary>
        /// Fetch a review of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of AddonReviewResponse</returns>
        public async System.Threading.Tasks.Task<AddonReviewResponse> GetAddonReviewAsync (long? addonId, long? reviewId, List<string> with = null)
        {
             ApiResponse<AddonReviewResponse> localVarResponse = await GetAddonReviewAsyncWithHttpInfo(addonId, reviewId, with);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a review of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="reviewId">Id of the review</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonReviewResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddonReviewResponse>> GetAddonReviewAsyncWithHttpInfo (long? addonId, long? reviewId, List<string> with = null)
        {
            // verify the required parameter 'addonId' is set
            if (addonId == null)
                throw new ApiException(400, "Missing required parameter 'addonId' when calling AddonReviewsApi->GetAddonReview");
            // verify the required parameter 'reviewId' is set
            if (reviewId == null)
                throw new ApiException(400, "Missing required parameter 'reviewId' when calling AddonReviewsApi->GetAddonReview");

            var localVarPath = "/addons/{addon_id}/reviews/{review_id}";
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

            if (addonId != null) localVarPathParams.Add("addon_id", this.Configuration.ApiClient.ParameterToString(addonId)); // path parameter
            if (reviewId != null) localVarPathParams.Add("review_id", this.Configuration.ApiClient.ParameterToString(reviewId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAddonReview", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddonReviewResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AddonReviewResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddonReviewResponse)));
        }

        /// <summary>
        /// Fetch all the reviews of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>AddonReviewListResponse</returns>
        public AddonReviewListResponse ListAddonReviews (long? addonId, List<string> with = null)
        {
             ApiResponse<AddonReviewListResponse> localVarResponse = ListAddonReviewsWithHttpInfo(addonId, with);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all the reviews of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonReviewListResponse</returns>
        public ApiResponse< AddonReviewListResponse > ListAddonReviewsWithHttpInfo (long? addonId, List<string> with = null)
        {
            // verify the required parameter 'addonId' is set
            if (addonId == null)
                throw new ApiException(400, "Missing required parameter 'addonId' when calling AddonReviewsApi->ListAddonReviews");

            var localVarPath = "/addons/{addon_id}/reviews";
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

            if (addonId != null) localVarPathParams.Add("addon_id", this.Configuration.ApiClient.ParameterToString(addonId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAddonReviews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddonReviewListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AddonReviewListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddonReviewListResponse)));
        }

        /// <summary>
        /// Fetch all the reviews of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of AddonReviewListResponse</returns>
        public async System.Threading.Tasks.Task<AddonReviewListResponse> ListAddonReviewsAsync (long? addonId, List<string> with = null)
        {
             ApiResponse<AddonReviewListResponse> localVarResponse = await ListAddonReviewsAsyncWithHttpInfo(addonId, with);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch all the reviews of an addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;AddonReview&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonReviewListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddonReviewListResponse>> ListAddonReviewsAsyncWithHttpInfo (long? addonId, List<string> with = null)
        {
            // verify the required parameter 'addonId' is set
            if (addonId == null)
                throw new ApiException(400, "Missing required parameter 'addonId' when calling AddonReviewsApi->ListAddonReviews");

            var localVarPath = "/addons/{addon_id}/reviews";
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

            if (addonId != null) localVarPathParams.Add("addon_id", this.Configuration.ApiClient.ParameterToString(addonId)); // path parameter
            if (with != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "with", with)); // query parameter
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAddonReviews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AddonReviewListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AddonReviewListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AddonReviewListResponse)));
        }

    }
}
