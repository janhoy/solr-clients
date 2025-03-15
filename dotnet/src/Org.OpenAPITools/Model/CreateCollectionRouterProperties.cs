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
    /// CreateCollectionRouterProperties
    /// </summary>
    public partial class CreateCollectionRouterProperties : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRouterProperties" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="field">field</param>
        [JsonConstructor]
        public CreateCollectionRouterProperties(Option<string?> name = default, Option<string?> field = default)
        {
            NameOption = name;
            FieldOption = field;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Field
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FieldOption { get; private set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [JsonPropertyName("field")]
        public string? Field { get { return this.FieldOption; } set { this.FieldOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCollectionRouterProperties {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
    /// A Json converter for type <see cref="CreateCollectionRouterProperties" />
    /// </summary>
    public class CreateCollectionRouterPropertiesJsonConverter : JsonConverter<CreateCollectionRouterProperties>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateCollectionRouterProperties" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateCollectionRouterProperties Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> field = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "field":
                            field = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class CreateCollectionRouterProperties.");

            if (field.IsSet && field.Value == null)
                throw new ArgumentNullException(nameof(field), "Property is not nullable for class CreateCollectionRouterProperties.");

            return new CreateCollectionRouterProperties(name, field);
        }

        /// <summary>
        /// Serializes a <see cref="CreateCollectionRouterProperties" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCollectionRouterProperties"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateCollectionRouterProperties createCollectionRouterProperties, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createCollectionRouterProperties, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateCollectionRouterProperties" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createCollectionRouterProperties"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateCollectionRouterProperties createCollectionRouterProperties, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createCollectionRouterProperties.NameOption.IsSet && createCollectionRouterProperties.Name == null)
                throw new ArgumentNullException(nameof(createCollectionRouterProperties.Name), "Property is required for class CreateCollectionRouterProperties.");

            if (createCollectionRouterProperties.FieldOption.IsSet && createCollectionRouterProperties.Field == null)
                throw new ArgumentNullException(nameof(createCollectionRouterProperties.Field), "Property is required for class CreateCollectionRouterProperties.");

            if (createCollectionRouterProperties.NameOption.IsSet)
                writer.WriteString("name", createCollectionRouterProperties.Name);

            if (createCollectionRouterProperties.FieldOption.IsSet)
                writer.WriteString("field", createCollectionRouterProperties.Field);
        }
    }
}
