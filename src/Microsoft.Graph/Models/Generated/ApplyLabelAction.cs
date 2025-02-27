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
    /// The type ApplyLabelAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ApplyLabelAction : InformationProtectionAction
    {

        /// <summary>
        /// Gets or sets labelId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "labelId", Required = Newtonsoft.Json.Required.Default)]
        public string LabelId { get; set; }
    
        /// <summary>
        /// Gets or sets classificationIds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classificationIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Guid> ClassificationIds { get; set; }
    
        /// <summary>
        /// Gets or sets actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<InformationProtectionAction> Actions { get; set; }
    
    }
}
