// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.ManagementAgent
{
    /// <summary>
    /// This resource provides the Management Agent resource in Oracle Cloud Infrastructure Management Agent service.
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
    ///         var testManagementAgent = new Oci.ManagementAgent.ManagementAgent("testManagementAgent", new Oci.ManagementAgent.ManagementAgentArgs
    ///         {
    ///             ManagedAgentId = oci_management_agent_managed_agent.Test_managed_agent.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// ManagementAgents can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:managementagent/managementAgent:ManagementAgent test_management_agent "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:managementagent/managementAgent:ManagementAgent")]
    public partial class ManagementAgent : Pulumi.CustomResource
    {
        /// <summary>
        /// The current availability status of managementAgent
        /// </summary>
        [Output("availabilityStatus")]
        public Output<string> AvailabilityStatus { get; private set; } = null!;

        /// <summary>
        /// Compartment Identifier
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        [Output("definedTags")]
        public Output<ImmutableDictionary<string, object>> DefinedTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Plugin Id list
        /// </summary>
        [Output("deployPluginsIds")]
        public Output<ImmutableArray<string>> DeployPluginsIds { get; private set; } = null!;

        /// <summary>
        /// (Updatable) New displayName of Agent.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        /// </summary>
        [Output("freeformTags")]
        public Output<ImmutableDictionary<string, object>> FreeformTags { get; private set; } = null!;

        /// <summary>
        /// Management Agent host machine name
        /// </summary>
        [Output("host")]
        public Output<string> Host { get; private set; } = null!;

        /// <summary>
        /// agent install key identifier
        /// </summary>
        [Output("installKeyId")]
        public Output<string> InstallKeyId { get; private set; } = null!;

        /// <summary>
        /// Path where Management Agent is installed
        /// </summary>
        [Output("installPath")]
        public Output<string> InstallPath { get; private set; } = null!;

        /// <summary>
        /// (Updatable) if set to true then, agent can be upgraded automatically else needs to be upgraded manually.
        /// </summary>
        [Output("isAgentAutoUpgradable")]
        public Output<bool> IsAgentAutoUpgradable { get; private set; } = null!;

        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        [Output("lifecycleDetails")]
        public Output<string> LifecycleDetails { get; private set; } = null!;

        /// <summary>
        /// Unique Management Agent identifier
        /// </summary>
        [Output("managedAgentId")]
        public Output<string> ManagedAgentId { get; private set; } = null!;

        /// <summary>
        /// Platform Name
        /// </summary>
        [Output("platformName")]
        public Output<string> PlatformName { get; private set; } = null!;

        /// <summary>
        /// Platform Type
        /// </summary>
        [Output("platformType")]
        public Output<string> PlatformType { get; private set; } = null!;

        /// <summary>
        /// Platform Version
        /// </summary>
        [Output("platformVersion")]
        public Output<string> PlatformVersion { get; private set; } = null!;

        /// <summary>
        /// list of managementAgentPlugins associated with the agent
        /// </summary>
        [Output("pluginLists")]
        public Output<ImmutableArray<Outputs.ManagementAgentPluginList>> PluginLists { get; private set; } = null!;

        /// <summary>
        /// The current state of managementAgent
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The time the Management Agent was created. An RFC3339 formatted datetime string
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// The time the Management Agent has last recorded its health status in telemetry. This value will be null if the agent has not recorded its health status in last 7 days. An RFC3339 formatted datetime string
        /// </summary>
        [Output("timeLastHeartbeat")]
        public Output<string> TimeLastHeartbeat { get; private set; } = null!;

        /// <summary>
        /// The time the Management Agent was updated. An RFC3339 formatted datetime string
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;

        /// <summary>
        /// Management Agent Version
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a ManagementAgent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagementAgent(string name, ManagementAgentArgs args, CustomResourceOptions? options = null)
            : base("oci:managementagent/managementAgent:ManagementAgent", name, args ?? new ManagementAgentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ManagementAgent(string name, Input<string> id, ManagementAgentState? state = null, CustomResourceOptions? options = null)
            : base("oci:managementagent/managementAgent:ManagementAgent", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ManagementAgent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagementAgent Get(string name, Input<string> id, ManagementAgentState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagementAgent(name, id, state, options);
        }
    }

    public sealed class ManagementAgentArgs : Pulumi.ResourceArgs
    {
        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        [Input("deployPluginsIds")]
        private InputList<string>? _deployPluginsIds;

        /// <summary>
        /// (Updatable) Plugin Id list
        /// </summary>
        public InputList<string> DeployPluginsIds
        {
            get => _deployPluginsIds ?? (_deployPluginsIds = new InputList<string>());
            set => _deployPluginsIds = value;
        }

        /// <summary>
        /// (Updatable) New displayName of Agent.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// (Updatable) if set to true then, agent can be upgraded automatically else needs to be upgraded manually.
        /// </summary>
        [Input("isAgentAutoUpgradable")]
        public Input<bool>? IsAgentAutoUpgradable { get; set; }

        /// <summary>
        /// Unique Management Agent identifier
        /// </summary>
        [Input("managedAgentId", required: true)]
        public Input<string> ManagedAgentId { get; set; } = null!;

        public ManagementAgentArgs()
        {
        }
    }

    public sealed class ManagementAgentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The current availability status of managementAgent
        /// </summary>
        [Input("availabilityStatus")]
        public Input<string>? AvailabilityStatus { get; set; }

        /// <summary>
        /// Compartment Identifier
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        [Input("deployPluginsIds")]
        private InputList<string>? _deployPluginsIds;

        /// <summary>
        /// (Updatable) Plugin Id list
        /// </summary>
        public InputList<string> DeployPluginsIds
        {
            get => _deployPluginsIds ?? (_deployPluginsIds = new InputList<string>());
            set => _deployPluginsIds = value;
        }

        /// <summary>
        /// (Updatable) New displayName of Agent.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// Management Agent host machine name
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// agent install key identifier
        /// </summary>
        [Input("installKeyId")]
        public Input<string>? InstallKeyId { get; set; }

        /// <summary>
        /// Path where Management Agent is installed
        /// </summary>
        [Input("installPath")]
        public Input<string>? InstallPath { get; set; }

        /// <summary>
        /// (Updatable) if set to true then, agent can be upgraded automatically else needs to be upgraded manually.
        /// </summary>
        [Input("isAgentAutoUpgradable")]
        public Input<bool>? IsAgentAutoUpgradable { get; set; }

        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        /// <summary>
        /// Unique Management Agent identifier
        /// </summary>
        [Input("managedAgentId")]
        public Input<string>? ManagedAgentId { get; set; }

        /// <summary>
        /// Platform Name
        /// </summary>
        [Input("platformName")]
        public Input<string>? PlatformName { get; set; }

        /// <summary>
        /// Platform Type
        /// </summary>
        [Input("platformType")]
        public Input<string>? PlatformType { get; set; }

        /// <summary>
        /// Platform Version
        /// </summary>
        [Input("platformVersion")]
        public Input<string>? PlatformVersion { get; set; }

        [Input("pluginLists")]
        private InputList<Inputs.ManagementAgentPluginListGetArgs>? _pluginLists;

        /// <summary>
        /// list of managementAgentPlugins associated with the agent
        /// </summary>
        public InputList<Inputs.ManagementAgentPluginListGetArgs> PluginLists
        {
            get => _pluginLists ?? (_pluginLists = new InputList<Inputs.ManagementAgentPluginListGetArgs>());
            set => _pluginLists = value;
        }

        /// <summary>
        /// The current state of managementAgent
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The time the Management Agent was created. An RFC3339 formatted datetime string
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The time the Management Agent has last recorded its health status in telemetry. This value will be null if the agent has not recorded its health status in last 7 days. An RFC3339 formatted datetime string
        /// </summary>
        [Input("timeLastHeartbeat")]
        public Input<string>? TimeLastHeartbeat { get; set; }

        /// <summary>
        /// The time the Management Agent was updated. An RFC3339 formatted datetime string
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        /// <summary>
        /// Management Agent Version
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ManagementAgentState()
        {
        }
    }
}