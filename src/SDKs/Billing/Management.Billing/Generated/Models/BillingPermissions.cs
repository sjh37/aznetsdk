// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The set of allowed action and not allowed actions a caller has on a
    /// billing account
    /// </summary>
    public partial class BillingPermissions
    {
        /// <summary>
        /// Initializes a new instance of the BillingPermissions class.
        /// </summary>
        public BillingPermissions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingPermissions class.
        /// </summary>
        /// <param name="actions">The set of actions that the caller is allowed
        /// to do</param>
        /// <param name="notActions">The set of actions the caller is not
        /// allowed to do</param>
        public BillingPermissions(IList<string> actions = default(IList<string>), IList<string> notActions = default(IList<string>))
        {
            Actions = actions;
            NotActions = notActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the set of actions that the caller is allowed to do
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; private set; }

        /// <summary>
        /// Gets the set of actions the caller is not allowed to do
        /// </summary>
        [JsonProperty(PropertyName = "notActions")]
        public IList<string> NotActions { get; private set; }

    }
}
