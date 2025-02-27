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
    /// The type Filter Operator Schema.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class FilterOperatorSchema : Entity
    {
    
        /// <summary>
        /// Gets or sets arity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "arity", Required = Newtonsoft.Json.Required.Default)]
        public ScopeOperatorType? Arity { get; set; }
    
        /// <summary>
        /// Gets or sets multivalued comparison type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multivaluedComparisonType", Required = Newtonsoft.Json.Required.Default)]
        public ScopeOperatorMultiValuedComparisonType? MultivaluedComparisonType { get; set; }
    
        /// <summary>
        /// Gets or sets supported attribute types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedAttributeTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AttributeType> SupportedAttributeTypes { get; set; }
    
    }
}

