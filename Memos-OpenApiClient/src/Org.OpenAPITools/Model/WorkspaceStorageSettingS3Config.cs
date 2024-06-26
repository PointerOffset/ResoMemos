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
    /// WorkspaceStorageSettingS3Config
    /// </summary>
    [DataContract(Name = "WorkspaceStorageSettingS3Config")]
    public partial class WorkspaceStorageSettingS3Config : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceStorageSettingS3Config" /> class.
        /// </summary>
        /// <param name="accessKeyId">accessKeyId.</param>
        /// <param name="accessKeySecret">accessKeySecret.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="region">region.</param>
        /// <param name="bucket">bucket.</param>
        public WorkspaceStorageSettingS3Config(string accessKeyId = default(string), string accessKeySecret = default(string), string endpoint = default(string), string region = default(string), string bucket = default(string))
        {
            this.AccessKeyId = accessKeyId;
            this.AccessKeySecret = accessKeySecret;
            this.Endpoint = endpoint;
            this.Region = region;
            this.Bucket = bucket;
        }

        /// <summary>
        /// Gets or Sets AccessKeyId
        /// </summary>
        [DataMember(Name = "accessKeyId", EmitDefaultValue = false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets or Sets AccessKeySecret
        /// </summary>
        [DataMember(Name = "accessKeySecret", EmitDefaultValue = false)]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkspaceStorageSettingS3Config {\n");
            sb.Append("  AccessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  AccessKeySecret: ").Append(AccessKeySecret).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
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
