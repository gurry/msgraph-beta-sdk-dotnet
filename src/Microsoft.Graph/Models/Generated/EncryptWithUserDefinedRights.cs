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
    /// The type EncryptWithUserDefinedRights.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EncryptWithUserDefinedRights : EncryptContent
    {

        /// <summary>
        /// Gets or sets decryptionRightsManagementTemplateId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decryptionRightsManagementTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string DecryptionRightsManagementTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets allowMailForwarding.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowMailForwarding", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowMailForwarding { get; set; }
    
        /// <summary>
        /// Gets or sets allowAdHocPermissions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowAdHocPermissions", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowAdHocPermissions { get; set; }
    
    }
}
