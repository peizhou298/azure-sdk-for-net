// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Unresolved dependency.
    /// </summary>
    public partial class UnresolvedDependency
    {
        /// <summary>
        /// Initializes a new instance of the UnresolvedDependency class.
        /// </summary>
        public UnresolvedDependency()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnresolvedDependency class.
        /// </summary>
        /// <param name="count">Gets or sets the count.</param>
        /// <param name="id">Gets or sets the arm id of the dependency.</param>
        public UnresolvedDependency(int? count = default(int?), string id = default(string))
        {
            Count = count;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the arm id of the dependency.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}