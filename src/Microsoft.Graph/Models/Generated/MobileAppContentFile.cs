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
    /// The type Mobile App Content File.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppContentFile : Entity
    {
    
        /// <summary>
        /// Gets or sets azure storage uri.
        /// The Azure Storage URI.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureStorageUri", Required = Newtonsoft.Json.Required.Default)]
        public string AzureStorageUri { get; set; }
    
        /// <summary>
        /// Gets or sets is committed.
        /// A value indicating whether the file is committed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCommitted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCommitted { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the file was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// the file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The size of the file prior to encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets size encrypted.
        /// The size of the file after encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sizeEncrypted", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SizeEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets azure storage uri expiration date time.
        /// The time the Azure storage Uri expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureStorageUriExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AzureStorageUriExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets manifest.
        /// The manifest information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manifest", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Manifest { get; set; }
    
        /// <summary>
        /// Gets or sets upload state.
        /// The state of the current upload request. Possible values are: success, transientError, error, unknown, azureStorageUriRequestSuccess, azureStorageUriRequestPending, azureStorageUriRequestFailed, azureStorageUriRequestTimedOut, azureStorageUriRenewalSuccess, azureStorageUriRenewalPending, azureStorageUriRenewalFailed, azureStorageUriRenewalTimedOut, commitFileSuccess, commitFilePending, commitFileFailed, commitFileTimedOut.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uploadState", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppContentFileUploadState? UploadState { get; set; }
    
        /// <summary>
        /// Gets or sets is framework file.
        /// A value indicating whether the file is a framework file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFrameworkFile", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFrameworkFile { get; set; }
    
        /// <summary>
        /// Gets or sets is dependency.
        /// Whether the content file is a dependency for the main content file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDependency", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDependency { get; set; }
    
    }
}

