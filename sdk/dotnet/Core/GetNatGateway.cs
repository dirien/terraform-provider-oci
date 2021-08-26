// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core
{
    public static class GetNatGateway
    {
        /// <summary>
        /// This data source provides details about a specific Nat Gateway resource in Oracle Cloud Infrastructure Core service.
        /// 
        /// Gets the specified NAT gateway's information.
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
        ///         var testNatGateway = Output.Create(Oci.Core.GetNatGateway.InvokeAsync(new Oci.Core.GetNatGatewayArgs
        ///         {
        ///             NatGatewayId = oci_core_nat_gateway.Test_nat_gateway.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetNatGatewayResult> InvokeAsync(GetNatGatewayArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNatGatewayResult>("oci:core/getNatGateway:getNatGateway", args ?? new GetNatGatewayArgs(), options.WithVersion());
    }


    public sealed class GetNatGatewayArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The NAT gateway's [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        [Input("natGatewayId", required: true)]
        public string NatGatewayId { get; set; } = null!;

        public GetNatGatewayArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetNatGatewayResult
    {
        /// <summary>
        /// Whether the NAT gateway blocks traffic through it. The default is `false`.  Example: `true`
        /// </summary>
        public readonly bool BlockTraffic;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the NAT gateway.
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
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the NAT gateway.
        /// </summary>
        public readonly string Id;
        public readonly string NatGatewayId;
        /// <summary>
        /// The IP address associated with the NAT gateway.
        /// </summary>
        public readonly string NatIp;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the public IP address associated with the NAT gateway.
        /// </summary>
        public readonly string PublicIpId;
        /// <summary>
        /// The NAT gateway's current state.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The date and time the NAT gateway was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN the NAT gateway belongs to.
        /// </summary>
        public readonly string VcnId;

        [OutputConstructor]
        private GetNatGatewayResult(
            bool blockTraffic,

            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string displayName,

            ImmutableDictionary<string, object> freeformTags,

            string id,

            string natGatewayId,

            string natIp,

            string publicIpId,

            string state,

            string timeCreated,

            string vcnId)
        {
            BlockTraffic = blockTraffic;
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            DisplayName = displayName;
            FreeformTags = freeformTags;
            Id = id;
            NatGatewayId = natGatewayId;
            NatIp = natIp;
            PublicIpId = publicIpId;
            State = state;
            TimeCreated = timeCreated;
            VcnId = vcnId;
        }
    }
}