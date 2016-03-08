// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupAcceptedSendersCollectionRequestBuilder.
    /// </summary>
    public partial class GroupAcceptedSendersCollectionRequestBuilder : BaseRequestBuilder, IGroupAcceptedSendersCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new GroupAcceptedSendersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupAcceptedSendersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupAcceptedSendersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupAcceptedSendersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupAcceptedSendersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified GroupDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the GroupDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        public IDirectoryObjectRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
