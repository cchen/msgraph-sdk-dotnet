// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SecuritySecureScoreControlProfilesCollectionRequestBuilder.
    /// </summary>
    public partial class SecuritySecureScoreControlProfilesCollectionRequestBuilder : BaseRequestBuilder, ISecuritySecureScoreControlProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SecuritySecureScoreControlProfilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecuritySecureScoreControlProfilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISecuritySecureScoreControlProfilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISecuritySecureScoreControlProfilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SecuritySecureScoreControlProfilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISecureScoreControlProfileRequestBuilder"/> for the specified SecuritySecureScoreControlProfile.
        /// </summary>
        /// <param name="id">The ID for the SecuritySecureScoreControlProfile.</param>
        /// <returns>The <see cref="ISecureScoreControlProfileRequestBuilder"/>.</returns>
        public ISecureScoreControlProfileRequestBuilder this[string id]
        {
            get
            {
                return new SecureScoreControlProfileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
