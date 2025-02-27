// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MacOSMinimumOperatingSystem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MacOSMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v10_7.
        /// Mac OS 10.7 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_7", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_7 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_8.
        /// Mac OS 10.8 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_8", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_8 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_9.
        /// Mac OS 10.9 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_9", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_9 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_10.
        /// Mac OS 10.10 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_10", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_10 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_11.
        /// Mac OS 10.11 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_11", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_11 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_12.
        /// Mac OS 10.12 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_12", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_12 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_13.
        /// Mac OS 10.13 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_13", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_13 { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
