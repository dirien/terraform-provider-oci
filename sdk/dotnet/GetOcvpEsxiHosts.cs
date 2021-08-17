// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetOcvpEsxiHosts
    {
        /// <summary>
        /// This data source provides the list of Esxi Hosts in Oracle Cloud Infrastructure Oracle Cloud VMware Solution service.
        /// 
        /// Lists the ESXi hosts in the specified SDDC. The list can be filtered
        /// by Compute instance OCID or ESXi display name.
        /// 
        /// Remember that in terms of implementation, an ESXi host is a Compute instance that
        /// is configured with the chosen bundle of VMware software. Each `EsxiHost`
        /// object has its own OCID (`id`), and a separate attribute for the OCID of
        /// the Compute instance (`computeInstanceId`). When filtering the list of
        /// ESXi hosts, you can specify the OCID of the Compute instance, not the
        /// ESXi host OCID.
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
        ///         var testEsxiHosts = Output.Create(Oci.GetOcvpEsxiHosts.InvokeAsync(new Oci.GetOcvpEsxiHostsArgs
        ///         {
        ///             ComputeInstanceId = oci_core_instance.Test_instance.Id,
        ///             DisplayName = @var.Esxi_host_display_name,
        ///             SddcId = oci_ocvp_sddc.Test_sddc.Id,
        ///             State = @var.Esxi_host_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetOcvpEsxiHostsResult> InvokeAsync(GetOcvpEsxiHostsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetOcvpEsxiHostsResult>("oci:index/getOcvpEsxiHosts:GetOcvpEsxiHosts", args ?? new GetOcvpEsxiHostsArgs(), options.WithVersion());
    }


    public sealed class GetOcvpEsxiHostsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Compute instance.
        /// </summary>
        [Input("computeInstanceId")]
        public string? ComputeInstanceId { get; set; }

        /// <summary>
        /// A filter to return only resources that match the given display name exactly.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetOcvpEsxiHostsFilterArgs>? _filters;
        public List<Inputs.GetOcvpEsxiHostsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetOcvpEsxiHostsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the SDDC.
        /// </summary>
        [Input("sddcId")]
        public string? SddcId { get; set; }

        /// <summary>
        /// The lifecycle state of the resource.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetOcvpEsxiHostsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetOcvpEsxiHostsResult
    {
        /// <summary>
        /// In terms of implementation, an ESXi host is a Compute instance that is configured with the chosen bundle of VMware software. The `computeInstanceId` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of that Compute instance.
        /// </summary>
        public readonly string? ComputeInstanceId;
        /// <summary>
        /// A descriptive name for the ESXi host. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The list of esxi_host_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetOcvpEsxiHostsEsxiHostCollectionResult> EsxiHostCollections;
        public readonly ImmutableArray<Outputs.GetOcvpEsxiHostsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the SDDC that the ESXi host belongs to.
        /// </summary>
        public readonly string? SddcId;
        /// <summary>
        /// The current state of the ESXi host.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetOcvpEsxiHostsResult(
            string? computeInstanceId,

            string? displayName,

            ImmutableArray<Outputs.GetOcvpEsxiHostsEsxiHostCollectionResult> esxiHostCollections,

            ImmutableArray<Outputs.GetOcvpEsxiHostsFilterResult> filters,

            string id,

            string? sddcId,

            string? state)
        {
            ComputeInstanceId = computeInstanceId;
            DisplayName = displayName;
            EsxiHostCollections = esxiHostCollections;
            Filters = filters;
            Id = id;
            SddcId = sddcId;
            State = state;
        }
    }
}