// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This data source provides details about a specific Dkim resource in Oracle Cloud Infrastructure Email service.
 *
 * Retrieves the specified DKIM.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testDkim = oci.GetEmailDkim({
 *     dkimId: oci_email_dkim.test_dkim.id,
 * });
 * ```
 */
export function getEmailDkim(args: GetEmailDkimArgs, opts?: pulumi.InvokeOptions): Promise<GetEmailDkimResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:index/getEmailDkim:GetEmailDkim", {
        "dkimId": args.dkimId,
    }, opts);
}

/**
 * A collection of arguments for invoking GetEmailDkim.
 */
export interface GetEmailDkimArgs {
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of this DKIM.
     */
    dkimId: string;
}

/**
 * A collection of values returned by GetEmailDkim.
 */
export interface GetEmailDkimResult {
    /**
     * The DNS CNAME record value to provision to the DKIM DNS subdomain, when using the CNAME method for DKIM setup (preferred).
     */
    readonly cnameRecordValue: string;
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains this DKIM.
     */
    readonly compartmentId: string;
    /**
     * Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
     */
    readonly definedTags: {[key: string]: any};
    /**
     * The description of the DKIM. Avoid entering confidential information.
     */
    readonly description: string;
    readonly dkimId: string;
    /**
     * The name of the DNS subdomain that must be provisioned to enable email recipients to verify DKIM signatures. It is usually created with a CNAME record set to the cnameRecordValue
     */
    readonly dnsSubdomainName: string;
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the email domain that this DKIM belongs to.
     */
    readonly emailDomainId: string;
    /**
     * Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
     */
    readonly freeformTags: {[key: string]: any};
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DKIM.
     */
    readonly id: string;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource.
     */
    readonly lifecycleDetails: string;
    /**
     * The DKIM selector. If the same domain is managed in more than one region, each region must use different selectors.
     */
    readonly name: string;
    /**
     * The current state of the DKIM.
     */
    readonly state: string;
    /**
     * Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
     */
    readonly systemTags: {[key: string]: any};
    /**
     * The time the DKIM was created. Times are expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format, "YYYY-MM-ddThh:mmZ".  Example: `2021-02-12T22:47:12.613Z`
     */
    readonly timeCreated: string;
    /**
     * The time of the last change to the DKIM configuration, due to a state change or an update operation. Times are expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format, "YYYY-MM-ddThh:mmZ".
     */
    readonly timeUpdated: string;
    /**
     * The DNS TXT record value to provision to the DKIM DNS subdomain in place of using a CNAME record. This is used in cases where a CNAME can not be used, such as when the cnameRecordValue would exceed the maximum length for a DNS entry. This can also be used by customers who have an existing procedure to directly provision TXT records for DKIM. Be aware that many DNS APIs will require you to break this string into segments of less than 255 characters.
     */
    readonly txtRecordValue: string;
}