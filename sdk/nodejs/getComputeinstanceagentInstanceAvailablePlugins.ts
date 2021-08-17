// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This data source provides the list of Instance Available Plugins in Oracle Cloud Infrastructure Compute Instance Agent service.
 *
 * The API to get the list of plugins that are available.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testInstanceAvailablePlugins = oci.GetComputeinstanceagentInstanceAvailablePlugins({
 *     osName: _var.instance_available_plugin_os_name,
 *     osVersion: _var.instance_available_plugin_os_version,
 *     name: _var.instance_available_plugin_name,
 * });
 * ```
 */
export function getComputeinstanceagentInstanceAvailablePlugins(args: GetComputeinstanceagentInstanceAvailablePluginsArgs, opts?: pulumi.InvokeOptions): Promise<GetComputeinstanceagentInstanceAvailablePluginsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:index/getComputeinstanceagentInstanceAvailablePlugins:GetComputeinstanceagentInstanceAvailablePlugins", {
        "compartmentId": args.compartmentId,
        "filters": args.filters,
        "name": args.name,
        "osName": args.osName,
        "osVersion": args.osVersion,
    }, opts);
}

/**
 * A collection of arguments for invoking GetComputeinstanceagentInstanceAvailablePlugins.
 */
export interface GetComputeinstanceagentInstanceAvailablePluginsArgs {
    compartmentId: string;
    filters?: inputs.GetComputeinstanceagentInstanceAvailablePluginsFilter[];
    /**
     * The plugin name
     */
    name?: string;
    /**
     * The OS for which the plugin is supported. Examples of OperatingSystemQueryParam:OperatingSystemVersionQueryParam are as follows: 'CentOS' '6.10' , 'CentOS Linux' '7', 'CentOS Linux' '8', 'Oracle Linux Server' '6.10', 'Oracle Linux Server' '8.0', 'Red Hat Enterprise Linux Server' '7.8', 'Windows' '10', 'Windows' '2008ServerR2', 'Windows' '2012ServerR2', 'Windows' '7', 'Windows' '8.1'
     */
    osName: string;
    /**
     * The OS version for which the plugin is supported.
     */
    osVersion: string;
}

/**
 * A collection of values returned by GetComputeinstanceagentInstanceAvailablePlugins.
 */
export interface GetComputeinstanceagentInstanceAvailablePluginsResult {
    /**
     * The list of available_plugins.
     */
    readonly availablePlugins: outputs.GetComputeinstanceagentInstanceAvailablePluginsAvailablePlugin[];
    readonly compartmentId: string;
    readonly filters?: outputs.GetComputeinstanceagentInstanceAvailablePluginsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The plugin name
     */
    readonly name?: string;
    readonly osName: string;
    readonly osVersion: string;
}