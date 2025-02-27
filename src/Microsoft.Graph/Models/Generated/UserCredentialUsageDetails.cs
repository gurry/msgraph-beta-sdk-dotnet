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
    /// The type User Credential Usage Details.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserCredentialUsageDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feature", Required = Newtonsoft.Json.Required.Default)]
        public FeatureType? Feature { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is success.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSuccess", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSuccess { get; set; }
    
        /// <summary>
        /// Gets or sets auth method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authMethod", Required = Newtonsoft.Json.Required.Default)]
        public UsageAuthMethod? AuthMethod { get; set; }
    
        /// <summary>
        /// Gets or sets failure reason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failureReason", Required = Newtonsoft.Json.Required.Default)]
        public string FailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EventDateTime { get; set; }
    
    }
}

