// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class SubscriptionValidationEventData
    {
        internal static SubscriptionValidationEventData DeserializeSubscriptionValidationEventData(JsonElement element)
        {
            Optional<string> validationCode = default;
            Optional<string> validationUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationCode"))
                {
                    validationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationUrl"))
                {
                    validationUrl = property.Value.GetString();
                    continue;
                }
            }
            return new SubscriptionValidationEventData(validationCode.Value, validationUrl.Value);
        }
    }
}