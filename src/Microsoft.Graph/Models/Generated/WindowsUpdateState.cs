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
    /// The type Windows Update State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsUpdateState : Entity
    {
    
        /// <summary>
        /// Gets or sets device id.
        /// The id of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The id of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets device display name.
        /// Device display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Windows udpate status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUpdateStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets quality update version.
        /// The Quality Update Version of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityUpdateVersion", Required = Newtonsoft.Json.Required.Default)]
        public string QualityUpdateVersion { get; set; }
    
        /// <summary>
        /// Gets or sets feature update version.
        /// The current feature update version of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUpdateVersion", Required = Newtonsoft.Json.Required.Default)]
        public string FeatureUpdateVersion { get; set; }
    
        /// <summary>
        /// Gets or sets last scan date time.
        /// The date time that the Windows Update Agent did a successful scan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastScanDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastScanDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last date time that the device sync with with Microsoft Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
    }
}

