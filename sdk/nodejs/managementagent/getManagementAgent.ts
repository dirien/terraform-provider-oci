// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides details about a specific Management Agent resource in Oracle Cloud Infrastructure Management Agent service.
 *
 * Gets complete details of the inventory of a given agent id
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testManagementAgent = oci.managementagent.getManagementAgent({
 *     managementAgentId: oci_management_agent_management_agent.test_management_agent.id,
 * });
 * ```
 */
export function getManagementAgent(args: GetManagementAgentArgs, opts?: pulumi.InvokeOptions): Promise<GetManagementAgentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:managementagent/getManagementAgent:getManagementAgent", {
        "managementAgentId": args.managementAgentId,
    }, opts);
}

/**
 * A collection of arguments for invoking getManagementAgent.
 */
export interface GetManagementAgentArgs {
    /**
     * Unique Management Agent identifier
     */
    managementAgentId: string;
}

/**
 * A collection of values returned by getManagementAgent.
 */
export interface GetManagementAgentResult {
    /**
     * The current availability status of managementAgent
     */
    readonly availabilityStatus: string;
    /**
     * Compartment Identifier
     */
    readonly compartmentId: string;
    /**
     * Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    readonly definedTags: {[key: string]: any};
    readonly deployPluginsIds: string[];
    /**
     * Management Agent Name
     */
    readonly displayName: string;
    /**
     * Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    readonly freeformTags: {[key: string]: any};
    /**
     * Management Agent host machine name
     */
    readonly host: string;
    /**
     * agent identifier
     */
    readonly id: string;
    /**
     * agent install key identifier
     */
    readonly installKeyId: string;
    /**
     * Path where Management Agent is installed
     */
    readonly installPath: string;
    /**
     * true if the agent can be upgraded automatically; false if it must be upgraded manually. true is currently unsupported.
     */
    readonly isAgentAutoUpgradable: boolean;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
     */
    readonly lifecycleDetails: string;
    readonly managedAgentId: string;
    readonly managementAgentId: string;
    /**
     * Platform Name
     */
    readonly platformName: string;
    /**
     * Platform Type
     */
    readonly platformType: string;
    /**
     * Platform Version
     */
    readonly platformVersion: string;
    /**
     * list of managementAgentPlugins associated with the agent
     */
    readonly pluginLists: outputs.managementagent.GetManagementAgentPluginList[];
    /**
     * The current state of managementAgent
     */
    readonly state: string;
    /**
     * The time the Management Agent was created. An RFC3339 formatted datetime string
     */
    readonly timeCreated: string;
    /**
     * The time the Management Agent has last recorded its health status in telemetry. This value will be null if the agent has not recorded its health status in last 7 days. An RFC3339 formatted datetime string
     */
    readonly timeLastHeartbeat: string;
    /**
     * The time the Management Agent was updated. An RFC3339 formatted datetime string
     */
    readonly timeUpdated: string;
    /**
     * Management Agent Version
     */
    readonly version: string;
}