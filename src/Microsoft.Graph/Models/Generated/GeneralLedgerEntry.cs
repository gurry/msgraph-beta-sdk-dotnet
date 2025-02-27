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
    /// The type General Ledger Entry.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GeneralLedgerEntry : Entity
    {
    
        /// <summary>
        /// Gets or sets posting date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postingDate", Required = Newtonsoft.Json.Required.Default)]
        public Date PostingDate { get; set; }
    
        /// <summary>
        /// Gets or sets document number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "documentNumber", Required = Newtonsoft.Json.Required.Default)]
        public string DocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets document type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "documentType", Required = Newtonsoft.Json.Required.Default)]
        public string DocumentType { get; set; }
    
        /// <summary>
        /// Gets or sets account id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? AccountId { get; set; }
    
        /// <summary>
        /// Gets or sets account number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountNumber", Required = Newtonsoft.Json.Required.Default)]
        public string AccountNumber { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets debit amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "debitAmount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? DebitAmount { get; set; }
    
        /// <summary>
        /// Gets or sets credit amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creditAmount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? CreditAmount { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account", Required = Newtonsoft.Json.Required.Default)]
        public Account Account { get; set; }
    
    }
}

