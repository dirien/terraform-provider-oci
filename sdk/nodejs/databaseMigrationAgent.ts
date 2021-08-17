// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * This resource provides the Agent resource in Oracle Cloud Infrastructure Database Migration service.
 *
 * Modifies the ODMS Agent represented by the given ODMS agent Id.
 *
 * ## Import
 *
 * Agents can be imported using the `id`, e.g.
 *
 * ```sh
 *  $ pulumi import oci:index/databaseMigrationAgent:DatabaseMigrationAgent test_agent "id"
 * ```
 */
export class DatabaseMigrationAgent extends pulumi.CustomResource {
    /**
     * Get an existing DatabaseMigrationAgent resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DatabaseMigrationAgentState, opts?: pulumi.CustomResourceOptions): DatabaseMigrationAgent {
        return new DatabaseMigrationAgent(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:index/databaseMigrationAgent:DatabaseMigrationAgent';

    /**
     * Returns true if the given object is an instance of DatabaseMigrationAgent.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DatabaseMigrationAgent {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DatabaseMigrationAgent.__pulumiType;
    }

    /**
     * The OCID of the agent
     */
    public readonly agentId!: pulumi.Output<string>;
    /**
     * (Updatable) The OCID of the compartment.
     */
    public readonly compartmentId!: pulumi.Output<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    public readonly definedTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * (Updatable) ODMS Agent name
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    public readonly freeformTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
     */
    public /*out*/ readonly lifecycleDetails!: pulumi.Output<string>;
    /**
     * (Updatable) ODMS Agent public key.
     */
    public readonly publicKey!: pulumi.Output<string>;
    /**
     * The current state of the ODMS On Prem Agent.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * (Updatable) The OCID of the Stream
     */
    public readonly streamId!: pulumi.Output<string>;
    /**
     * Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
     */
    public /*out*/ readonly systemTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * The time the Agent was created. An RFC3339 formatted datetime string.
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;
    /**
     * The time of the last Agent details update. An RFC3339 formatted datetime string.
     */
    public /*out*/ readonly timeUpdated!: pulumi.Output<string>;
    /**
     * (Updatable) ODMS Agent version
     */
    public readonly version!: pulumi.Output<string>;

    /**
     * Create a DatabaseMigrationAgent resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatabaseMigrationAgentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DatabaseMigrationAgentArgs | DatabaseMigrationAgentState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DatabaseMigrationAgentState | undefined;
            inputs["agentId"] = state ? state.agentId : undefined;
            inputs["compartmentId"] = state ? state.compartmentId : undefined;
            inputs["definedTags"] = state ? state.definedTags : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["freeformTags"] = state ? state.freeformTags : undefined;
            inputs["lifecycleDetails"] = state ? state.lifecycleDetails : undefined;
            inputs["publicKey"] = state ? state.publicKey : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["streamId"] = state ? state.streamId : undefined;
            inputs["systemTags"] = state ? state.systemTags : undefined;
            inputs["timeCreated"] = state ? state.timeCreated : undefined;
            inputs["timeUpdated"] = state ? state.timeUpdated : undefined;
            inputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as DatabaseMigrationAgentArgs | undefined;
            if ((!args || args.agentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'agentId'");
            }
            inputs["agentId"] = args ? args.agentId : undefined;
            inputs["compartmentId"] = args ? args.compartmentId : undefined;
            inputs["definedTags"] = args ? args.definedTags : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["freeformTags"] = args ? args.freeformTags : undefined;
            inputs["publicKey"] = args ? args.publicKey : undefined;
            inputs["streamId"] = args ? args.streamId : undefined;
            inputs["version"] = args ? args.version : undefined;
            inputs["lifecycleDetails"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["systemTags"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["timeUpdated"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(DatabaseMigrationAgent.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DatabaseMigrationAgent resources.
 */
export interface DatabaseMigrationAgentState {
    /**
     * The OCID of the agent
     */
    agentId?: pulumi.Input<string>;
    /**
     * (Updatable) The OCID of the compartment.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) ODMS Agent name
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
     */
    lifecycleDetails?: pulumi.Input<string>;
    /**
     * (Updatable) ODMS Agent public key.
     */
    publicKey?: pulumi.Input<string>;
    /**
     * The current state of the ODMS On Prem Agent.
     */
    state?: pulumi.Input<string>;
    /**
     * (Updatable) The OCID of the Stream
     */
    streamId?: pulumi.Input<string>;
    /**
     * Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
     */
    systemTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The time the Agent was created. An RFC3339 formatted datetime string.
     */
    timeCreated?: pulumi.Input<string>;
    /**
     * The time of the last Agent details update. An RFC3339 formatted datetime string.
     */
    timeUpdated?: pulumi.Input<string>;
    /**
     * (Updatable) ODMS Agent version
     */
    version?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DatabaseMigrationAgent resource.
 */
export interface DatabaseMigrationAgentArgs {
    /**
     * The OCID of the agent
     */
    agentId: pulumi.Input<string>;
    /**
     * (Updatable) The OCID of the compartment.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) ODMS Agent name
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) ODMS Agent public key.
     */
    publicKey?: pulumi.Input<string>;
    /**
     * (Updatable) The OCID of the Stream
     */
    streamId?: pulumi.Input<string>;
    /**
     * (Updatable) ODMS Agent version
     */
    version?: pulumi.Input<string>;
}