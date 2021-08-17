// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Outputs
{

    [OutputType]
    public sealed class CoreInstancePoolLoadBalancer
    {
        /// <summary>
        /// The name of the backend set on the load balancer to add instances to.
        /// </summary>
        public readonly string BackendSetName;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer attachment.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance pool of the load balancer attachment.
        /// </summary>
        public readonly string? InstancePoolId;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer to attach to the instance pool.
        /// </summary>
        public readonly string LoadBalancerId;
        /// <summary>
        /// The port value to use when creating the backend set.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// (Updatable) The target state for the instance pool update operation (ignored at create time and should not be set). Could be set to RUNNING or STOPPED.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// Indicates which VNIC on each instance in the pool should be used to associate with the load balancer. Possible values are "PrimaryVnic" or the displayName of one of the secondary VNICs on the instance configuration that is associated with the instance pool.
        /// </summary>
        public readonly string VnicSelection;

        [OutputConstructor]
        private CoreInstancePoolLoadBalancer(
            string backendSetName,

            string? id,

            string? instancePoolId,

            string loadBalancerId,

            int port,

            string? state,

            string vnicSelection)
        {
            BackendSetName = backendSetName;
            Id = id;
            InstancePoolId = instancePoolId;
            LoadBalancerId = loadBalancerId;
            Port = port;
            State = state;
            VnicSelection = vnicSelection;
        }
    }
}