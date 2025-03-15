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
    /// CollectionBackupDetails
    /// </summary>
    public partial class CollectionBackupDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionBackupDetails" /> class.
        /// </summary>
        /// <param name="backupId">backupId</param>
        /// <param name="indexVersion">indexVersion</param>
        /// <param name="startTime">startTime</param>
        /// <param name="endTime">endTime</param>
        /// <param name="indexFileCount">indexFileCount</param>
        /// <param name="indexSizeMB">indexSizeMB</param>
        /// <param name="shardBackupIds">shardBackupIds</param>
        /// <param name="collectionAlias">collectionAlias</param>
        /// <param name="extraProperties">extraProperties</param>
        /// <param name="collectionConfigName">collectionConfigName</param>
        [JsonConstructor]
        public CollectionBackupDetails(Option<int?> backupId = default, Option<string?> indexVersion = default, Option<string?> startTime = default, Option<string?> endTime = default, Option<int?> indexFileCount = default, Option<double?> indexSizeMB = default, Option<Dictionary<string, string>?> shardBackupIds = default, Option<string?> collectionAlias = default, Option<Dictionary<string, string>?> extraProperties = default, Option<string?> collectionConfigName = default)
        {
            BackupIdOption = backupId;
            IndexVersionOption = indexVersion;
            StartTimeOption = startTime;
            EndTimeOption = endTime;
            IndexFileCountOption = indexFileCount;
            IndexSizeMBOption = indexSizeMB;
            ShardBackupIdsOption = shardBackupIds;
            CollectionAliasOption = collectionAlias;
            ExtraPropertiesOption = extraProperties;
            CollectionConfigNameOption = collectionConfigName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of BackupId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> BackupIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets BackupId
        /// </summary>
        [JsonPropertyName("backupId")]
        public int? BackupId { get { return this.BackupIdOption; } set { this.BackupIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of IndexVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IndexVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets IndexVersion
        /// </summary>
        [JsonPropertyName("indexVersion")]
        public string? IndexVersion { get { return this.IndexVersionOption; } set { this.IndexVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of StartTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StartTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public string? StartTime { get { return this.StartTimeOption; } set { this.StartTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EndTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public string? EndTime { get { return this.EndTimeOption; } set { this.EndTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of IndexFileCount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> IndexFileCountOption { get; private set; }

        /// <summary>
        /// Gets or Sets IndexFileCount
        /// </summary>
        [JsonPropertyName("indexFileCount")]
        public int? IndexFileCount { get { return this.IndexFileCountOption; } set { this.IndexFileCountOption = new(value); } }

        /// <summary>
        /// Used to track the state of IndexSizeMB
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> IndexSizeMBOption { get; private set; }

        /// <summary>
        /// Gets or Sets IndexSizeMB
        /// </summary>
        [JsonPropertyName("indexSizeMB")]
        public double? IndexSizeMB { get { return this.IndexSizeMBOption; } set { this.IndexSizeMBOption = new(value); } }

        /// <summary>
        /// Used to track the state of ShardBackupIds
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>?> ShardBackupIdsOption { get; private set; }

        /// <summary>
        /// Gets or Sets ShardBackupIds
        /// </summary>
        [JsonPropertyName("shardBackupIds")]
        public Dictionary<string, string>? ShardBackupIds { get { return this.ShardBackupIdsOption; } set { this.ShardBackupIdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of CollectionAlias
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CollectionAliasOption { get; private set; }

        /// <summary>
        /// Gets or Sets CollectionAlias
        /// </summary>
        [JsonPropertyName("collectionAlias")]
        public string? CollectionAlias { get { return this.CollectionAliasOption; } set { this.CollectionAliasOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExtraProperties
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, string>?> ExtraPropertiesOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExtraProperties
        /// </summary>
        [JsonPropertyName("extraProperties")]
        public Dictionary<string, string>? ExtraProperties { get { return this.ExtraPropertiesOption; } set { this.ExtraPropertiesOption = new(value); } }

        /// <summary>
        /// Used to track the state of CollectionConfigName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CollectionConfigNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets CollectionConfigName
        /// </summary>
        [JsonPropertyName("collection.configName")]
        public string? CollectionConfigName { get { return this.CollectionConfigNameOption; } set { this.CollectionConfigNameOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionBackupDetails {\n");
            sb.Append("  BackupId: ").Append(BackupId).Append("\n");
            sb.Append("  IndexVersion: ").Append(IndexVersion).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  IndexFileCount: ").Append(IndexFileCount).Append("\n");
            sb.Append("  IndexSizeMB: ").Append(IndexSizeMB).Append("\n");
            sb.Append("  ShardBackupIds: ").Append(ShardBackupIds).Append("\n");
            sb.Append("  CollectionAlias: ").Append(CollectionAlias).Append("\n");
            sb.Append("  ExtraProperties: ").Append(ExtraProperties).Append("\n");
            sb.Append("  CollectionConfigName: ").Append(CollectionConfigName).Append("\n");
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
    /// A Json converter for type <see cref="CollectionBackupDetails" />
    /// </summary>
    public class CollectionBackupDetailsJsonConverter : JsonConverter<CollectionBackupDetails>
    {
        /// <summary>
        /// Deserializes json to <see cref="CollectionBackupDetails" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CollectionBackupDetails Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> backupId = default;
            Option<string?> indexVersion = default;
            Option<string?> startTime = default;
            Option<string?> endTime = default;
            Option<int?> indexFileCount = default;
            Option<double?> indexSizeMB = default;
            Option<Dictionary<string, string>?> shardBackupIds = default;
            Option<string?> collectionAlias = default;
            Option<Dictionary<string, string>?> extraProperties = default;
            Option<string?> collectionConfigName = default;

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
                        case "backupId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                backupId = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "indexVersion":
                            indexVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "startTime":
                            startTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "endTime":
                            endTime = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "indexFileCount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                indexFileCount = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "indexSizeMB":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                indexSizeMB = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "shardBackupIds":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                shardBackupIds = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "collectionAlias":
                            collectionAlias = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "extraProperties":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                extraProperties = new Option<Dictionary<string, string>?>(JsonSerializer.Deserialize<Dictionary<string, string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "collection.configName":
                            collectionConfigName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (backupId.IsSet && backupId.Value == null)
                throw new ArgumentNullException(nameof(backupId), "Property is not nullable for class CollectionBackupDetails.");

            if (indexVersion.IsSet && indexVersion.Value == null)
                throw new ArgumentNullException(nameof(indexVersion), "Property is not nullable for class CollectionBackupDetails.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class CollectionBackupDetails.");

            if (endTime.IsSet && endTime.Value == null)
                throw new ArgumentNullException(nameof(endTime), "Property is not nullable for class CollectionBackupDetails.");

            if (indexFileCount.IsSet && indexFileCount.Value == null)
                throw new ArgumentNullException(nameof(indexFileCount), "Property is not nullable for class CollectionBackupDetails.");

            if (indexSizeMB.IsSet && indexSizeMB.Value == null)
                throw new ArgumentNullException(nameof(indexSizeMB), "Property is not nullable for class CollectionBackupDetails.");

            if (shardBackupIds.IsSet && shardBackupIds.Value == null)
                throw new ArgumentNullException(nameof(shardBackupIds), "Property is not nullable for class CollectionBackupDetails.");

            if (collectionAlias.IsSet && collectionAlias.Value == null)
                throw new ArgumentNullException(nameof(collectionAlias), "Property is not nullable for class CollectionBackupDetails.");

            if (extraProperties.IsSet && extraProperties.Value == null)
                throw new ArgumentNullException(nameof(extraProperties), "Property is not nullable for class CollectionBackupDetails.");

            if (collectionConfigName.IsSet && collectionConfigName.Value == null)
                throw new ArgumentNullException(nameof(collectionConfigName), "Property is not nullable for class CollectionBackupDetails.");

            return new CollectionBackupDetails(backupId, indexVersion, startTime, endTime, indexFileCount, indexSizeMB, shardBackupIds, collectionAlias, extraProperties, collectionConfigName);
        }

        /// <summary>
        /// Serializes a <see cref="CollectionBackupDetails" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="collectionBackupDetails"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CollectionBackupDetails collectionBackupDetails, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, collectionBackupDetails, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CollectionBackupDetails" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="collectionBackupDetails"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CollectionBackupDetails collectionBackupDetails, JsonSerializerOptions jsonSerializerOptions)
        {
            if (collectionBackupDetails.IndexVersionOption.IsSet && collectionBackupDetails.IndexVersion == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.IndexVersion), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.StartTimeOption.IsSet && collectionBackupDetails.StartTime == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.StartTime), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.EndTimeOption.IsSet && collectionBackupDetails.EndTime == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.EndTime), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.ShardBackupIdsOption.IsSet && collectionBackupDetails.ShardBackupIds == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.ShardBackupIds), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.CollectionAliasOption.IsSet && collectionBackupDetails.CollectionAlias == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.CollectionAlias), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.ExtraPropertiesOption.IsSet && collectionBackupDetails.ExtraProperties == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.ExtraProperties), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.CollectionConfigNameOption.IsSet && collectionBackupDetails.CollectionConfigName == null)
                throw new ArgumentNullException(nameof(collectionBackupDetails.CollectionConfigName), "Property is required for class CollectionBackupDetails.");

            if (collectionBackupDetails.BackupIdOption.IsSet)
                writer.WriteNumber("backupId", collectionBackupDetails.BackupIdOption.Value!.Value);

            if (collectionBackupDetails.IndexVersionOption.IsSet)
                writer.WriteString("indexVersion", collectionBackupDetails.IndexVersion);

            if (collectionBackupDetails.StartTimeOption.IsSet)
                writer.WriteString("startTime", collectionBackupDetails.StartTime);

            if (collectionBackupDetails.EndTimeOption.IsSet)
                writer.WriteString("endTime", collectionBackupDetails.EndTime);

            if (collectionBackupDetails.IndexFileCountOption.IsSet)
                writer.WriteNumber("indexFileCount", collectionBackupDetails.IndexFileCountOption.Value!.Value);

            if (collectionBackupDetails.IndexSizeMBOption.IsSet)
                writer.WriteNumber("indexSizeMB", collectionBackupDetails.IndexSizeMBOption.Value!.Value);

            if (collectionBackupDetails.ShardBackupIdsOption.IsSet)
            {
                writer.WritePropertyName("shardBackupIds");
                JsonSerializer.Serialize(writer, collectionBackupDetails.ShardBackupIds, jsonSerializerOptions);
            }
            if (collectionBackupDetails.CollectionAliasOption.IsSet)
                writer.WriteString("collectionAlias", collectionBackupDetails.CollectionAlias);

            if (collectionBackupDetails.ExtraPropertiesOption.IsSet)
            {
                writer.WritePropertyName("extraProperties");
                JsonSerializer.Serialize(writer, collectionBackupDetails.ExtraProperties, jsonSerializerOptions);
            }
            if (collectionBackupDetails.CollectionConfigNameOption.IsSet)
                writer.WriteString("collection.configName", collectionBackupDetails.CollectionConfigName);
        }
    }
}
