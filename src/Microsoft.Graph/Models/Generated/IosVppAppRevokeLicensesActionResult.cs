// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosVppAppRevokeLicensesActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IosVppAppRevokeLicensesActionResult
    {

        /// <summary>
        /// Gets or sets userId.
        /// UserId associated with the action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets managedDeviceId.
        /// DeviceId associated with the action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets totalLicensesCount.
        /// A count of the number of licenses for which revoke was attempted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicensesCount { get; set; }
    
        /// <summary>
        /// Gets or sets failedLicensesCount.
        /// A count of the number of licenses for which revoke failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedLicensesCount { get; set; }
    
        /// <summary>
        /// Gets or sets actionFailureReason.
        /// The reason for the revoke licenses action failure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionFailureReason", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenActionFailureReason? ActionFailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets actionName.
        /// Action name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionName", Required = Newtonsoft.Json.Required.Default)]
        public string ActionName { get; set; }
    
        /// <summary>
        /// Gets or sets actionState.
        /// State of the action
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionState", Required = Newtonsoft.Json.Required.Default)]
        public ActionState? ActionState { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// Time the action was initiated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastUpdatedDateTime.
        /// Time the action state was last updated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
