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
    /// CreateCollectionRequestBodyModel
    /// </summary>
    [DataContract(Name = "CreateCollectionRequestBody")]
    public partial class CreateCollectionRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequestBodyModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="replicationFactor">replicationFactor.</param>
        /// <param name="config">config.</param>
        /// <param name="numShards">numShards.</param>
        /// <param name="shardNames">shardNames.</param>
        /// <param name="pullReplicas">pullReplicas.</param>
        /// <param name="tlogReplicas">tlogReplicas.</param>
        /// <param name="nrtReplicas">nrtReplicas.</param>
        /// <param name="waitForFinalState">waitForFinalState.</param>
        /// <param name="perReplicaState">perReplicaState.</param>
        /// <param name="alias">alias.</param>
        /// <param name="properties">properties.</param>
        /// <param name="async">async.</param>
        /// <param name="router">router.</param>
        /// <param name="nodeSet">nodeSet.</param>
        /// <param name="createReplicas">createReplicas.</param>
        /// <param name="shuffleNodes">shuffleNodes.</param>
        public CreateCollectionRequestBodyModel(string name = default(string), int replicationFactor = default(int), string config = default(string), int numShards = default(int), Collection<string> shardNames = default(Collection<string>), int pullReplicas = default(int), int tlogReplicas = default(int), int nrtReplicas = default(int), bool waitForFinalState = default(bool), bool perReplicaState = default(bool), string alias = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), string async = default(string), CreateCollectionRouterPropertiesModel router = default(CreateCollectionRouterPropertiesModel), Collection<string> nodeSet = default(Collection<string>), bool createReplicas = default(bool), bool shuffleNodes = default(bool))
        {
            this.Name = name;
            this.ReplicationFactor = replicationFactor;
            this.Config = config;
            this.NumShards = numShards;
            this.ShardNames = shardNames;
            this.PullReplicas = pullReplicas;
            this.TlogReplicas = tlogReplicas;
            this.NrtReplicas = nrtReplicas;
            this.WaitForFinalState = waitForFinalState;
            this.PerReplicaState = perReplicaState;
            this.Alias = alias;
            this.Properties = properties;
            this.Async = async;
            this.Router = router;
            this.NodeSet = nodeSet;
            this.CreateReplicas = createReplicas;
            this.ShuffleNodes = shuffleNodes;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReplicationFactor
        /// </summary>
        [DataMember(Name = "replicationFactor", EmitDefaultValue = false)]
        public int ReplicationFactor { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public string Config { get; set; }

        /// <summary>
        /// Gets or Sets NumShards
        /// </summary>
        [DataMember(Name = "numShards", EmitDefaultValue = false)]
        public int NumShards { get; set; }

        /// <summary>
        /// Gets or Sets ShardNames
        /// </summary>
        [DataMember(Name = "shardNames", EmitDefaultValue = false)]
        public Collection<string> ShardNames { get; set; }

        /// <summary>
        /// Gets or Sets PullReplicas
        /// </summary>
        [DataMember(Name = "pullReplicas", EmitDefaultValue = false)]
        public int PullReplicas { get; set; }

        /// <summary>
        /// Gets or Sets TlogReplicas
        /// </summary>
        [DataMember(Name = "tlogReplicas", EmitDefaultValue = false)]
        public int TlogReplicas { get; set; }

        /// <summary>
        /// Gets or Sets NrtReplicas
        /// </summary>
        [DataMember(Name = "nrtReplicas", EmitDefaultValue = false)]
        public int NrtReplicas { get; set; }

        /// <summary>
        /// Gets or Sets WaitForFinalState
        /// </summary>
        [DataMember(Name = "waitForFinalState", EmitDefaultValue = true)]
        public bool WaitForFinalState { get; set; }

        /// <summary>
        /// Gets or Sets PerReplicaState
        /// </summary>
        [DataMember(Name = "perReplicaState", EmitDefaultValue = true)]
        public bool PerReplicaState { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Async
        /// </summary>
        [DataMember(Name = "async", EmitDefaultValue = false)]
        public string Async { get; set; }

        /// <summary>
        /// Gets or Sets Router
        /// </summary>
        [DataMember(Name = "router", EmitDefaultValue = false)]
        public CreateCollectionRouterPropertiesModel Router { get; set; }

        /// <summary>
        /// Gets or Sets NodeSet
        /// </summary>
        [DataMember(Name = "nodeSet", EmitDefaultValue = false)]
        public Collection<string> NodeSet { get; set; }

        /// <summary>
        /// Gets or Sets CreateReplicas
        /// </summary>
        [DataMember(Name = "createReplicas", EmitDefaultValue = true)]
        public bool CreateReplicas { get; set; }

        /// <summary>
        /// Gets or Sets ShuffleNodes
        /// </summary>
        [DataMember(Name = "shuffleNodes", EmitDefaultValue = true)]
        public bool ShuffleNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCollectionRequestBodyModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReplicationFactor: ").Append(ReplicationFactor).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  NumShards: ").Append(NumShards).Append("\n");
            sb.Append("  ShardNames: ").Append(ShardNames).Append("\n");
            sb.Append("  PullReplicas: ").Append(PullReplicas).Append("\n");
            sb.Append("  TlogReplicas: ").Append(TlogReplicas).Append("\n");
            sb.Append("  NrtReplicas: ").Append(NrtReplicas).Append("\n");
            sb.Append("  WaitForFinalState: ").Append(WaitForFinalState).Append("\n");
            sb.Append("  PerReplicaState: ").Append(PerReplicaState).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
            sb.Append("  Router: ").Append(Router).Append("\n");
            sb.Append("  NodeSet: ").Append(NodeSet).Append("\n");
            sb.Append("  CreateReplicas: ").Append(CreateReplicas).Append("\n");
            sb.Append("  ShuffleNodes: ").Append(ShuffleNodes).Append("\n");
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
