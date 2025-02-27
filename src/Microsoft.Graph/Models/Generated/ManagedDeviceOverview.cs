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
    /// The type Managed Device Overview.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceOverview : Entity
    {
    
        /// <summary>
        /// Gets or sets enrolled device count.
        /// Total enrolled device count. Does not include PC devices managed via Intune PC Agent
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrolledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets mdm enrolled count.
        /// The number of devices enrolled in MDM
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmEnrolledCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MdmEnrolledCount { get; set; }
    
        /// <summary>
        /// Gets or sets dual enrolled device count.
        /// The number of devices enrolled in both MDM and EAS
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dualEnrolledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DualEnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets device operating system summary.
        /// Device operating system summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOperatingSystemSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceOperatingSystemSummary DeviceOperatingSystemSummary { get; set; }
    
        /// <summary>
        /// Gets or sets device exchange access state summary.
        /// Distribution of Exchange Access State in Intune
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceExchangeAccessStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary { get; set; }
    
        /// <summary>
        /// Gets or sets managed device models and manufacturers.
        /// Models and Manufactures meatadata for managed devices in the account
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceModelsAndManufacturers", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDeviceModelsAndManufacturers ManagedDeviceModelsAndManufacturers { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified date time of device overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
    }
}

