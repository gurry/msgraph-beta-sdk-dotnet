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
    /// The type Side Loading Key.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SideLoadingKey : Entity
    {
    
        /// <summary>
        /// Gets or sets value.
        /// Side Loading Key Value, it is 5x5 value, seperated by hiphens.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Side Loading Key Name displayed to the ITPro Admins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Side Loading Key description displayed to the ITPro Admins..
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets total activation.
        /// Side Loading Key Total Activation displayed to the ITPro Admins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalActivation", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalActivation { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Side Loading Key Last Updated Date displayed to the ITPro Admins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public string LastUpdatedDateTime { get; set; }
    
    }
}

