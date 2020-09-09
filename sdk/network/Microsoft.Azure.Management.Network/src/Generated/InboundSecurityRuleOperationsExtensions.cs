// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InboundSecurityRuleOperations.
    /// </summary>
    public static partial class InboundSecurityRuleOperationsExtensions
    {
            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance Inbound Security
            /// Rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of the Network Virtual Appliance.
            /// </param>
            /// <param name='ruleCollectionName'>
            /// The name of security rule collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance
            /// Inbound Security Rules operation.
            /// </param>
            public static InboundSecurityRule CreateOrUpdate(this IInboundSecurityRuleOperations operations, string resourceGroupName, string networkVirtualApplianceName, string ruleCollectionName, InboundSecurityRule parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, networkVirtualApplianceName, ruleCollectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance Inbound Security
            /// Rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of the Network Virtual Appliance.
            /// </param>
            /// <param name='ruleCollectionName'>
            /// The name of security rule collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance
            /// Inbound Security Rules operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InboundSecurityRule> CreateOrUpdateAsync(this IInboundSecurityRuleOperations operations, string resourceGroupName, string networkVirtualApplianceName, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, ruleCollectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance Inbound Security
            /// Rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of the Network Virtual Appliance.
            /// </param>
            /// <param name='ruleCollectionName'>
            /// The name of security rule collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance
            /// Inbound Security Rules operation.
            /// </param>
            public static InboundSecurityRule BeginCreateOrUpdate(this IInboundSecurityRuleOperations operations, string resourceGroupName, string networkVirtualApplianceName, string ruleCollectionName, InboundSecurityRule parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, networkVirtualApplianceName, ruleCollectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance Inbound Security
            /// Rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of the Network Virtual Appliance.
            /// </param>
            /// <param name='ruleCollectionName'>
            /// The name of security rule collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance
            /// Inbound Security Rules operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InboundSecurityRule> BeginCreateOrUpdateAsync(this IInboundSecurityRuleOperations operations, string resourceGroupName, string networkVirtualApplianceName, string ruleCollectionName, InboundSecurityRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, ruleCollectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}