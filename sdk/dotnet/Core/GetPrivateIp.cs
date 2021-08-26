// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core
{
    public static class GetPrivateIp
    {
        /// <summary>
        /// This data source provides details about a specific Private Ip resource in Oracle Cloud Infrastructure Core service.
        /// 
        /// Gets the specified private IP. You must specify the object's OCID.
        /// Alternatively, you can get the object by using
        /// [ListPrivateIps](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/PrivateIp/ListPrivateIps)
        /// with the private IP address (for example, 10.0.3.3) and subnet OCID.
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Oci = Pulumi.Oci;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var testPrivateIp = Output.Create(Oci.Core.GetPrivateIp.InvokeAsync(new Oci.Core.GetPrivateIpArgs
        ///         {
        ///             PrivateIpId = oci_core_private_ip.Test_private_ip.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPrivateIpResult> InvokeAsync(GetPrivateIpArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateIpResult>("oci:core/getPrivateIp:getPrivateIp", args ?? new GetPrivateIpArgs(), options.WithVersion());
    }


    public sealed class GetPrivateIpArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the private IP.
        /// </summary>
        [Input("privateIpId", required: true)]
        public string PrivateIpId { get; set; } = null!;

        public GetPrivateIpArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateIpResult
    {
        /// <summary>
        /// The private IP's availability domain. This attribute will be null if this is a *secondary* private IP assigned to a VNIC that is in a *regional* subnet.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        public readonly string AvailabilityDomain;
        /// <summary>
        /// The OCID of the compartment containing the private IP.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// The hostname for the private IP. Used for DNS. The value is the hostname portion of the private IP's fully qualified domain name (FQDN) (for example, `bminstance-1` in FQDN `bminstance-1.subnet123.vcn1.oraclevcn.com`). Must be unique across all VNICs in the subnet and comply with [RFC 952](https://tools.ietf.org/html/rfc952) and [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// </summary>
        public readonly string HostnameLabel;
        /// <summary>
        /// The private IP's Oracle ID (OCID).
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The private IP address of the `privateIp` object. The address is within the CIDR of the VNIC's subnet.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// Whether this private IP is the primary one on the VNIC. Primary private IPs are unassigned and deleted automatically when the VNIC is terminated.  Example: `true`
        /// </summary>
        public readonly bool IsPrimary;
        /// <summary>
        /// true if the IP is reserved and can exist detached from vnic
        /// </summary>
        public readonly bool IsReserved;
        public readonly string PrivateIpId;
        /// <summary>
        /// The OCID of the subnet the VNIC is in.
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// The date and time the private IP was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// Applicable only if the `PrivateIp` object is being used with a VLAN as part of the Oracle Cloud VMware Solution. The `vlanId` is the OCID of the VLAN. See [Vlan](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/Vlan).
        /// </summary>
        public readonly string VlanId;
        /// <summary>
        /// The OCID of the VNIC the private IP is assigned to. The VNIC and private IP must be in the same subnet. However, if the `PrivateIp` object is being used with a VLAN as part of the Oracle Cloud VMware Solution, the `vnicId` is null.
        /// </summary>
        public readonly string VnicId;

        [OutputConstructor]
        private GetPrivateIpResult(
            string availabilityDomain,

            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string displayName,

            ImmutableDictionary<string, object> freeformTags,

            string hostnameLabel,

            string id,

            string ipAddress,

            bool isPrimary,

            bool isReserved,

            string privateIpId,

            string subnetId,

            string timeCreated,

            string vlanId,

            string vnicId)
        {
            AvailabilityDomain = availabilityDomain;
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            DisplayName = displayName;
            FreeformTags = freeformTags;
            HostnameLabel = hostnameLabel;
            Id = id;
            IpAddress = ipAddress;
            IsPrimary = isPrimary;
            IsReserved = isReserved;
            PrivateIpId = privateIpId;
            SubnetId = subnetId;
            TimeCreated = timeCreated;
            VlanId = vlanId;
            VnicId = vnicId;
        }
    }
}