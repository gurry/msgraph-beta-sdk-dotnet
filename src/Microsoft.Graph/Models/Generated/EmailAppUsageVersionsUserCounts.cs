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
    /// The type Email App Usage Versions User Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EmailAppUsageVersionsUserCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets outlook2016.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook2016", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Outlook2016 { get; set; }
    
        /// <summary>
        /// Gets or sets outlook2013.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook2013", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Outlook2013 { get; set; }
    
        /// <summary>
        /// Gets or sets outlook2010.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook2010", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Outlook2010 { get; set; }
    
        /// <summary>
        /// Gets or sets outlook2007.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook2007", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Outlook2007 { get; set; }
    
        /// <summary>
        /// Gets or sets undetermined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "undetermined", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Undetermined { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

