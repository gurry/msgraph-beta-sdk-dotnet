// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidDeviceOwnerRequiredPasswordType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidDeviceOwnerRequiredPasswordType
    {
    
        /// <summary>
        /// Device Default
        /// </summary>
        DeviceDefault = 0,
	
        /// <summary>
        /// Required
        /// </summary>
        Required = 1,
	
        /// <summary>
        /// Numeric
        /// </summary>
        Numeric = 2,
	
        /// <summary>
        /// Numeric Complex
        /// </summary>
        NumericComplex = 3,
	
        /// <summary>
        /// Alphabetic
        /// </summary>
        Alphabetic = 4,
	
        /// <summary>
        /// Alphanumeric
        /// </summary>
        Alphanumeric = 5,
	
        /// <summary>
        /// Alphanumeric With Symbols
        /// </summary>
        AlphanumericWithSymbols = 6,
	
        /// <summary>
        /// Low Security Biometric
        /// </summary>
        LowSecurityBiometric = 7,
	
    }
}
