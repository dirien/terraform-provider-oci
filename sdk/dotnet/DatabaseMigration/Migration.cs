// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.DatabaseMigration
{
    /// <summary>
    /// This resource provides the Migration resource in Oracle Cloud Infrastructure Database Migration service.
    /// 
    /// Create a Migration resource that contains all the details to perform the
    /// database migration operation like source and destination database
    /// details, credentials, etc.
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
    ///         var testMigration = new Oci.DatabaseMigration.Migration("testMigration", new Oci.DatabaseMigration.MigrationArgs
    ///         {
    ///             CompartmentId = @var.Compartment_id,
    ///             SourceDatabaseConnectionId = oci_database_migration_connection.Test_connection.Id,
    ///             TargetDatabaseConnectionId = oci_database_migration_connection.Test_connection.Id,
    ///             Type = @var.Migration_type,
    ///             AgentId = oci_database_migration_agent.Test_agent.Id,
    ///             DataTransferMediumDetails = new Oci.DatabaseMigration.Inputs.MigrationDataTransferMediumDetailsArgs
    ///             {
    ///                 DatabaseLinkDetails = new Oci.DatabaseMigration.Inputs.MigrationDataTransferMediumDetailsDatabaseLinkDetailsArgs
    ///                 {
    ///                     Name = @var.Migration_data_transfer_medium_details_database_link_details_name,
    ///                 },
    ///                 ObjectStorageDetails = new Oci.DatabaseMigration.Inputs.MigrationDataTransferMediumDetailsObjectStorageDetailsArgs
    ///                 {
    ///                     Bucket = @var.Migration_data_transfer_medium_details_object_storage_details_bucket,
    ///                     Namespace = @var.Migration_data_transfer_medium_details_object_storage_details_namespace,
    ///                 },
    ///             },
    ///             DatapumpSettings = new Oci.DatabaseMigration.Inputs.MigrationDatapumpSettingsArgs
    ///             {
    ///                 DataPumpParameters = new Oci.DatabaseMigration.Inputs.MigrationDatapumpSettingsDataPumpParametersArgs
    ///                 {
    ///                     Estimate = @var.Migration_datapump_settings_data_pump_parameters_estimate,
    ///                     ExcludeParameters = @var.Migration_datapump_settings_data_pump_parameters_exclude_parameters,
    ///                     ExportParallelismDegree = @var.Migration_datapump_settings_data_pump_parameters_export_parallelism_degree,
    ///                     ImportParallelismDegree = @var.Migration_datapump_settings_data_pump_parameters_import_parallelism_degree,
    ///                     IsCluster = @var.Migration_datapump_settings_data_pump_parameters_is_cluster,
    ///                     TableExistsAction = @var.Migration_datapump_settings_data_pump_parameters_table_exists_action,
    ///                 },
    ///                 ExportDirectoryObject = new Oci.DatabaseMigration.Inputs.MigrationDatapumpSettingsExportDirectoryObjectArgs
    ///                 {
    ///                     Name = @var.Migration_datapump_settings_export_directory_object_name,
    ///                     Path = @var.Migration_datapump_settings_export_directory_object_path,
    ///                 },
    ///                 ImportDirectoryObject = new Oci.DatabaseMigration.Inputs.MigrationDatapumpSettingsImportDirectoryObjectArgs
    ///                 {
    ///                     Name = @var.Migration_datapump_settings_import_directory_object_name,
    ///                     Path = @var.Migration_datapump_settings_import_directory_object_path,
    ///                 },
    ///                 JobMode = @var.Migration_datapump_settings_job_mode,
    ///                 MetadataRemaps = 
    ///                 {
    ///                     new Oci.DatabaseMigration.Inputs.MigrationDatapumpSettingsMetadataRemapArgs
    ///                     {
    ///                         NewValue = @var.Migration_datapump_settings_metadata_remaps_new_value,
    ///                         OldValue = @var.Migration_datapump_settings_metadata_remaps_old_value,
    ///                         Type = @var.Migration_datapump_settings_metadata_remaps_type,
    ///                     },
    ///                 },
    ///             },
    ///             DefinedTags = 
    ///             {
    ///                 { "foo-namespace.bar-key", "value" },
    ///             },
    ///             DisplayName = @var.Migration_display_name,
    ///             ExcludeObjects = 
    ///             {
    ///                 new Oci.DatabaseMigration.Inputs.MigrationExcludeObjectArgs
    ///                 {
    ///                     Object = @var.Migration_exclude_objects_object,
    ///                     Owner = @var.Migration_exclude_objects_owner,
    ///                 },
    ///             },
    ///             FreeformTags = 
    ///             {
    ///                 { "bar-key", "value" },
    ///             },
    ///             GoldenGateDetails = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsArgs
    ///             {
    ///                 Hub = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsHubArgs
    ///                 {
    ///                     RestAdminCredentials = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsHubRestAdminCredentialsArgs
    ///                     {
    ///                         Password = @var.Migration_golden_gate_details_hub_rest_admin_credentials_password,
    ///                         Username = @var.Migration_golden_gate_details_hub_rest_admin_credentials_username,
    ///                     },
    ///                     SourceDbAdminCredentials = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsHubSourceDbAdminCredentialsArgs
    ///                     {
    ///                         Password = @var.Migration_golden_gate_details_hub_source_db_admin_credentials_password,
    ///                         Username = @var.Migration_golden_gate_details_hub_source_db_admin_credentials_username,
    ///                     },
    ///                     SourceMicroservicesDeploymentName = oci_apigateway_deployment.Test_deployment.Name,
    ///                     TargetDbAdminCredentials = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsHubTargetDbAdminCredentialsArgs
    ///                     {
    ///                         Password = @var.Migration_golden_gate_details_hub_target_db_admin_credentials_password,
    ///                         Username = @var.Migration_golden_gate_details_hub_target_db_admin_credentials_username,
    ///                     },
    ///                     TargetMicroservicesDeploymentName = oci_apigateway_deployment.Test_deployment.Name,
    ///                     Url = @var.Migration_golden_gate_details_hub_url,
    ///                     ComputeId = oci_database_migration_compute.Test_compute.Id,
    ///                     SourceContainerDbAdminCredentials = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsHubSourceContainerDbAdminCredentialsArgs
    ///                     {
    ///                         Password = @var.Migration_golden_gate_details_hub_source_container_db_admin_credentials_password,
    ///                         Username = @var.Migration_golden_gate_details_hub_source_container_db_admin_credentials_username,
    ///                     },
    ///                 },
    ///                 Settings = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsSettingsArgs
    ///                 {
    ///                     AcceptableLag = @var.Migration_golden_gate_details_settings_acceptable_lag,
    ///                     Extract = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsSettingsExtractArgs
    ///                     {
    ///                         LongTransDuration = @var.Migration_golden_gate_details_settings_extract_long_trans_duration,
    ///                         PerformanceProfile = @var.Migration_golden_gate_details_settings_extract_performance_profile,
    ///                     },
    ///                     Replicat = new Oci.DatabaseMigration.Inputs.MigrationGoldenGateDetailsSettingsReplicatArgs
    ///                     {
    ///                         MapParallelism = @var.Migration_golden_gate_details_settings_replicat_map_parallelism,
    ///                         MaxApplyParallelism = @var.Migration_golden_gate_details_settings_replicat_max_apply_parallelism,
    ///                         MinApplyParallelism = @var.Migration_golden_gate_details_settings_replicat_min_apply_parallelism,
    ///                     },
    ///                 },
    ///             },
    ///             SourceContainerDatabaseConnectionId = oci_database_migration_connection.Test_connection.Id,
    ///             VaultDetails = new Oci.DatabaseMigration.Inputs.MigrationVaultDetailsArgs
    ///             {
    ///                 CompartmentId = @var.Compartment_id,
    ///                 KeyId = oci_kms_key.Test_key.Id,
    ///                 VaultId = oci_kms_vault.Test_vault.Id,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Migrations can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:databasemigration/migration:Migration test_migration "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:databasemigration/migration:Migration")]
    public partial class Migration : Pulumi.CustomResource
    {
        /// <summary>
        /// (Updatable) The OCID of the registered ODMS Agent. Required for OFFLINE Migrations.
        /// </summary>
        [Output("agentId")]
        public Output<string> AgentId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) OCID of the compartment where the secret containing the credentials will be created.
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// OCID of the Secret in the Oracle Cloud Infrastructure vault containing the Migration credentials. Used to store Golden Gate admin user credentials.
        /// </summary>
        [Output("credentialsSecretId")]
        public Output<string> CredentialsSecretId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Data Transfer Medium details for the Migration. If not specified, it will default to Database Link. Only one type of medium details can be specified.
        /// </summary>
        [Output("dataTransferMediumDetails")]
        public Output<Outputs.MigrationDataTransferMediumDetails> DataTransferMediumDetails { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Optional settings for Datapump Export and Import jobs
        /// </summary>
        [Output("datapumpSettings")]
        public Output<Outputs.MigrationDatapumpSettings> DatapumpSettings { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        [Output("definedTags")]
        public Output<ImmutableDictionary<string, object>> DefinedTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Migration Display Name
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Database objects to exclude from migration.
        /// </summary>
        [Output("excludeObjects")]
        public Output<ImmutableArray<Outputs.MigrationExcludeObject>> ExcludeObjects { get; private set; } = null!;

        /// <summary>
        /// OCID of the current ODMS Job in execution for the Migration, if any.
        /// </summary>
        [Output("executingJobId")]
        public Output<string> ExecutingJobId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        [Output("freeformTags")]
        public Output<ImmutableDictionary<string, object>> FreeformTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Details about Oracle GoldenGate Microservices. Required for online logical migration.
        /// </summary>
        [Output("goldenGateDetails")]
        public Output<Outputs.MigrationGoldenGateDetails> GoldenGateDetails { get; private set; } = null!;

        /// <summary>
        /// Additional status related to the execution and current state of the Migration.
        /// </summary>
        [Output("lifecycleDetails")]
        public Output<string> LifecycleDetails { get; private set; } = null!;

        /// <summary>
        /// (Updatable) The OCID of the Source Container Database Connection. Only used for ONLINE migrations. Only Connections of type Non-Autonomous can be used as source container databases.
        /// </summary>
        [Output("sourceContainerDatabaseConnectionId")]
        public Output<string> SourceContainerDatabaseConnectionId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) The OCID of the Source Database Connection.
        /// </summary>
        [Output("sourceDatabaseConnectionId")]
        public Output<string> SourceDatabaseConnectionId { get; private set; } = null!;

        /// <summary>
        /// The current state of the Migration Resource.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
        /// </summary>
        [Output("systemTags")]
        public Output<ImmutableDictionary<string, object>> SystemTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) The OCID of the Target Database Connection.
        /// </summary>
        [Output("targetDatabaseConnectionId")]
        public Output<string> TargetDatabaseConnectionId { get; private set; } = null!;

        /// <summary>
        /// The time the Migration was created. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// The time of last Migration. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeLastMigration")]
        public Output<string> TimeLastMigration { get; private set; } = null!;

        /// <summary>
        /// The time of the last Migration details update. An RFC3339 formatted datetime string.
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Migration type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Oracle Cloud Infrastructure Vault details to store migration and connection credentials secrets
        /// </summary>
        [Output("vaultDetails")]
        public Output<Outputs.MigrationVaultDetails> VaultDetails { get; private set; } = null!;

        /// <summary>
        /// Name of a migration phase. The Job will wait after executing this phase until the Resume Job endpoint is called.
        /// </summary>
        [Output("waitAfter")]
        public Output<string> WaitAfter { get; private set; } = null!;


        /// <summary>
        /// Create a Migration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Migration(string name, MigrationArgs args, CustomResourceOptions? options = null)
            : base("oci:databasemigration/migration:Migration", name, args ?? new MigrationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Migration(string name, Input<string> id, MigrationState? state = null, CustomResourceOptions? options = null)
            : base("oci:databasemigration/migration:Migration", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Migration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Migration Get(string name, Input<string> id, MigrationState? state = null, CustomResourceOptions? options = null)
        {
            return new Migration(name, id, state, options);
        }
    }

    public sealed class MigrationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) The OCID of the registered ODMS Agent. Required for OFFLINE Migrations.
        /// </summary>
        [Input("agentId")]
        public Input<string>? AgentId { get; set; }

        /// <summary>
        /// (Updatable) OCID of the compartment where the secret containing the credentials will be created.
        /// </summary>
        [Input("compartmentId", required: true)]
        public Input<string> CompartmentId { get; set; } = null!;

        /// <summary>
        /// (Updatable) Data Transfer Medium details for the Migration. If not specified, it will default to Database Link. Only one type of medium details can be specified.
        /// </summary>
        [Input("dataTransferMediumDetails")]
        public Input<Inputs.MigrationDataTransferMediumDetailsArgs>? DataTransferMediumDetails { get; set; }

        /// <summary>
        /// (Updatable) Optional settings for Datapump Export and Import jobs
        /// </summary>
        [Input("datapumpSettings")]
        public Input<Inputs.MigrationDatapumpSettingsArgs>? DatapumpSettings { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) Migration Display Name
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("excludeObjects")]
        private InputList<Inputs.MigrationExcludeObjectArgs>? _excludeObjects;

        /// <summary>
        /// (Updatable) Database objects to exclude from migration.
        /// </summary>
        public InputList<Inputs.MigrationExcludeObjectArgs> ExcludeObjects
        {
            get => _excludeObjects ?? (_excludeObjects = new InputList<Inputs.MigrationExcludeObjectArgs>());
            set => _excludeObjects = value;
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
        /// (Updatable) Details about Oracle GoldenGate Microservices. Required for online logical migration.
        /// </summary>
        [Input("goldenGateDetails")]
        public Input<Inputs.MigrationGoldenGateDetailsArgs>? GoldenGateDetails { get; set; }

        /// <summary>
        /// (Updatable) The OCID of the Source Container Database Connection. Only used for ONLINE migrations. Only Connections of type Non-Autonomous can be used as source container databases.
        /// </summary>
        [Input("sourceContainerDatabaseConnectionId")]
        public Input<string>? SourceContainerDatabaseConnectionId { get; set; }

        /// <summary>
        /// (Updatable) The OCID of the Source Database Connection.
        /// </summary>
        [Input("sourceDatabaseConnectionId", required: true)]
        public Input<string> SourceDatabaseConnectionId { get; set; } = null!;

        /// <summary>
        /// (Updatable) The OCID of the Target Database Connection.
        /// </summary>
        [Input("targetDatabaseConnectionId", required: true)]
        public Input<string> TargetDatabaseConnectionId { get; set; } = null!;

        /// <summary>
        /// (Updatable) Migration type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// (Updatable) Oracle Cloud Infrastructure Vault details to store migration and connection credentials secrets
        /// </summary>
        [Input("vaultDetails")]
        public Input<Inputs.MigrationVaultDetailsArgs>? VaultDetails { get; set; }

        public MigrationArgs()
        {
        }
    }

    public sealed class MigrationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) The OCID of the registered ODMS Agent. Required for OFFLINE Migrations.
        /// </summary>
        [Input("agentId")]
        public Input<string>? AgentId { get; set; }

        /// <summary>
        /// (Updatable) OCID of the compartment where the secret containing the credentials will be created.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        /// <summary>
        /// OCID of the Secret in the Oracle Cloud Infrastructure vault containing the Migration credentials. Used to store Golden Gate admin user credentials.
        /// </summary>
        [Input("credentialsSecretId")]
        public Input<string>? CredentialsSecretId { get; set; }

        /// <summary>
        /// (Updatable) Data Transfer Medium details for the Migration. If not specified, it will default to Database Link. Only one type of medium details can be specified.
        /// </summary>
        [Input("dataTransferMediumDetails")]
        public Input<Inputs.MigrationDataTransferMediumDetailsGetArgs>? DataTransferMediumDetails { get; set; }

        /// <summary>
        /// (Updatable) Optional settings for Datapump Export and Import jobs
        /// </summary>
        [Input("datapumpSettings")]
        public Input<Inputs.MigrationDatapumpSettingsGetArgs>? DatapumpSettings { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) Migration Display Name
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("excludeObjects")]
        private InputList<Inputs.MigrationExcludeObjectGetArgs>? _excludeObjects;

        /// <summary>
        /// (Updatable) Database objects to exclude from migration.
        /// </summary>
        public InputList<Inputs.MigrationExcludeObjectGetArgs> ExcludeObjects
        {
            get => _excludeObjects ?? (_excludeObjects = new InputList<Inputs.MigrationExcludeObjectGetArgs>());
            set => _excludeObjects = value;
        }

        /// <summary>
        /// OCID of the current ODMS Job in execution for the Migration, if any.
        /// </summary>
        [Input("executingJobId")]
        public Input<string>? ExecutingJobId { get; set; }

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
        /// (Updatable) Details about Oracle GoldenGate Microservices. Required for online logical migration.
        /// </summary>
        [Input("goldenGateDetails")]
        public Input<Inputs.MigrationGoldenGateDetailsGetArgs>? GoldenGateDetails { get; set; }

        /// <summary>
        /// Additional status related to the execution and current state of the Migration.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        /// <summary>
        /// (Updatable) The OCID of the Source Container Database Connection. Only used for ONLINE migrations. Only Connections of type Non-Autonomous can be used as source container databases.
        /// </summary>
        [Input("sourceContainerDatabaseConnectionId")]
        public Input<string>? SourceContainerDatabaseConnectionId { get; set; }

        /// <summary>
        /// (Updatable) The OCID of the Source Database Connection.
        /// </summary>
        [Input("sourceDatabaseConnectionId")]
        public Input<string>? SourceDatabaseConnectionId { get; set; }

        /// <summary>
        /// The current state of the Migration Resource.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("systemTags")]
        private InputMap<object>? _systemTags;

        /// <summary>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
        /// </summary>
        public InputMap<object> SystemTags
        {
            get => _systemTags ?? (_systemTags = new InputMap<object>());
            set => _systemTags = value;
        }

        /// <summary>
        /// (Updatable) The OCID of the Target Database Connection.
        /// </summary>
        [Input("targetDatabaseConnectionId")]
        public Input<string>? TargetDatabaseConnectionId { get; set; }

        /// <summary>
        /// The time the Migration was created. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The time of last Migration. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeLastMigration")]
        public Input<string>? TimeLastMigration { get; set; }

        /// <summary>
        /// The time of the last Migration details update. An RFC3339 formatted datetime string.
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        /// <summary>
        /// (Updatable) Migration type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// (Updatable) Oracle Cloud Infrastructure Vault details to store migration and connection credentials secrets
        /// </summary>
        [Input("vaultDetails")]
        public Input<Inputs.MigrationVaultDetailsGetArgs>? VaultDetails { get; set; }

        /// <summary>
        /// Name of a migration phase. The Job will wait after executing this phase until the Resume Job endpoint is called.
        /// </summary>
        [Input("waitAfter")]
        public Input<string>? WaitAfter { get; set; }

        public MigrationState()
        {
        }
    }
}