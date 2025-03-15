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
    /// FileListResponseException
    /// </summary>
    public partial class FileListResponseException : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileListResponseException" /> class.
        /// </summary>
        /// <param name="cause">cause</param>
        /// <param name="stackTrace">stackTrace</param>
        /// <param name="message">message</param>
        /// <param name="suppressed">suppressed</param>
        /// <param name="localizedMessage">localizedMessage</param>
        [JsonConstructor]
        public FileListResponseException(Option<FileListResponseExceptionCause?> cause = default, Option<List<FileListResponseExceptionCauseStackTraceInner>?> stackTrace = default, Option<string?> message = default, Option<List<FileListResponseExceptionCause>?> suppressed = default, Option<string?> localizedMessage = default)
        {
            CauseOption = cause;
            StackTraceOption = stackTrace;
            MessageOption = message;
            SuppressedOption = suppressed;
            LocalizedMessageOption = localizedMessage;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Cause
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<FileListResponseExceptionCause?> CauseOption { get; private set; }

        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [JsonPropertyName("cause")]
        public FileListResponseExceptionCause? Cause { get { return this.CauseOption; } set { this.CauseOption = new(value); } }

        /// <summary>
        /// Used to track the state of StackTrace
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<FileListResponseExceptionCauseStackTraceInner>?> StackTraceOption { get; private set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [JsonPropertyName("stackTrace")]
        public List<FileListResponseExceptionCauseStackTraceInner>? StackTrace { get { return this.StackTraceOption; } set { this.StackTraceOption = new(value); } }

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
        /// Used to track the state of Suppressed
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<FileListResponseExceptionCause>?> SuppressedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Suppressed
        /// </summary>
        [JsonPropertyName("suppressed")]
        public List<FileListResponseExceptionCause>? Suppressed { get { return this.SuppressedOption; } set { this.SuppressedOption = new(value); } }

        /// <summary>
        /// Used to track the state of LocalizedMessage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocalizedMessageOption { get; private set; }

        /// <summary>
        /// Gets or Sets LocalizedMessage
        /// </summary>
        [JsonPropertyName("localizedMessage")]
        public string? LocalizedMessage { get { return this.LocalizedMessageOption; } set { this.LocalizedMessageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileListResponseException {\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
            sb.Append("  LocalizedMessage: ").Append(LocalizedMessage).Append("\n");
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
    /// A Json converter for type <see cref="FileListResponseException" />
    /// </summary>
    public class FileListResponseExceptionJsonConverter : JsonConverter<FileListResponseException>
    {
        /// <summary>
        /// Deserializes json to <see cref="FileListResponseException" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FileListResponseException Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<FileListResponseExceptionCause?> cause = default;
            Option<List<FileListResponseExceptionCauseStackTraceInner>?> stackTrace = default;
            Option<string?> message = default;
            Option<List<FileListResponseExceptionCause>?> suppressed = default;
            Option<string?> localizedMessage = default;

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
                        case "cause":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                cause = new Option<FileListResponseExceptionCause?>(JsonSerializer.Deserialize<FileListResponseExceptionCause>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "stackTrace":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stackTrace = new Option<List<FileListResponseExceptionCauseStackTraceInner>?>(JsonSerializer.Deserialize<List<FileListResponseExceptionCauseStackTraceInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "suppressed":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                suppressed = new Option<List<FileListResponseExceptionCause>?>(JsonSerializer.Deserialize<List<FileListResponseExceptionCause>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "localizedMessage":
                            localizedMessage = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (cause.IsSet && cause.Value == null)
                throw new ArgumentNullException(nameof(cause), "Property is not nullable for class FileListResponseException.");

            if (stackTrace.IsSet && stackTrace.Value == null)
                throw new ArgumentNullException(nameof(stackTrace), "Property is not nullable for class FileListResponseException.");

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class FileListResponseException.");

            if (suppressed.IsSet && suppressed.Value == null)
                throw new ArgumentNullException(nameof(suppressed), "Property is not nullable for class FileListResponseException.");

            if (localizedMessage.IsSet && localizedMessage.Value == null)
                throw new ArgumentNullException(nameof(localizedMessage), "Property is not nullable for class FileListResponseException.");

            return new FileListResponseException(cause, stackTrace, message, suppressed, localizedMessage);
        }

        /// <summary>
        /// Serializes a <see cref="FileListResponseException" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fileListResponseException"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FileListResponseException fileListResponseException, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, fileListResponseException, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FileListResponseException" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fileListResponseException"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FileListResponseException fileListResponseException, JsonSerializerOptions jsonSerializerOptions)
        {
            if (fileListResponseException.CauseOption.IsSet && fileListResponseException.Cause == null)
                throw new ArgumentNullException(nameof(fileListResponseException.Cause), "Property is required for class FileListResponseException.");

            if (fileListResponseException.StackTraceOption.IsSet && fileListResponseException.StackTrace == null)
                throw new ArgumentNullException(nameof(fileListResponseException.StackTrace), "Property is required for class FileListResponseException.");

            if (fileListResponseException.MessageOption.IsSet && fileListResponseException.Message == null)
                throw new ArgumentNullException(nameof(fileListResponseException.Message), "Property is required for class FileListResponseException.");

            if (fileListResponseException.SuppressedOption.IsSet && fileListResponseException.Suppressed == null)
                throw new ArgumentNullException(nameof(fileListResponseException.Suppressed), "Property is required for class FileListResponseException.");

            if (fileListResponseException.LocalizedMessageOption.IsSet && fileListResponseException.LocalizedMessage == null)
                throw new ArgumentNullException(nameof(fileListResponseException.LocalizedMessage), "Property is required for class FileListResponseException.");

            if (fileListResponseException.CauseOption.IsSet)
            {
                writer.WritePropertyName("cause");
                JsonSerializer.Serialize(writer, fileListResponseException.Cause, jsonSerializerOptions);
            }
            if (fileListResponseException.StackTraceOption.IsSet)
            {
                writer.WritePropertyName("stackTrace");
                JsonSerializer.Serialize(writer, fileListResponseException.StackTrace, jsonSerializerOptions);
            }
            if (fileListResponseException.MessageOption.IsSet)
                writer.WriteString("message", fileListResponseException.Message);

            if (fileListResponseException.SuppressedOption.IsSet)
            {
                writer.WritePropertyName("suppressed");
                JsonSerializer.Serialize(writer, fileListResponseException.Suppressed, jsonSerializerOptions);
            }
            if (fileListResponseException.LocalizedMessageOption.IsSet)
                writer.WriteString("localizedMessage", fileListResponseException.LocalizedMessage);
        }
    }
}
