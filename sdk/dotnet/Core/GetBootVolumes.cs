// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core
{
    public static class GetBootVolumes
    {
        /// <summary>
        /// This data source provides the list of Boot Volumes in Oracle Cloud Infrastructure Core service.
        /// 
        /// Lists the boot volumes in the specified compartment and availability domain.
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
        ///         var testBootVolumes = Output.Create(Oci.Core.GetBootVolumes.InvokeAsync(new Oci.Core.GetBootVolumesArgs
        ///         {
        ///             AvailabilityDomain = @var.Boot_volume_availability_domain,
        ///             CompartmentId = @var.Compartment_id,
        ///             VolumeGroupId = oci_core_volume_group.Test_volume_group.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBootVolumesResult> InvokeAsync(GetBootVolumesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBootVolumesResult>("oci:core/getBootVolumes:getBootVolumes", args ?? new GetBootVolumesArgs(), options.WithVersion());
    }


    public sealed class GetBootVolumesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the availability domain.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        [Input("availabilityDomain", required: true)]
        public string AvailabilityDomain { get; set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetBootVolumesFilterArgs>? _filters;
        public List<Inputs.GetBootVolumesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetBootVolumesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The OCID of the volume group.
        /// </summary>
        [Input("volumeGroupId")]
        public string? VolumeGroupId { get; set; }

        public GetBootVolumesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBootVolumesResult
    {
        /// <summary>
        /// The availability domain of the boot volume replica.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        public readonly string AvailabilityDomain;
        /// <summary>
        /// The list of boot_volumes.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBootVolumesBootVolumeResult> BootVolumes;
        /// <summary>
        /// The OCID of the compartment that contains the boot volume.
        /// </summary>
        public readonly string CompartmentId;
        public readonly ImmutableArray<Outputs.GetBootVolumesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The OCID of the source volume group.
        /// </summary>
        public readonly string? VolumeGroupId;

        [OutputConstructor]
        private GetBootVolumesResult(
            string availabilityDomain,

            ImmutableArray<Outputs.GetBootVolumesBootVolumeResult> bootVolumes,

            string compartmentId,

            ImmutableArray<Outputs.GetBootVolumesFilterResult> filters,

            string id,

            string? volumeGroupId)
        {
            AvailabilityDomain = availabilityDomain;
            BootVolumes = bootVolumes;
            CompartmentId = compartmentId;
            Filters = filters;
            Id = id;
            VolumeGroupId = volumeGroupId;
        }
    }
}