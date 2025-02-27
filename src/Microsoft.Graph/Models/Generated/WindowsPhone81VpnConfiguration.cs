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
    /// The type Windows Phone81Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsPhone81VpnConfiguration : Windows81VpnConfiguration
    {
    
        /// <summary>
        /// Gets or sets bypass vpn on company wifi.
        /// Bypass VPN on company Wi-Fi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bypassVpnOnCompanyWifi", Required = Newtonsoft.Json.Required.Default)]
        public bool? BypassVpnOnCompanyWifi { get; set; }
    
        /// <summary>
        /// Gets or sets bypass vpn on home wifi.
        /// Bypass VPN on home Wi-Fi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bypassVpnOnHomeWifi", Required = Newtonsoft.Json.Required.Default)]
        public bool? BypassVpnOnHomeWifi { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets remember user credentials.
        /// Remember user credentials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rememberUserCredentials", Required = Newtonsoft.Json.Required.Default)]
        public bool? RememberUserCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets dns suffix search list.
        /// DNS suffix search list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsSuffixSearchList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DnsSuffixSearchList { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public WindowsPhone81CertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

