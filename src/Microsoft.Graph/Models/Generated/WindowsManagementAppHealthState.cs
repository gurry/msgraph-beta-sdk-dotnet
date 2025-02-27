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
    /// The type Windows Management App Health State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsManagementAppHealthState : Entity
    {
    
        /// <summary>
        /// Gets or sets health state.
        /// Windows management app health state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthState", Required = Newtonsoft.Json.Required.Default)]
        public HealthState? HealthState { get; set; }
    
        /// <summary>
        /// Gets or sets installed version.
        /// Windows management app installed version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedVersion", Required = Newtonsoft.Json.Required.Default)]
        public string InstalledVersion { get; set; }
    
        /// <summary>
        /// Gets or sets last check in date time.
        /// Windows management app last check-in time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastCheckInDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastCheckInDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Name of the device on which Windows management app is installed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device osversion.
        /// Windows 10 OS version of the device on which Windows management app is installed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOSVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceOSVersion { get; set; }
    
    }
}

