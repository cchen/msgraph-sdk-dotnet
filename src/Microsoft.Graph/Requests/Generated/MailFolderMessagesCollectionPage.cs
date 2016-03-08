// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    /// <summary>
    /// The type MailFolderMessagesCollectionPage.
    /// </summary>
    public partial class MailFolderMessagesCollectionPage : CollectionPage<Message>, IMailFolderMessagesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IMailFolderMessagesCollectionRequest"/> instance.
        /// </summary>
        public IMailFolderMessagesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new MailFolderMessagesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
