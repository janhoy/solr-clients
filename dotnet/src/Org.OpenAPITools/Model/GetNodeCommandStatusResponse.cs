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
    /// GetNodeCommandStatusResponse
    /// </summary>
    public partial class GetNodeCommandStatusResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetNodeCommandStatusResponse" /> class.
        /// </summary>
        /// <param name="msg">msg</param>
        /// <param name="response">response</param>
        /// <param name="responseHeader">responseHeader</param>
        /// <param name="error">error</param>
        /// <param name="sTATUS">sTATUS</param>
        [JsonConstructor]
        public GetNodeCommandStatusResponse(Option<string?> msg = default, Option<Object?> response = default, Option<ResponseHeader?> responseHeader = default, Option<ErrorInfo?> error = default, Option<string?> sTATUS = default)
        {
            MsgOption = msg;
            ResponseOption = response;
            ResponseHeaderOption = responseHeader;
            ErrorOption = error;
            STATUSOption = sTATUS;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Msg
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MsgOption { get; private set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [JsonPropertyName("msg")]
        public string? Msg { get { return this.MsgOption; } set { this.MsgOption = new(value); } }

        /// <summary>
        /// Used to track the state of Response
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ResponseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [JsonPropertyName("response")]
        public Object? Response { get { return this.ResponseOption; } set { this.ResponseOption = new(value); } }

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
        /// Used to track the state of STATUS
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> STATUSOption { get; private set; }

        /// <summary>
        /// Gets or Sets STATUS
        /// </summary>
        [JsonPropertyName("STATUS")]
        public string? STATUS { get { return this.STATUSOption; } set { this.STATUSOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetNodeCommandStatusResponse {\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  STATUS: ").Append(STATUS).Append("\n");
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
    /// A Json converter for type <see cref="GetNodeCommandStatusResponse" />
    /// </summary>
    public class GetNodeCommandStatusResponseJsonConverter : JsonConverter<GetNodeCommandStatusResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetNodeCommandStatusResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetNodeCommandStatusResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> msg = default;
            Option<Object?> response = default;
            Option<ResponseHeader?> responseHeader = default;
            Option<ErrorInfo?> error = default;
            Option<string?> sTATUS = default;

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
                        case "msg":
                            msg = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "response":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                response = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "responseHeader":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                responseHeader = new Option<ResponseHeader?>(JsonSerializer.Deserialize<ResponseHeader>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "error":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                error = new Option<ErrorInfo?>(JsonSerializer.Deserialize<ErrorInfo>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "STATUS":
                            sTATUS = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (msg.IsSet && msg.Value == null)
                throw new ArgumentNullException(nameof(msg), "Property is not nullable for class GetNodeCommandStatusResponse.");

            if (response.IsSet && response.Value == null)
                throw new ArgumentNullException(nameof(response), "Property is not nullable for class GetNodeCommandStatusResponse.");

            if (responseHeader.IsSet && responseHeader.Value == null)
                throw new ArgumentNullException(nameof(responseHeader), "Property is not nullable for class GetNodeCommandStatusResponse.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class GetNodeCommandStatusResponse.");

            if (sTATUS.IsSet && sTATUS.Value == null)
                throw new ArgumentNullException(nameof(sTATUS), "Property is not nullable for class GetNodeCommandStatusResponse.");

            return new GetNodeCommandStatusResponse(msg, response, responseHeader, error, sTATUS);
        }

        /// <summary>
        /// Serializes a <see cref="GetNodeCommandStatusResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getNodeCommandStatusResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetNodeCommandStatusResponse getNodeCommandStatusResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getNodeCommandStatusResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetNodeCommandStatusResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getNodeCommandStatusResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetNodeCommandStatusResponse getNodeCommandStatusResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getNodeCommandStatusResponse.MsgOption.IsSet && getNodeCommandStatusResponse.Msg == null)
                throw new ArgumentNullException(nameof(getNodeCommandStatusResponse.Msg), "Property is required for class GetNodeCommandStatusResponse.");

            if (getNodeCommandStatusResponse.ResponseOption.IsSet && getNodeCommandStatusResponse.Response == null)
                throw new ArgumentNullException(nameof(getNodeCommandStatusResponse.Response), "Property is required for class GetNodeCommandStatusResponse.");

            if (getNodeCommandStatusResponse.ResponseHeaderOption.IsSet && getNodeCommandStatusResponse.ResponseHeader == null)
                throw new ArgumentNullException(nameof(getNodeCommandStatusResponse.ResponseHeader), "Property is required for class GetNodeCommandStatusResponse.");

            if (getNodeCommandStatusResponse.ErrorOption.IsSet && getNodeCommandStatusResponse.Error == null)
                throw new ArgumentNullException(nameof(getNodeCommandStatusResponse.Error), "Property is required for class GetNodeCommandStatusResponse.");

            if (getNodeCommandStatusResponse.STATUSOption.IsSet && getNodeCommandStatusResponse.STATUS == null)
                throw new ArgumentNullException(nameof(getNodeCommandStatusResponse.STATUS), "Property is required for class GetNodeCommandStatusResponse.");

            if (getNodeCommandStatusResponse.MsgOption.IsSet)
                writer.WriteString("msg", getNodeCommandStatusResponse.Msg);

            if (getNodeCommandStatusResponse.ResponseOption.IsSet)
            {
                writer.WritePropertyName("response");
                JsonSerializer.Serialize(writer, getNodeCommandStatusResponse.Response, jsonSerializerOptions);
            }
            if (getNodeCommandStatusResponse.ResponseHeaderOption.IsSet)
            {
                writer.WritePropertyName("responseHeader");
                JsonSerializer.Serialize(writer, getNodeCommandStatusResponse.ResponseHeader, jsonSerializerOptions);
            }
            if (getNodeCommandStatusResponse.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, getNodeCommandStatusResponse.Error, jsonSerializerOptions);
            }
            if (getNodeCommandStatusResponse.STATUSOption.IsSet)
                writer.WriteString("STATUS", getNodeCommandStatusResponse.STATUS);
        }
    }
}
