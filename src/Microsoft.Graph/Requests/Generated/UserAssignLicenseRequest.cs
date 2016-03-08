// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type UserAssignLicenseRequest.
    /// </summary>
    public partial class UserAssignLicenseRequest : BaseRequest, IUserAssignLicenseRequest
    {
    
        /// <summary>
        /// Constructs a new UserAssignLicenseRequest.
        /// </summary>
        public UserAssignLicenseRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            IEnumerable<AssignedLicense> addLicenses = null,
            IEnumerable<Guid> removeLicenses = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new UserAssignLicenseRequestBody();
            this.RequestBody.AddLicenses = addLicenses;
            this.RequestBody.RemoveLicenses = removeLicenses;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public UserAssignLicenseRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task<User> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheUser</returns>
        public Task<User> PostAsync(CancellationToken cancellationToken)
        {
    
            return this.SendAsync<User>(this.RequestBody, cancellationToken);
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAssignLicenseRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserAssignLicenseRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
    }
}
