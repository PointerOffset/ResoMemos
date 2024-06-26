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
    /// V1ListIdentityProvidersResponse
    /// </summary>
    [DataContract(Name = "v1ListIdentityProvidersResponse")]
    public partial class V1ListIdentityProvidersResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListIdentityProvidersResponse" /> class.
        /// </summary>
        /// <param name="identityProviders">identityProviders.</param>
        public V1ListIdentityProvidersResponse(List<Apiv1IdentityProvider> identityProviders = default(List<Apiv1IdentityProvider>))
        {
            this.IdentityProviders = identityProviders;
        }

        /// <summary>
        /// Gets or Sets IdentityProviders
        /// </summary>
        [DataMember(Name = "identityProviders", EmitDefaultValue = false)]
        public List<Apiv1IdentityProvider> IdentityProviders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1ListIdentityProvidersResponse {\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
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
