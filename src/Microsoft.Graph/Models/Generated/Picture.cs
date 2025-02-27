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
    /// The type Picture.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Picture : Entity
    {
    
        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "width", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Width { get; set; }
    
        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "height", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public Stream Content { get; set; }
    
    }
}

