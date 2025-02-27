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
    /// The enum ChatMessagePolicyViolationVerdictDetailsType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum ChatMessagePolicyViolationVerdictDetailsType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Allow False Positive Override
        /// </summary>
        AllowFalsePositiveOverride = 1,
	
        /// <summary>
        /// Allow Override Without Justification
        /// </summary>
        AllowOverrideWithoutJustification = 2,
	
        /// <summary>
        /// Allow Override With Justification
        /// </summary>
        AllowOverrideWithJustification = 4,
	
    }
}
