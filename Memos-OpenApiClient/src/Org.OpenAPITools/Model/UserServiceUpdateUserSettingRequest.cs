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
    /// UserServiceUpdateUserSettingRequest
    /// </summary>
    [DataContract(Name = "UserService_UpdateUserSetting_request")]
    public partial class UserServiceUpdateUserSettingRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserServiceUpdateUserSettingRequest" /> class.
        /// </summary>
        /// <param name="locale">The preferred locale of the user..</param>
        /// <param name="appearance">The preferred appearance of the user..</param>
        /// <param name="memoVisibility">The default visibility of the memo..</param>
        public UserServiceUpdateUserSettingRequest(string locale = default(string), string appearance = default(string), string memoVisibility = default(string))
        {
            this.Locale = locale;
            this.Appearance = appearance;
            this.MemoVisibility = memoVisibility;
        }

        /// <summary>
        /// The preferred locale of the user.
        /// </summary>
        /// <value>The preferred locale of the user.</value>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// The preferred appearance of the user.
        /// </summary>
        /// <value>The preferred appearance of the user.</value>
        [DataMember(Name = "appearance", EmitDefaultValue = false)]
        public string Appearance { get; set; }

        /// <summary>
        /// The default visibility of the memo.
        /// </summary>
        /// <value>The default visibility of the memo.</value>
        [DataMember(Name = "memoVisibility", EmitDefaultValue = false)]
        public string MemoVisibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserServiceUpdateUserSettingRequest {\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Appearance: ").Append(Appearance).Append("\n");
            sb.Append("  MemoVisibility: ").Append(MemoVisibility).Append("\n");
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
