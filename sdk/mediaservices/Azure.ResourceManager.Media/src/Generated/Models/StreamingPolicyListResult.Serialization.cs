// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingPolicyListResult
    {
        internal static StreamingPolicyListResult DeserializeStreamingPolicyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<StreamingPolicyData>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StreamingPolicyData> array = new List<StreamingPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingPolicyData.DeserializeStreamingPolicyData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StreamingPolicyListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
