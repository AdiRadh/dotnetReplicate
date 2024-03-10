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
    /// TrainingsCreateRequest
    /// </summary>
    [DataContract(Name = "trainings_create_request")]
    public partial class TrainingsCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingsCreateRequest" /> class.
        /// </summary>
        /// <param name="destination">A string representing the desired model to push to in the format &#x60;{destination_model_owner}/{destination_model_name}&#x60;. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response. .</param>
        /// <param name="input">An object containing inputs to the Cog model&#39;s &#x60;train()&#x60; function. .</param>
        /// <param name="webhook">An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once..</param>
        public TrainingsCreateRequest(string destination = default(string), Object input = default(Object), string webhook = default(string))
        {
            this.Destination = destination;
            this.Input = input;
            this.Webhook = webhook;
        }

        /// <summary>
        /// A string representing the desired model to push to in the format &#x60;{destination_model_owner}/{destination_model_name}&#x60;. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response. 
        /// </summary>
        /// <value>A string representing the desired model to push to in the format &#x60;{destination_model_owner}/{destination_model_name}&#x60;. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response. </value>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// An object containing inputs to the Cog model&#39;s &#x60;train()&#x60; function. 
        /// </summary>
        /// <value>An object containing inputs to the Cog model&#39;s &#x60;train()&#x60; function. </value>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public Object Input { get; set; }

        /// <summary>
        /// An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once.
        /// </summary>
        /// <value>An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once.</value>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public string Webhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrainingsCreateRequest {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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
