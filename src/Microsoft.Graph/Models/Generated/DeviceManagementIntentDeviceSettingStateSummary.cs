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
    /// The type Device Management Intent Device Setting State Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementIntentDeviceSettingStateSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets setting name.
        /// Name of a setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets compliant count.
        /// Number of compliant devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CompliantCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict count.
        /// Number of devices in conflict
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conflictCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConflictCount { get; set; }
    
        /// <summary>
        /// Gets or sets error count.
        /// Number of error devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant count.
        /// Number of non compliant devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nonCompliantCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NonCompliantCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated count.
        /// Number of remediated devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediatedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemediatedCount { get; set; }
    
    }
}

