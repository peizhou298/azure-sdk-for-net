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
    [JsonConverter(typeof(WebAppServicePlanUpdatedEventDataSkuConverter))]
    public partial class WebAppServicePlanUpdatedEventDataSku
    {
        internal static WebAppServicePlanUpdatedEventDataSku DeserializeWebAppServicePlanUpdatedEventDataSku(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<string> capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Family"))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Capacity"))
                {
                    capacity = property.Value.GetString();
                    continue;
                }
            }
            return new WebAppServicePlanUpdatedEventDataSku(name.Value, tier.Value, size.Value, family.Value, capacity.Value);
        }

        internal partial class WebAppServicePlanUpdatedEventDataSkuConverter : JsonConverter<WebAppServicePlanUpdatedEventDataSku>
        {
            public override void Write(Utf8JsonWriter writer, WebAppServicePlanUpdatedEventDataSku model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebAppServicePlanUpdatedEventDataSku Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebAppServicePlanUpdatedEventDataSku(document.RootElement);
            }
        }
    }
}
