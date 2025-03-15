// <auto-generated>
/*
 * v2 API
 *
 * OpenAPI spec for Solr's v2 API endpoints
 *
 * The version of the OpenAPI document: 9.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Diagnostics.CodeAnalysis;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IReplicaPropertiesApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ReplicaPropertiesApiEvents Events { get; }

        /// <summary>
        /// Adds a property to the specified replica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to add.</param>
        /// <param name="addReplicaPropertyRequestBody">The value of the replica property to create or update</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAddReplicaPropertyApiResponse"/>&gt;</returns>
        Task<IAddReplicaPropertyApiResponse> AddReplicaPropertyAsync(string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds a property to the specified replica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to add.</param>
        /// <param name="addReplicaPropertyRequestBody">The value of the replica property to create or update</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAddReplicaPropertyApiResponse"/>?&gt;</returns>
        Task<IAddReplicaPropertyApiResponse?> AddReplicaPropertyOrDefaultAsync(string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an existing replica property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IDeleteReplicaPropertyApiResponse"/>&gt;</returns>
        Task<IDeleteReplicaPropertyApiResponse> DeleteReplicaPropertyAsync(string collName, string shardName, string replicaName, string propName, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an existing replica property
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IDeleteReplicaPropertyApiResponse"/>?&gt;</returns>
        Task<IDeleteReplicaPropertyApiResponse?> DeleteReplicaPropertyOrDefaultAsync(string collName, string shardName, string replicaName, string propName, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IAddReplicaPropertyApiResponse"/>
    /// </summary>
    public interface IAddReplicaPropertyApiResponse : Org.OpenAPITools.Client.IApiResponse, IDefault<Org.OpenAPITools.Model.SolrJerseyResponse?>
    {
        /// <summary>
        /// Returns true if the response is the default response type
        /// </summary>
        /// <returns></returns>
        bool IsDefault { get; }
    }

    /// <summary>
    /// The <see cref="IDeleteReplicaPropertyApiResponse"/>
    /// </summary>
    public interface IDeleteReplicaPropertyApiResponse : Org.OpenAPITools.Client.IApiResponse, IDefault<Org.OpenAPITools.Model.SolrJerseyResponse?>
    {
        /// <summary>
        /// Returns true if the response is the default response type
        /// </summary>
        /// <returns></returns>
        bool IsDefault { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReplicaPropertiesApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnAddReplicaProperty;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorAddReplicaProperty;

        internal void ExecuteOnAddReplicaProperty(ReplicaPropertiesApi.AddReplicaPropertyApiResponse apiResponse)
        {
            OnAddReplicaProperty?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorAddReplicaProperty(Exception exception)
        {
            OnErrorAddReplicaProperty?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnDeleteReplicaProperty;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorDeleteReplicaProperty;

        internal void ExecuteOnDeleteReplicaProperty(ReplicaPropertiesApi.DeleteReplicaPropertyApiResponse apiResponse)
        {
            OnDeleteReplicaProperty?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorDeleteReplicaProperty(Exception exception)
        {
            OnErrorDeleteReplicaProperty?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ReplicaPropertiesApi : IReplicaPropertiesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ReplicaPropertiesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ReplicaPropertiesApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaPropertiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReplicaPropertiesApi(ILogger<ReplicaPropertiesApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ReplicaPropertiesApiEvents replicaPropertiesApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ReplicaPropertiesApi>();
            HttpClient = httpClient;
            Events = replicaPropertiesApiEvents;
        }

        partial void FormatAddReplicaProperty(ref string collName, ref string shardName, ref string replicaName, ref string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <param name="addReplicaPropertyRequestBody"></param>
        /// <returns></returns>
        private void ValidateAddReplicaProperty(string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody)
        {
            if (collName == null)
                throw new ArgumentNullException(nameof(collName));

            if (shardName == null)
                throw new ArgumentNullException(nameof(shardName));

            if (replicaName == null)
                throw new ArgumentNullException(nameof(replicaName));

            if (propName == null)
                throw new ArgumentNullException(nameof(propName));

            if (addReplicaPropertyRequestBody == null)
                throw new ArgumentNullException(nameof(addReplicaPropertyRequestBody));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <param name="addReplicaPropertyRequestBody"></param>
        private void AfterAddReplicaPropertyDefaultImplementation(IAddReplicaPropertyApiResponse apiResponseLocalVar, string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody)
        {
            bool suppressDefaultLog = false;
            AfterAddReplicaProperty(ref suppressDefaultLog, apiResponseLocalVar, collName, shardName, replicaName, propName, addReplicaPropertyRequestBody);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <param name="addReplicaPropertyRequestBody"></param>
        partial void AfterAddReplicaProperty(ref bool suppressDefaultLog, IAddReplicaPropertyApiResponse apiResponseLocalVar, string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <param name="addReplicaPropertyRequestBody"></param>
        private void OnErrorAddReplicaPropertyDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorAddReplicaProperty(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, collName, shardName, replicaName, propName, addReplicaPropertyRequestBody);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <param name="addReplicaPropertyRequestBody"></param>
        partial void OnErrorAddReplicaProperty(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody);

        /// <summary>
        /// Adds a property to the specified replica 
        /// </summary>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to add.</param>
        /// <param name="addReplicaPropertyRequestBody">The value of the replica property to create or update</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAddReplicaPropertyApiResponse"/>&gt;</returns>
        public async Task<IAddReplicaPropertyApiResponse?> AddReplicaPropertyOrDefaultAsync(string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await AddReplicaPropertyAsync(collName, shardName, replicaName, propName, addReplicaPropertyRequestBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Adds a property to the specified replica 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to add.</param>
        /// <param name="addReplicaPropertyRequestBody">The value of the replica property to create or update</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAddReplicaPropertyApiResponse"/>&gt;</returns>
        public async Task<IAddReplicaPropertyApiResponse> AddReplicaPropertyAsync(string collName, string shardName, string replicaName, string propName, AddReplicaPropertyRequestBody addReplicaPropertyRequestBody, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateAddReplicaProperty(collName, shardName, replicaName, propName, addReplicaPropertyRequestBody);

                FormatAddReplicaProperty(ref collName, ref shardName, ref replicaName, ref propName, addReplicaPropertyRequestBody);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BcollName%7D", Uri.EscapeDataString(collName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BshardName%7D", Uri.EscapeDataString(shardName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BreplicaName%7D", Uri.EscapeDataString(replicaName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BpropName%7D", Uri.EscapeDataString(propName.ToString()));

                    httpRequestMessageLocalVar.Content = (addReplicaPropertyRequestBody as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(addReplicaPropertyRequestBody, _jsonSerializerOptions));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "*/*"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Put;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<AddReplicaPropertyApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<AddReplicaPropertyApiResponse>();

                        AddReplicaPropertyApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterAddReplicaPropertyDefaultImplementation(apiResponseLocalVar, collName, shardName, replicaName, propName, addReplicaPropertyRequestBody);

                        Events.ExecuteOnAddReplicaProperty(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorAddReplicaPropertyDefaultImplementation(e, "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}", uriBuilderLocalVar.Path, collName, shardName, replicaName, propName, addReplicaPropertyRequestBody);
                Events.ExecuteOnErrorAddReplicaProperty(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="AddReplicaPropertyApiResponse"/>
        /// </summary>
        public partial class AddReplicaPropertyApiResponse : Org.OpenAPITools.Client.ApiResponse, IAddReplicaPropertyApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<AddReplicaPropertyApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="AddReplicaPropertyApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public AddReplicaPropertyApiResponse(ILogger<AddReplicaPropertyApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is the default response type
            /// </summary>
            /// <returns></returns>
            public bool IsDefault => true;

            /// <summary>
            /// Deserializes the response if the response is 0 Default
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.SolrJerseyResponse? Default()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsDefault
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.SolrJerseyResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 0 Default and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryDefault([NotNullWhen(true)]out Org.OpenAPITools.Model.SolrJerseyResponse? result)
            {
                result = null;

                try
                {
                    result = Default();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)0);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }

        partial void FormatDeleteReplicaProperty(ref string collName, ref string shardName, ref string replicaName, ref string propName);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        /// <returns></returns>
        private void ValidateDeleteReplicaProperty(string collName, string shardName, string replicaName, string propName)
        {
            if (collName == null)
                throw new ArgumentNullException(nameof(collName));

            if (shardName == null)
                throw new ArgumentNullException(nameof(shardName));

            if (replicaName == null)
                throw new ArgumentNullException(nameof(replicaName));

            if (propName == null)
                throw new ArgumentNullException(nameof(propName));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        private void AfterDeleteReplicaPropertyDefaultImplementation(IDeleteReplicaPropertyApiResponse apiResponseLocalVar, string collName, string shardName, string replicaName, string propName)
        {
            bool suppressDefaultLog = false;
            AfterDeleteReplicaProperty(ref suppressDefaultLog, apiResponseLocalVar, collName, shardName, replicaName, propName);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        partial void AfterDeleteReplicaProperty(ref bool suppressDefaultLog, IDeleteReplicaPropertyApiResponse apiResponseLocalVar, string collName, string shardName, string replicaName, string propName);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        private void OnErrorDeleteReplicaPropertyDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string collName, string shardName, string replicaName, string propName)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorDeleteReplicaProperty(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, collName, shardName, replicaName, propName);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="collName"></param>
        /// <param name="shardName"></param>
        /// <param name="replicaName"></param>
        /// <param name="propName"></param>
        partial void OnErrorDeleteReplicaProperty(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string collName, string shardName, string replicaName, string propName);

        /// <summary>
        /// Delete an existing replica property 
        /// </summary>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IDeleteReplicaPropertyApiResponse"/>&gt;</returns>
        public async Task<IDeleteReplicaPropertyApiResponse?> DeleteReplicaPropertyOrDefaultAsync(string collName, string shardName, string replicaName, string propName, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await DeleteReplicaPropertyAsync(collName, shardName, replicaName, propName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Delete an existing replica property 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="collName">The name of the collection the replica belongs to.</param>
        /// <param name="shardName">The name of the shard the replica belongs to.</param>
        /// <param name="replicaName">The replica, e.g., &#x60;core_node1&#x60;.</param>
        /// <param name="propName">The name of the property to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IDeleteReplicaPropertyApiResponse"/>&gt;</returns>
        public async Task<IDeleteReplicaPropertyApiResponse> DeleteReplicaPropertyAsync(string collName, string shardName, string replicaName, string propName, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateDeleteReplicaProperty(collName, shardName, replicaName, propName);

                FormatDeleteReplicaProperty(ref collName, ref shardName, ref replicaName, ref propName);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BcollName%7D", Uri.EscapeDataString(collName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BshardName%7D", Uri.EscapeDataString(shardName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BreplicaName%7D", Uri.EscapeDataString(replicaName.ToString()));
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BpropName%7D", Uri.EscapeDataString(propName.ToString()));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "*/*"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Delete;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<DeleteReplicaPropertyApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<DeleteReplicaPropertyApiResponse>();

                        DeleteReplicaPropertyApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterDeleteReplicaPropertyDefaultImplementation(apiResponseLocalVar, collName, shardName, replicaName, propName);

                        Events.ExecuteOnDeleteReplicaProperty(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorDeleteReplicaPropertyDefaultImplementation(e, "/collections/{collName}/shards/{shardName}/replicas/{replicaName}/properties/{propName}", uriBuilderLocalVar.Path, collName, shardName, replicaName, propName);
                Events.ExecuteOnErrorDeleteReplicaProperty(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="DeleteReplicaPropertyApiResponse"/>
        /// </summary>
        public partial class DeleteReplicaPropertyApiResponse : Org.OpenAPITools.Client.ApiResponse, IDeleteReplicaPropertyApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<DeleteReplicaPropertyApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="DeleteReplicaPropertyApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public DeleteReplicaPropertyApiResponse(ILogger<DeleteReplicaPropertyApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is the default response type
            /// </summary>
            /// <returns></returns>
            public bool IsDefault => true;

            /// <summary>
            /// Deserializes the response if the response is 0 Default
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.SolrJerseyResponse? Default()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsDefault
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.SolrJerseyResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 0 Default and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryDefault([NotNullWhen(true)]out Org.OpenAPITools.Model.SolrJerseyResponse? result)
            {
                result = null;

                try
                {
                    result = Default();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)0);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
