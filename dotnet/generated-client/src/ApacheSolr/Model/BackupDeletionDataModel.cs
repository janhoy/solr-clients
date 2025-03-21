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
    /// BackupDeletionDataModel
    /// </summary>
    [DataContract(Name = "BackupDeletionData")]
    public partial class BackupDeletionDataModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupDeletionDataModel" /> class.
        /// </summary>
        /// <param name="startTime">startTime.</param>
        /// <param name="backupId">backupId.</param>
        /// <param name="size">size.</param>
        /// <param name="numFiles">numFiles.</param>
        public BackupDeletionDataModel(string startTime = default(string), int backupId = default(int), long size = default(long), int numFiles = default(int))
        {
            this.StartTime = startTime;
            this.BackupId = backupId;
            this.Size = size;
            this.NumFiles = numFiles;
        }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets BackupId
        /// </summary>
        [DataMember(Name = "backupId", EmitDefaultValue = false)]
        public int BackupId { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public long Size { get; set; }

        /// <summary>
        /// Gets or Sets NumFiles
        /// </summary>
        [DataMember(Name = "numFiles", EmitDefaultValue = false)]
        public int NumFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BackupDeletionDataModel {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  BackupId: ").Append(BackupId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  NumFiles: ").Append(NumFiles).Append("\n");
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
