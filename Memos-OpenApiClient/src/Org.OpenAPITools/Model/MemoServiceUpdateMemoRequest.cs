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
    /// MemoServiceUpdateMemoRequest
    /// </summary>
    [DataContract(Name = "MemoService_UpdateMemo_request")]
    public partial class MemoServiceUpdateMemoRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RowStatus
        /// </summary>
        [DataMember(Name = "rowStatus", EmitDefaultValue = false)]
        public V1RowStatus? RowStatus { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public V1Visibility? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoServiceUpdateMemoRequest" /> class.
        /// </summary>
        /// <param name="uid">The user defined id of the memo..</param>
        /// <param name="rowStatus">rowStatus.</param>
        /// <param name="creator">creator.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="updateTime">updateTime.</param>
        /// <param name="displayTime">displayTime.</param>
        /// <param name="content">content.</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="tags">tags.</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="property">property.</param>
        public MemoServiceUpdateMemoRequest(string uid = default(string), V1RowStatus? rowStatus = default(V1RowStatus?), string creator = default(string), DateTime createTime = default(DateTime), DateTime updateTime = default(DateTime), DateTime displayTime = default(DateTime), string content = default(string), V1Visibility? visibility = default(V1Visibility?), List<string> tags = default(List<string>), bool pinned = default(bool), V1MemoProperty property = default(V1MemoProperty))
        {
            this.Uid = uid;
            this.RowStatus = rowStatus;
            this.Creator = creator;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.DisplayTime = displayTime;
            this.Content = content;
            this.Visibility = visibility;
            this.Tags = tags;
            this.Pinned = pinned;
            this.Property = property;
        }

        /// <summary>
        /// The user defined id of the memo.
        /// </summary>
        /// <value>The user defined id of the memo.</value>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets DisplayTime
        /// </summary>
        [DataMember(Name = "displayTime", EmitDefaultValue = false)]
        public DateTime DisplayTime { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Nodes
        /// </summary>
        [DataMember(Name = "nodes", EmitDefaultValue = false)]
        public List<V1Node> Nodes { get; private set; }

        /// <summary>
        /// Returns false as Nodes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNodes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public int ParentId { get; private set; }

        /// <summary>
        /// Returns false as ParentId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParentId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public List<V1Resource> Resources { get; private set; }

        /// <summary>
        /// Returns false as Resources should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResources()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Relations
        /// </summary>
        [DataMember(Name = "relations", EmitDefaultValue = false)]
        public List<V1MemoRelation> Relations { get; private set; }

        /// <summary>
        /// Returns false as Relations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRelations()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Reactions
        /// </summary>
        [DataMember(Name = "reactions", EmitDefaultValue = false)]
        public List<V1Reaction> Reactions { get; private set; }

        /// <summary>
        /// Returns false as Reactions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReactions()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "property", EmitDefaultValue = false)]
        public V1MemoProperty Property { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public string Parent { get; private set; }

        /// <summary>
        /// Returns false as Parent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParent()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemoServiceUpdateMemoRequest {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  RowStatus: ").Append(RowStatus).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  DisplayTime: ").Append(DisplayTime).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
