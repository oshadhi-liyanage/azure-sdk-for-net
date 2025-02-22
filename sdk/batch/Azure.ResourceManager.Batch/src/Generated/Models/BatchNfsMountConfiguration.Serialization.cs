// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchNfsMountConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
            }
            writer.WriteEndObject();
        }

        internal static BatchNfsMountConfiguration DeserializeBatchNfsMountConfiguration(JsonElement element)
        {
            string source = default;
            string relativeMountPath = default;
            Optional<string> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
            }
            return new BatchNfsMountConfiguration(source, relativeMountPath, mountOptions.Value);
        }
    }
}
