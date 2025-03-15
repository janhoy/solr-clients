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
    /// InstallShardDataRequestBody
    /// </summary>
    public partial class InstallShardDataRequestBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallShardDataRequestBody" /> class.
        /// </summary>
        /// <param name="location">location</param>
        /// <param name="repository">repository</param>
        /// <param name="async">async</param>
        [JsonConstructor]
        public InstallShardDataRequestBody(string location, Option<string?> repository = default, Option<string?> async = default)
        {
            Location = location;
            RepositoryOption = repository;
            AsyncOption = async;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Used to track the state of Repository
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> RepositoryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [JsonPropertyName("repository")]
        public string? Repository { get { return this.RepositoryOption; } set { this.RepositoryOption = new(value); } }

        /// <summary>
        /// Used to track the state of Async
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AsyncOption { get; private set; }

        /// <summary>
        /// Gets or Sets Async
        /// </summary>
        [JsonPropertyName("async")]
        public string? Async { get { return this.AsyncOption; } set { this.AsyncOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstallShardDataRequestBody {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
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
    /// A Json converter for type <see cref="InstallShardDataRequestBody" />
    /// </summary>
    public class InstallShardDataRequestBodyJsonConverter : JsonConverter<InstallShardDataRequestBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="InstallShardDataRequestBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override InstallShardDataRequestBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> location = default;
            Option<string?> repository = default;
            Option<string?> async = default;

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
                        case "location":
                            location = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "repository":
                            repository = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "async":
                            async = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!location.IsSet)
                throw new ArgumentException("Property is required for class InstallShardDataRequestBody.", nameof(location));

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class InstallShardDataRequestBody.");

            if (repository.IsSet && repository.Value == null)
                throw new ArgumentNullException(nameof(repository), "Property is not nullable for class InstallShardDataRequestBody.");

            if (async.IsSet && async.Value == null)
                throw new ArgumentNullException(nameof(async), "Property is not nullable for class InstallShardDataRequestBody.");

            return new InstallShardDataRequestBody(location.Value!, repository, async);
        }

        /// <summary>
        /// Serializes a <see cref="InstallShardDataRequestBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installShardDataRequestBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, InstallShardDataRequestBody installShardDataRequestBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, installShardDataRequestBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="InstallShardDataRequestBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="installShardDataRequestBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, InstallShardDataRequestBody installShardDataRequestBody, JsonSerializerOptions jsonSerializerOptions)
        {
            if (installShardDataRequestBody.Location == null)
                throw new ArgumentNullException(nameof(installShardDataRequestBody.Location), "Property is required for class InstallShardDataRequestBody.");

            if (installShardDataRequestBody.RepositoryOption.IsSet && installShardDataRequestBody.Repository == null)
                throw new ArgumentNullException(nameof(installShardDataRequestBody.Repository), "Property is required for class InstallShardDataRequestBody.");

            if (installShardDataRequestBody.AsyncOption.IsSet && installShardDataRequestBody.Async == null)
                throw new ArgumentNullException(nameof(installShardDataRequestBody.Async), "Property is required for class InstallShardDataRequestBody.");

            writer.WriteString("location", installShardDataRequestBody.Location);

            if (installShardDataRequestBody.RepositoryOption.IsSet)
                writer.WriteString("repository", installShardDataRequestBody.Repository);

            if (installShardDataRequestBody.AsyncOption.IsSet)
                writer.WriteString("async", installShardDataRequestBody.Async);
        }
    }
}
