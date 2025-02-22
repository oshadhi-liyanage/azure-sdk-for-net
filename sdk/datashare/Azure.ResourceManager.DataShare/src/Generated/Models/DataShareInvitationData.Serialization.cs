// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class DataShareInvitationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(TargetActiveDirectoryId))
            {
                writer.WritePropertyName("targetActiveDirectoryId"u8);
                writer.WriteStringValue(TargetActiveDirectoryId);
            }
            if (Optional.IsDefined(TargetEmail))
            {
                writer.WritePropertyName("targetEmail"u8);
                writer.WriteStringValue(TargetEmail);
            }
            if (Optional.IsDefined(TargetObjectId))
            {
                writer.WritePropertyName("targetObjectId"u8);
                writer.WriteStringValue(TargetObjectId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataShareInvitationData DeserializeDataShareInvitationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<Guid> invitationId = default;
            Optional<DataShareInvitationStatus> invitationStatus = default;
            Optional<DateTimeOffset> respondedAt = default;
            Optional<DateTimeOffset> sentAt = default;
            Optional<string> targetActiveDirectoryId = default;
            Optional<string> targetEmail = default;
            Optional<string> targetObjectId = default;
            Optional<string> userEmail = default;
            Optional<string> userName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("invitationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invitationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("invitationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            invitationStatus = new DataShareInvitationStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("respondedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            respondedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sentAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sentAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("targetActiveDirectoryId"u8))
                        {
                            targetActiveDirectoryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetEmail"u8))
                        {
                            targetEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetObjectId"u8))
                        {
                            targetObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userEmail"u8))
                        {
                            userEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataShareInvitationData(id, name, type, systemData.Value, Optional.ToNullable(expirationDate), Optional.ToNullable(invitationId), Optional.ToNullable(invitationStatus), Optional.ToNullable(respondedAt), Optional.ToNullable(sentAt), targetActiveDirectoryId.Value, targetEmail.Value, targetObjectId.Value, userEmail.Value, userName.Value);
        }
    }
}
