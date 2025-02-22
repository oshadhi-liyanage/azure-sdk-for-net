// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ServiceObjectiveListResult
    {
        internal static ServiceObjectiveListResult DeserializeServiceObjectiveListResult(JsonElement element)
        {
            IReadOnlyList<ServiceObjectiveData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ServiceObjectiveData> array = new List<ServiceObjectiveData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceObjectiveData.DeserializeServiceObjectiveData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ServiceObjectiveListResult(value);
        }
    }
}
