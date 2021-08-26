// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.AiAnomalyDetection
{
    public static class GetProjects
    {
        /// <summary>
        /// This data source provides the list of Projects in Oracle Cloud Infrastructure Ai Anomaly Detection service.
        /// 
        /// Returns a list of  Projects.
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
        ///         var testProjects = Output.Create(Oci.AiAnomalyDetection.GetProjects.InvokeAsync(new Oci.AiAnomalyDetection.GetProjectsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Project_display_name,
        ///             State = @var.Project_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProjectsResult> InvokeAsync(GetProjectsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProjectsResult>("oci:aianomalydetection/getProjects:getProjects", args ?? new GetProjectsArgs(), options.WithVersion());
    }


    public sealed class GetProjectsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the compartment in which to list resources.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// A filter to return only resources that match the entire display name given.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetProjectsFilterArgs>? _filters;
        public List<Inputs.GetProjectsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetProjectsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// &lt;b&gt;Filter&lt;/b&gt; results by the specified lifecycle state. Must be a valid state for the resource type.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetProjectsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProjectsResult
    {
        /// <summary>
        /// The OCID for the project's compartment.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetProjectsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of project_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProjectsProjectCollectionResult> ProjectCollections;
        /// <summary>
        /// The lifecycle state of the Project.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetProjectsResult(
            string compartmentId,

            string? displayName,

            ImmutableArray<Outputs.GetProjectsFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetProjectsProjectCollectionResult> projectCollections,

            string? state)
        {
            CompartmentId = compartmentId;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            ProjectCollections = projectCollections;
            State = state;
        }
    }
}