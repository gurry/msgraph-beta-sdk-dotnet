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
    /// The type Embedded SIMActivation Code Pool.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EmbeddedSIMActivationCodePool : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The admin defined name of the embedded SIM activation code pool.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the embedded SIM activation code pool was created. Generated service side.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The time the embedded SIM activation code pool was last modified. Updated service side.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets activation codes.
        /// The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activationCodes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EmbeddedSIMActivationCode> ActivationCodes { get; set; }
    
        /// <summary>
        /// Gets or sets activation code count.
        /// The total count of activation codes which belong to this pool.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activationCodeCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActivationCodeCount { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Navigational property to a list of targets to which this pool is assigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IEmbeddedSIMActivationCodePoolAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// Navigational property to a list of device states for this pool.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStates", Required = Newtonsoft.Json.Required.Default)]
        public IEmbeddedSIMActivationCodePoolDeviceStatesCollectionPage DeviceStates { get; set; }
    
    }
}

