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
    /// LogMessageInfo
    /// </summary>
    public partial class LogMessageInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessageInfo" /> class.
        /// </summary>
        /// <param name="found">found</param>
        /// <param name="levels">levels</param>
        /// <param name="buffer">buffer</param>
        /// <param name="threshold">threshold</param>
        /// <param name="since">since</param>
        /// <param name="last">last</param>
        [JsonConstructor]
        public LogMessageInfo(Option<bool?> found = default, Option<List<string>?> levels = default, Option<int?> buffer = default, Option<string?> threshold = default, Option<long?> since = default, Option<long?> last = default)
        {
            FoundOption = found;
            LevelsOption = levels;
            BufferOption = buffer;
            ThresholdOption = threshold;
            SinceOption = since;
            LastOption = last;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Found
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> FoundOption { get; private set; }

        /// <summary>
        /// Gets or Sets Found
        /// </summary>
        [JsonPropertyName("found")]
        public bool? Found { get { return this.FoundOption; } set { this.FoundOption = new(value); } }

        /// <summary>
        /// Used to track the state of Levels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> LevelsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Levels
        /// </summary>
        [JsonPropertyName("levels")]
        public List<string>? Levels { get { return this.LevelsOption; } set { this.LevelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Buffer
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> BufferOption { get; private set; }

        /// <summary>
        /// Gets or Sets Buffer
        /// </summary>
        [JsonPropertyName("buffer")]
        public int? Buffer { get { return this.BufferOption; } set { this.BufferOption = new(value); } }

        /// <summary>
        /// Used to track the state of Threshold
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ThresholdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [JsonPropertyName("threshold")]
        public string? Threshold { get { return this.ThresholdOption; } set { this.ThresholdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Since
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> SinceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Since
        /// </summary>
        [JsonPropertyName("since")]
        public long? Since { get { return this.SinceOption; } set { this.SinceOption = new(value); } }

        /// <summary>
        /// Used to track the state of Last
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> LastOption { get; private set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [JsonPropertyName("last")]
        public long? Last { get { return this.LastOption; } set { this.LastOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogMessageInfo {\n");
            sb.Append("  Found: ").Append(Found).Append("\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
            sb.Append("  Buffer: ").Append(Buffer).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
    /// A Json converter for type <see cref="LogMessageInfo" />
    /// </summary>
    public class LogMessageInfoJsonConverter : JsonConverter<LogMessageInfo>
    {
        /// <summary>
        /// Deserializes json to <see cref="LogMessageInfo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override LogMessageInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> found = default;
            Option<List<string>?> levels = default;
            Option<int?> buffer = default;
            Option<string?> threshold = default;
            Option<long?> since = default;
            Option<long?> last = default;

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
                        case "found":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                found = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "levels":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                levels = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "buffer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                buffer = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "threshold":
                            threshold = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "since":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                since = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "last":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                last = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (found.IsSet && found.Value == null)
                throw new ArgumentNullException(nameof(found), "Property is not nullable for class LogMessageInfo.");

            if (levels.IsSet && levels.Value == null)
                throw new ArgumentNullException(nameof(levels), "Property is not nullable for class LogMessageInfo.");

            if (buffer.IsSet && buffer.Value == null)
                throw new ArgumentNullException(nameof(buffer), "Property is not nullable for class LogMessageInfo.");

            if (threshold.IsSet && threshold.Value == null)
                throw new ArgumentNullException(nameof(threshold), "Property is not nullable for class LogMessageInfo.");

            if (since.IsSet && since.Value == null)
                throw new ArgumentNullException(nameof(since), "Property is not nullable for class LogMessageInfo.");

            if (last.IsSet && last.Value == null)
                throw new ArgumentNullException(nameof(last), "Property is not nullable for class LogMessageInfo.");

            return new LogMessageInfo(found, levels, buffer, threshold, since, last);
        }

        /// <summary>
        /// Serializes a <see cref="LogMessageInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="logMessageInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, LogMessageInfo logMessageInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, logMessageInfo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="LogMessageInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="logMessageInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, LogMessageInfo logMessageInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (logMessageInfo.LevelsOption.IsSet && logMessageInfo.Levels == null)
                throw new ArgumentNullException(nameof(logMessageInfo.Levels), "Property is required for class LogMessageInfo.");

            if (logMessageInfo.ThresholdOption.IsSet && logMessageInfo.Threshold == null)
                throw new ArgumentNullException(nameof(logMessageInfo.Threshold), "Property is required for class LogMessageInfo.");

            if (logMessageInfo.FoundOption.IsSet)
                writer.WriteBoolean("found", logMessageInfo.FoundOption.Value!.Value);

            if (logMessageInfo.LevelsOption.IsSet)
            {
                writer.WritePropertyName("levels");
                JsonSerializer.Serialize(writer, logMessageInfo.Levels, jsonSerializerOptions);
            }
            if (logMessageInfo.BufferOption.IsSet)
                writer.WriteNumber("buffer", logMessageInfo.BufferOption.Value!.Value);

            if (logMessageInfo.ThresholdOption.IsSet)
                writer.WriteString("threshold", logMessageInfo.Threshold);

            if (logMessageInfo.SinceOption.IsSet)
                writer.WriteNumber("since", logMessageInfo.SinceOption.Value!.Value);

            if (logMessageInfo.LastOption.IsSet)
                writer.WriteNumber("last", logMessageInfo.LastOption.Value!.Value);
        }
    }
}
