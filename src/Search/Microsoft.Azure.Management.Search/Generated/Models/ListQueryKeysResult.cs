// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response containing the query API keys for a given Azure Search
    /// service.
    /// </summary>
    public partial class ListQueryKeysResult
    {
        /// <summary>
        /// Initializes a new instance of the ListQueryKeysResult class.
        /// </summary>
        public ListQueryKeysResult() { }

        /// <summary>
        /// Initializes a new instance of the ListQueryKeysResult class.
        /// </summary>
        public ListQueryKeysResult(IList<QueryKey> value = default(IList<QueryKey>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets the query keys for the Azure Search service.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<QueryKey> Value { get; private set; }

    }
}
