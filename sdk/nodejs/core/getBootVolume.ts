// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides details about a specific Boot Volume resource in Oracle Cloud Infrastructure Core service.
 *
 * Gets information for the specified boot volume.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testBootVolume = oci.core.getBootVolume({
 *     bootVolumeId: oci_core_boot_volume.test_boot_volume.id,
 * });
 * ```
 */
export function getBootVolume(args: GetBootVolumeArgs, opts?: pulumi.InvokeOptions): Promise<GetBootVolumeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:core/getBootVolume:getBootVolume", {
        "bootVolumeId": args.bootVolumeId,
    }, opts);
}

/**
 * A collection of arguments for invoking getBootVolume.
 */
export interface GetBootVolumeArgs {
    /**
     * The OCID of the boot volume.
     */
    bootVolumeId: string;
}

/**
 * A collection of values returned by getBootVolume.
 */
export interface GetBootVolumeResult {
    /**
     * The number of Volume Performance Units per GB that this boot volume is effectively tuned to when it's idle.
     */
    readonly autoTunedVpusPerGb: string;
    /**
     * The availability domain of the boot volume replica.  Example: `Uocm:PHX-AD-1`
     */
    readonly availabilityDomain: string;
    /**
     * @deprecated The 'backup_policy_id' field has been deprecated. Please use the 'oci_core_volume_backup_policy_assignment' resource instead.
     */
    readonly backupPolicyId: string;
    readonly bootVolumeId: string;
    /**
     * The list of boot volume replicas of this boot volume
     */
    readonly bootVolumeReplicas: outputs.core.GetBootVolumeBootVolumeReplica[];
    readonly bootVolumeReplicasDeletion: boolean;
    /**
     * The OCID of the compartment that contains the boot volume.
     */
    readonly compartmentId: string;
    /**
     * Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
     */
    readonly definedTags: {[key: string]: any};
    /**
     * A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
     */
    readonly displayName: string;
    /**
     * Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
     */
    readonly freeformTags: {[key: string]: any};
    /**
     * The OCID of the boot volume replica.
     */
    readonly id: string;
    /**
     * The image OCID used to create the boot volume.
     */
    readonly imageId: string;
    /**
     * Specifies whether the auto-tune performance is enabled for this boot volume.
     */
    readonly isAutoTuneEnabled: boolean;
    /**
     * Specifies whether the boot volume's data has finished copying from the source boot volume or boot volume backup.
     */
    readonly isHydrated: boolean;
    /**
     * The OCID of the Key Management master encryption key assigned to the boot volume.
     */
    readonly kmsKeyId: string;
    /**
     * The size of the boot volume in GBs.
     */
    readonly sizeInGbs: string;
    /**
     * The size of the volume in MBs. The value must be a multiple of 1024. This field is deprecated. Please use `sizeInGbs`.
     */
    readonly sizeInMbs: string;
    readonly sourceDetails: outputs.core.GetBootVolumeSourceDetails;
    /**
     * The current state of a boot volume.
     */
    readonly state: string;
    /**
     * System tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    readonly systemTags: {[key: string]: any};
    /**
     * The date and time the boot volume was created. Format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
     */
    readonly timeCreated: string;
    /**
     * The OCID of the source volume group.
     */
    readonly volumeGroupId: string;
    /**
     * The number of volume performance units (VPUs) that will be applied to this boot volume per GB, representing the Block Volume service's elastic performance options. See [Block Volume Elastic Performance](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/blockvolumeelasticperformance.htm) for more information.
     */
    readonly vpusPerGb: string;
}