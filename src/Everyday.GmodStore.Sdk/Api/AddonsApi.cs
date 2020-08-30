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
    public interface IAddonsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetch a single addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonResponse</returns>
        AddonResponse GetAddon (long addonId, List<string> with = default(List<string>));

        /// <summary>
        /// Fetch a single addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonResponse</returns>
        ApiResponse<AddonResponse> GetAddonWithHttpInfo (long addonId, List<string> with = default(List<string>));
        /// <summary>
        /// Fetch all the addons that you have access to
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonListResponse</returns>
        AddonListResponse ListSelfAddons (List<string> with = default(List<string>));

        /// <summary>
        /// Fetch all the addons that you have access to
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonListResponse</returns>
        ApiResponse<AddonListResponse> ListSelfAddonsWithHttpInfo (List<string> with = default(List<string>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddonsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Fetch a single addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of AddonResponse</returns>
        System.Threading.Tasks.Task<AddonResponse> GetAddonAsync (long addonId, List<string> with = default(List<string>));

        /// <summary>
        /// Fetch a single addon
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddonResponse>> GetAddonAsyncWithHttpInfo (long addonId, List<string> with = default(List<string>));
        /// <summary>
        /// Fetch all the addons that you have access to
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of AddonListResponse</returns>
        System.Threading.Tasks.Task<AddonListResponse> ListSelfAddonsAsync (List<string> with = default(List<string>));

        /// <summary>
        /// Fetch all the addons that you have access to
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddonListResponse>> ListSelfAddonsAsyncWithHttpInfo (List<string> with = default(List<string>));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddonsApi : IAddonsApiSync, IAddonsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddonsApi : IAddonsApi
    {
        private Everyday.GmodStore.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddonsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddonsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AddonsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddonsApi(Everyday.GmodStore.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AddonsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AddonsApi(Everyday.GmodStore.Sdk.Client.ISynchronousClient client,Everyday.GmodStore.Sdk.Client.IAsynchronousClient asyncClient, Everyday.GmodStore.Sdk.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

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
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Everyday.GmodStore.Sdk.Client.IReadableConfiguration Configuration {get; set;}

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
        /// Fetch a single addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonResponse</returns>
        public AddonResponse GetAddon (long addonId, List<string> with = default(List<string>))
        {
             Everyday.GmodStore.Sdk.Client.ApiResponse<AddonResponse> localVarResponse = GetAddonWithHttpInfo(addonId, with);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch a single addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonResponse</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse< AddonResponse > GetAddonWithHttpInfo (long addonId, List<string> with = default(List<string>))
        {
            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("addon_id", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(addonId)); // path parameter
            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< AddonResponse >("/addons/{addon_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAddon", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch a single addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of AddonResponse</returns>
        public async System.Threading.Tasks.Task<AddonResponse> GetAddonAsync (long addonId, List<string> with = default(List<string>))
        {
             Everyday.GmodStore.Sdk.Client.ApiResponse<AddonResponse> localVarResponse = await GetAddonAsyncWithHttpInfo(addonId, with);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch a single addon 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addonId">Id of the addon</param>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonResponse)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<AddonResponse>> GetAddonAsyncWithHttpInfo (long addonId, List<string> with = default(List<string>))
        {

            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("addon_id", Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToString(addonId)); // path parameter
            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AddonResponse>("/addons/{addon_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAddon", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch all the addons that you have access to 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>AddonListResponse</returns>
        public AddonListResponse ListSelfAddons (List<string> with = default(List<string>))
        {
             Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse> localVarResponse = ListSelfAddonsWithHttpInfo(with);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fetch all the addons that you have access to 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>ApiResponse of AddonListResponse</returns>
        public Everyday.GmodStore.Sdk.Client.ApiResponse< AddonListResponse > ListSelfAddonsWithHttpInfo (List<string> with = default(List<string>))
        {
            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Everyday.GmodStore.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< AddonListResponse >("/addons", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListSelfAddons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetch all the addons that you have access to 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of AddonListResponse</returns>
        public async System.Threading.Tasks.Task<AddonListResponse> ListSelfAddonsAsync (List<string> with = default(List<string>))
        {
             Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse> localVarResponse = await ListSelfAddonsAsyncWithHttpInfo(with);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fetch all the addons that you have access to 
        /// </summary>
        /// <exception cref="Everyday.GmodStore.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="with">The relations you want to fetch with the &#x60;Addon&#x60; (optional)</param>
        /// <returns>Task of ApiResponse (AddonListResponse)</returns>
        public async System.Threading.Tasks.Task<Everyday.GmodStore.Sdk.Client.ApiResponse<AddonListResponse>> ListSelfAddonsAsyncWithHttpInfo (List<string> with = default(List<string>))
        {

            Everyday.GmodStore.Sdk.Client.RequestOptions localVarRequestOptions = new Everyday.GmodStore.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (with != null)
            {
                localVarRequestOptions.QueryParameters.Add(Everyday.GmodStore.Sdk.Client.ClientUtils.ParameterToMultiMap("csv", "with", with));
            }

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AddonListResponse>("/addons", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListSelfAddons", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
