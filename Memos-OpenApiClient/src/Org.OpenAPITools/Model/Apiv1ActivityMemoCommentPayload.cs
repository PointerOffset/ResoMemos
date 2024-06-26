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
    /// ActivityMemoCommentPayload represents the payload of a memo comment activity.
    /// </summary>
    [DataContract(Name = "apiv1ActivityMemoCommentPayload")]
    public partial class Apiv1ActivityMemoCommentPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1ActivityMemoCommentPayload" /> class.
        /// </summary>
        /// <param name="memoId">The memo id of comment..</param>
        /// <param name="relatedMemoId">The memo id of related memo..</param>
        public Apiv1ActivityMemoCommentPayload(int memoId = default(int), int relatedMemoId = default(int))
        {
            this.MemoId = memoId;
            this.RelatedMemoId = relatedMemoId;
        }

        /// <summary>
        /// The memo id of comment.
        /// </summary>
        /// <value>The memo id of comment.</value>
        [DataMember(Name = "memoId", EmitDefaultValue = false)]
        public int MemoId { get; set; }

        /// <summary>
        /// The memo id of related memo.
        /// </summary>
        /// <value>The memo id of related memo.</value>
        [DataMember(Name = "relatedMemoId", EmitDefaultValue = false)]
        public int RelatedMemoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apiv1ActivityMemoCommentPayload {\n");
            sb.Append("  MemoId: ").Append(MemoId).Append("\n");
            sb.Append("  RelatedMemoId: ").Append(RelatedMemoId).Append("\n");
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