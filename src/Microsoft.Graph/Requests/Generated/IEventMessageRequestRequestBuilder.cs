// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEventMessageRequestRequestBuilder.
    /// </summary>
    public partial interface IEventMessageRequestRequestBuilder : IEventMessageRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEventMessageRequestRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEventMessageRequestRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for EventMessageRequestAccept.
        /// </summary>
        /// <returns>The <see cref="IEventMessageRequestAcceptRequestBuilder"/>.</returns>
        IEventMessageRequestAcceptRequestBuilder Accept(
            bool? SendResponse = null,
            string Comment = null);

        /// <summary>
        /// Gets the request builder for EventMessageRequestDecline.
        /// </summary>
        /// <returns>The <see cref="IEventMessageRequestDeclineRequestBuilder"/>.</returns>
        IEventMessageRequestDeclineRequestBuilder Decline(
            bool? SendResponse = null,
            string Comment = null);

        /// <summary>
        /// Gets the request builder for EventMessageRequestTentativelyAccept.
        /// </summary>
        /// <returns>The <see cref="IEventMessageRequestTentativelyAcceptRequestBuilder"/>.</returns>
        IEventMessageRequestTentativelyAcceptRequestBuilder TentativelyAccept(
            bool? SendResponse = null,
            string Comment = null);
    
    }
}
