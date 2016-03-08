// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ResponseStatus.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ResponseStatus
    {
    
        /// <summary>
        /// Gets or sets response.
        /// </summary>
        [DataMember(Name = "response", EmitDefaultValue = false, IsRequired = false)]
        public ResponseType? Response { get; set; }
    
        /// <summary>
        /// Gets or sets time.
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? Time { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
