// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// The interface IDriveItemDeltaCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<DriveItemDeltaCollectionPage>))]
    public interface IDriveItemDeltaCollectionPage : ICollectionPage<DriveItem>
    {
        /// <summary>
        /// Gets the next page <see cref="IDriveItemDeltaRequest"/> instance.
        /// </summary>
        IDriveItemDeltaRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
