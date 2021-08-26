// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * ## Import
 *
 * Import is not supported for this resource.
 */
export class Record extends pulumi.CustomResource {
    /**
     * Get an existing Record resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RecordState, opts?: pulumi.CustomResourceOptions): Record {
        return new Record(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:dns/record:Record';

    /**
     * Returns true if the given object is an instance of Record.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Record {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Record.__pulumiType;
    }

    /**
     * (Updatable) The OCID of the compartment the resource belongs to. If supplied, it must match the Zone's compartment ocid.
     */
    public readonly compartmentId!: pulumi.Output<string | undefined>;
    /**
     * The fully qualified domain name where the record can be located. Domain value is case insensitive.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * A Boolean flag indicating whether or not parts of the record are unable to be explicitly managed.
     */
    public /*out*/ readonly isProtected!: pulumi.Output<boolean>;
    /**
     * (Updatable) The record's data, as whitespace-delimited tokens in type-specific presentation format. All RDATA is normalized and the returned presentation of your RDATA may differ from its initial input. For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm)
     */
    public readonly rdata!: pulumi.Output<string | undefined>;
    /**
     * A unique identifier for the record within its zone.
     */
    public /*out*/ readonly recordHash!: pulumi.Output<string>;
    /**
     * The latest version of the record's zone in which its RRSet differs from the preceding version.
     */
    public /*out*/ readonly rrsetVersion!: pulumi.Output<string>;
    /**
     * The canonical name for the record's type, such as A or CNAME. For more information, see [Resource Record (RR) TYPEs](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4).
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    public readonly rtype!: pulumi.Output<string>;
    /**
     * (Updatable) The Time To Live for the record, in seconds.
     */
    public readonly ttl!: pulumi.Output<number | undefined>;
    /**
     * The name or OCID of the target zone.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    public readonly zoneNameOrId!: pulumi.Output<string>;

    /**
     * Create a Record resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RecordArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RecordArgs | RecordState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RecordState | undefined;
            inputs["compartmentId"] = state ? state.compartmentId : undefined;
            inputs["domain"] = state ? state.domain : undefined;
            inputs["isProtected"] = state ? state.isProtected : undefined;
            inputs["rdata"] = state ? state.rdata : undefined;
            inputs["recordHash"] = state ? state.recordHash : undefined;
            inputs["rrsetVersion"] = state ? state.rrsetVersion : undefined;
            inputs["rtype"] = state ? state.rtype : undefined;
            inputs["ttl"] = state ? state.ttl : undefined;
            inputs["zoneNameOrId"] = state ? state.zoneNameOrId : undefined;
        } else {
            const args = argsOrState as RecordArgs | undefined;
            if ((!args || args.domain === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domain'");
            }
            if ((!args || args.rtype === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rtype'");
            }
            if ((!args || args.zoneNameOrId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneNameOrId'");
            }
            inputs["compartmentId"] = args ? args.compartmentId : undefined;
            inputs["domain"] = args ? args.domain : undefined;
            inputs["rdata"] = args ? args.rdata : undefined;
            inputs["rtype"] = args ? args.rtype : undefined;
            inputs["ttl"] = args ? args.ttl : undefined;
            inputs["zoneNameOrId"] = args ? args.zoneNameOrId : undefined;
            inputs["isProtected"] = undefined /*out*/;
            inputs["recordHash"] = undefined /*out*/;
            inputs["rrsetVersion"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Record.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Record resources.
 */
export interface RecordState {
    /**
     * (Updatable) The OCID of the compartment the resource belongs to. If supplied, it must match the Zone's compartment ocid.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * The fully qualified domain name where the record can be located. Domain value is case insensitive.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    domain?: pulumi.Input<string>;
    /**
     * A Boolean flag indicating whether or not parts of the record are unable to be explicitly managed.
     */
    isProtected?: pulumi.Input<boolean>;
    /**
     * (Updatable) The record's data, as whitespace-delimited tokens in type-specific presentation format. All RDATA is normalized and the returned presentation of your RDATA may differ from its initial input. For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm)
     */
    rdata?: pulumi.Input<string>;
    /**
     * A unique identifier for the record within its zone.
     */
    recordHash?: pulumi.Input<string>;
    /**
     * The latest version of the record's zone in which its RRSet differs from the preceding version.
     */
    rrsetVersion?: pulumi.Input<string>;
    /**
     * The canonical name for the record's type, such as A or CNAME. For more information, see [Resource Record (RR) TYPEs](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4).
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    rtype?: pulumi.Input<string>;
    /**
     * (Updatable) The Time To Live for the record, in seconds.
     */
    ttl?: pulumi.Input<number>;
    /**
     * The name or OCID of the target zone.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    zoneNameOrId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Record resource.
 */
export interface RecordArgs {
    /**
     * (Updatable) The OCID of the compartment the resource belongs to. If supplied, it must match the Zone's compartment ocid.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * The fully qualified domain name where the record can be located. Domain value is case insensitive.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    domain: pulumi.Input<string>;
    /**
     * (Updatable) The record's data, as whitespace-delimited tokens in type-specific presentation format. All RDATA is normalized and the returned presentation of your RDATA may differ from its initial input. For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm)
     */
    rdata?: pulumi.Input<string>;
    /**
     * The canonical name for the record's type, such as A or CNAME. For more information, see [Resource Record (RR) TYPEs](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4).
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    rtype: pulumi.Input<string>;
    /**
     * (Updatable) The Time To Live for the record, in seconds.
     */
    ttl?: pulumi.Input<number>;
    /**
     * The name or OCID of the target zone.
     *
     * @deprecated The 'oci_dns_record' resource has been deprecated. Please use 'oci_dns_rrset' instead.
     */
    zoneNameOrId: pulumi.Input<string>;
}