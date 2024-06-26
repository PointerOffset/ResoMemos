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
    /// Defines v1InboxType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum V1InboxType
    {
        /// <summary>
        /// Enum TYPEUNSPECIFIED for value: TYPE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPEUNSPECIFIED = 1,

        /// <summary>
        /// Enum MEMOCOMMENT for value: MEMO_COMMENT
        /// </summary>
        [EnumMember(Value = "MEMO_COMMENT")]
        MEMOCOMMENT = 2,

        /// <summary>
        /// Enum VERSIONUPDATE for value: VERSION_UPDATE
        /// </summary>
        [EnumMember(Value = "VERSION_UPDATE")]
        VERSIONUPDATE = 3
    }

}