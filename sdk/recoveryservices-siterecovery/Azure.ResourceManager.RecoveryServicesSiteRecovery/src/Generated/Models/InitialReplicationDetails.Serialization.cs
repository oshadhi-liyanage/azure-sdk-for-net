// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InitialReplicationDetails
    {
        internal static InitialReplicationDetails DeserializeInitialReplicationDetails(JsonElement element)
        {
            Optional<string> initialReplicationType = default;
            Optional<string> initialReplicationProgressPercentage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialReplicationType"u8))
                {
                    initialReplicationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"u8))
                {
                    initialReplicationProgressPercentage = property.Value.GetString();
                    continue;
                }
            }
            return new InitialReplicationDetails(initialReplicationType.Value, initialReplicationProgressPercentage.Value);
        }
    }
}
