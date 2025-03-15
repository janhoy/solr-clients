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
    /// CreateAliasRequestBodyModel
    /// </summary>
    [DataContract(Name = "CreateAliasRequestBody")]
    public partial class CreateAliasRequestBodyModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAliasRequestBodyModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAliasRequestBodyModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAliasRequestBodyModel" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="collections">collections.</param>
        /// <param name="async">async.</param>
        /// <param name="routers">routers.</param>
        /// <param name="collCreationParameters">collCreationParameters.</param>
        public CreateAliasRequestBodyModel(string name = default(string), Collection<string> collections = default(Collection<string>), string async = default(string), Collection<RoutedAliasPropertiesModel> routers = default(Collection<RoutedAliasPropertiesModel>), CreateCollectionRequestBodyModel collCreationParameters = default(CreateCollectionRequestBodyModel))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateAliasRequestBodyModel and cannot be null");
            }
            this.Name = name;
            this.Collections = collections;
            this.Async = async;
            this.Routers = routers;
            this.CollCreationParameters = collCreationParameters;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name = "collections", EmitDefaultValue = false)]
        public Collection<string> Collections { get; set; }

        /// <summary>
        /// Gets or Sets Async
        /// </summary>
        [DataMember(Name = "async", EmitDefaultValue = false)]
        public string Async { get; set; }

        /// <summary>
        /// Gets or Sets Routers
        /// </summary>
        [DataMember(Name = "routers", EmitDefaultValue = false)]
        public Collection<RoutedAliasPropertiesModel> Routers { get; set; }

        /// <summary>
        /// Gets or Sets CollCreationParameters
        /// </summary>
        [DataMember(Name = "collCreationParameters", EmitDefaultValue = false)]
        public CreateCollectionRequestBodyModel CollCreationParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAliasRequestBodyModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
            sb.Append("  Async: ").Append(Async).Append("\n");
            sb.Append("  Routers: ").Append(Routers).Append("\n");
            sb.Append("  CollCreationParameters: ").Append(CollCreationParameters).Append("\n");
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
