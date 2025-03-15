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
    /// DeleteCollectionSnapshotResponseModel
    /// </summary>
    [DataContract(Name = "DeleteCollectionSnapshotResponse")]
    public partial class DeleteCollectionSnapshotResponseModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCollectionSnapshotResponseModel" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="error">error.</param>
        /// <param name="requestid">requestid.</param>
        /// <param name="collection">The name of the collection..</param>
        /// <param name="snapshot">The name of the snapshot to be deleted..</param>
        /// <param name="followAliases">A flag that treats the collName parameter as a collection alias..</param>
        public DeleteCollectionSnapshotResponseModel(ResponseHeaderModel responseHeader = default(ResponseHeaderModel), ErrorInfoModel error = default(ErrorInfoModel), string requestid = default(string), string collection = default(string), string snapshot = default(string), bool followAliases = default(bool))
        {
            this.ResponseHeader = responseHeader;
            this.Error = error;
            this.Requestid = requestid;
            this.Collection = collection;
            this.Snapshot = snapshot;
            this.FollowAliases = followAliases;
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
        /// Gets or Sets Requestid
        /// </summary>
        [DataMember(Name = "requestid", EmitDefaultValue = false)]
        public string Requestid { get; set; }

        /// <summary>
        /// The name of the collection.
        /// </summary>
        /// <value>The name of the collection.</value>
        [DataMember(Name = "collection", EmitDefaultValue = false)]
        public string Collection { get; set; }

        /// <summary>
        /// The name of the snapshot to be deleted.
        /// </summary>
        /// <value>The name of the snapshot to be deleted.</value>
        [DataMember(Name = "snapshot", EmitDefaultValue = false)]
        public string Snapshot { get; set; }

        /// <summary>
        /// A flag that treats the collName parameter as a collection alias.
        /// </summary>
        /// <value>A flag that treats the collName parameter as a collection alias.</value>
        [DataMember(Name = "followAliases", EmitDefaultValue = true)]
        public bool FollowAliases { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteCollectionSnapshotResponseModel {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Requestid: ").Append(Requestid).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Snapshot: ").Append(Snapshot).Append("\n");
            sb.Append("  FollowAliases: ").Append(FollowAliases).Append("\n");
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
