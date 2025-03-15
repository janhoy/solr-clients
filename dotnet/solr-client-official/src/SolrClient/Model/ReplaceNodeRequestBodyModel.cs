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
    /// ReplaceNodeRequestBodyModel
    /// </summary>
    [DataContract(Name = "ReplaceNodeRequestBody")]
    public partial class ReplaceNodeRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceNodeRequestBodyModel" /> class.
        /// </summary>
        /// <param name="targetNodeName">The target node where replicas will be copied. If this parameter is not provided, Solr will identify nodes automatically based on policies or number of cores in each node..</param>
        /// <param name="waitForFinalState">If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replica is online and active..</param>
        /// <param name="async">Request ID to track this action which will be processed asynchronously..</param>
        public ReplaceNodeRequestBodyModel(string targetNodeName = default(string), bool waitForFinalState = default(bool), string async = default(string))
        {
            this.TargetNodeName = targetNodeName;
            this.WaitForFinalState = waitForFinalState;
            this.Async = async;
        }

        /// <summary>
        /// The target node where replicas will be copied. If this parameter is not provided, Solr will identify nodes automatically based on policies or number of cores in each node.
        /// </summary>
        /// <value>The target node where replicas will be copied. If this parameter is not provided, Solr will identify nodes automatically based on policies or number of cores in each node.</value>
        [DataMember(Name = "targetNodeName", EmitDefaultValue = false)]
        public string TargetNodeName { get; set; }

        /// <summary>
        /// If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replica is online and active.
        /// </summary>
        /// <value>If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replica is online and active.</value>
        [DataMember(Name = "waitForFinalState", EmitDefaultValue = true)]
        public bool WaitForFinalState { get; set; }

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
            sb.Append("class ReplaceNodeRequestBodyModel {\n");
            sb.Append("  TargetNodeName: ").Append(TargetNodeName).Append("\n");
            sb.Append("  WaitForFinalState: ").Append(WaitForFinalState).Append("\n");
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
