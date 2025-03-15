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
    /// SubResponseAccumulatingJerseyResponse
    /// </summary>
    public partial class SubResponseAccumulatingJerseyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubResponseAccumulatingJerseyResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader</param>
        /// <param name="error">error</param>
        /// <param name="requestid">requestid</param>
        /// <param name="success">success</param>
        /// <param name="failure">failure</param>
        /// <param name="warning">warning</param>
        [JsonConstructor]
        public SubResponseAccumulatingJerseyResponse(Option<ResponseHeader?> responseHeader = default, Option<ErrorInfo?> error = default, Option<string?> requestid = default, Option<Object?> success = default, Option<Object?> failure = default, Option<string?> warning = default)
        {
            ResponseHeaderOption = responseHeader;
            ErrorOption = error;
            RequestidOption = requestid;
            SuccessOption = success;
            FailureOption = failure;
            WarningOption = warning;
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
        /// Used to track the state of Requestid
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RequestidOption { get; private set; }

        /// <summary>
        /// Gets or Sets Requestid
        /// </summary>
        [JsonPropertyName("requestid")]
        public string? Requestid { get { return this.RequestidOption; } set { this.RequestidOption = new(value); } }

        /// <summary>
        /// Used to track the state of Success
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> SuccessOption { get; private set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [JsonPropertyName("success")]
        public Object? Success { get { return this.SuccessOption; } set { this.SuccessOption = new(value); } }

        /// <summary>
        /// Used to track the state of Failure
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> FailureOption { get; private set; }

        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [JsonPropertyName("failure")]
        public Object? Failure { get { return this.FailureOption; } set { this.FailureOption = new(value); } }

        /// <summary>
        /// Used to track the state of Warning
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> WarningOption { get; private set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [JsonPropertyName("warning")]
        public string? Warning { get { return this.WarningOption; } set { this.WarningOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubResponseAccumulatingJerseyResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Requestid: ").Append(Requestid).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
    /// A Json converter for type <see cref="SubResponseAccumulatingJerseyResponse" />
    /// </summary>
    public class SubResponseAccumulatingJerseyResponseJsonConverter : JsonConverter<SubResponseAccumulatingJerseyResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="SubResponseAccumulatingJerseyResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SubResponseAccumulatingJerseyResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ResponseHeader?> responseHeader = default;
            Option<ErrorInfo?> error = default;
            Option<string?> requestid = default;
            Option<Object?> success = default;
            Option<Object?> failure = default;
            Option<string?> warning = default;

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
                        case "requestid":
                            requestid = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "success":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                success = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "failure":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                failure = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "warning":
                            warning = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (responseHeader.IsSet && responseHeader.Value == null)
                throw new ArgumentNullException(nameof(responseHeader), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            if (requestid.IsSet && requestid.Value == null)
                throw new ArgumentNullException(nameof(requestid), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            if (failure.IsSet && failure.Value == null)
                throw new ArgumentNullException(nameof(failure), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            if (warning.IsSet && warning.Value == null)
                throw new ArgumentNullException(nameof(warning), "Property is not nullable for class SubResponseAccumulatingJerseyResponse.");

            return new SubResponseAccumulatingJerseyResponse(responseHeader, error, requestid, success, failure, warning);
        }

        /// <summary>
        /// Serializes a <see cref="SubResponseAccumulatingJerseyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="subResponseAccumulatingJerseyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SubResponseAccumulatingJerseyResponse subResponseAccumulatingJerseyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, subResponseAccumulatingJerseyResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SubResponseAccumulatingJerseyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="subResponseAccumulatingJerseyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SubResponseAccumulatingJerseyResponse subResponseAccumulatingJerseyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (subResponseAccumulatingJerseyResponse.ResponseHeaderOption.IsSet && subResponseAccumulatingJerseyResponse.ResponseHeader == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.ResponseHeader), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.ErrorOption.IsSet && subResponseAccumulatingJerseyResponse.Error == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.Error), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.RequestidOption.IsSet && subResponseAccumulatingJerseyResponse.Requestid == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.Requestid), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.SuccessOption.IsSet && subResponseAccumulatingJerseyResponse.Success == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.Success), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.FailureOption.IsSet && subResponseAccumulatingJerseyResponse.Failure == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.Failure), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.WarningOption.IsSet && subResponseAccumulatingJerseyResponse.Warning == null)
                throw new ArgumentNullException(nameof(subResponseAccumulatingJerseyResponse.Warning), "Property is required for class SubResponseAccumulatingJerseyResponse.");

            if (subResponseAccumulatingJerseyResponse.ResponseHeaderOption.IsSet)
            {
                writer.WritePropertyName("responseHeader");
                JsonSerializer.Serialize(writer, subResponseAccumulatingJerseyResponse.ResponseHeader, jsonSerializerOptions);
            }
            if (subResponseAccumulatingJerseyResponse.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, subResponseAccumulatingJerseyResponse.Error, jsonSerializerOptions);
            }
            if (subResponseAccumulatingJerseyResponse.RequestidOption.IsSet)
                writer.WriteString("requestid", subResponseAccumulatingJerseyResponse.Requestid);

            if (subResponseAccumulatingJerseyResponse.SuccessOption.IsSet)
            {
                writer.WritePropertyName("success");
                JsonSerializer.Serialize(writer, subResponseAccumulatingJerseyResponse.Success, jsonSerializerOptions);
            }
            if (subResponseAccumulatingJerseyResponse.FailureOption.IsSet)
            {
                writer.WritePropertyName("failure");
                JsonSerializer.Serialize(writer, subResponseAccumulatingJerseyResponse.Failure, jsonSerializerOptions);
            }
            if (subResponseAccumulatingJerseyResponse.WarningOption.IsSet)
                writer.WriteString("warning", subResponseAccumulatingJerseyResponse.Warning);
        }
    }
}
