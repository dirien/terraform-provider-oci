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
    /// This resource provides the HeatWave cluster resource in Oracle Cloud Infrastructure MySQL Database service.
    /// 
    /// Updates the HeatWave cluster.
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
    ///         var testHeatWaveCluster = new Oci.MysqlHeatWaveCluster("testHeatWaveCluster", new Oci.MysqlHeatWaveClusterArgs
    ///         {
    ///             DbSystemId = oci_database_db_system.Test_db_system.Id,
    ///             ClusterSize = @var.Heat_wave_cluster_cluster_size,
    ///             ShapeName = oci_mysql_shape.Test_shape.Name,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// HeatWaveCluster can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:index/mysqlHeatWaveCluster:MysqlHeatWaveCluster test_heat_wave_cluster "dbSystem/{dbSystemId}/heatWaveCluster"
    /// ```
    /// </summary>
    [OciResourceType("oci:index/mysqlHeatWaveCluster:MysqlHeatWaveCluster")]
    public partial class MysqlHeatWaveCluster : Pulumi.CustomResource
    {
        /// <summary>
        /// A HeatWave node is a compute host that is part of a HeatWave cluster.
        /// </summary>
        [Output("clusterNodes")]
        public Output<ImmutableArray<Outputs.MysqlHeatWaveClusterClusterNode>> ClusterNodes { get; private set; } = null!;

        /// <summary>
        /// (Updatable) A change to the number of nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with the new cluster of nodes. This may result in a significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Output("clusterSize")]
        public Output<int> ClusterSize { get; private set; } = null!;

        /// <summary>
        /// The DB System [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        [Output("dbSystemId")]
        public Output<string> DbSystemId { get; private set; } = null!;

        /// <summary>
        /// Additional information about the current lifecycleState.
        /// </summary>
        [Output("lifecycleDetails")]
        public Output<string> LifecycleDetails { get; private set; } = null!;

        /// <summary>
        /// (Updatable) A change to the shape of the nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with Compute instances of the new Shape. This may result in significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Output("shapeName")]
        public Output<string> ShapeName { get; private set; } = null!;

        /// <summary>
        /// (Updatable) The target state for the HeatWave cluster. Could be set to `ACTIVE` or `INACTIVE`.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The date and time the HeatWave cluster was created, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// The time the HeatWave cluster was last updated, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;


        /// <summary>
        /// Create a MysqlHeatWaveCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MysqlHeatWaveCluster(string name, MysqlHeatWaveClusterArgs args, CustomResourceOptions? options = null)
            : base("oci:index/mysqlHeatWaveCluster:MysqlHeatWaveCluster", name, args ?? new MysqlHeatWaveClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MysqlHeatWaveCluster(string name, Input<string> id, MysqlHeatWaveClusterState? state = null, CustomResourceOptions? options = null)
            : base("oci:index/mysqlHeatWaveCluster:MysqlHeatWaveCluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MysqlHeatWaveCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MysqlHeatWaveCluster Get(string name, Input<string> id, MysqlHeatWaveClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MysqlHeatWaveCluster(name, id, state, options);
        }
    }

    public sealed class MysqlHeatWaveClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) A change to the number of nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with the new cluster of nodes. This may result in a significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Input("clusterSize", required: true)]
        public Input<int> ClusterSize { get; set; } = null!;

        /// <summary>
        /// The DB System [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        [Input("dbSystemId", required: true)]
        public Input<string> DbSystemId { get; set; } = null!;

        /// <summary>
        /// (Updatable) A change to the shape of the nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with Compute instances of the new Shape. This may result in significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Input("shapeName", required: true)]
        public Input<string> ShapeName { get; set; } = null!;

        /// <summary>
        /// (Updatable) The target state for the HeatWave cluster. Could be set to `ACTIVE` or `INACTIVE`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public MysqlHeatWaveClusterArgs()
        {
        }
    }

    public sealed class MysqlHeatWaveClusterState : Pulumi.ResourceArgs
    {
        [Input("clusterNodes")]
        private InputList<Inputs.MysqlHeatWaveClusterClusterNodeGetArgs>? _clusterNodes;

        /// <summary>
        /// A HeatWave node is a compute host that is part of a HeatWave cluster.
        /// </summary>
        public InputList<Inputs.MysqlHeatWaveClusterClusterNodeGetArgs> ClusterNodes
        {
            get => _clusterNodes ?? (_clusterNodes = new InputList<Inputs.MysqlHeatWaveClusterClusterNodeGetArgs>());
            set => _clusterNodes = value;
        }

        /// <summary>
        /// (Updatable) A change to the number of nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with the new cluster of nodes. This may result in a significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Input("clusterSize")]
        public Input<int>? ClusterSize { get; set; }

        /// <summary>
        /// The DB System [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        [Input("dbSystemId")]
        public Input<string>? DbSystemId { get; set; }

        /// <summary>
        /// Additional information about the current lifecycleState.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        /// <summary>
        /// (Updatable) A change to the shape of the nodes in the HeatWave cluster will result in the entire cluster being torn down and re-created with Compute instances of the new Shape. This may result in significant downtime for the analytics capability while the HeatWave cluster is re-provisioned.
        /// </summary>
        [Input("shapeName")]
        public Input<string>? ShapeName { get; set; }

        /// <summary>
        /// (Updatable) The target state for the HeatWave cluster. Could be set to `ACTIVE` or `INACTIVE`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The date and time the HeatWave cluster was created, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The time the HeatWave cluster was last updated, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        public MysqlHeatWaveClusterState()
        {
        }
    }
}