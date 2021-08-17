// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetCorePublicIpPools
    {
        /// <summary>
        /// This data source provides the list of Public Ip Pools in Oracle Cloud Infrastructure Core service.
        /// 
        /// Lists the public IP pools in the specified compartment.
        /// You can filter the list using query parameters.
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
        ///         var testPublicIpPools = Output.Create(Oci.GetCorePublicIpPools.InvokeAsync(new Oci.GetCorePublicIpPoolsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             ByoipRangeId = oci_core_byoip_range.Test_byoip_range.Id,
        ///             DisplayName = @var.Public_ip_pool_display_name,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCorePublicIpPoolsResult> InvokeAsync(GetCorePublicIpPoolsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCorePublicIpPoolsResult>("oci:index/getCorePublicIpPools:GetCorePublicIpPools", args ?? new GetCorePublicIpPoolsArgs(), options.WithVersion());
    }


    public sealed class GetCorePublicIpPoolsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// A filter to return only resources that match the given BYOIP CIDR block.
        /// </summary>
        [Input("byoipRangeId")]
        public string? ByoipRangeId { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// A filter to return only resources that match the given display name exactly.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetCorePublicIpPoolsFilterArgs>? _filters;
        public List<Inputs.GetCorePublicIpPoolsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetCorePublicIpPoolsFilterArgs>());
            set => _filters = value;
        }

        public GetCorePublicIpPoolsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCorePublicIpPoolsResult
    {
        public readonly string? ByoipRangeId;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing this pool.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetCorePublicIpPoolsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of public_ip_pool_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCorePublicIpPoolsPublicIpPoolCollectionResult> PublicIpPoolCollections;

        [OutputConstructor]
        private GetCorePublicIpPoolsResult(
            string? byoipRangeId,

            string compartmentId,

            string? displayName,

            ImmutableArray<Outputs.GetCorePublicIpPoolsFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetCorePublicIpPoolsPublicIpPoolCollectionResult> publicIpPoolCollections)
        {
            ByoipRangeId = byoipRangeId;
            CompartmentId = compartmentId;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            PublicIpPoolCollections = publicIpPoolCollections;
        }
    }
}