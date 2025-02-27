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
    /// The type BinaryManagementConditionExpression.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class BinaryManagementConditionExpression : ManagementConditionExpressionModel
    {

        /// <summary>
        /// Gets or sets operator.
        /// The operator used in the evaluation of the binary operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public BinaryManagementConditionExpressionOperatorType? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets firstOperand.
        /// The first operand of the binary operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstOperand", Required = Newtonsoft.Json.Required.Default)]
        public ManagementConditionExpressionModel FirstOperand { get; set; }
    
        /// <summary>
        /// Gets or sets secondOperand.
        /// The second operand of the binary operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secondOperand", Required = Newtonsoft.Json.Required.Default)]
        public ManagementConditionExpressionModel SecondOperand { get; set; }
    
    }
}
