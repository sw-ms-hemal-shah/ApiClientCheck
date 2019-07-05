/* 
 * Seg API
 *
 * Provide API for Manage Segs
 *
 * OpenAPI spec version: 1.0
 * Contact: vpatel@alliantcreditunion.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using component.netcore.api.refit.info;
using component.netcore.api.refit.interfaces;
using RestSharp.Portable;
using SegApiClient.Client;
using SegApiClient.Model;

namespace SegApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardTypeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets card type.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </remarks>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CardType&gt;</returns>
        List<CardType> Cardtype ();

        /// <summary>
        /// Gets card type.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </remarks>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CardType&gt;</returns>
        //ApiResponse<List<CardType>> CardtypeWithHttpInfo ();
        List<CardType> CardtypeWithHttpInfo();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets card type.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </remarks>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CardType&gt;</returns>
        System.Threading.Tasks.Task<List<CardType>> CardtypeAsync ();

        /// <summary>
        /// Gets card type.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </remarks>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CardType&gt;)</returns>
        //System.Threading.Tasks.Task<ApiResponse<List<CardType>>> CardtypeAsyncWithHttpInfo ();
        System.Threading.Tasks.Task<List<CardType>> CardtypeAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardTypeApi : ICardTypeApi
    {
        private readonly IApiCaller _refitWrapper;

        private SegApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardTypeApi(String basePath, IApiCaller refitWrapper)
        {
            this.Configuration = new SegApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SegApiClient.Client.Configuration.DefaultExceptionFactory;

            _refitWrapper = refitWrapper;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardTypeApi(IApiCaller refitWrapper, SegApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SegApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SegApiClient.Client.Configuration.DefaultExceptionFactory;

            _refitWrapper = refitWrapper;
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
        public SegApiClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SegApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// Gets card type. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </summary>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CardType&gt;</returns>
        public List<CardType> Cardtype ()
        {
             List<CardType> localVarResponse = CardtypeWithHttpInfo();
             return localVarResponse;
        }

        /// <summary>
        /// Gets card type. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </summary>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CardType&gt;</returns>
        //public ApiResponse< List<CardType> > CardtypeWithHttpInfo ()
        public List<CardType> CardtypeWithHttpInfo()
        {

            var localVarPath = "/api/v1/segs/cardType";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            Dictionary<string, string> dictionaryToken = new Dictionary<string, string>();
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
                dictionaryToken.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //make Refit HTTP request
            var apiCallInfo = new ApiCallInfo()
            {
                HeaderValues = dictionaryToken,
                Url = Configuration.BasePath + localVarPath,
                HttpMethod = Microsoft.AspNetCore.Http.HttpMethods.Get
            };
            return _refitWrapper.CallApi<List<CardType>>(apiCallInfo).Result;
            
            // make the HTTP request
            //IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
            //    Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            //    localVarPathParams, localVarHttpContentType);

            //int localVarStatusCode = (int) localVarResponse.StatusCode;

            //if (ExceptionFactory != null)
            //{
            //    Exception exception = ExceptionFactory("Cardtype", localVarResponse);
            //    if (exception != null) throw exception;
            //}

            //return new ApiResponse<List<CardType>>(localVarStatusCode,
            //    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
            //    (List<CardType>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CardType>)));
        }

        /// <summary>
        /// Gets card type. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </summary>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CardType&gt;</returns>
        public async System.Threading.Tasks.Task<List<CardType>> CardtypeAsync ()
        {
            //ApiResponse<List<CardType>> localVarResponse = await CardtypeAsyncWithHttpInfo();
            //return localVarResponse.Data;
            var localVarResponse = await CardtypeAsyncWithHttpInfo();
            return localVarResponse;
        }

        /// <summary>
        /// Gets card type. &lt;br/&gt;&lt;br/&gt;&lt;b&gt;Roles&lt;/b&gt;&lt;br/&gt;Denied Anonymous Access&lt;br/&gt;seg.reviewer&lt;br/&gt; seg.admin
        /// </summary>
        /// <exception cref="SegApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CardType&gt;)</returns>
        public async System.Threading.Tasks.Task<List<CardType>> CardtypeAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v1/segs/cardType";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (oauth2) required
            // oauth required
            Dictionary<string, string> dictionaryToken = new Dictionary<string, string>();
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
                dictionaryToken.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //make Refit HTTP request
            var apiCallInfo = new ApiCallInfo()
            {
                HeaderValues = dictionaryToken,
                Url = Configuration.BasePath + localVarPath,
                HttpMethod = Microsoft.AspNetCore.Http.HttpMethods.Get
            };
            return await _refitWrapper.CallApi<List<CardType>>(apiCallInfo);

            // make the HTTP request
            //IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
            //    Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            //    localVarPathParams, localVarHttpContentType);

            //int localVarStatusCode = (int) localVarResponse.StatusCode;

            //if (ExceptionFactory != null)
            //{
            //    Exception exception = ExceptionFactory("Cardtype", localVarResponse);
            //    if (exception != null) throw exception;
            //}

            //return new ApiResponse<List<CardType>>(localVarStatusCode,
            //    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
            //    (List<CardType>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CardType>)));
        }

    }
}
