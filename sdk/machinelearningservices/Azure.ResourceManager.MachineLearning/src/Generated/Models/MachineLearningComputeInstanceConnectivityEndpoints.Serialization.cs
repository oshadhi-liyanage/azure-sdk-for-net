// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceConnectivityEndpoints
    {
        internal static MachineLearningComputeInstanceConnectivityEndpoints DeserializeMachineLearningComputeInstanceConnectivityEndpoints(JsonElement element)
        {
            Optional<string> publicIPAddress = default;
            Optional<string> privateIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        publicIPAddress = null;
                        continue;
                    }
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateIPAddress = null;
                        continue;
                    }
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningComputeInstanceConnectivityEndpoints(publicIPAddress.Value, privateIPAddress.Value);
        }
    }
}
