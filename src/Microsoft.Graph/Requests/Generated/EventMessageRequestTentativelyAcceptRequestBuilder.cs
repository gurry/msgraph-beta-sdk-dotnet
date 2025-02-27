// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EventMessageRequestTentativelyAcceptRequestBuilder.
    /// </summary>
    public partial class EventMessageRequestTentativelyAcceptRequestBuilder : BaseActionMethodRequestBuilder<IEventMessageRequestTentativelyAcceptRequest>, IEventMessageRequestTentativelyAcceptRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EventMessageRequestTentativelyAcceptRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="SendResponse">A SendResponse parameter for the OData method call.</param>
        /// <param name="Comment">A Comment parameter for the OData method call.</param>
        public EventMessageRequestTentativelyAcceptRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool? SendResponse,
            string Comment)
            : base(requestUrl, client)
        {
            this.SetParameter("sendResponse", SendResponse, true);
            this.SetParameter("comment", Comment, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEventMessageRequestTentativelyAcceptRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new EventMessageRequestTentativelyAcceptRequest(functionUrl, this.Client, options);

            if (this.HasParameter("sendResponse"))
            {
                request.RequestBody.SendResponse = this.GetParameter<bool?>("sendResponse");
            }

            if (this.HasParameter("comment"))
            {
                request.RequestBody.Comment = this.GetParameter<string>("comment");
            }

            return request;
        }
    }
}
