// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.AiAnomalyDetection
{
    public static class GetModel
    {
        /// <summary>
        /// This data source provides details about a specific Model resource in Oracle Cloud Infrastructure Ai Anomaly Detection service.
        /// 
        /// Gets a Model by identifier
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
        ///         var testModel = Output.Create(Oci.AiAnomalyDetection.GetModel.InvokeAsync(new Oci.AiAnomalyDetection.GetModelArgs
        ///         {
        ///             ModelId = oci_ai_anomaly_detection_model.Test_model.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetModelResult> InvokeAsync(GetModelArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetModelResult>("oci:aianomalydetection/getModel:getModel", args ?? new GetModelArgs(), options.WithVersion());
    }


    public sealed class GetModelArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The OCID of the Model.
        /// </summary>
        [Input("modelId", required: true)]
        public string ModelId { get; set; } = null!;

        public GetModelArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetModelResult
    {
        /// <summary>
        /// The OCID for the model's compartment.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// A short description of the Model.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// The OCID of the model that is immutable on creation.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        public readonly string LifecycleDetails;
        public readonly string ModelId;
        /// <summary>
        /// Specifies the details of the MSET model during the create call.
        /// </summary>
        public readonly Outputs.GetModelModelTrainingDetailsResult ModelTrainingDetails;
        /// <summary>
        /// Specifies the details for an Anomaly Detection model trained with MSET.
        /// </summary>
        public readonly Outputs.GetModelModelTrainingResultsResult ModelTrainingResults;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project to associate with the model.
        /// </summary>
        public readonly string ProjectId;
        /// <summary>
        /// The state of the model.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> SystemTags;
        /// <summary>
        /// The time the the Model was created. An RFC3339 formatted datetime string.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// The time the Model was updated. An RFC3339 formatted datetime string.
        /// </summary>
        public readonly string TimeUpdated;

        [OutputConstructor]
        private GetModelResult(
            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string description,

            string displayName,

            ImmutableDictionary<string, object> freeformTags,

            string id,

            string lifecycleDetails,

            string modelId,

            Outputs.GetModelModelTrainingDetailsResult modelTrainingDetails,

            Outputs.GetModelModelTrainingResultsResult modelTrainingResults,

            string projectId,

            string state,

            ImmutableDictionary<string, object> systemTags,

            string timeCreated,

            string timeUpdated)
        {
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            Description = description;
            DisplayName = displayName;
            FreeformTags = freeformTags;
            Id = id;
            LifecycleDetails = lifecycleDetails;
            ModelId = modelId;
            ModelTrainingDetails = modelTrainingDetails;
            ModelTrainingResults = modelTrainingResults;
            ProjectId = projectId;
            State = state;
            SystemTags = systemTags;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
        }
    }
}