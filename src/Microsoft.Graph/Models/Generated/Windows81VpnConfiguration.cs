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
    /// The type Windows81Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows81VpnConfiguration : WindowsVpnConfiguration
    {
    
        /// <summary>
        /// Gets or sets apply only to windows81.
        /// Value indicating whether this policy only applies to Windows 8.1. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyOnlyToWindows81", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplyOnlyToWindows81 { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public WindowsVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets login group or domain.
        /// Login group or domain when connection type is set to Dell SonicWALL Mobile Connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "loginGroupOrDomain", Required = Newtonsoft.Json.Required.Default)]
        public string LoginGroupOrDomain { get; set; }
    
        /// <summary>
        /// Gets or sets enable split tunneling.
        /// Enable split tunneling for the VPN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSplitTunneling", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSplitTunneling { get; set; }
    
        /// <summary>
        /// Gets or sets proxy server.
        /// Proxy Server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyServer", Required = Newtonsoft.Json.Required.Default)]
        public Windows81VpnProxyServer ProxyServer { get; set; }
    
    }
}

