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
    /// UnloadCoreRequestBodyModel
    /// </summary>
    [DataContract(Name = "UnloadCoreRequestBody")]
    public partial class UnloadCoreRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnloadCoreRequestBodyModel" /> class.
        /// </summary>
        /// <param name="deleteIndex">If true, will remove the index when unloading the core..</param>
        /// <param name="deleteDataDir">If true, removes the data directory and all sub-directories..</param>
        /// <param name="deleteInstanceDir">If true, removes everything related to the core, including the index directory, configuration files and other related files..</param>
        /// <param name="async">Request ID to track this action which will be processed asynchronously..</param>
        public UnloadCoreRequestBodyModel(bool deleteIndex = default(bool), bool deleteDataDir = default(bool), bool deleteInstanceDir = default(bool), string async = default(string))
        {
            this.DeleteIndex = deleteIndex;
            this.DeleteDataDir = deleteDataDir;
            this.DeleteInstanceDir = deleteInstanceDir;
            this.Async = async;
        }

        /// <summary>
        /// If true, will remove the index when unloading the core.
        /// </summary>
        /// <value>If true, will remove the index when unloading the core.</value>
        [DataMember(Name = "deleteIndex", EmitDefaultValue = true)]
        public bool DeleteIndex { get; set; }

        /// <summary>
        /// If true, removes the data directory and all sub-directories.
        /// </summary>
        /// <value>If true, removes the data directory and all sub-directories.</value>
        [DataMember(Name = "deleteDataDir", EmitDefaultValue = true)]
        public bool DeleteDataDir { get; set; }

        /// <summary>
        /// If true, removes everything related to the core, including the index directory, configuration files and other related files.
        /// </summary>
        /// <value>If true, removes everything related to the core, including the index directory, configuration files and other related files.</value>
        [DataMember(Name = "deleteInstanceDir", EmitDefaultValue = true)]
        public bool DeleteInstanceDir { get; set; }

        /// <summary>
        /// Request ID to track this action which will be processed asynchronously.
        /// </summary>
        /// <value>Request ID to track this action which will be processed asynchronously.</value>
        [DataMember(Name = "async", EmitDefaultValue = false)]
        public string Async { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnloadCoreRequestBodyModel {\n");
            sb.Append("  DeleteIndex: ").Append(DeleteIndex).Append("\n");
            sb.Append("  DeleteDataDir: ").Append(DeleteDataDir).Append("\n");
            sb.Append("  DeleteInstanceDir: ").Append(DeleteInstanceDir).Append("\n");
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
