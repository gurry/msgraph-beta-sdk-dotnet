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
    /// The type ChatMessagePolicyViolation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ChatMessagePolicyViolation
    {

        /// <summary>
        /// Gets or sets dlpAction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dlpAction", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessagePolicyViolationDlpActionType? DlpAction { get; set; }
    
        /// <summary>
        /// Gets or sets justificationText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justificationText", Required = Newtonsoft.Json.Required.Default)]
        public string JustificationText { get; set; }
    
        /// <summary>
        /// Gets or sets policyTip.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyTip", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessagePolicyViolationPolicyTip PolicyTip { get; set; }
    
        /// <summary>
        /// Gets or sets userAction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAction", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessagePolicyViolationUserActionType? UserAction { get; set; }
    
        /// <summary>
        /// Gets or sets verdictDetails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "verdictDetails", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessagePolicyViolationVerdictDetailsType? VerdictDetails { get; set; }
    
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
