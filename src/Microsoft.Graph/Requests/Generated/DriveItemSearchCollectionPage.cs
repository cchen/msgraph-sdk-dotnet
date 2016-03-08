// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{   
    /// <summary>
    /// The type DriveItemSearchCollectionPage.
    /// </summary>
    public partial class DriveItemSearchCollectionPage : CollectionPage<DriveItem>, IDriveItemSearchCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveItemSearchRequest"/> instance.
        /// </summary>
        public IDriveItemSearchRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new DriveItemSearchRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
