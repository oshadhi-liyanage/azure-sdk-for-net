// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class RelationshipsLookup
    {
        internal static RelationshipsLookup DeserializeRelationshipsLookup(JsonElement element)
        {
            Optional<string> profileName = default;
            Optional<IReadOnlyList<ParticipantProfilePropertyReference>> profilePropertyReferences = default;
            Optional<string> relatedProfileName = default;
            Optional<IReadOnlyList<ParticipantProfilePropertyReference>> relatedProfilePropertyReferences = default;
            Optional<string> existingRelationshipName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item));
                    }
                    profilePropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("relatedProfileName"u8))
                {
                    relatedProfileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relatedProfilePropertyReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ParticipantProfilePropertyReference> array = new List<ParticipantProfilePropertyReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParticipantProfilePropertyReference.DeserializeParticipantProfilePropertyReference(item));
                    }
                    relatedProfilePropertyReferences = array;
                    continue;
                }
                if (property.NameEquals("existingRelationshipName"u8))
                {
                    existingRelationshipName = property.Value.GetString();
                    continue;
                }
            }
            return new RelationshipsLookup(profileName.Value, Optional.ToList(profilePropertyReferences), relatedProfileName.Value, Optional.ToList(relatedProfilePropertyReferences), existingRelationshipName.Value);
        }
    }
}
