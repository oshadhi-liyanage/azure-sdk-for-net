// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    internal partial class MySqlFlexibleServerBackupListResult
    {
        internal static MySqlFlexibleServerBackupListResult DeserializeMySqlFlexibleServerBackupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MySqlFlexibleServerBackupData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MySqlFlexibleServerBackupData> array = new List<MySqlFlexibleServerBackupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerBackupData.DeserializeMySqlFlexibleServerBackupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MySqlFlexibleServerBackupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
