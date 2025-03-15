/*
 * v2 API
 *
 * OpenAPI spec for Solr's v2 API endpoints
 *
 * The version of the OpenAPI document: 9.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using SolrClient.Client;
using SolrClient.Model;

namespace SolrClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Query a Solr core or collection using the structured request DSL
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <returns>FlexibleSolrJerseyResponseModel</returns>
        FlexibleSolrJerseyResponseModel JsonQuery(IndexTypeModel indexType, string indexName, Object body);

        /// <summary>
        /// Query a Solr core or collection using the structured request DSL
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlexibleSolrJerseyResponseModel</returns>
        ApiResponse<FlexibleSolrJerseyResponseModel> JsonQueryWithHttpInfo(IndexTypeModel indexType, string indexName, Object body);
        /// <summary>
        /// Query a Solr core or collection using individual query parameters
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <returns>FlexibleSolrJerseyResponseModel</returns>
        FlexibleSolrJerseyResponseModel Query(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?));

        /// <summary>
        /// Query a Solr core or collection using individual query parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <returns>ApiResponse of FlexibleSolrJerseyResponseModel</returns>
        ApiResponse<FlexibleSolrJerseyResponseModel> QueryWithHttpInfo(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Query a Solr core or collection using the structured request DSL
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FlexibleSolrJerseyResponseModel</returns>
        System.Threading.Tasks.Task<FlexibleSolrJerseyResponseModel> JsonQueryAsync(IndexTypeModel indexType, string indexName, Object body, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Query a Solr core or collection using the structured request DSL
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FlexibleSolrJerseyResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexibleSolrJerseyResponseModel>> JsonQueryWithHttpInfoAsync(IndexTypeModel indexType, string indexName, Object body, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Query a Solr core or collection using individual query parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FlexibleSolrJerseyResponseModel</returns>
        System.Threading.Tasks.Task<FlexibleSolrJerseyResponseModel> QueryAsync(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Query a Solr core or collection using individual query parameters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FlexibleSolrJerseyResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexibleSolrJerseyResponseModel>> QueryWithHttpInfoAsync(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryingApi : IQueryingApiSync, IQueryingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class QueryingApi : IDisposable, IQueryingApi
    {
        private SolrClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public QueryingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public QueryingApi(string basePath)
        {
            this.Configuration = SolrClient.Client.Configuration.MergeConfigurations(
                SolrClient.Client.GlobalConfiguration.Instance,
                new SolrClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new SolrClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = SolrClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public QueryingApi(SolrClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SolrClient.Client.Configuration.MergeConfigurations(
                SolrClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new SolrClient.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = SolrClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public QueryingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public QueryingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = SolrClient.Client.Configuration.MergeConfigurations(
                SolrClient.Client.GlobalConfiguration.Instance,
                new SolrClient.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new SolrClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = SolrClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public QueryingApi(HttpClient client, SolrClient.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = SolrClient.Client.Configuration.MergeConfigurations(
                SolrClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new SolrClient.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = SolrClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public QueryingApi(SolrClient.Client.ISynchronousClient client, SolrClient.Client.IAsynchronousClient asyncClient, SolrClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SolrClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public SolrClient.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SolrClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SolrClient.Client.ISynchronousClient Client { get; set; }

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
        public SolrClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SolrClient.Client.ExceptionFactory ExceptionFactory
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
        /// Query a Solr core or collection using the structured request DSL 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <returns>FlexibleSolrJerseyResponseModel</returns>
        public FlexibleSolrJerseyResponseModel JsonQuery(IndexTypeModel indexType, string indexName, Object body)
        {
            SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> localVarResponse = JsonQueryWithHttpInfo(indexType, indexName, body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query a Solr core or collection using the structured request DSL 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of FlexibleSolrJerseyResponseModel</returns>
        public SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> JsonQueryWithHttpInfo(IndexTypeModel indexType, string indexName, Object body)
        {
            // verify the required parameter 'indexName' is set
            if (indexName == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'indexName' when calling QueryingApi->JsonQuery");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'body' when calling QueryingApi->JsonQuery");

            SolrClient.Client.RequestOptions localVarRequestOptions = new SolrClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = SolrClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SolrClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("indexType", SolrClient.Client.ClientUtils.ParameterToString(indexType)); // path parameter
            localVarRequestOptions.PathParameters.Add("indexName", SolrClient.Client.ClientUtils.ParameterToString(indexName)); // path parameter
            localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = this.Client.Post<FlexibleSolrJerseyResponseModel>("/{indexType}/{indexName}/select", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("JsonQuery", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Query a Solr core or collection using the structured request DSL 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FlexibleSolrJerseyResponseModel</returns>
        public async System.Threading.Tasks.Task<FlexibleSolrJerseyResponseModel> JsonQueryAsync(IndexTypeModel indexType, string indexName, Object body, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> localVarResponse = await JsonQueryWithHttpInfoAsync(indexType, indexName, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query a Solr core or collection using the structured request DSL 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FlexibleSolrJerseyResponseModel)</returns>
        public async System.Threading.Tasks.Task<SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel>> JsonQueryWithHttpInfoAsync(IndexTypeModel indexType, string indexName, Object body, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'indexName' is set
            if (indexName == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'indexName' when calling QueryingApi->JsonQuery");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'body' when calling QueryingApi->JsonQuery");


            SolrClient.Client.RequestOptions localVarRequestOptions = new SolrClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };


            var localVarContentType = SolrClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SolrClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("indexType", SolrClient.Client.ClientUtils.ParameterToString(indexType)); // path parameter
            localVarRequestOptions.PathParameters.Add("indexName", SolrClient.Client.ClientUtils.ParameterToString(indexName)); // path parameter
            localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FlexibleSolrJerseyResponseModel>("/{indexType}/{indexName}/select", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("JsonQuery", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Query a Solr core or collection using individual query parameters 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <returns>FlexibleSolrJerseyResponseModel</returns>
        public FlexibleSolrJerseyResponseModel Query(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?))
        {
            SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> localVarResponse = QueryWithHttpInfo(indexType, indexName, q, fq, fl, rows);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query a Solr core or collection using individual query parameters 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <returns>ApiResponse of FlexibleSolrJerseyResponseModel</returns>
        public SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> QueryWithHttpInfo(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?))
        {
            // verify the required parameter 'indexName' is set
            if (indexName == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'indexName' when calling QueryingApi->Query");

            SolrClient.Client.RequestOptions localVarRequestOptions = new SolrClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = SolrClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SolrClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("indexType", SolrClient.Client.ClientUtils.ParameterToString(indexType)); // path parameter
            localVarRequestOptions.PathParameters.Add("indexName", SolrClient.Client.ClientUtils.ParameterToString(indexName)); // path parameter
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (fq != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("multi", "fq", fq));
            }
            if (fl != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "fl", fl));
            }
            if (rows != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "rows", rows));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<FlexibleSolrJerseyResponseModel>("/{indexType}/{indexName}/select", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Query a Solr core or collection using individual query parameters 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FlexibleSolrJerseyResponseModel</returns>
        public async System.Threading.Tasks.Task<FlexibleSolrJerseyResponseModel> QueryAsync(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel> localVarResponse = await QueryWithHttpInfoAsync(indexType, indexName, q, fq, fl, rows, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Query a Solr core or collection using individual query parameters 
        /// </summary>
        /// <exception cref="SolrClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="indexType"></param>
        /// <param name="indexName"></param>
        /// <param name="q"> (optional)</param>
        /// <param name="fq"> (optional)</param>
        /// <param name="fl"> (optional)</param>
        /// <param name="rows"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FlexibleSolrJerseyResponseModel)</returns>
        public async System.Threading.Tasks.Task<SolrClient.Client.ApiResponse<FlexibleSolrJerseyResponseModel>> QueryWithHttpInfoAsync(IndexTypeModel indexType, string indexName, string? q = default(string?), Collection<string>? fq = default(Collection<string>?), string? fl = default(string?), int? rows = default(int?), System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'indexName' is set
            if (indexName == null)
                throw new SolrClient.Client.ApiException(400, "Missing required parameter 'indexName' when calling QueryingApi->Query");


            SolrClient.Client.RequestOptions localVarRequestOptions = new SolrClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };


            var localVarContentType = SolrClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SolrClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("indexType", SolrClient.Client.ClientUtils.ParameterToString(indexType)); // path parameter
            localVarRequestOptions.PathParameters.Add("indexName", SolrClient.Client.ClientUtils.ParameterToString(indexName)); // path parameter
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (fq != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("multi", "fq", fq));
            }
            if (fl != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "fl", fl));
            }
            if (rows != null)
            {
                localVarRequestOptions.QueryParameters.Add(SolrClient.Client.ClientUtils.ParameterToMultiMap("", "rows", rows));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FlexibleSolrJerseyResponseModel>("/{indexType}/{indexName}/select", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
