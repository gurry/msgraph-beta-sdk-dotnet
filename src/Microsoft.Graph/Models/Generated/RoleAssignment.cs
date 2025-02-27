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
    /// The type Role Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RoleAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The display or friendly name of the role Assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the Role Assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets scope members.
        /// List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scopeMembers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ScopeMembers { get; set; }
    
        /// <summary>
        /// Gets or sets scope type.
        /// Specifies the type of scope for a Role Assignment. Default type 'ResourceScope' allows assignment of ResourceScopes. For 'AllDevices', 'AllLicensedUsers', and 'AllDevicesAndLicensedUsers', the ResourceScopes property should be left empty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scopeType", Required = Newtonsoft.Json.Required.Default)]
        public RoleAssignmentScopeType? ScopeType { get; set; }
    
        /// <summary>
        /// Gets or sets resource scopes.
        /// List of ids of role scope member security groups.  These are IDs from Azure Active Directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceScopes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ResourceScopes { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// Role definition this assignment is part of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinition", Required = Newtonsoft.Json.Required.Default)]
        public RoleDefinition RoleDefinition { get; set; }
    
    }
}

