// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisObjectMetadataStatusResult
    {
        internal static SsisObjectMetadataStatusResult DeserializeSsisObjectMetadataStatusResult(JsonElement element)
        {
            Optional<string> status = default;
            Optional<string> name = default;
            Optional<string> properties = default;
            Optional<string> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.GetString();
                    continue;
                }
            }
            return new SsisObjectMetadataStatusResult(status.Value, name.Value, properties.Value, error.Value);
        }
    }
}
