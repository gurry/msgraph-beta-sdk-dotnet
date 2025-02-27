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
    /// The type Azure ADUser Feature Usage.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AzureADUserFeatureUsage : Entity
    {
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets license recommended.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseRecommended", Required = Newtonsoft.Json.Required.Default)]
        public AzureADLicenseType? LicenseRecommended { get; set; }
    
        /// <summary>
        /// Gets or sets license assigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseAssigned", Required = Newtonsoft.Json.Required.Default)]
        public AzureADLicenseType? LicenseAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets feature usage details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "featureUsageDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<FeatureUsageDetail> FeatureUsageDetails { get; set; }
    
    }
}

