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
    /// The type Privileged Role Settings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrivilegedRoleSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets approver ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approverIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ApproverIds { get; set; }
    
        /// <summary>
        /// Gets or sets min elevation duration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minElevationDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration MinElevationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets max elavation duration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxElavationDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration MaxElavationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets elevation duration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "elevationDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration ElevationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets notification to user on elevation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationToUserOnElevation", Required = Newtonsoft.Json.Required.Default)]
        public bool? NotificationToUserOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets ticketing info on elevation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ticketingInfoOnElevation", Required = Newtonsoft.Json.Required.Default)]
        public bool? TicketingInfoOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets mfa on elevation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaOnElevation", Required = Newtonsoft.Json.Required.Default)]
        public bool? MfaOnElevation { get; set; }
    
        /// <summary>
        /// Gets or sets last global admin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastGlobalAdmin", Required = Newtonsoft.Json.Required.Default)]
        public bool? LastGlobalAdmin { get; set; }
    
        /// <summary>
        /// Gets or sets is mfa on elevation configurable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMfaOnElevationConfigurable", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMfaOnElevationConfigurable { get; set; }
    
        /// <summary>
        /// Gets or sets approval on elevation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approvalOnElevation", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApprovalOnElevation { get; set; }
    
    }
}

