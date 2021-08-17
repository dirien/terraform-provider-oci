// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetBdsAutoScalingConfiguration
    {
        /// <summary>
        /// This data source provides details about a specific Auto Scaling Configuration resource in Oracle Cloud Infrastructure Big Data Service service.
        /// 
        /// Returns details of the autoscale configuration identified by the given ID.
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
        ///         var testAutoScalingConfiguration = Output.Create(Oci.GetBdsAutoScalingConfiguration.InvokeAsync(new Oci.GetBdsAutoScalingConfigurationArgs
        ///         {
        ///             AutoScalingConfigurationId = oci_autoscaling_auto_scaling_configuration.Test_auto_scaling_configuration.Id,
        ///             BdsInstanceId = oci_bds_bds_instance.Test_bds_instance.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBdsAutoScalingConfigurationResult> InvokeAsync(GetBdsAutoScalingConfigurationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBdsAutoScalingConfigurationResult>("oci:index/getBdsAutoScalingConfiguration:GetBdsAutoScalingConfiguration", args ?? new GetBdsAutoScalingConfigurationArgs(), options.WithVersion());
    }


    public sealed class GetBdsAutoScalingConfigurationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique Oracle-assigned identifier of the autoscale configuration.
        /// </summary>
        [Input("autoScalingConfigurationId", required: true)]
        public string AutoScalingConfigurationId { get; set; } = null!;

        /// <summary>
        /// The OCID of the cluster.
        /// </summary>
        [Input("bdsInstanceId", required: true)]
        public string BdsInstanceId { get; set; } = null!;

        public GetBdsAutoScalingConfigurationArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBdsAutoScalingConfigurationResult
    {
        public readonly string AutoScalingConfigurationId;
        public readonly string BdsInstanceId;
        public readonly string ClusterAdminPassword;
        /// <summary>
        /// A user-friendly name. The name does not have to be unique, and it may be changed. Avoid entering confidential information.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The unique identifier for the autoscale configuration.
        /// </summary>
        public readonly string Id;
        public readonly bool IsEnabled;
        /// <summary>
        /// A node type that is managed by an autoscale configuration. The only supported type is WORKER.
        /// </summary>
        public readonly string NodeType;
        /// <summary>
        /// Policy definitions for the autoscale configuration.
        /// </summary>
        public readonly Outputs.GetBdsAutoScalingConfigurationPolicyResult Policy;
        /// <summary>
        /// The state of the autoscale configuration.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The time the cluster was created, shown as an RFC 3339 formatted datetime string.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// The time the autoscale configuration was updated, shown as an RFC 3339 formatted datetime string.
        /// </summary>
        public readonly string TimeUpdated;

        [OutputConstructor]
        private GetBdsAutoScalingConfigurationResult(
            string autoScalingConfigurationId,

            string bdsInstanceId,

            string clusterAdminPassword,

            string displayName,

            string id,

            bool isEnabled,

            string nodeType,

            Outputs.GetBdsAutoScalingConfigurationPolicyResult policy,

            string state,

            string timeCreated,

            string timeUpdated)
        {
            AutoScalingConfigurationId = autoScalingConfigurationId;
            BdsInstanceId = bdsInstanceId;
            ClusterAdminPassword = clusterAdminPassword;
            DisplayName = displayName;
            Id = id;
            IsEnabled = isEnabled;
            NodeType = nodeType;
            Policy = policy;
            State = state;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
        }
    }
}