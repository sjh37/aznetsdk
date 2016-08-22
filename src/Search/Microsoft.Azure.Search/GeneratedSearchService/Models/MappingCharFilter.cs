// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A character filter that applies mappings defined with the mappings
    /// option. Matching is greedy (longest pattern matching at a given point
    /// wins). Replacement is allowed to be the empty string. This character
    /// filter is implemented using Apache Lucene.
    /// <see href="*https://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/charfilter/MappingCharFilter.html" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.MappingCharFilter")]
    public partial class MappingCharFilter : CharFilter
    {
        /// <summary>
        /// Initializes a new instance of the MappingCharFilter class.
        /// </summary>
        public MappingCharFilter() { }

        /// <summary>
        /// Initializes a new instance of the MappingCharFilter class.
        /// </summary>
        public MappingCharFilter(string name, IList<string> mappings)
            : base(name)
        {
            Mappings = mappings;
        }

        /// <summary>
        /// Gets or sets a list of mappings of the following format: "a=&gt;b"
        /// (all occurrences of the character "a" will be replaced with
        /// character "b").
        /// </summary>
        [JsonProperty(PropertyName = "mappings")]
        public IList<string> Mappings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Mappings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mappings");
            }
        }
    }
}