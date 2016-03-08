// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceDrivesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceDrivesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceDrivesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceDrivesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDriveRequestBuilder"/> for the specified Drive.
        /// </summary>
        /// <param name="id">The ID for the Drive.</param>
        /// <returns>The <see cref="IDriveRequestBuilder"/>.</returns>
        IDriveRequestBuilder this[string id] { get; }
    }
}
