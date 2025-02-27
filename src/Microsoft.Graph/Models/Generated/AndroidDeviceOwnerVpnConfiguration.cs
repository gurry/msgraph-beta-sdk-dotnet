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
    /// The type Android Device Owner Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerVpnConfiguration : VpnConfiguration
    {
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

