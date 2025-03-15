/*
 * v2 API
 *
 * OpenAPI spec for Solr's v2 API endpoints
 *
 * The version of the OpenAPI document: 9.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        /// <summary>
        /// The formats used to deserialize the date
        /// </summary>
        public static string[] Formats { get; } = {
            "yyyy'-'MM'-'dd",
            "yyyyMMdd"

        };

        /// <summary>
        /// Returns a DateOnly from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType == JsonTokenType.Null)
                throw new NotSupportedException();

            string value = reader.GetString()!;

            foreach(string format in Formats)
                if (DateOnly.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out DateOnly result))
                    return result;

            throw new NotSupportedException();
        }

        /// <summary>
        /// Writes the DateOnly to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateOnlyValue"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DateOnly dateOnlyValue, JsonSerializerOptions options) =>
            writer.WriteStringValue(dateOnlyValue.ToString("yyyy'-'MM'-'dd", CultureInfo.InvariantCulture));
    }
}
