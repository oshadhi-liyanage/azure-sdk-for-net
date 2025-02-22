// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceMovePolicy. </summary>
    public partial class ResourceMovePolicy
    {
        /// <summary> Initializes a new instance of ResourceMovePolicy. </summary>
        public ResourceMovePolicy()
        {
        }

        /// <summary> Initializes a new instance of ResourceMovePolicy. </summary>
        /// <param name="validationRequired"></param>
        /// <param name="crossResourceGroupMoveEnabled"></param>
        /// <param name="crossSubscriptionMoveEnabled"></param>
        internal ResourceMovePolicy(bool? validationRequired, bool? crossResourceGroupMoveEnabled, bool? crossSubscriptionMoveEnabled)
        {
            ValidationRequired = validationRequired;
            CrossResourceGroupMoveEnabled = crossResourceGroupMoveEnabled;
            CrossSubscriptionMoveEnabled = crossSubscriptionMoveEnabled;
        }

        /// <summary> Gets or sets the validation required. </summary>
        public bool? ValidationRequired { get; set; }
        /// <summary> Gets or sets the cross resource group move enabled. </summary>
        public bool? CrossResourceGroupMoveEnabled { get; set; }
        /// <summary> Gets or sets the cross subscription move enabled. </summary>
        public bool? CrossSubscriptionMoveEnabled { get; set; }
    }
}
