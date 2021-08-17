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
    /// This resource provides the Table resource in Oracle Cloud Infrastructure NoSQL Database service.
    /// 
    /// Create a new table.
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
    ///         var testTable = new Oci.NosqlTable("testTable", new Oci.NosqlTableArgs
    ///         {
    ///             CompartmentId = @var.Compartment_id,
    ///             DdlStatement = @var.Table_ddl_statement,
    ///             TableLimits = new Oci.Inputs.NosqlTableTableLimitsArgs
    ///             {
    ///                 MaxReadUnits = @var.Table_table_limits_max_read_units,
    ///                 MaxStorageInGbs = @var.Table_table_limits_max_storage_in_gbs,
    ///                 MaxWriteUnits = @var.Table_table_limits_max_write_units,
    ///             },
    ///             DefinedTags = @var.Table_defined_tags,
    ///             FreeformTags = 
    ///             {
    ///                 { "bar-key", "value" },
    ///             },
    ///             IsAutoReclaimable = @var.Table_is_auto_reclaimable,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Tables can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:index/nosqlTable:NosqlTable test_table "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:index/nosqlTable:NosqlTable")]
    public partial class NosqlTable : Pulumi.CustomResource
    {
        /// <summary>
        /// (Updatable) Compartment Identifier.
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Complete CREATE TABLE DDL statement.
        /// </summary>
        [Output("ddlStatement")]
        public Output<string> DdlStatement { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        /// </summary>
        [Output("definedTags")]
        public Output<ImmutableDictionary<string, object>> DefinedTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        [Output("freeformTags")]
        public Output<ImmutableDictionary<string, object>> FreeformTags { get; private set; } = null!;

        /// <summary>
        /// True if table can be reclaimed after an idle period.
        /// </summary>
        [Output("isAutoReclaimable")]
        public Output<bool> IsAutoReclaimable { get; private set; } = null!;

        /// <summary>
        /// A message describing the current state in more detail.
        /// </summary>
        [Output("lifecycleDetails")]
        public Output<string> LifecycleDetails { get; private set; } = null!;

        /// <summary>
        /// Table name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The table schema information as a JSON object.
        /// </summary>
        [Output("schema")]
        public Output<Outputs.NosqlTableSchema> Schema { get; private set; } = null!;

        /// <summary>
        /// The state of a table.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        /// </summary>
        [Output("systemTags")]
        public Output<ImmutableDictionary<string, object>> SystemTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Throughput and storage limits configuration of a table.
        /// </summary>
        [Output("tableLimits")]
        public Output<Outputs.NosqlTableTableLimits> TableLimits { get; private set; } = null!;

        /// <summary>
        /// The time the the table was created. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeOfExpiration")]
        public Output<string> TimeOfExpiration { get; private set; } = null!;

        /// <summary>
        /// The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;


        /// <summary>
        /// Create a NosqlTable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NosqlTable(string name, NosqlTableArgs args, CustomResourceOptions? options = null)
            : base("oci:index/nosqlTable:NosqlTable", name, args ?? new NosqlTableArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NosqlTable(string name, Input<string> id, NosqlTableState? state = null, CustomResourceOptions? options = null)
            : base("oci:index/nosqlTable:NosqlTable", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NosqlTable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NosqlTable Get(string name, Input<string> id, NosqlTableState? state = null, CustomResourceOptions? options = null)
        {
            return new NosqlTable(name, id, state, options);
        }
    }

    public sealed class NosqlTableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) Compartment Identifier.
        /// </summary>
        [Input("compartmentId", required: true)]
        public Input<string> CompartmentId { get; set; } = null!;

        /// <summary>
        /// (Updatable) Complete CREATE TABLE DDL statement.
        /// </summary>
        [Input("ddlStatement", required: true)]
        public Input<string> DdlStatement { get; set; } = null!;

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// True if table can be reclaimed after an idle period.
        /// </summary>
        [Input("isAutoReclaimable")]
        public Input<bool>? IsAutoReclaimable { get; set; }

        /// <summary>
        /// Table name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// (Updatable) Throughput and storage limits configuration of a table.
        /// </summary>
        [Input("tableLimits", required: true)]
        public Input<Inputs.NosqlTableTableLimitsArgs> TableLimits { get; set; } = null!;

        public NosqlTableArgs()
        {
        }
    }

    public sealed class NosqlTableState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) Compartment Identifier.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        /// <summary>
        /// (Updatable) Complete CREATE TABLE DDL statement.
        /// </summary>
        [Input("ddlStatement")]
        public Input<string>? DdlStatement { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// True if table can be reclaimed after an idle period.
        /// </summary>
        [Input("isAutoReclaimable")]
        public Input<bool>? IsAutoReclaimable { get; set; }

        /// <summary>
        /// A message describing the current state in more detail.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        /// <summary>
        /// Table name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The table schema information as a JSON object.
        /// </summary>
        [Input("schema")]
        public Input<Inputs.NosqlTableSchemaGetArgs>? Schema { get; set; }

        /// <summary>
        /// The state of a table.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("systemTags")]
        private InputMap<object>? _systemTags;

        /// <summary>
        /// Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        /// </summary>
        public InputMap<object> SystemTags
        {
            get => _systemTags ?? (_systemTags = new InputMap<object>());
            set => _systemTags = value;
        }

        /// <summary>
        /// (Updatable) Throughput and storage limits configuration of a table.
        /// </summary>
        [Input("tableLimits")]
        public Input<Inputs.NosqlTableTableLimitsGetArgs>? TableLimits { get; set; }

        /// <summary>
        /// The time the the table was created. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeOfExpiration")]
        public Input<string>? TimeOfExpiration { get; set; }

        /// <summary>
        /// The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        public NosqlTableState()
        {
        }
    }
}