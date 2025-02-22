// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FactoryGlobalParameterSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
            writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Value.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static FactoryGlobalParameterSpecification DeserializeFactoryGlobalParameterSpecification(JsonElement element)
        {
            FactoryGlobalParameterType type = default;
            BinaryData value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new FactoryGlobalParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new FactoryGlobalParameterSpecification(type, value);
        }
    }
}
