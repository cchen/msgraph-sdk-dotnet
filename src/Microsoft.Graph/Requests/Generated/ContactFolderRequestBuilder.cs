// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ContactFolderRequestBuilder.
    /// </summary>
    public partial class ContactFolderRequestBuilder : EntityRequestBuilder, IContactFolderRequestBuilder
    {

        /// <summary>
        /// Constructs a new ContactFolderRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ContactFolderRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IContactFolderRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IContactFolderRequest Request(IEnumerable<Option> options)
        {
            return new ContactFolderRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for Contacts.
        /// </summary>
        /// <returns>The <see cref="IContactFolderContactsCollectionRequestBuilder"/>.</returns>
        public IContactFolderContactsCollectionRequestBuilder Contacts
        {
            get
            {
                return new ContactFolderContactsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("contacts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ChildFolders.
        /// </summary>
        /// <returns>The <see cref="IContactFolderChildFoldersCollectionRequestBuilder"/>.</returns>
        public IContactFolderChildFoldersCollectionRequestBuilder ChildFolders
        {
            get
            {
                return new ContactFolderChildFoldersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("childFolders"), this.Client);
            }
        }
    
    }
}
