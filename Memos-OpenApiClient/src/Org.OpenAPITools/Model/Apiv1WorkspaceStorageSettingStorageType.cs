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
    ///  - DATABASE: DATABASE is the database storage type.  - LOCAL: LOCAL is the local storage type.  - S3: S3 is the S3 storage type.
    /// </summary>
    /// <value> - DATABASE: DATABASE is the database storage type.  - LOCAL: LOCAL is the local storage type.  - S3: S3 is the S3 storage type.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Apiv1WorkspaceStorageSettingStorageType
    {
        /// <summary>
        /// Enum STORAGETYPEUNSPECIFIED for value: STORAGE_TYPE_UNSPECIFIED
        /// </summary>
        [EnumMember(Value = "STORAGE_TYPE_UNSPECIFIED")]
        STORAGETYPEUNSPECIFIED = 1,

        /// <summary>
        /// Enum DATABASE for value: DATABASE
        /// </summary>
        [EnumMember(Value = "DATABASE")]
        DATABASE = 2,

        /// <summary>
        /// Enum LOCAL for value: LOCAL
        /// </summary>
        [EnumMember(Value = "LOCAL")]
        LOCAL = 3,

        /// <summary>
        /// Enum S3 for value: S3
        /// </summary>
        [EnumMember(Value = "S3")]
        S3 = 4
    }

}
