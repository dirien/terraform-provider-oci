// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.LogAnalytics
{
    public static class GetLogAnalyticsLogGroup
    {
        /// <summary>
        /// This data source provides details about a specific Log Analytics Log Group resource in Oracle Cloud Infrastructure Log Analytics service.
        /// 
        /// Gets detailed information about the specified log group such as display name, description, defined tags, and free-form tags.
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
        ///         var testLogAnalyticsLogGroup = Output.Create(Oci.LogAnalytics.GetLogAnalyticsLogGroup.InvokeAsync(new Oci.LogAnalytics.GetLogAnalyticsLogGroupArgs
        ///         {
        ///             LogAnalyticsLogGroupId = oci_log_analytics_log_analytics_log_group.Test_log_analytics_log_group.Id,
        ///             Namespace = @var.Log_analytics_log_group_namespace,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetLogAnalyticsLogGroupResult> InvokeAsync(GetLogAnalyticsLogGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLogAnalyticsLogGroupResult>("oci:loganalytics/getLogAnalyticsLogGroup:getLogAnalyticsLogGroup", args ?? new GetLogAnalyticsLogGroupArgs(), options.WithVersion());
    }


    public sealed class GetLogAnalyticsLogGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// unique logAnalytics log group identifier
        /// </summary>
        [Input("logAnalyticsLogGroupId", required: true)]
        public string LogAnalyticsLogGroupId { get; set; } = null!;

        /// <summary>
        /// The Logging Analytics namespace used for the request.
        /// </summary>
        [Input("namespace", required: true)]
        public string Namespace { get; set; } = null!;

        public GetLogAnalyticsLogGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLogAnalyticsLogGroupResult
    {
        /// <summary>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// Description for this resource.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// A user-friendly name that is changeable and that does not have to be unique. Format: a leading alphanumeric, followed by zero or more alphanumerics, underscores, spaces, backslashes, or hyphens in any order). No trailing spaces allowed.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// The log analytics entity OCID. This ID is a reference used by log analytics features and it represents a resource that is provisioned and managed by the customer on their premises or on the cloud.
        /// </summary>
        public readonly string Id;
        public readonly string LogAnalyticsLogGroupId;
        public readonly string Namespace;
        /// <summary>
        /// The date and time the resource was created, in the format defined by RFC3339.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// The date and time the resource was last updated, in the format defined by RFC3339.
        /// </summary>
        public readonly string TimeUpdated;

        [OutputConstructor]
        private GetLogAnalyticsLogGroupResult(
            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string description,

            string displayName,

            ImmutableDictionary<string, object> freeformTags,

            string id,

            string logAnalyticsLogGroupId,

            string @namespace,

            string timeCreated,

            string timeUpdated)
        {
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            Description = description;
            DisplayName = displayName;
            FreeformTags = freeformTags;
            Id = id;
            LogAnalyticsLogGroupId = logAnalyticsLogGroupId;
            Namespace = @namespace;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
        }
    }
}