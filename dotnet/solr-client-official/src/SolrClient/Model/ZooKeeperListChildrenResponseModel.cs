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
    /// ZooKeeperListChildrenResponseModel
    /// </summary>
    [DataContract(Name = "ZooKeeperListChildrenResponse")]
    public partial class ZooKeeperListChildrenResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZooKeeperListChildrenResponseModel" /> class.
        /// </summary>
        /// <param name="unknownFields">unknownFields.</param>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="error">error.</param>
        /// <param name="wARNING">wARNING.</param>
        /// <param name="stat">stat.</param>
        public ZooKeeperListChildrenResponseModel(Dictionary<string, Dictionary<string, ZooKeeperStatModel>> unknownFields = default(Dictionary<string, Dictionary<string, ZooKeeperStatModel>>), ResponseHeaderModel responseHeader = default(ResponseHeaderModel), ErrorInfoModel error = default(ErrorInfoModel), string wARNING = default(string), ZooKeeperStatModel stat = default(ZooKeeperStatModel))
        {
            this.UnknownFields = unknownFields;
            this.ResponseHeader = responseHeader;
            this.Error = error;
            this.WARNING = wARNING;
            this.Stat = stat;
        }

        /// <summary>
        /// Gets or Sets UnknownFields
        /// </summary>
        [DataMember(Name = "unknownFields", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, ZooKeeperStatModel>> UnknownFields { get; set; }

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
        /// Gets or Sets WARNING
        /// </summary>
        [DataMember(Name = "WARNING", EmitDefaultValue = false)]
        public string WARNING { get; set; }

        /// <summary>
        /// Gets or Sets Stat
        /// </summary>
        [DataMember(Name = "stat", EmitDefaultValue = false)]
        public ZooKeeperStatModel Stat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZooKeeperListChildrenResponseModel {\n");
            sb.Append("  UnknownFields: ").Append(UnknownFields).Append("\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  WARNING: ").Append(WARNING).Append("\n");
            sb.Append("  Stat: ").Append(Stat).Append("\n");
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
