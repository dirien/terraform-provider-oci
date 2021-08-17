// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This data source provides details about a specific Analytics Cluster resource in Oracle Cloud Infrastructure MySQL Database service.
 *
 * DEPRECATED -- please use HeatWave API instead.
 * Gets information about the Analytics Cluster.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testAnalyticsCluster = oci.GetMysqlAnalyticsCluster({
 *     dbSystemId: oci_database_db_system.test_db_system.id,
 * });
 * ```
 */
export function getMysqlAnalyticsCluster(args: GetMysqlAnalyticsClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetMysqlAnalyticsClusterResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:index/getMysqlAnalyticsCluster:GetMysqlAnalyticsCluster", {
        "dbSystemId": args.dbSystemId,
    }, opts);
}

/**
 * A collection of arguments for invoking GetMysqlAnalyticsCluster.
 */
export interface GetMysqlAnalyticsClusterArgs {
    /**
     * The DB System [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
     */
    dbSystemId: string;
}

/**
 * A collection of values returned by GetMysqlAnalyticsCluster.
 */
export interface GetMysqlAnalyticsClusterResult {
    /**
     * An Analytics Cluster Node is a compute host that is part of an Analytics Cluster.
     */
    readonly clusterNodes: outputs.GetMysqlAnalyticsClusterClusterNode[];
    /**
     * The number of analytics-processing compute instances, of the specified shape, in the Analytics Cluster.
     */
    readonly clusterSize: number;
    /**
     * The OCID of the parent DB System this Analytics Cluster is attached to.
     */
    readonly dbSystemId: string;
    readonly id: string;
    /**
     * Additional information about the current lifecycleState.
     */
    readonly lifecycleDetails: string;
    /**
     * The shape determines resources to allocate to the Analytics Cluster nodes - CPU cores, memory.
     */
    readonly shapeName: string;
    /**
     * The current state of the Analytics Cluster.
     */
    readonly state: string;
    /**
     * The date and time the Analytics Cluster was created, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
     */
    readonly timeCreated: string;
    /**
     * The time the Analytics Cluster was last updated, as described by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
     */
    readonly timeUpdated: string;
}