// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceAppleProvider : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Registration))
            {
                writer.WritePropertyName("registration"u8);
                writer.WriteObjectValue(Registration);
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteObjectValue(Login);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceAppleProvider DeserializeAppServiceAppleProvider(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<AppServiceAppleRegistration> registration = default;
            Optional<LoginScopes> login = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("registration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registration = AppServiceAppleRegistration.DeserializeAppServiceAppleRegistration(property.Value);
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    login = Models.LoginScopes.DeserializeLoginScopes(property.Value);
                    continue;
                }
            }
            return new AppServiceAppleProvider(Optional.ToNullable(enabled), registration.Value, login.Value);
        }
    }
}
