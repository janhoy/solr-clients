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
    /// PurgeUnusedFilesRequestBodyModel
    /// </summary>
    [DataContract(Name = "PurgeUnusedFilesRequestBody")]
    public partial class PurgeUnusedFilesRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurgeUnusedFilesRequestBodyModel" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="repositoryName">repositoryName.</param>
        /// <param name="async">async.</param>
        public PurgeUnusedFilesRequestBodyModel(string location = default(string), string repositoryName = default(string), string async = default(string))
        {
            this.Location = location;
            this.RepositoryName = repositoryName;
            this.Async = async;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets RepositoryName
        /// </summary>
        [DataMember(Name = "repositoryName", EmitDefaultValue = false)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or Sets Async
        /// </summary>
        [DataMember(Name = "async", EmitDefaultValue = false)]
        public string Async { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurgeUnusedFilesRequestBodyModel {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RepositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
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
