/*
 * Replicate HTTP API
 *
 * A web service for running Replicate models
 *
 * The version of the OpenAPI document: 1.0.0-a1
 * Contact: team@replicate.com
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
using OpenAPIDateConverter = dotnetReplicate.Client.OpenAPIDateConverter;

namespace dotnetReplicate.Model
{
    /// <summary>
    /// DeploymentsGet200ResponseCurrentReleaseConfiguration
    /// </summary>
    [DataContract(Name = "deployments_get_200_response_current_release_configuration")]
    public partial class Configuration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="hardware">The SKU for the hardware used to run the model..</param>
        /// <param name="scaling">scaling.</param>
        public Configuration(string hardware = default(string), Scaling scaling = default(Scaling))
        {
            this.Hardware = hardware;
            this.Scaling = scaling;
        }

        /// <summary>
        /// The SKU for the hardware used to run the model.
        /// </summary>
        /// <value>The SKU for the hardware used to run the model.</value>
        [DataMember(Name = "hardware", EmitDefaultValue = false)]
        public string Hardware { get; set; }

        /// <summary>
        /// Gets or Sets Scaling
        /// </summary>
        [DataMember(Name = "scaling", EmitDefaultValue = false)]
        public Scaling Scaling { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeploymentsGet200ResponseCurrentReleaseConfiguration {\n");
            sb.Append("  Hardware: ").Append(Hardware).Append("\n");
            sb.Append("  Scaling: ").Append(Scaling).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}