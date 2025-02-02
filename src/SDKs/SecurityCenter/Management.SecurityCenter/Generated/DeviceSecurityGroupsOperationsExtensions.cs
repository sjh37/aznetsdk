// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeviceSecurityGroupsOperations.
    /// </summary>
    public static partial class DeviceSecurityGroupsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of device security groups for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            public static IPage<DeviceSecurityGroup> List(this IDeviceSecurityGroupsOperations operations, string resourceId)
            {
                return operations.ListAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of device security groups for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeviceSecurityGroup>> ListAsync(this IDeviceSecurityGroupsOperations operations, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the device security group for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            public static DeviceSecurityGroup Get(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName)
            {
                return operations.GetAsync(resourceId, deviceSecurityGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the device security group for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceSecurityGroup> GetAsync(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceId, deviceSecurityGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the device security group on a specified IoT hub
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            /// <param name='deviceSecurityGroup'>
            /// Security group object.
            /// </param>
            public static DeviceSecurityGroup CreateOrUpdate(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName, DeviceSecurityGroup deviceSecurityGroup)
            {
                return operations.CreateOrUpdateAsync(resourceId, deviceSecurityGroupName, deviceSecurityGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the device security group on a specified IoT hub
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            /// <param name='deviceSecurityGroup'>
            /// Security group object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceSecurityGroup> CreateOrUpdateAsync(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName, DeviceSecurityGroup deviceSecurityGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceId, deviceSecurityGroupName, deviceSecurityGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            public static void Delete(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName)
            {
                operations.DeleteAsync(resourceId, deviceSecurityGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='deviceSecurityGroupName'>
            /// The name of the security group. Please notice that the name is case
            /// insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDeviceSecurityGroupsOperations operations, string resourceId, string deviceSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceId, deviceSecurityGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of device security groups for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeviceSecurityGroup> ListNext(this IDeviceSecurityGroupsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of device security groups for the specified IoT hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeviceSecurityGroup>> ListNextAsync(this IDeviceSecurityGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
