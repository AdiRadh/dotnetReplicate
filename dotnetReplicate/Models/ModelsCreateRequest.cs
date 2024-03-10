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
    /// ModelsCreateRequest
    /// </summary>
    [DataContract(Name = "models_create_request")]
    public partial class ModelsCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </summary>
        /// <value>Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 1,

            /// <summary>
            /// Enum Private for value: private
            /// </summary>
            [EnumMember(Value = "private")]
            Private = 2
        }


        /// <summary>
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </summary>
        /// <value>Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.</value>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelsCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateRequest" /> class.
        /// </summary>
        /// <param name="coverImageUrl">A URL for the model&#39;s cover image. This should be an image file..</param>
        /// <param name="description">A description of the model..</param>
        /// <param name="githubUrl">A URL for the model&#39;s source code on GitHub..</param>
        /// <param name="hardware">The SKU for the hardware used to run the model. Possible values can be retrieved from the &#x60;hardware.list&#x60; endpoint. (required).</param>
        /// <param name="licenseUrl">A URL for the model&#39;s license..</param>
        /// <param name="name">The name of the model. This must be unique among all models owned by the user or organization. (required).</param>
        /// <param name="owner">The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization. (required).</param>
        /// <param name="paperUrl">A URL for the model&#39;s paper..</param>
        /// <param name="visibility">Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model. (required).</param>
        public ModelsCreateRequest(string coverImageUrl = default(string), string description = default(string), string githubUrl = default(string), string hardware = default(string), string licenseUrl = default(string), string name = default(string), string owner = default(string), string paperUrl = default(string), VisibilityEnum visibility = default(VisibilityEnum))
        {
            // to ensure "hardware" is required (not null)
            if (hardware == null)
            {
                throw new ArgumentNullException("hardware is a required property for ModelsCreateRequest and cannot be null");
            }
            this.Hardware = hardware;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ModelsCreateRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "owner" is required (not null)
            if (owner == null)
            {
                throw new ArgumentNullException("owner is a required property for ModelsCreateRequest and cannot be null");
            }
            this.Owner = owner;
            this.Visibility = visibility;
            this.CoverImageUrl = coverImageUrl;
            this.Description = description;
            this.GithubUrl = githubUrl;
            this.LicenseUrl = licenseUrl;
            this.PaperUrl = paperUrl;
        }

        /// <summary>
        /// A URL for the model&#39;s cover image. This should be an image file.
        /// </summary>
        /// <value>A URL for the model&#39;s cover image. This should be an image file.</value>
        [DataMember(Name = "cover_image_url", EmitDefaultValue = false)]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// A description of the model.
        /// </summary>
        /// <value>A description of the model.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A URL for the model&#39;s source code on GitHub.
        /// </summary>
        /// <value>A URL for the model&#39;s source code on GitHub.</value>
        [DataMember(Name = "github_url", EmitDefaultValue = false)]
        public string GithubUrl { get; set; }

        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the &#x60;hardware.list&#x60; endpoint.
        /// </summary>
        /// <value>The SKU for the hardware used to run the model. Possible values can be retrieved from the &#x60;hardware.list&#x60; endpoint.</value>
        [DataMember(Name = "hardware", IsRequired = true, EmitDefaultValue = true)]
        public string Hardware { get; set; }

        /// <summary>
        /// A URL for the model&#39;s license.
        /// </summary>
        /// <value>A URL for the model&#39;s license.</value>
        [DataMember(Name = "license_url", EmitDefaultValue = false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// The name of the model. This must be unique among all models owned by the user or organization.
        /// </summary>
        /// <value>The name of the model. This must be unique among all models owned by the user or organization.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.
        /// </summary>
        /// <value>The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.</value>
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// A URL for the model&#39;s paper.
        /// </summary>
        /// <value>A URL for the model&#39;s paper.</value>
        [DataMember(Name = "paper_url", EmitDefaultValue = false)]
        public string PaperUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelsCreateRequest {\n");
            sb.Append("  CoverImageUrl: ").Append(CoverImageUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GithubUrl: ").Append(GithubUrl).Append("\n");
            sb.Append("  Hardware: ").Append(Hardware).Append("\n");
            sb.Append("  LicenseUrl: ").Append(LicenseUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PaperUrl: ").Append(PaperUrl).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
