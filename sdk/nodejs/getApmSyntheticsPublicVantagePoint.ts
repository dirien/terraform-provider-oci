// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This data source provides details about a specific Public Vantage Point resource in Oracle Cloud Infrastructure Apm Synthetics service.
 *
 * Returns a list of public vantage points.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testPublicVantagePoint = oci.GetApmSyntheticsPublicVantagePoint({
 *     apmDomainId: oci_apm_synthetics_apm_domain.test_apm_domain.id,
 *     displayName: _var.public_vantage_point_display_name,
 *     name: _var.public_vantage_point_name,
 * });
 * ```
 */
export function getApmSyntheticsPublicVantagePoint(args: GetApmSyntheticsPublicVantagePointArgs, opts?: pulumi.InvokeOptions): Promise<GetApmSyntheticsPublicVantagePointResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:index/getApmSyntheticsPublicVantagePoint:GetApmSyntheticsPublicVantagePoint", {
        "apmDomainId": args.apmDomainId,
        "displayName": args.displayName,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking GetApmSyntheticsPublicVantagePoint.
 */
export interface GetApmSyntheticsPublicVantagePointArgs {
    /**
     * The APM domain ID the request is intended for.
     */
    apmDomainId: string;
    /**
     * A filter to return only resources that match the entire display name given.
     */
    displayName?: string;
    /**
     * A filter to return only resources that match the entire name given.
     */
    name?: string;
}

/**
 * A collection of values returned by GetApmSyntheticsPublicVantagePoint.
 */
export interface GetApmSyntheticsPublicVantagePointResult {
    readonly apmDomainId: string;
    /**
     * Unique name that can be edited. The name should not contain any confidential information.
     */
    readonly displayName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of PublicVantagePointSummary items.
     */
    readonly items: outputs.GetApmSyntheticsPublicVantagePointItem[];
    /**
     * Unique permanent name of the vantage point.
     */
    readonly name?: string;
}