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
    /// The type Device Compliance Device Status.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceDeviceStatus : Entity
    {
    
        /// <summary>
        /// Gets or sets device display name.
        /// Device name of the DevicePolicyStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// The User Name that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The device model that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceModel", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// Platform of the device that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Platform { get; set; }
    
        /// <summary>
        /// Gets or sets compliance grace period expiration date time.
        /// The DateTime when device compliance grace period expires
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceGracePeriodExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// Last modified date time of the policy report.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastReportedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// UserPrincipalName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}

