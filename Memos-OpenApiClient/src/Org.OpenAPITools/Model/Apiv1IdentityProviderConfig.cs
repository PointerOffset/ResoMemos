/*
 * api/v1/activity_service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Apiv1IdentityProviderConfig
    /// </summary>
    [DataContract(Name = "apiv1IdentityProviderConfig")]
    public partial class Apiv1IdentityProviderConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1IdentityProviderConfig" /> class.
        /// </summary>
        /// <param name="oauth2Config">oauth2Config.</param>
        public Apiv1IdentityProviderConfig(Apiv1OAuth2Config oauth2Config = default(Apiv1OAuth2Config))
        {
            this.Oauth2Config = oauth2Config;
        }

        /// <summary>
        /// Gets or Sets Oauth2Config
        /// </summary>
        [DataMember(Name = "oauth2Config", EmitDefaultValue = false)]
        public Apiv1OAuth2Config Oauth2Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apiv1IdentityProviderConfig {\n");
            sb.Append("  Oauth2Config: ").Append(Oauth2Config).Append("\n");
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
