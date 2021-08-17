// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetHealthChecksPingMonitors
    {
        /// <summary>
        /// This data source provides the list of Ping Monitors in Oracle Cloud Infrastructure Health Checks service.
        /// 
        /// Gets a list of configured ping monitors.
        /// 
        /// Results are paginated based on `page` and `limit`.  The `opc-next-page` header provides
        /// a URL for fetching the next page.
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
        ///         var testPingMonitors = Output.Create(Oci.GetHealthChecksPingMonitors.InvokeAsync(new Oci.GetHealthChecksPingMonitorsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Ping_monitor_display_name,
        ///             HomeRegion = @var.Ping_monitor_home_region,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetHealthChecksPingMonitorsResult> InvokeAsync(GetHealthChecksPingMonitorsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetHealthChecksPingMonitorsResult>("oci:index/getHealthChecksPingMonitors:GetHealthChecksPingMonitors", args ?? new GetHealthChecksPingMonitorsArgs(), options.WithVersion());
    }


    public sealed class GetHealthChecksPingMonitorsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filters results by compartment.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// Filters results that exactly match the `displayName` field.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetHealthChecksPingMonitorsFilterArgs>? _filters;
        public List<Inputs.GetHealthChecksPingMonitorsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetHealthChecksPingMonitorsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Filters results that match the `homeRegion`.
        /// </summary>
        [Input("homeRegion")]
        public string? HomeRegion { get; set; }

        public GetHealthChecksPingMonitorsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetHealthChecksPingMonitorsResult
    {
        /// <summary>
        /// The OCID of the compartment.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A user-friendly and mutable name suitable for display in a user interface.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetHealthChecksPingMonitorsFilterResult> Filters;
        /// <summary>
        /// The region where updates must be made and where results must be fetched from.
        /// </summary>
        public readonly string? HomeRegion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The list of ping_monitors.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHealthChecksPingMonitorsPingMonitorResult> PingMonitors;

        [OutputConstructor]
        private GetHealthChecksPingMonitorsResult(
            string compartmentId,

            string? displayName,

            ImmutableArray<Outputs.GetHealthChecksPingMonitorsFilterResult> filters,

            string? homeRegion,

            string id,

            ImmutableArray<Outputs.GetHealthChecksPingMonitorsPingMonitorResult> pingMonitors)
        {
            CompartmentId = compartmentId;
            DisplayName = displayName;
            Filters = filters;
            HomeRegion = homeRegion;
            Id = id;
            PingMonitors = pingMonitors;
        }
    }
}