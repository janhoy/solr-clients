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


namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// A wrapper for operation parameters which are not required
    /// </summary>
    public struct Option<TType>
    {
        /// <summary>
        /// The value to send to the server
        /// </summary>
        public TType Value { get; }

        /// <summary>
        /// When true the value will be sent to the server
        /// </summary>
        internal bool IsSet { get; }

        /// <summary>
        /// A wrapper for operation parameters which are not required
        /// </summary>
        /// <param name="value"></param>
        public Option(TType value)
        {
            IsSet = true;
            Value = value;
        }

        /// <summary>
        /// Implicitly converts this option to the contained type
        /// </summary>
        /// <param name="option"></param>
        public static implicit operator TType(Option<TType> option) => option.Value;

        /// <summary>
        /// Implicitly converts the provided value to an Option
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Option<TType>(TType value) => new Option<TType>(value);
    }
}