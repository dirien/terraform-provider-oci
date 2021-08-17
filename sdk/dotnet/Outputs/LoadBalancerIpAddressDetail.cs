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
    public sealed class LoadBalancerIpAddressDetail
    {
        public readonly string? IpAddress;
        public readonly bool? IsPublic;
        public readonly Outputs.LoadBalancerIpAddressDetailReservedIp? ReservedIp;

        [OutputConstructor]
        private LoadBalancerIpAddressDetail(
            string? ipAddress,

            bool? isPublic,

            Outputs.LoadBalancerIpAddressDetailReservedIp? reservedIp)
        {
            IpAddress = ipAddress;
            IsPublic = isPublic;
            ReservedIp = reservedIp;
        }
    }
}