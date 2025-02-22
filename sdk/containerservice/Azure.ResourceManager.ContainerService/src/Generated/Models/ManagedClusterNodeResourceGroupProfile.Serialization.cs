// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterNodeResourceGroupProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RestrictionLevel))
            {
                writer.WritePropertyName("restrictionLevel"u8);
                writer.WriteStringValue(RestrictionLevel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterNodeResourceGroupProfile DeserializeManagedClusterNodeResourceGroupProfile(JsonElement element)
        {
            Optional<ManagedClusterNodeResourceGroupRestrictionLevel> restrictionLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restrictionLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    restrictionLevel = new ManagedClusterNodeResourceGroupRestrictionLevel(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterNodeResourceGroupProfile(Optional.ToNullable(restrictionLevel));
        }
    }
}
