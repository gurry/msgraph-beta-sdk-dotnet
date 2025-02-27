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
    /// The type Directory Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DirectoryDefinition : Entity
    {
    
        /// <summary>
        /// Gets or sets discovery date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discoveryDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DiscoveryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets discoverabilities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discoverabilities", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryDefinitionDiscoverabilities? Discoverabilities { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "objects", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ObjectDefinition> Objects { get; set; }
    
        /// <summary>
        /// Gets or sets read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "readOnly", Required = Newtonsoft.Json.Required.Default)]
        public bool? ReadOnly { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
    }
}

