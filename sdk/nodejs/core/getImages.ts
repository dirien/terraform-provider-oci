// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This data source provides the list of Images in Oracle Cloud Infrastructure Core service.
 *
 * Lists the available images in the specified compartment, including
 * [platform images](https://docs.cloud.oracle.com/iaas/Content/Compute/References/images.htm) and
 * [custom images](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/managingcustomimages.htm) that have
 * been created.
 *
 * The list of images that's returned is ordered to first show all
 * platform images, then all custom images. The order of images might
 * change when new images are released.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testImages = oci.core.getImages({
 *     compartmentId: _var.compartment_id,
 *     displayName: _var.image_display_name,
 *     operatingSystem: _var.image_operating_system,
 *     operatingSystemVersion: _var.image_operating_system_version,
 *     shape: _var.image_shape,
 *     state: _var.image_state,
 *     sortBy: _var.image_sort_by,
 *     sortOrder: _var.image_sort_order,
 * });
 * ```
 */
export function getImages(args: GetImagesArgs, opts?: pulumi.InvokeOptions): Promise<GetImagesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("oci:core/getImages:getImages", {
        "compartmentId": args.compartmentId,
        "displayName": args.displayName,
        "filters": args.filters,
        "operatingSystem": args.operatingSystem,
        "operatingSystemVersion": args.operatingSystemVersion,
        "shape": args.shape,
        "sortBy": args.sortBy,
        "sortOrder": args.sortOrder,
        "state": args.state,
    }, opts);
}

/**
 * A collection of arguments for invoking getImages.
 */
export interface GetImagesArgs {
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
     */
    compartmentId: string;
    /**
     * A filter to return only resources that match the given display name exactly.
     */
    displayName?: string;
    filters?: inputs.core.GetImagesFilter[];
    /**
     * The image's operating system.  Example: `Oracle Linux`
     */
    operatingSystem?: string;
    /**
     * The image's operating system version.  Example: `7.2`
     */
    operatingSystemVersion?: string;
    /**
     * Shape name.
     */
    shape?: string;
    /**
     * Sort the resources returned, by creation time or display name. Example `TIMECREATED` or `DISPLAYNAME`.
     */
    sortBy?: string;
    /**
     * The sort order to use, either ascending (`ASC`) or descending (`DESC`).
     */
    sortOrder?: string;
    /**
     * A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.
     */
    state?: string;
}

/**
 * A collection of values returned by getImages.
 */
export interface GetImagesResult {
    /**
     * The OCID of the compartment containing the instance you want to use as the basis for the image.
     */
    readonly compartmentId: string;
    /**
     * A user-friendly name for the image. It does not have to be unique, and it's changeable. Avoid entering confidential information.
     */
    readonly displayName?: string;
    readonly filters?: outputs.core.GetImagesFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The list of images.
     */
    readonly images: outputs.core.GetImagesImage[];
    /**
     * The image's operating system.  Example: `Oracle Linux`
     */
    readonly operatingSystem?: string;
    /**
     * The image's operating system version.  Example: `7.2`
     */
    readonly operatingSystemVersion?: string;
    readonly shape?: string;
    readonly sortBy?: string;
    readonly sortOrder?: string;
    /**
     * The current state of the image.
     */
    readonly state?: string;
}