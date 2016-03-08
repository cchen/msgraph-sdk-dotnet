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
    /// The type EventDeclineRequest.
    /// </summary>
    public partial class EventDeclineRequest : BaseRequest, IEventDeclineRequest
    {
    
        /// <summary>
        /// Constructs a new EventDeclineRequest.
        /// </summary>
        public EventDeclineRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            string comment = null,
            bool? sendResponse = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new EventDeclineRequestBody();
            this.RequestBody.Comment = comment;
            this.RequestBody.SendResponse = sendResponse;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public EventDeclineRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public Task PostAsync(CancellationToken cancellationToken)
        {
    
            return this.SendAsync(this.RequestBody, cancellationToken); 
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEventDeclineRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEventDeclineRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
    }
}
