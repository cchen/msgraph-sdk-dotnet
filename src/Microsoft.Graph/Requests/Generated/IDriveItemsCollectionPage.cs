// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    using Newtonsoft.Json;
    
    /// <summary>
    /// The interface IDriveItemsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<DriveItemsCollectionPage>))]
    public interface IDriveItemsCollectionPage : ICollectionPage<DriveItem>
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveItemsCollectionRequest"/> instance.
        /// </summary>
        IDriveItemsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
