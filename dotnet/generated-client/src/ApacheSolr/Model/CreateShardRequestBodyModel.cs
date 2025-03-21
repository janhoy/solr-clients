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
    /// CreateShardRequestBodyModel
    /// </summary>
    [DataContract(Name = "CreateShardRequestBody")]
    public partial class CreateShardRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardRequestBodyModel" /> class.
        /// </summary>
        /// <param name="replicationFactor">replicationFactor.</param>
        /// <param name="nrtReplicas">nrtReplicas.</param>
        /// <param name="tlogReplicas">tlogReplicas.</param>
        /// <param name="pullReplicas">pullReplicas.</param>
        /// <param name="waitForFinalState">waitForFinalState.</param>
        /// <param name="followAliases">followAliases.</param>
        /// <param name="async">async.</param>
        /// <param name="properties">properties.</param>
        /// <param name="shardName">shardName.</param>
        /// <param name="createReplicas">createReplicas.</param>
        /// <param name="nodeSet">nodeSet.</param>
        public CreateShardRequestBodyModel(int replicationFactor = default(int), int nrtReplicas = default(int), int tlogReplicas = default(int), int pullReplicas = default(int), bool waitForFinalState = default(bool), bool followAliases = default(bool), string async = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), string shardName = default(string), bool createReplicas = default(bool), Collection<string> nodeSet = default(Collection<string>))
        {
            this.ReplicationFactor = replicationFactor;
            this.NrtReplicas = nrtReplicas;
            this.TlogReplicas = tlogReplicas;
            this.PullReplicas = pullReplicas;
            this.WaitForFinalState = waitForFinalState;
            this.FollowAliases = followAliases;
            this.Async = async;
            this.Properties = properties;
            this.ShardName = shardName;
            this.CreateReplicas = createReplicas;
            this.NodeSet = nodeSet;
        }

        /// <summary>
        /// Gets or Sets ReplicationFactor
        /// </summary>
        [DataMember(Name = "replicationFactor", EmitDefaultValue = false)]
        public int ReplicationFactor { get; set; }

        /// <summary>
        /// Gets or Sets NrtReplicas
        /// </summary>
        [DataMember(Name = "nrtReplicas", EmitDefaultValue = false)]
        public int NrtReplicas { get; set; }

        /// <summary>
        /// Gets or Sets TlogReplicas
        /// </summary>
        [DataMember(Name = "tlogReplicas", EmitDefaultValue = false)]
        public int TlogReplicas { get; set; }

        /// <summary>
        /// Gets or Sets PullReplicas
        /// </summary>
        [DataMember(Name = "pullReplicas", EmitDefaultValue = false)]
        public int PullReplicas { get; set; }

        /// <summary>
        /// Gets or Sets WaitForFinalState
        /// </summary>
        [DataMember(Name = "waitForFinalState", EmitDefaultValue = true)]
        public bool WaitForFinalState { get; set; }

        /// <summary>
        /// Gets or Sets FollowAliases
        /// </summary>
        [DataMember(Name = "followAliases", EmitDefaultValue = true)]
        public bool FollowAliases { get; set; }

        /// <summary>
        /// Gets or Sets Async
        /// </summary>
        [DataMember(Name = "async", EmitDefaultValue = false)]
        public string Async { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets ShardName
        /// </summary>
        [DataMember(Name = "shardName", EmitDefaultValue = false)]
        public string ShardName { get; set; }

        /// <summary>
        /// Gets or Sets CreateReplicas
        /// </summary>
        [DataMember(Name = "createReplicas", EmitDefaultValue = true)]
        public bool CreateReplicas { get; set; }

        /// <summary>
        /// Gets or Sets NodeSet
        /// </summary>
        [DataMember(Name = "nodeSet", EmitDefaultValue = false)]
        public Collection<string> NodeSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShardRequestBodyModel {\n");
            sb.Append("  ReplicationFactor: ").Append(ReplicationFactor).Append("\n");
            sb.Append("  NrtReplicas: ").Append(NrtReplicas).Append("\n");
            sb.Append("  TlogReplicas: ").Append(TlogReplicas).Append("\n");
            sb.Append("  PullReplicas: ").Append(PullReplicas).Append("\n");
            sb.Append("  WaitForFinalState: ").Append(WaitForFinalState).Append("\n");
            sb.Append("  FollowAliases: ").Append(FollowAliases).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  ShardName: ").Append(ShardName).Append("\n");
            sb.Append("  CreateReplicas: ").Append(CreateReplicas).Append("\n");
            sb.Append("  NodeSet: ").Append(NodeSet).Append("\n");
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
