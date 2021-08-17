// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    /// <summary>
    /// This resource provides the Usage resource in Oracle Cloud Infrastructure Metering Computation service.
    /// 
    /// Returns usage for the given account.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Oci = Pulumi.Oci;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testUsage = new Oci.MeteringComputationUsage("testUsage", new Oci.MeteringComputationUsageArgs
    ///         {
    ///             Granularity = @var.Usage_granularity,
    ///             TenantId = oci_metering_computation_tenant.Test_tenant.Id,
    ///             TimeUsageEnded = @var.Usage_time_usage_ended,
    ///             TimeUsageStarted = @var.Usage_time_usage_started,
    ///             CompartmentDepth = @var.Usage_compartment_depth,
    ///             Filter = @var.Usage_filter,
    ///             Forecast = new Oci.Inputs.MeteringComputationUsageForecastArgs
    ///             {
    ///                 TimeForecastEnded = @var.Usage_forecast_time_forecast_ended,
    ///                 ForecastType = @var.Usage_forecast_forecast_type,
    ///                 TimeForecastStarted = @var.Usage_forecast_time_forecast_started,
    ///             },
    ///             GroupBies = @var.Usage_group_by,
    ///             GroupByTags = 
    ///             {
    ///                 new Oci.Inputs.MeteringComputationUsageGroupByTagArgs
    ///                 {
    ///                     Key = @var.Usage_group_by_tag_key,
    ///                     Namespace = @var.Usage_group_by_tag_namespace,
    ///                     Value = @var.Usage_group_by_tag_value,
    ///                 },
    ///             },
    ///             IsAggregateByTime = @var.Usage_is_aggregate_by_time,
    ///             QueryType = @var.Usage_query_type,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Import is not supported for this resource.
    /// </summary>
    [OciResourceType("oci:index/meteringComputationUsage:MeteringComputationUsage")]
    public partial class MeteringComputationUsage : Pulumi.CustomResource
    {
        /// <summary>
        /// The compartment depth level.
        /// </summary>
        [Output("compartmentDepth")]
        public Output<double> CompartmentDepth { get; private set; } = null!;

        [Output("filter")]
        public Output<string?> Filter { get; private set; } = null!;

        /// <summary>
        /// Forecast configuration of usage/cost.
        /// </summary>
        [Output("forecast")]
        public Output<Outputs.MeteringComputationUsageForecast> Forecast { get; private set; } = null!;

        /// <summary>
        /// The usage granularity. HOURLY - Hourly data aggregation. DAILY - Daily data aggregation. MONTHLY - Monthly data aggregation. TOTAL - Not yet supported.
        /// </summary>
        [Output("granularity")]
        public Output<string> Granularity { get; private set; } = null!;

        /// <summary>
        /// Aggregate the result by. example: `["tagNamespace", "tagKey", "tagValue", "service", "skuName", "skuPartNumber", "unit", "compartmentName", "compartmentPath", "compartmentId", "platform", "region", "logicalAd", "resourceId", "tenantId", "tenantName"]`
        /// </summary>
        [Output("groupBies")]
        public Output<ImmutableArray<string>> GroupBies { get; private set; } = null!;

        /// <summary>
        /// GroupBy a specific tagKey. Provide the tagNamespace and tagKey in the tag object. Only supports one tag in the list. For example: `[{"namespace":"oracle", "key":"createdBy"]`
        /// </summary>
        [Output("groupByTags")]
        public Output<ImmutableArray<Outputs.MeteringComputationUsageGroupByTag>> GroupByTags { get; private set; } = null!;

        /// <summary>
        /// Whether aggregated by time. If isAggregateByTime is true, all usage/cost over the query time period will be added up.
        /// </summary>
        [Output("isAggregateByTime")]
        public Output<bool> IsAggregateByTime { get; private set; } = null!;

        /// <summary>
        /// A list of usage items.
        /// </summary>
        [Output("items")]
        public Output<ImmutableArray<Outputs.MeteringComputationUsageItem>> Items { get; private set; } = null!;

        /// <summary>
        /// The query usage type. COST by default if it is missing. Usage - Query the usage data. Cost - Query the cost/billing data. Credit - Query the credit adjustments data. ExpiredCredit - Query the expired credits data. AllCredit - Query the credit adjustments and expired credit.
        /// </summary>
        [Output("queryType")]
        public Output<string> QueryType { get; private set; } = null!;

        /// <summary>
        /// Tenant ID.
        /// </summary>
        [Output("tenantId")]
        public Output<string> TenantId { get; private set; } = null!;

        /// <summary>
        /// The usage end time.
        /// </summary>
        [Output("timeUsageEnded")]
        public Output<string> TimeUsageEnded { get; private set; } = null!;

        /// <summary>
        /// The usage start time.
        /// </summary>
        [Output("timeUsageStarted")]
        public Output<string> TimeUsageStarted { get; private set; } = null!;


        /// <summary>
        /// Create a MeteringComputationUsage resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MeteringComputationUsage(string name, MeteringComputationUsageArgs args, CustomResourceOptions? options = null)
            : base("oci:index/meteringComputationUsage:MeteringComputationUsage", name, args ?? new MeteringComputationUsageArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MeteringComputationUsage(string name, Input<string> id, MeteringComputationUsageState? state = null, CustomResourceOptions? options = null)
            : base("oci:index/meteringComputationUsage:MeteringComputationUsage", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MeteringComputationUsage resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MeteringComputationUsage Get(string name, Input<string> id, MeteringComputationUsageState? state = null, CustomResourceOptions? options = null)
        {
            return new MeteringComputationUsage(name, id, state, options);
        }
    }

    public sealed class MeteringComputationUsageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The compartment depth level.
        /// </summary>
        [Input("compartmentDepth")]
        public Input<double>? CompartmentDepth { get; set; }

        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// Forecast configuration of usage/cost.
        /// </summary>
        [Input("forecast")]
        public Input<Inputs.MeteringComputationUsageForecastArgs>? Forecast { get; set; }

        /// <summary>
        /// The usage granularity. HOURLY - Hourly data aggregation. DAILY - Daily data aggregation. MONTHLY - Monthly data aggregation. TOTAL - Not yet supported.
        /// </summary>
        [Input("granularity", required: true)]
        public Input<string> Granularity { get; set; } = null!;

        [Input("groupBies")]
        private InputList<string>? _groupBies;

        /// <summary>
        /// Aggregate the result by. example: `["tagNamespace", "tagKey", "tagValue", "service", "skuName", "skuPartNumber", "unit", "compartmentName", "compartmentPath", "compartmentId", "platform", "region", "logicalAd", "resourceId", "tenantId", "tenantName"]`
        /// </summary>
        public InputList<string> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<string>());
            set => _groupBies = value;
        }

        [Input("groupByTags")]
        private InputList<Inputs.MeteringComputationUsageGroupByTagArgs>? _groupByTags;

        /// <summary>
        /// GroupBy a specific tagKey. Provide the tagNamespace and tagKey in the tag object. Only supports one tag in the list. For example: `[{"namespace":"oracle", "key":"createdBy"]`
        /// </summary>
        public InputList<Inputs.MeteringComputationUsageGroupByTagArgs> GroupByTags
        {
            get => _groupByTags ?? (_groupByTags = new InputList<Inputs.MeteringComputationUsageGroupByTagArgs>());
            set => _groupByTags = value;
        }

        /// <summary>
        /// Whether aggregated by time. If isAggregateByTime is true, all usage/cost over the query time period will be added up.
        /// </summary>
        [Input("isAggregateByTime")]
        public Input<bool>? IsAggregateByTime { get; set; }

        /// <summary>
        /// The query usage type. COST by default if it is missing. Usage - Query the usage data. Cost - Query the cost/billing data. Credit - Query the credit adjustments data. ExpiredCredit - Query the expired credits data. AllCredit - Query the credit adjustments and expired credit.
        /// </summary>
        [Input("queryType")]
        public Input<string>? QueryType { get; set; }

        /// <summary>
        /// Tenant ID.
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        /// <summary>
        /// The usage end time.
        /// </summary>
        [Input("timeUsageEnded", required: true)]
        public Input<string> TimeUsageEnded { get; set; } = null!;

        /// <summary>
        /// The usage start time.
        /// </summary>
        [Input("timeUsageStarted", required: true)]
        public Input<string> TimeUsageStarted { get; set; } = null!;

        public MeteringComputationUsageArgs()
        {
        }
    }

    public sealed class MeteringComputationUsageState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The compartment depth level.
        /// </summary>
        [Input("compartmentDepth")]
        public Input<double>? CompartmentDepth { get; set; }

        [Input("filter")]
        public Input<string>? Filter { get; set; }

        /// <summary>
        /// Forecast configuration of usage/cost.
        /// </summary>
        [Input("forecast")]
        public Input<Inputs.MeteringComputationUsageForecastGetArgs>? Forecast { get; set; }

        /// <summary>
        /// The usage granularity. HOURLY - Hourly data aggregation. DAILY - Daily data aggregation. MONTHLY - Monthly data aggregation. TOTAL - Not yet supported.
        /// </summary>
        [Input("granularity")]
        public Input<string>? Granularity { get; set; }

        [Input("groupBies")]
        private InputList<string>? _groupBies;

        /// <summary>
        /// Aggregate the result by. example: `["tagNamespace", "tagKey", "tagValue", "service", "skuName", "skuPartNumber", "unit", "compartmentName", "compartmentPath", "compartmentId", "platform", "region", "logicalAd", "resourceId", "tenantId", "tenantName"]`
        /// </summary>
        public InputList<string> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<string>());
            set => _groupBies = value;
        }

        [Input("groupByTags")]
        private InputList<Inputs.MeteringComputationUsageGroupByTagGetArgs>? _groupByTags;

        /// <summary>
        /// GroupBy a specific tagKey. Provide the tagNamespace and tagKey in the tag object. Only supports one tag in the list. For example: `[{"namespace":"oracle", "key":"createdBy"]`
        /// </summary>
        public InputList<Inputs.MeteringComputationUsageGroupByTagGetArgs> GroupByTags
        {
            get => _groupByTags ?? (_groupByTags = new InputList<Inputs.MeteringComputationUsageGroupByTagGetArgs>());
            set => _groupByTags = value;
        }

        /// <summary>
        /// Whether aggregated by time. If isAggregateByTime is true, all usage/cost over the query time period will be added up.
        /// </summary>
        [Input("isAggregateByTime")]
        public Input<bool>? IsAggregateByTime { get; set; }

        [Input("items")]
        private InputList<Inputs.MeteringComputationUsageItemGetArgs>? _items;

        /// <summary>
        /// A list of usage items.
        /// </summary>
        public InputList<Inputs.MeteringComputationUsageItemGetArgs> Items
        {
            get => _items ?? (_items = new InputList<Inputs.MeteringComputationUsageItemGetArgs>());
            set => _items = value;
        }

        /// <summary>
        /// The query usage type. COST by default if it is missing. Usage - Query the usage data. Cost - Query the cost/billing data. Credit - Query the credit adjustments data. ExpiredCredit - Query the expired credits data. AllCredit - Query the credit adjustments and expired credit.
        /// </summary>
        [Input("queryType")]
        public Input<string>? QueryType { get; set; }

        /// <summary>
        /// Tenant ID.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// The usage end time.
        /// </summary>
        [Input("timeUsageEnded")]
        public Input<string>? TimeUsageEnded { get; set; }

        /// <summary>
        /// The usage start time.
        /// </summary>
        [Input("timeUsageStarted")]
        public Input<string>? TimeUsageStarted { get; set; }

        public MeteringComputationUsageState()
        {
        }
    }
}