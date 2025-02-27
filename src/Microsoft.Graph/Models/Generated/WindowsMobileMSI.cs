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
    /// The type Windows Mobile MSI.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsMobileMSI : MobileLobApp
    {
    
        /// <summary>
        /// Gets or sets command line.
        /// The command line.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "commandLine", Required = Newtonsoft.Json.Required.Default)]
        public string CommandLine { get; set; }
    
        /// <summary>
        /// Gets or sets product code.
        /// The product code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productCode", Required = Newtonsoft.Json.Required.Default)]
        public string ProductCode { get; set; }
    
        /// <summary>
        /// Gets or sets product version.
        /// The product version of Windows Mobile MSI Line of Business (LoB) app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ProductVersion { get; set; }
    
        /// <summary>
        /// Gets or sets ignore version detection.
        /// A boolean to control whether the app's version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ignoreVersionDetection", Required = Newtonsoft.Json.Required.Default)]
        public bool? IgnoreVersionDetection { get; set; }
    
        /// <summary>
        /// Gets or sets identity version.
        /// The identity version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets use device context.
        /// Indicates whether to install a dual-mode MSI in the device context. If true, app will be installed for all users. If false, app will be installed per-user. If null, service will use the MSI package's default install context. In case of dual-mode MSI, this default will be per-user.  Cannot be set for non-dual-mode apps.  Cannot be changed after initial creation of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useDeviceContext", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseDeviceContext { get; set; }
    
    }
}

