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
    /// HardwareList200ResponseInner
    /// </summary>
    [DataContract(Name = "hardware_list_200_response_inner")]
    public partial class HardwareListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareListResponse" /> class.
        /// </summary>
        /// <param name="name">The name of the hardware..</param>
        /// <param name="sku">The SKU of the hardware..</param>
        public HardwareListResponse(string name = default(string), string sku = default(string))
        {
            this.Name = name;
            this.Sku = sku;
        }

        /// <summary>
        /// The name of the hardware.
        /// </summary>
        /// <value>The name of the hardware.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The SKU of the hardware.
        /// </summary>
        /// <value>The SKU of the hardware.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HardwareList200ResponseInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
