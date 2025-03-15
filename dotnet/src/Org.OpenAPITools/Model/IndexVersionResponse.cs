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
    /// IndexVersionResponse
    /// </summary>
    public partial class IndexVersionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexVersionResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader</param>
        /// <param name="error">error</param>
        /// <param name="indexversion">indexversion</param>
        /// <param name="generation">generation</param>
        /// <param name="status">status</param>
        [JsonConstructor]
        public IndexVersionResponse(Option<ResponseHeader?> responseHeader = default, Option<ErrorInfo?> error = default, Option<long?> indexversion = default, Option<long?> generation = default, Option<string?> status = default)
        {
            ResponseHeaderOption = responseHeader;
            ErrorOption = error;
            IndexversionOption = indexversion;
            GenerationOption = generation;
            StatusOption = status;
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
        /// Used to track the state of Indexversion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IndexversionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Indexversion
        /// </summary>
        [JsonPropertyName("indexversion")]
        public long? Indexversion { get { return this.IndexversionOption; } set { this.IndexversionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Generation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> GenerationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Generation
        /// </summary>
        [JsonPropertyName("generation")]
        public long? Generation { get { return this.GenerationOption; } set { this.GenerationOption = new(value); } }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndexVersionResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Indexversion: ").Append(Indexversion).Append("\n");
            sb.Append("  Generation: ").Append(Generation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
    /// A Json converter for type <see cref="IndexVersionResponse" />
    /// </summary>
    public class IndexVersionResponseJsonConverter : JsonConverter<IndexVersionResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="IndexVersionResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override IndexVersionResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ResponseHeader?> responseHeader = default;
            Option<ErrorInfo?> error = default;
            Option<long?> indexversion = default;
            Option<long?> generation = default;
            Option<string?> status = default;

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
                        case "indexversion":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                indexversion = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "generation":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                generation = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "status":
                            status = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (responseHeader.IsSet && responseHeader.Value == null)
                throw new ArgumentNullException(nameof(responseHeader), "Property is not nullable for class IndexVersionResponse.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class IndexVersionResponse.");

            if (indexversion.IsSet && indexversion.Value == null)
                throw new ArgumentNullException(nameof(indexversion), "Property is not nullable for class IndexVersionResponse.");

            if (generation.IsSet && generation.Value == null)
                throw new ArgumentNullException(nameof(generation), "Property is not nullable for class IndexVersionResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class IndexVersionResponse.");

            return new IndexVersionResponse(responseHeader, error, indexversion, generation, status);
        }

        /// <summary>
        /// Serializes a <see cref="IndexVersionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="indexVersionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, IndexVersionResponse indexVersionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, indexVersionResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="IndexVersionResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="indexVersionResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, IndexVersionResponse indexVersionResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (indexVersionResponse.ResponseHeaderOption.IsSet && indexVersionResponse.ResponseHeader == null)
                throw new ArgumentNullException(nameof(indexVersionResponse.ResponseHeader), "Property is required for class IndexVersionResponse.");

            if (indexVersionResponse.ErrorOption.IsSet && indexVersionResponse.Error == null)
                throw new ArgumentNullException(nameof(indexVersionResponse.Error), "Property is required for class IndexVersionResponse.");

            if (indexVersionResponse.StatusOption.IsSet && indexVersionResponse.Status == null)
                throw new ArgumentNullException(nameof(indexVersionResponse.Status), "Property is required for class IndexVersionResponse.");

            if (indexVersionResponse.ResponseHeaderOption.IsSet)
            {
                writer.WritePropertyName("responseHeader");
                JsonSerializer.Serialize(writer, indexVersionResponse.ResponseHeader, jsonSerializerOptions);
            }
            if (indexVersionResponse.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, indexVersionResponse.Error, jsonSerializerOptions);
            }
            if (indexVersionResponse.IndexversionOption.IsSet)
                writer.WriteNumber("indexversion", indexVersionResponse.IndexversionOption.Value!.Value);

            if (indexVersionResponse.GenerationOption.IsSet)
                writer.WriteNumber("generation", indexVersionResponse.GenerationOption.Value!.Value);

            if (indexVersionResponse.StatusOption.IsSet)
                writer.WriteString("status", indexVersionResponse.Status);
        }
    }
}
