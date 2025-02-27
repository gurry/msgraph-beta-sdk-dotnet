// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Azure ADFeature Usage.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AzureADFeatureUsage : Entity
    {
    
        /// <summary>
        /// Gets or sets snapshot date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "snapshotDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SnapshotDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feature name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureName", Required = Newtonsoft.Json.Required.Default)]
        public string FeatureName { get; set; }
    
        /// <summary>
        /// Gets or sets usage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Usage { get; set; }
    
    }
}

