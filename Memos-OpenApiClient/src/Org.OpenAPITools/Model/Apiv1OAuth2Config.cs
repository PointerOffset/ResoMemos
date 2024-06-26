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
    /// Apiv1OAuth2Config
    /// </summary>
    [DataContract(Name = "apiv1OAuth2Config")]
    public partial class Apiv1OAuth2Config : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1OAuth2Config" /> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="authUrl">authUrl.</param>
        /// <param name="tokenUrl">tokenUrl.</param>
        /// <param name="userInfoUrl">userInfoUrl.</param>
        /// <param name="scopes">scopes.</param>
        /// <param name="fieldMapping">fieldMapping.</param>
        public Apiv1OAuth2Config(string clientId = default(string), string clientSecret = default(string), string authUrl = default(string), string tokenUrl = default(string), string userInfoUrl = default(string), List<string> scopes = default(List<string>), Apiv1FieldMapping fieldMapping = default(Apiv1FieldMapping))
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.AuthUrl = authUrl;
            this.TokenUrl = tokenUrl;
            this.UserInfoUrl = userInfoUrl;
            this.Scopes = scopes;
            this.FieldMapping = fieldMapping;
        }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "clientSecret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets AuthUrl
        /// </summary>
        [DataMember(Name = "authUrl", EmitDefaultValue = false)]
        public string AuthUrl { get; set; }

        /// <summary>
        /// Gets or Sets TokenUrl
        /// </summary>
        [DataMember(Name = "tokenUrl", EmitDefaultValue = false)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Gets or Sets UserInfoUrl
        /// </summary>
        [DataMember(Name = "userInfoUrl", EmitDefaultValue = false)]
        public string UserInfoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Gets or Sets FieldMapping
        /// </summary>
        [DataMember(Name = "fieldMapping", EmitDefaultValue = false)]
        public Apiv1FieldMapping FieldMapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apiv1OAuth2Config {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  AuthUrl: ").Append(AuthUrl).Append("\n");
            sb.Append("  TokenUrl: ").Append(TokenUrl).Append("\n");
            sb.Append("  UserInfoUrl: ").Append(UserInfoUrl).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  FieldMapping: ").Append(FieldMapping).Append("\n");
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