// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserDirectReportsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserDirectReportsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserDirectReportsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserDirectReportsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserDirectReportsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserDirectReportsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserDirectReportsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserDirectReportsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified UserDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the UserDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserDirectReportsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserDirectReportsCollectionReferencesRequestBuilder"/>.</returns>
        public IUserDirectReportsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserDirectReportsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
