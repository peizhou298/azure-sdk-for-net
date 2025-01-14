// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerRegistryEventDataConverter))]
    public partial class ContainerRegistryEventData
    {
        internal static ContainerRegistryEventData DeserializeContainerRegistryEventData(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<ContainerRegistryEventTarget> target = default;
            Optional<ContainerRegistryEventRequest> request = default;
            Optional<ContainerRegistryEventActor> actor = default;
            Optional<ContainerRegistryEventSource> source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    target = ContainerRegistryEventTarget.DeserializeContainerRegistryEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("request"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    request = ContainerRegistryEventRequest.DeserializeContainerRegistryEventRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("actor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actor = ContainerRegistryEventActor.DeserializeContainerRegistryEventActor(property.Value);
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = ContainerRegistryEventSource.DeserializeContainerRegistryEventSource(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryEventData(id.Value, Optional.ToNullable(timestamp), action.Value, target.Value, request.Value, actor.Value, source.Value);
        }

        internal partial class ContainerRegistryEventDataConverter : JsonConverter<ContainerRegistryEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerRegistryEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ContainerRegistryEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerRegistryEventData(document.RootElement);
            }
        }
    }
}
