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
using FileParameter = SolrClient.Client.FileParameter;
using OpenAPIDateConverter = SolrClient.Client.OpenAPIDateConverter;

namespace SolrClient.Model
{
    /// <summary>
    /// SchemaListCopyFieldsResponseModel
    /// </summary>
    [DataContract(Name = "SchemaListCopyFieldsResponse")]
    public partial class SchemaListCopyFieldsResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaListCopyFieldsResponseModel" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="error">error.</param>
        /// <param name="copyFields">copyFields.</param>
        public SchemaListCopyFieldsResponseModel(ResponseHeaderModel responseHeader = default(ResponseHeaderModel), ErrorInfoModel error = default(ErrorInfoModel), Collection<Object> copyFields = default(Collection<Object>))
        {
            this.ResponseHeader = responseHeader;
            this.Error = error;
            this.CopyFields = copyFields;
        }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "responseHeader", EmitDefaultValue = false)]
        public ResponseHeaderModel ResponseHeader { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public ErrorInfoModel Error { get; set; }

        /// <summary>
        /// Gets or Sets CopyFields
        /// </summary>
        [DataMember(Name = "copyFields", EmitDefaultValue = false)]
        public Collection<Object> CopyFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchemaListCopyFieldsResponseModel {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  CopyFields: ").Append(CopyFields).Append("\n");
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
