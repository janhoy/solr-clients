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
    public interface IZookeeperReadApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ZookeeperReadApiEvents Events { get; }

        /// <summary>
        /// List and stat all children of a specified ZooKeeper node
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="zkPath">The path of the ZooKeeper node to stat and list children of</param>
        /// <param name="children">Controls whether stat information for child nodes is included in the response. &#39;true&#39; by default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListNodesApiResponse"/>&gt;</returns>
        Task<IListNodesApiResponse> ListNodesAsync(string zkPath, Option<bool> children = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// List and stat all children of a specified ZooKeeper node
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="zkPath">The path of the ZooKeeper node to stat and list children of</param>
        /// <param name="children">Controls whether stat information for child nodes is included in the response. &#39;true&#39; by default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListNodesApiResponse"/>?&gt;</returns>
        Task<IListNodesApiResponse?> ListNodesOrDefaultAsync(string zkPath, Option<bool> children = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the data stored in a specified ZooKeeper node
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="zkPath">The path of the node to read from ZooKeeper</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadNodeApiResponse"/>&gt;</returns>
        Task<IReadNodeApiResponse> ReadNodeAsync(string zkPath, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Return the data stored in a specified ZooKeeper node
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="zkPath">The path of the node to read from ZooKeeper</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadNodeApiResponse"/>?&gt;</returns>
        Task<IReadNodeApiResponse?> ReadNodeOrDefaultAsync(string zkPath, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IListNodesApiResponse"/>
    /// </summary>
    public interface IListNodesApiResponse : Org.OpenAPITools.Client.IApiResponse, IDefault<Org.OpenAPITools.Model.ZooKeeperListChildrenResponse?>
    {
        /// <summary>
        /// Returns true if the response is the default response type
        /// </summary>
        /// <returns></returns>
        bool IsDefault { get; }
    }

    /// <summary>
    /// The <see cref="IReadNodeApiResponse"/>
    /// </summary>
    public interface IReadNodeApiResponse : Org.OpenAPITools.Client.IApiResponse, IDefault<Org.OpenAPITools.Model.ZooKeeperFileResponse?>
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
    public class ZookeeperReadApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnListNodes;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorListNodes;

        internal void ExecuteOnListNodes(ZookeeperReadApi.ListNodesApiResponse apiResponse)
        {
            OnListNodes?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorListNodes(Exception exception)
        {
            OnErrorListNodes?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnReadNode;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorReadNode;

        internal void ExecuteOnReadNode(ZookeeperReadApi.ReadNodeApiResponse apiResponse)
        {
            OnReadNode?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorReadNode(Exception exception)
        {
            OnErrorReadNode?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ZookeeperReadApi : IZookeeperReadApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ZookeeperReadApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ZookeeperReadApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZookeeperReadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZookeeperReadApi(ILogger<ZookeeperReadApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ZookeeperReadApiEvents zookeeperReadApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ZookeeperReadApi>();
            HttpClient = httpClient;
            Events = zookeeperReadApiEvents;
        }

        partial void FormatListNodes(ref string zkPath, ref Option<bool> children);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="zkPath"></param>
        /// <returns></returns>
        private void ValidateListNodes(string zkPath)
        {
            if (zkPath == null)
                throw new ArgumentNullException(nameof(zkPath));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="zkPath"></param>
        /// <param name="children"></param>
        private void AfterListNodesDefaultImplementation(IListNodesApiResponse apiResponseLocalVar, string zkPath, Option<bool> children)
        {
            bool suppressDefaultLog = false;
            AfterListNodes(ref suppressDefaultLog, apiResponseLocalVar, zkPath, children);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="zkPath"></param>
        /// <param name="children"></param>
        partial void AfterListNodes(ref bool suppressDefaultLog, IListNodesApiResponse apiResponseLocalVar, string zkPath, Option<bool> children);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="zkPath"></param>
        /// <param name="children"></param>
        private void OnErrorListNodesDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string zkPath, Option<bool> children)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorListNodes(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, zkPath, children);
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
        /// <param name="zkPath"></param>
        /// <param name="children"></param>
        partial void OnErrorListNodes(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string zkPath, Option<bool> children);

        /// <summary>
        /// List and stat all children of a specified ZooKeeper node 
        /// </summary>
        /// <param name="zkPath">The path of the ZooKeeper node to stat and list children of</param>
        /// <param name="children">Controls whether stat information for child nodes is included in the response. &#39;true&#39; by default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListNodesApiResponse"/>&gt;</returns>
        public async Task<IListNodesApiResponse?> ListNodesOrDefaultAsync(string zkPath, Option<bool> children = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ListNodesAsync(zkPath, children, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// List and stat all children of a specified ZooKeeper node 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="zkPath">The path of the ZooKeeper node to stat and list children of</param>
        /// <param name="children">Controls whether stat information for child nodes is included in the response. &#39;true&#39; by default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IListNodesApiResponse"/>&gt;</returns>
        public async Task<IListNodesApiResponse> ListNodesAsync(string zkPath, Option<bool> children = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateListNodes(zkPath);

                FormatListNodes(ref zkPath, ref children);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/cluster/zookeeper/children{zkPath}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BzkPath%7D", Uri.EscapeDataString(zkPath.ToString()));

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (children.IsSet)
                        parseQueryStringLocalVar["children"] = ClientUtils.ParameterToString(children.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json",
                        "application/javabin"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ListNodesApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ListNodesApiResponse>();

                        ListNodesApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/cluster/zookeeper/children{zkPath}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterListNodesDefaultImplementation(apiResponseLocalVar, zkPath, children);

                        Events.ExecuteOnListNodes(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorListNodesDefaultImplementation(e, "/cluster/zookeeper/children{zkPath}", uriBuilderLocalVar.Path, zkPath, children);
                Events.ExecuteOnErrorListNodes(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ListNodesApiResponse"/>
        /// </summary>
        public partial class ListNodesApiResponse : Org.OpenAPITools.Client.ApiResponse, IListNodesApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ListNodesApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ListNodesApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ListNodesApiResponse(ILogger<ListNodesApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public Org.OpenAPITools.Model.ZooKeeperListChildrenResponse? Default()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsDefault
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.ZooKeeperListChildrenResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 0 Default and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryDefault([NotNullWhen(true)]out Org.OpenAPITools.Model.ZooKeeperListChildrenResponse? result)
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

        partial void FormatReadNode(ref string zkPath);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="zkPath"></param>
        /// <returns></returns>
        private void ValidateReadNode(string zkPath)
        {
            if (zkPath == null)
                throw new ArgumentNullException(nameof(zkPath));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="zkPath"></param>
        private void AfterReadNodeDefaultImplementation(IReadNodeApiResponse apiResponseLocalVar, string zkPath)
        {
            bool suppressDefaultLog = false;
            AfterReadNode(ref suppressDefaultLog, apiResponseLocalVar, zkPath);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="zkPath"></param>
        partial void AfterReadNode(ref bool suppressDefaultLog, IReadNodeApiResponse apiResponseLocalVar, string zkPath);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="zkPath"></param>
        private void OnErrorReadNodeDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string zkPath)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorReadNode(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, zkPath);
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
        /// <param name="zkPath"></param>
        partial void OnErrorReadNode(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string zkPath);

        /// <summary>
        /// Return the data stored in a specified ZooKeeper node 
        /// </summary>
        /// <param name="zkPath">The path of the node to read from ZooKeeper</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadNodeApiResponse"/>&gt;</returns>
        public async Task<IReadNodeApiResponse?> ReadNodeOrDefaultAsync(string zkPath, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ReadNodeAsync(zkPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Return the data stored in a specified ZooKeeper node 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="zkPath">The path of the node to read from ZooKeeper</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IReadNodeApiResponse"/>&gt;</returns>
        public async Task<IReadNodeApiResponse> ReadNodeAsync(string zkPath, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateReadNode(zkPath);

                FormatReadNode(ref zkPath);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/cluster/zookeeper/data{zkPath}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BzkPath%7D", Uri.EscapeDataString(zkPath.ToString()));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/vnd.apache.solr.raw",
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ReadNodeApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ReadNodeApiResponse>();

                        ReadNodeApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/cluster/zookeeper/data{zkPath}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterReadNodeDefaultImplementation(apiResponseLocalVar, zkPath);

                        Events.ExecuteOnReadNode(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorReadNodeDefaultImplementation(e, "/cluster/zookeeper/data{zkPath}", uriBuilderLocalVar.Path, zkPath);
                Events.ExecuteOnErrorReadNode(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ReadNodeApiResponse"/>
        /// </summary>
        public partial class ReadNodeApiResponse : Org.OpenAPITools.Client.ApiResponse, IReadNodeApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ReadNodeApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ReadNodeApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ReadNodeApiResponse(ILogger<ReadNodeApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public Org.OpenAPITools.Model.ZooKeeperFileResponse? Default()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsDefault
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.ZooKeeperFileResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 0 Default and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryDefault([NotNullWhen(true)]out Org.OpenAPITools.Model.ZooKeeperFileResponse? result)
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
