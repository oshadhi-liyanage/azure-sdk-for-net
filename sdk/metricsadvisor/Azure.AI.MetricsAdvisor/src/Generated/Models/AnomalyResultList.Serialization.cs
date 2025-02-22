// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyResultList
    {
        internal static AnomalyResultList DeserializeAnomalyResultList(JsonElement element)
        {
            Optional<string> nextLink = default;
            IReadOnlyList<DataPointAnomaly> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<DataPointAnomaly> array = new List<DataPointAnomaly>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataPointAnomaly.DeserializeDataPointAnomaly(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AnomalyResultList(nextLink.Value, value);
        }
    }
}
