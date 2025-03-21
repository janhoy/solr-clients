/*
 * v2 API
 *
 * OpenAPI spec for Solr's v2 API endpoints
 *
 * The version of the OpenAPI document: 9.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ApacheSolr.Client.FileParameter;
using OpenAPIDateConverter = ApacheSolr.Client.OpenAPIDateConverter;

namespace ApacheSolr.Model
{
    /// <summary>
    /// UpdateAliasPropertyRequestBodyModel
    /// </summary>
    [DataContract(Name = "UpdateAliasPropertyRequestBody")]
    public partial class UpdateAliasPropertyRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAliasPropertyRequestBodyModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAliasPropertyRequestBodyModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAliasPropertyRequestBodyModel" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        public UpdateAliasPropertyRequestBodyModel(Object value = default(Object))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for UpdateAliasPropertyRequestBodyModel and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateAliasPropertyRequestBodyModel {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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

}
