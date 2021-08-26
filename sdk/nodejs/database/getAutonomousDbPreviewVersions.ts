// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the list of Autonomous Db Preview Versions in Oracle Cloud Infrastructure Database service.
 *
 * Gets a list of supported Autonomous Database versions. Note that preview version software is only available for
 * databases with [shared Exadata infrastructure](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/adboverview.htm#AEI).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testAutonomousDbPreviewVersions = oci.database.getAutonomousDbPreviewVersions({
 *     compartmentId: _var.compartment_id,
 * });
 * ```
 */
export function getAutonomousDbPreviewVersions(args: GetAutonomousDbPreviewVersionsArgs, opts?: pulumi.InvokeOptions): Promise<GetAutonomousDbPreviewVersionsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:database/getAutonomousDbPreviewVersions:getAutonomousDbPreviewVersions", {
        "compartmentId": args.compartmentId,
        "filters": args.filters,
    }, opts);
}

/**
 * A collection of arguments for invoking getAutonomousDbPreviewVersions.
 */
export interface GetAutonomousDbPreviewVersionsArgs {
    /**
     * The compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
     */
    compartmentId: string;
    filters?: inputs.database.GetAutonomousDbPreviewVersionsFilter[];
}

/**
 * A collection of values returned by getAutonomousDbPreviewVersions.
 */
export interface GetAutonomousDbPreviewVersionsResult {
    /**
     * The list of autonomous_db_preview_versions.
     */
    readonly autonomousDbPreviewVersions: outputs.database.GetAutonomousDbPreviewVersionsAutonomousDbPreviewVersion[];
    readonly compartmentId: string;
    readonly filters?: outputs.database.GetAutonomousDbPreviewVersionsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}