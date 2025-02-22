// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class ProviderShareSubscriptionList
    {
        internal static ProviderShareSubscriptionList DeserializeProviderShareSubscriptionList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<ProviderShareSubscriptionData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<ProviderShareSubscriptionData> array = new List<ProviderShareSubscriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderShareSubscriptionData.DeserializeProviderShareSubscriptionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ProviderShareSubscriptionList(nextLink.Value, value);
        }
    }
}
