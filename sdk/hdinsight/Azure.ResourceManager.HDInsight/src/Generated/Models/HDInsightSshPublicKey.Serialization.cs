// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightSshPublicKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateData))
            {
                writer.WritePropertyName("certificateData"u8);
                writer.WriteStringValue(CertificateData);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightSshPublicKey DeserializeHDInsightSshPublicKey(JsonElement element)
        {
            Optional<string> certificateData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateData"u8))
                {
                    certificateData = property.Value.GetString();
                    continue;
                }
            }
            return new HDInsightSshPublicKey(certificateData.Value);
        }
    }
}
