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
    /// The type List Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ListItem : BaseItem
    {
    
        /// <summary>
        /// Gets or sets content type.
        /// The content type of this list item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public ContentTypeInfo ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// The list of recent activities that took place on this item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activities", Required = Newtonsoft.Json.Required.Default)]
        public IListItemActivitiesCollectionPage Activities { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place on this item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "analytics", Required = Newtonsoft.Json.Required.Default)]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets drive item.
        /// For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "driveItem", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem DriveItem { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// The values of the columns set on this list item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fields", Required = Newtonsoft.Json.Required.Default)]
        public FieldValueSet Fields { get; set; }
    
        /// <summary>
        /// Gets or sets versions.
        /// The list of previous versions of the list item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "versions", Required = Newtonsoft.Json.Required.Default)]
        public IListItemVersionsCollectionPage Versions { get; set; }
    
    }
}

