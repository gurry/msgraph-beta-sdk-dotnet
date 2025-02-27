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
    /// The type Text Classification Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TextClassificationRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets sensitive type ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitiveTypeIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SensitiveTypeIds { get; set; }
    
    }
}

