// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Artifacts
{
    public static class GetContainerRepositories
    {
        /// <summary>
        /// This data source provides the list of Container Repositories in Oracle Cloud Infrastructure Artifacts service.
        /// 
        /// List container repositories in a compartment.
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
        ///         var testContainerRepositories = Output.Create(Oci.Artifacts.GetContainerRepositories.InvokeAsync(new Oci.Artifacts.GetContainerRepositoriesArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             CompartmentIdInSubtree = @var.Container_repository_compartment_id_in_subtree,
        ///             DisplayName = @var.Container_repository_display_name,
        ///             IsPublic = @var.Container_repository_is_public,
        ///             RepositoryId = oci_artifacts_repository.Test_repository.Id,
        ///             State = @var.Container_repository_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetContainerRepositoriesResult> InvokeAsync(GetContainerRepositoriesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetContainerRepositoriesResult>("oci:artifacts/getContainerRepositories:getContainerRepositories", args ?? new GetContainerRepositoriesArgs(), options.WithVersion());
    }


    public sealed class GetContainerRepositoriesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are inspected depending on the the setting of `accessLevel`. Default is false. Can only be set to true when calling the API on the tenancy (root compartment).
        /// </summary>
        [Input("compartmentIdInSubtree")]
        public bool? CompartmentIdInSubtree { get; set; }

        /// <summary>
        /// A filter to return only resources that match the given display name exactly.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetContainerRepositoriesFilterArgs>? _filters;
        public List<Inputs.GetContainerRepositoriesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetContainerRepositoriesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A filter to return resources that match the isPublic value.
        /// </summary>
        [Input("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// A filter to return container images only for the specified container repository OCID.
        /// </summary>
        [Input("repositoryId")]
        public string? RepositoryId { get; set; }

        /// <summary>
        /// A filter to return only resources that match the given lifecycle state name exactly.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetContainerRepositoriesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetContainerRepositoriesResult
    {
        /// <summary>
        /// The OCID of the compartment in which the container repository exists.
        /// </summary>
        public readonly string CompartmentId;
        public readonly bool? CompartmentIdInSubtree;
        /// <summary>
        /// The list of container_repository_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetContainerRepositoriesContainerRepositoryCollectionResult> ContainerRepositoryCollections;
        /// <summary>
        /// The container repository name.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetContainerRepositoriesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Whether the repository is public. A public repository allows unauthenticated access.
        /// </summary>
        public readonly bool? IsPublic;
        public readonly string? RepositoryId;
        /// <summary>
        /// The current state of the container repository.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetContainerRepositoriesResult(
            string compartmentId,

            bool? compartmentIdInSubtree,

            ImmutableArray<Outputs.GetContainerRepositoriesContainerRepositoryCollectionResult> containerRepositoryCollections,

            string? displayName,

            ImmutableArray<Outputs.GetContainerRepositoriesFilterResult> filters,

            string id,

            bool? isPublic,

            string? repositoryId,

            string? state)
        {
            CompartmentId = compartmentId;
            CompartmentIdInSubtree = compartmentIdInSubtree;
            ContainerRepositoryCollections = containerRepositoryCollections;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            IsPublic = isPublic;
            RepositoryId = repositoryId;
            State = state;
        }
    }
}