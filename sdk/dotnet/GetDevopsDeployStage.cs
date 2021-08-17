// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetDevopsDeployStage
    {
        /// <summary>
        /// This data source provides details about a specific Deploy Stage resource in Oracle Cloud Infrastructure Devops service.
        /// 
        /// Retrieves a deployment stage by identifier.
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
        ///         var testDeployStage = Output.Create(Oci.GetDevopsDeployStage.InvokeAsync(new Oci.GetDevopsDeployStageArgs
        ///         {
        ///             DeployStageId = oci_devops_deploy_stage.Test_deploy_stage.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDevopsDeployStageResult> InvokeAsync(GetDevopsDeployStageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDevopsDeployStageResult>("oci:index/getDevopsDeployStage:GetDevopsDeployStage", args ?? new GetDevopsDeployStageArgs(), options.WithVersion());
    }


    public sealed class GetDevopsDeployStageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique stage identifier.
        /// </summary>
        [Input("deployStageId", required: true)]
        public string DeployStageId { get; set; } = null!;

        public GetDevopsDeployStageArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDevopsDeployStageResult
    {
        /// <summary>
        /// Specifies the approval policy.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageApprovalPolicyResult ApprovalPolicy;
        /// <summary>
        /// Collection of backend environment IP addresses.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageBlueBackendIpsResult BlueBackendIps;
        /// <summary>
        /// The OCID of a compartment.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A compute instance group environment OCID for rolling deployment.
        /// </summary>
        public readonly string ComputeInstanceGroupDeployEnvironmentId;
        /// <summary>
        /// User provided key and value pair configuration, which is assigned through constants or parameter.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Config;
        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// Optional binary artifact OCID user may provide to this stage.
        /// </summary>
        public readonly string DeployArtifactId;
        /// <summary>
        /// Additional file artifact OCIDs.
        /// </summary>
        public readonly ImmutableArray<string> DeployArtifactIds;
        /// <summary>
        /// The OCID of a pipeline.
        /// </summary>
        public readonly string DeployPipelineId;
        public readonly string DeployStageId;
        /// <summary>
        /// Collection containing the predecessors of a stage.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageDeployStagePredecessorCollectionResult DeployStagePredecessorCollection;
        /// <summary>
        /// Deployment stage type.
        /// </summary>
        public readonly string DeployStageType;
        /// <summary>
        /// The OCID of the artifact that contains the deployment specification.
        /// </summary>
        public readonly string DeploymentSpecDeployArtifactId;
        /// <summary>
        /// Optional description about the deployment stage.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Deployment stage display name, which can be renamed and is not necessarily unique. Avoid entering confidential information.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// A Docker image artifact OCID.
        /// </summary>
        public readonly string DockerImageDeployArtifactId;
        /// <summary>
        /// Specifies a failure policy for a compute instance group rolling deployment stage.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageFailurePolicyResult FailurePolicy;
        /// <summary>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// Function environment OCID.
        /// </summary>
        public readonly string FunctionDeployEnvironmentId;
        /// <summary>
        /// Timeout for execution of the Function. Value in seconds.
        /// </summary>
        public readonly int FunctionTimeoutInSeconds;
        /// <summary>
        /// Collection of backend environment IP addresses.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageGreenBackendIpsResult GreenBackendIps;
        /// <summary>
        /// Unique identifier that is immutable on creation.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A boolean flag specifies whether this stage executes asynchronously.
        /// </summary>
        public readonly bool IsAsync;
        /// <summary>
        /// A boolean flag specifies whether the invoked function must be validated.
        /// </summary>
        public readonly bool IsValidationEnabled;
        /// <summary>
        /// List of Kubernetes manifest artifact OCIDs, the manifests should not include any job resource.
        /// </summary>
        public readonly ImmutableArray<string> KubernetesManifestDeployArtifactIds;
        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        public readonly string LifecycleDetails;
        /// <summary>
        /// Specifies config for load balancer traffic shift stages.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageLoadBalancerConfigResult LoadBalancerConfig;
        /// <summary>
        /// Maximum usable memory for the Function (in MB).
        /// </summary>
        public readonly string MaxMemoryInMbs;
        /// <summary>
        /// Default Namespace to be used for Kubernetes deployment when not specified in the manifest.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Kubernetes cluster environment OCID for deployment.
        /// </summary>
        public readonly string OkeClusterDeployEnvironmentId;
        /// <summary>
        /// The OCID of a project.
        /// </summary>
        public readonly string ProjectId;
        /// <summary>
        /// Specifies the rollback policy. This is initiated on the failure of certain stage types.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageRollbackPolicyResult RollbackPolicy;
        /// <summary>
        /// Description of rollout policy for load balancer traffic shift stage.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageRolloutPolicyResult RolloutPolicy;
        /// <summary>
        /// The current state of the deployment stage.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"orcl-cloud.free-tier-retained": "true"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> SystemTags;
        /// <summary>
        /// Time the deployment stage was created. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// Time the deployment stage was updated. Format defined by [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339).
        /// </summary>
        public readonly string TimeUpdated;
        /// <summary>
        /// Specifies the target or destination backend set.
        /// </summary>
        public readonly string TrafficShiftTarget;
        /// <summary>
        /// Specifies wait criteria for the Wait stage.
        /// </summary>
        public readonly Outputs.GetDevopsDeployStageWaitCriteriaResult WaitCriteria;

        [OutputConstructor]
        private GetDevopsDeployStageResult(
            Outputs.GetDevopsDeployStageApprovalPolicyResult approvalPolicy,

            Outputs.GetDevopsDeployStageBlueBackendIpsResult blueBackendIps,

            string compartmentId,

            string computeInstanceGroupDeployEnvironmentId,

            ImmutableDictionary<string, object> config,

            ImmutableDictionary<string, object> definedTags,

            string deployArtifactId,

            ImmutableArray<string> deployArtifactIds,

            string deployPipelineId,

            string deployStageId,

            Outputs.GetDevopsDeployStageDeployStagePredecessorCollectionResult deployStagePredecessorCollection,

            string deployStageType,

            string deploymentSpecDeployArtifactId,

            string description,

            string displayName,

            string dockerImageDeployArtifactId,

            Outputs.GetDevopsDeployStageFailurePolicyResult failurePolicy,

            ImmutableDictionary<string, object> freeformTags,

            string functionDeployEnvironmentId,

            int functionTimeoutInSeconds,

            Outputs.GetDevopsDeployStageGreenBackendIpsResult greenBackendIps,

            string id,

            bool isAsync,

            bool isValidationEnabled,

            ImmutableArray<string> kubernetesManifestDeployArtifactIds,

            string lifecycleDetails,

            Outputs.GetDevopsDeployStageLoadBalancerConfigResult loadBalancerConfig,

            string maxMemoryInMbs,

            string @namespace,

            string okeClusterDeployEnvironmentId,

            string projectId,

            Outputs.GetDevopsDeployStageRollbackPolicyResult rollbackPolicy,

            Outputs.GetDevopsDeployStageRolloutPolicyResult rolloutPolicy,

            string state,

            ImmutableDictionary<string, object> systemTags,

            string timeCreated,

            string timeUpdated,

            string trafficShiftTarget,

            Outputs.GetDevopsDeployStageWaitCriteriaResult waitCriteria)
        {
            ApprovalPolicy = approvalPolicy;
            BlueBackendIps = blueBackendIps;
            CompartmentId = compartmentId;
            ComputeInstanceGroupDeployEnvironmentId = computeInstanceGroupDeployEnvironmentId;
            Config = config;
            DefinedTags = definedTags;
            DeployArtifactId = deployArtifactId;
            DeployArtifactIds = deployArtifactIds;
            DeployPipelineId = deployPipelineId;
            DeployStageId = deployStageId;
            DeployStagePredecessorCollection = deployStagePredecessorCollection;
            DeployStageType = deployStageType;
            DeploymentSpecDeployArtifactId = deploymentSpecDeployArtifactId;
            Description = description;
            DisplayName = displayName;
            DockerImageDeployArtifactId = dockerImageDeployArtifactId;
            FailurePolicy = failurePolicy;
            FreeformTags = freeformTags;
            FunctionDeployEnvironmentId = functionDeployEnvironmentId;
            FunctionTimeoutInSeconds = functionTimeoutInSeconds;
            GreenBackendIps = greenBackendIps;
            Id = id;
            IsAsync = isAsync;
            IsValidationEnabled = isValidationEnabled;
            KubernetesManifestDeployArtifactIds = kubernetesManifestDeployArtifactIds;
            LifecycleDetails = lifecycleDetails;
            LoadBalancerConfig = loadBalancerConfig;
            MaxMemoryInMbs = maxMemoryInMbs;
            Namespace = @namespace;
            OkeClusterDeployEnvironmentId = okeClusterDeployEnvironmentId;
            ProjectId = projectId;
            RollbackPolicy = rollbackPolicy;
            RolloutPolicy = rolloutPolicy;
            State = state;
            SystemTags = systemTags;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
            TrafficShiftTarget = trafficShiftTarget;
            WaitCriteria = waitCriteria;
        }
    }
}