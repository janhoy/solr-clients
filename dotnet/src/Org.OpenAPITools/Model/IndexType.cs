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
    /// Defines IndexType
    /// </summary>
    public enum IndexType
    {
        /// <summary>
        /// Enum Collections for value: collections
        /// </summary>
        Collections = 1,

        /// <summary>
        /// Enum Cores for value: cores
        /// </summary>
        Cores = 2
    }

    /// <summary>
    /// Converts <see cref="IndexType"/> to and from the JSON value
    /// </summary>
    public static class IndexTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="IndexType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IndexType FromString(string value)
        {
            if (value.Equals("collections"))
                return IndexType.Collections;

            if (value.Equals("cores"))
                return IndexType.Cores;

            throw new NotImplementedException($"Could not convert value to type IndexType: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="IndexType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IndexType? FromStringOrDefault(string value)
        {
            if (value.Equals("collections"))
                return IndexType.Collections;

            if (value.Equals("cores"))
                return IndexType.Cores;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="IndexType"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(IndexType value)
        {
            if (value == IndexType.Collections)
                return "collections";

            if (value == IndexType.Cores)
                return "cores";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="IndexType"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class IndexTypeJsonConverter : JsonConverter<IndexType>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override IndexType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            IndexType? result = rawValue == null
                ? null
                : IndexTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the IndexType to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="indexType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, IndexType indexType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(indexType.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="IndexType"/>
    /// </summary>
    public class IndexTypeNullableJsonConverter : JsonConverter<IndexType?>
    {
        /// <summary>
        /// Returns a IndexType from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override IndexType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            IndexType? result = rawValue == null
                ? null
                : IndexTypeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="indexType"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, IndexType? indexType, JsonSerializerOptions options)
        {
            writer.WriteStringValue(indexType?.ToString() ?? "null");
        }
    }
}
