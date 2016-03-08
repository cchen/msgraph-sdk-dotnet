// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    /// <summary>
    /// The type GraphServiceSubscribedSkusCollectionPage.
    /// </summary>
    public partial class GraphServiceSubscribedSkusCollectionPage : CollectionPage<SubscribedSku>, IGraphServiceSubscribedSkusCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceSubscribedSkusCollectionRequest"/> instance.
        /// </summary>
        public IGraphServiceSubscribedSkusCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new GraphServiceSubscribedSkusCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
