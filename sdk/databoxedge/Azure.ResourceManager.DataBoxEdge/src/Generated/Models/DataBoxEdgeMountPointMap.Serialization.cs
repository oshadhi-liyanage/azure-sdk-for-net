// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeMountPointMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("shareId"u8);
            writer.WriteStringValue(ShareId);
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeMountPointMap DeserializeDataBoxEdgeMountPointMap(JsonElement element)
        {
            ResourceIdentifier shareId = default;
            Optional<ResourceIdentifier> roleId = default;
            Optional<string> mountPoint = default;
            Optional<DataBoxEdgeMountType> mountType = default;
            Optional<DataBoxEdgeRoleType> roleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareId"u8))
                {
                    shareId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPoint"u8))
                {
                    mountPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mountType = new DataBoxEdgeMountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleType = new DataBoxEdgeRoleType(property.Value.GetString());
                    continue;
                }
            }
            return new DataBoxEdgeMountPointMap(shareId, roleId.Value, mountPoint.Value, Optional.ToNullable(mountType), Optional.ToNullable(roleType));
        }
    }
}
