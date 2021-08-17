// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetCoreImages
    {
        /// <summary>
        /// This data source provides the list of Images in Oracle Cloud Infrastructure Core service.
        /// 
        /// Lists the available images in the specified compartment, including
        /// [platform images](https://docs.cloud.oracle.com/iaas/Content/Compute/References/images.htm) and
        /// [custom images](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/managingcustomimages.htm) that have
        /// been created.
        /// 
        /// The list of images that's returned is ordered to first show all
        /// platform images, then all custom images. The order of images might
        /// change when new images are released.
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
        ///         var testImages = Output.Create(Oci.GetCoreImages.InvokeAsync(new Oci.GetCoreImagesArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Image_display_name,
        ///             OperatingSystem = @var.Image_operating_system,
        ///             OperatingSystemVersion = @var.Image_operating_system_version,
        ///             Shape = @var.Image_shape,
        ///             State = @var.Image_state,
        ///             SortBy = @var.Image_sort_by,
        ///             SortOrder = @var.Image_sort_order,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCoreImagesResult> InvokeAsync(GetCoreImagesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCoreImagesResult>("oci:index/getCoreImages:GetCoreImages", args ?? new GetCoreImagesArgs(), options.WithVersion());
    }


    public sealed class GetCoreImagesArgs : Pulumi.InvokeArgs
    {
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
        private List<Inputs.GetCoreImagesFilterArgs>? _filters;
        public List<Inputs.GetCoreImagesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetCoreImagesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The image's operating system.  Example: `Oracle Linux`
        /// </summary>
        [Input("operatingSystem")]
        public string? OperatingSystem { get; set; }

        /// <summary>
        /// The image's operating system version.  Example: `7.2`
        /// </summary>
        [Input("operatingSystemVersion")]
        public string? OperatingSystemVersion { get; set; }

        /// <summary>
        /// Shape name.
        /// </summary>
        [Input("shape")]
        public string? Shape { get; set; }

        /// <summary>
        /// Sort the resources returned, by creation time or display name. Example `TIMECREATED` or `DISPLAYNAME`.
        /// </summary>
        [Input("sortBy")]
        public string? SortBy { get; set; }

        /// <summary>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// </summary>
        [Input("sortOrder")]
        public string? SortOrder { get; set; }

        /// <summary>
        /// A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetCoreImagesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCoreImagesResult
    {
        /// <summary>
        /// The OCID of the compartment containing the instance you want to use as the basis for the image.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A user-friendly name for the image. It does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetCoreImagesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of images.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCoreImagesImageResult> Images;
        /// <summary>
        /// The image's operating system.  Example: `Oracle Linux`
        /// </summary>
        public readonly string? OperatingSystem;
        /// <summary>
        /// The image's operating system version.  Example: `7.2`
        /// </summary>
        public readonly string? OperatingSystemVersion;
        public readonly string? Shape;
        public readonly string? SortBy;
        public readonly string? SortOrder;
        /// <summary>
        /// The current state of the image.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetCoreImagesResult(
            string compartmentId,

            string? displayName,

            ImmutableArray<Outputs.GetCoreImagesFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetCoreImagesImageResult> images,

            string? operatingSystem,

            string? operatingSystemVersion,

            string? shape,

            string? sortBy,

            string? sortOrder,

            string? state)
        {
            CompartmentId = compartmentId;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            Images = images;
            OperatingSystem = operatingSystem;
            OperatingSystemVersion = operatingSystemVersion;
            Shape = shape;
            SortBy = sortBy;
            SortOrder = sortOrder;
            State = state;
        }
    }
}