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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ReplicationBackupResponse
    /// </summary>
    public partial class ReplicationBackupResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationBackupResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader</param>
        /// <param name="error">error</param>
        /// <param name="result">result</param>
        /// <param name="status">status</param>
        /// <param name="message">message</param>
        /// <param name="exception">exception</param>
        [JsonConstructor]
        public ReplicationBackupResponse(Option<ResponseHeader?> responseHeader = default, Option<ErrorInfo?> error = default, Option<Object?> result = default, Option<string?> status = default, Option<string?> message = default, Option<FileListResponseException?> exception = default)
        {
            ResponseHeaderOption = responseHeader;
            ErrorOption = error;
            ResultOption = result;
            StatusOption = status;
            MessageOption = message;
            ExceptionOption = exception;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ResponseHeader
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ResponseHeader?> ResponseHeaderOption { get; private set; }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [JsonPropertyName("responseHeader")]
        public ResponseHeader? ResponseHeader { get { return this.ResponseHeaderOption; } set { this.ResponseHeaderOption = new(value); } }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ErrorInfo?> ErrorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [JsonPropertyName("error")]
        public ErrorInfo? Error { get { return this.ErrorOption; } set { this.ErrorOption = new(value); } }

        /// <summary>
        /// Used to track the state of Result
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ResultOption { get; private set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [JsonPropertyName("result")]
        public Object? Result { get { return this.ResultOption; } set { this.ResultOption = new(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get { return this.MessageOption; } set { this.MessageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Exception
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FileListResponseException?> ExceptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [JsonPropertyName("exception")]
        public FileListResponseException? Exception { get { return this.ExceptionOption; } set { this.ExceptionOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplicationBackupResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ReplicationBackupResponse" />
    /// </summary>
    public class ReplicationBackupResponseJsonConverter : JsonConverter<ReplicationBackupResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ReplicationBackupResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ReplicationBackupResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ResponseHeader?> responseHeader = default;
            Option<ErrorInfo?> error = default;
            Option<Object?> result = default;
            Option<string?> status = default;
            Option<string?> message = default;
            Option<FileListResponseException?> exception = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "responseHeader":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                responseHeader = new Option<ResponseHeader?>(JsonSerializer.Deserialize<ResponseHeader>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "error":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                error = new Option<ErrorInfo?>(JsonSerializer.Deserialize<ErrorInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "result":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                result = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "status":
                            status = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "exception":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                exception = new Option<FileListResponseException?>(JsonSerializer.Deserialize<FileListResponseException>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (responseHeader.IsSet && responseHeader.Value == null)
                throw new ArgumentNullException(nameof(responseHeader), "Property is not nullable for class ReplicationBackupResponse.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class ReplicationBackupResponse.");

            if (result.IsSet && result.Value == null)
                throw new ArgumentNullException(nameof(result), "Property is not nullable for class ReplicationBackupResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class ReplicationBackupResponse.");

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class ReplicationBackupResponse.");

            if (exception.IsSet && exception.Value == null)
                throw new ArgumentNullException(nameof(exception), "Property is not nullable for class ReplicationBackupResponse.");

            return new ReplicationBackupResponse(responseHeader, error, result, status, message, exception);
        }

        /// <summary>
        /// Serializes a <see cref="ReplicationBackupResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="replicationBackupResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ReplicationBackupResponse replicationBackupResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, replicationBackupResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ReplicationBackupResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="replicationBackupResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ReplicationBackupResponse replicationBackupResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (replicationBackupResponse.ResponseHeaderOption.IsSet && replicationBackupResponse.ResponseHeader == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.ResponseHeader), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.ErrorOption.IsSet && replicationBackupResponse.Error == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.Error), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.ResultOption.IsSet && replicationBackupResponse.Result == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.Result), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.StatusOption.IsSet && replicationBackupResponse.Status == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.Status), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.MessageOption.IsSet && replicationBackupResponse.Message == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.Message), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.ExceptionOption.IsSet && replicationBackupResponse.Exception == null)
                throw new ArgumentNullException(nameof(replicationBackupResponse.Exception), "Property is required for class ReplicationBackupResponse.");

            if (replicationBackupResponse.ResponseHeaderOption.IsSet)
            {
                writer.WritePropertyName("responseHeader");
                JsonSerializer.Serialize(writer, replicationBackupResponse.ResponseHeader, jsonSerializerOptions);
            }
            if (replicationBackupResponse.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, replicationBackupResponse.Error, jsonSerializerOptions);
            }
            if (replicationBackupResponse.ResultOption.IsSet)
            {
                writer.WritePropertyName("result");
                JsonSerializer.Serialize(writer, replicationBackupResponse.Result, jsonSerializerOptions);
            }
            if (replicationBackupResponse.StatusOption.IsSet)
                writer.WriteString("status", replicationBackupResponse.Status);

            if (replicationBackupResponse.MessageOption.IsSet)
                writer.WriteString("message", replicationBackupResponse.Message);

            if (replicationBackupResponse.ExceptionOption.IsSet)
            {
                writer.WritePropertyName("exception");
                JsonSerializer.Serialize(writer, replicationBackupResponse.Exception, jsonSerializerOptions);
            }
        }
    }
}
