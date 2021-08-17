// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This data source provides details about a specific Resource Availability resource in Oracle Cloud Infrastructure Limits service.
 *
 * For a given compartmentId, resource limit name, and scope, returns the following:
 *   * The number of available resources associated with the given limit.
 *   * The usage in the selected compartment for the given limit.
 *       Note that not all resource limits support this API. If the value is not available, the API returns a 404 response.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testResourceAvailability = oci.GetLimitsResourceAvailability({
 *     compartmentId: _var.tenancy_ocid,
 *     limitName: _var.resource_availability_limit_name,
 *     serviceName: oci_limits_service.test_service.name,
 *     availabilityDomain: _var.resource_availability_availability_domain,
 * });
 * ```
 */
export function getLimitsResourceAvailability(args: GetLimitsResourceAvailabilityArgs, opts?: pulumi.InvokeOptions): Promise<GetLimitsResourceAvailabilityResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:index/getLimitsResourceAvailability:GetLimitsResourceAvailability", {
        "availabilityDomain": args.availabilityDomain,
        "compartmentId": args.compartmentId,
        "limitName": args.limitName,
        "serviceName": args.serviceName,
    }, opts);
}

/**
 * A collection of arguments for invoking GetLimitsResourceAvailability.
 */
export interface GetLimitsResourceAvailabilityArgs {
    /**
     * This field is mandatory if the scopeType of the target resource limit is AD. Otherwise, this field should be omitted. If the above requirements are not met, the API returns a 400 - InvalidParameter response.
     */
    availabilityDomain?: string;
    /**
     * The OCID of the compartment for which data is being fetched.
     */
    compartmentId: string;
    /**
     * The limit name for which to fetch the data.
     */
    limitName: string;
    /**
     * The service name of the target quota.
     */
    serviceName: string;
}

/**
 * A collection of values returned by GetLimitsResourceAvailability.
 */
export interface GetLimitsResourceAvailabilityResult {
    readonly availabilityDomain?: string;
    /**
     * The count of available resources. To support resources with fractional counts, the field rounds down to the nearest integer.
     */
    readonly available: string;
    readonly compartmentId: string;
    /**
     * The effective quota value for the given compartment. This field is only present if there is a current quota policy affecting the current resource in the target region or availability domain.
     */
    readonly effectiveQuotaValue: number;
    /**
     * The most accurate count of available resources.
     */
    readonly fractionalAvailability: number;
    /**
     * The current most accurate usage in the given compartment.
     */
    readonly fractionalUsage: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly limitName: string;
    readonly serviceName: string;
    /**
     * The current usage in the given compartment. To support resources with fractional counts, the field rounds up to the nearest integer.
     */
    readonly used: string;
}