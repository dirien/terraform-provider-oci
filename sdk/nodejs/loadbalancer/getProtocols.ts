// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the list of Load Balancer Protocols in Oracle Cloud Infrastructure Load Balancer service.
 *
 * Lists all supported traffic protocols.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testLoadBalancerProtocols = oci.loadbalancer.getProtocols({
 *     compartmentId: _var.compartment_id,
 * });
 * ```
 */
export function getProtocols(args: GetProtocolsArgs, opts?: pulumi.InvokeOptions): Promise<GetProtocolsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:loadbalancer/getProtocols:getProtocols", {
        "compartmentId": args.compartmentId,
        "filters": args.filters,
    }, opts);
}

/**
 * A collection of arguments for invoking getProtocols.
 */
export interface GetProtocolsArgs {
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the load balancer protocols to list.
     */
    compartmentId: string;
    filters?: inputs.loadbalancer.GetProtocolsFilter[];
}

/**
 * A collection of values returned by getProtocols.
 */
export interface GetProtocolsResult {
    readonly compartmentId: string;
    readonly filters?: outputs.loadbalancer.GetProtocolsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The list of protocols.
     */
    readonly protocols: outputs.loadbalancer.GetProtocolsProtocol[];
}