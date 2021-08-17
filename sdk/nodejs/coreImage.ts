// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This resource provides the Image resource in Oracle Cloud Infrastructure Core service.
 *
 * Creates a boot disk image for the specified instance or imports an exported image from the Oracle Cloud Infrastructure Object Storage service.
 *
 * When creating a new image, you must provide the OCID of the instance you want to use as the basis for the image, and
 * the OCID of the compartment containing that instance. For more information about images,
 * see [Managing Custom Images](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/managingcustomimages.htm).
 *
 * When importing an exported image from Object Storage, you specify the source information
 * in [ImageSourceDetails](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/requests/ImageSourceDetails).
 *
 * When importing an image based on the namespace, bucket name, and object name,
 * use [ImageSourceViaObjectStorageTupleDetails](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/requests/ImageSourceViaObjectStorageTupleDetails).
 *
 * When importing an image based on the Object Storage URL, use
 * [ImageSourceViaObjectStorageUriDetails](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/requests/ImageSourceViaObjectStorageUriDetails).
 * See [Object Storage URLs](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/imageimportexport.htm#URLs) and [Using Pre-Authenticated Requests](https://docs.cloud.oracle.com/iaas/Content/Object/Tasks/usingpreauthenticatedrequests.htm)
 * for constructing URLs for image import/export.
 *
 * For more information about importing exported images, see
 * [Image Import/Export](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/imageimportexport.htm).
 *
 * You may optionally specify a *display name* for the image, which is simply a friendly name or description.
 * It does not have to be unique, and you can change it. See [UpdateImage](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/Image/UpdateImage).
 * Avoid entering confidential information.
 *
 * ## Example Usage
 * ### Create image from instance in tenancy
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testImage = new oci.CoreImage("testImage", {
 *     compartmentId: _var.compartment_id,
 *     instanceId: oci_core_instance.test_instance.id,
 *     definedTags: {
 *         "Operations.CostCenter": "42",
 *     },
 *     displayName: _var.image_display_name,
 *     launchMode: _var.image_launch_mode,
 *     freeformTags: {
 *         Department: "Finance",
 *     },
 * });
 * ```
 * ### Create image from exported image via direct access to object store
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testImage = new oci.CoreImage("testImage", {
 *     compartmentId: _var.compartment_id,
 *     displayName: _var.image_display_name,
 *     launchMode: _var.image_launch_mode,
 *     imageSourceDetails: {
 *         sourceType: "objectStorageTuple",
 *         bucketName: _var.bucket_name,
 *         namespaceName: _var.namespace,
 *         objectName: _var.object_name,
 *         operatingSystem: _var.image_image_source_details_operating_system,
 *         operatingSystemVersion: _var.image_image_source_details_operating_system_version,
 *         sourceImageType: _var.source_image_type,
 *     },
 * });
 * ```
 * ### Create image from exported image at publicly accessible uri
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testImage = new oci.CoreImage("testImage", {
 *     compartmentId: _var.compartment_id,
 *     displayName: _var.image_display_name,
 *     launchMode: _var.image_launch_mode,
 *     imageSourceDetails: {
 *         sourceType: "objectStorageUri",
 *         sourceUri: _var.source_uri,
 *         operatingSystem: _var.image_image_source_details_operating_system,
 *         operatingSystemVersion: _var.image_image_source_details_operating_system_version,
 *         sourceImageType: _var.source_image_type,
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * Images can be imported using the `id`, e.g.
 *
 * ```sh
 *  $ pulumi import oci:index/coreImage:CoreImage test_image "id"
 * ```
 */
export class CoreImage extends pulumi.CustomResource {
    /**
     * Get an existing CoreImage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CoreImageState, opts?: pulumi.CustomResourceOptions): CoreImage {
        return new CoreImage(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:index/coreImage:CoreImage';

    /**
     * Returns true if the given object is an instance of CoreImage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CoreImage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CoreImage.__pulumiType;
    }

    /**
     * Oracle Cloud Agent features supported on the image.
     */
    public /*out*/ readonly agentFeatures!: pulumi.Output<outputs.CoreImageAgentFeatures>;
    /**
     * The OCID of the image originally used to launch the instance.
     */
    public /*out*/ readonly baseImageId!: pulumi.Output<string>;
    /**
     * The size of the internal storage for this image that is subject to billing (1 GB = 1,073,741,824 bytes).  Example: `100`
     */
    public /*out*/ readonly billableSizeInGbs!: pulumi.Output<string>;
    /**
     * (Updatable) The OCID of the compartment you want the image to be created in.
     */
    public readonly compartmentId!: pulumi.Output<string>;
    /**
     * Whether instances launched with this image can be used to create new images. For example, you cannot create an image of an Oracle Database instance.  Example: `true`
     */
    public /*out*/ readonly createImageAllowed!: pulumi.Output<boolean>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
     */
    public readonly definedTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * (Updatable) A user-friendly name for the image. It does not have to be unique, and it's changeable. Avoid entering confidential information.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
     */
    public readonly freeformTags!: pulumi.Output<{[key: string]: any}>;
    public readonly imageSourceDetails!: pulumi.Output<outputs.CoreImageImageSourceDetails | undefined>;
    /**
     * The OCID of the instance you want to use as the basis for the image.
     */
    public readonly instanceId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the configuration mode for launching virtual machine (VM) instances. The configuration modes are:
     */
    public readonly launchMode!: pulumi.Output<string>;
    /**
     * Options for tuning the compatibility and performance of VM shapes. The values that you specify override any default values.
     */
    public /*out*/ readonly launchOptions!: pulumi.Output<outputs.CoreImageLaunchOptions>;
    /**
     * The listing type of the image. The default value is "NONE".
     */
    public /*out*/ readonly listingType!: pulumi.Output<string>;
    /**
     * The image's operating system.  Example: `Oracle Linux`
     */
    public /*out*/ readonly operatingSystem!: pulumi.Output<string>;
    /**
     * The image's operating system version.  Example: `7.2`
     */
    public /*out*/ readonly operatingSystemVersion!: pulumi.Output<string>;
    /**
     * The boot volume size for an instance launched from this image (1 MB = 1,048,576 bytes). Note this is not the same as the size of the image when it was exported or the actual size of the image.  Example: `47694`
     */
    public /*out*/ readonly sizeInMbs!: pulumi.Output<string>;
    /**
     * The current state of the image.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The date and time the image was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;

    /**
     * Create a CoreImage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CoreImageArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CoreImageArgs | CoreImageState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CoreImageState | undefined;
            inputs["agentFeatures"] = state ? state.agentFeatures : undefined;
            inputs["baseImageId"] = state ? state.baseImageId : undefined;
            inputs["billableSizeInGbs"] = state ? state.billableSizeInGbs : undefined;
            inputs["compartmentId"] = state ? state.compartmentId : undefined;
            inputs["createImageAllowed"] = state ? state.createImageAllowed : undefined;
            inputs["definedTags"] = state ? state.definedTags : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["freeformTags"] = state ? state.freeformTags : undefined;
            inputs["imageSourceDetails"] = state ? state.imageSourceDetails : undefined;
            inputs["instanceId"] = state ? state.instanceId : undefined;
            inputs["launchMode"] = state ? state.launchMode : undefined;
            inputs["launchOptions"] = state ? state.launchOptions : undefined;
            inputs["listingType"] = state ? state.listingType : undefined;
            inputs["operatingSystem"] = state ? state.operatingSystem : undefined;
            inputs["operatingSystemVersion"] = state ? state.operatingSystemVersion : undefined;
            inputs["sizeInMbs"] = state ? state.sizeInMbs : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["timeCreated"] = state ? state.timeCreated : undefined;
        } else {
            const args = argsOrState as CoreImageArgs | undefined;
            if ((!args || args.compartmentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'compartmentId'");
            }
            inputs["compartmentId"] = args ? args.compartmentId : undefined;
            inputs["definedTags"] = args ? args.definedTags : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["freeformTags"] = args ? args.freeformTags : undefined;
            inputs["imageSourceDetails"] = args ? args.imageSourceDetails : undefined;
            inputs["instanceId"] = args ? args.instanceId : undefined;
            inputs["launchMode"] = args ? args.launchMode : undefined;
            inputs["agentFeatures"] = undefined /*out*/;
            inputs["baseImageId"] = undefined /*out*/;
            inputs["billableSizeInGbs"] = undefined /*out*/;
            inputs["createImageAllowed"] = undefined /*out*/;
            inputs["launchOptions"] = undefined /*out*/;
            inputs["listingType"] = undefined /*out*/;
            inputs["operatingSystem"] = undefined /*out*/;
            inputs["operatingSystemVersion"] = undefined /*out*/;
            inputs["sizeInMbs"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(CoreImage.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CoreImage resources.
 */
export interface CoreImageState {
    /**
     * Oracle Cloud Agent features supported on the image.
     */
    agentFeatures?: pulumi.Input<inputs.CoreImageAgentFeatures>;
    /**
     * The OCID of the image originally used to launch the instance.
     */
    baseImageId?: pulumi.Input<string>;
    /**
     * The size of the internal storage for this image that is subject to billing (1 GB = 1,073,741,824 bytes).  Example: `100`
     */
    billableSizeInGbs?: pulumi.Input<string>;
    /**
     * (Updatable) The OCID of the compartment you want the image to be created in.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * Whether instances launched with this image can be used to create new images. For example, you cannot create an image of an Oracle Database instance.  Example: `true`
     */
    createImageAllowed?: pulumi.Input<boolean>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) A user-friendly name for the image. It does not have to be unique, and it's changeable. Avoid entering confidential information.
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    imageSourceDetails?: pulumi.Input<inputs.CoreImageImageSourceDetails>;
    /**
     * The OCID of the instance you want to use as the basis for the image.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Specifies the configuration mode for launching virtual machine (VM) instances. The configuration modes are:
     */
    launchMode?: pulumi.Input<string>;
    /**
     * Options for tuning the compatibility and performance of VM shapes. The values that you specify override any default values.
     */
    launchOptions?: pulumi.Input<inputs.CoreImageLaunchOptions>;
    /**
     * The listing type of the image. The default value is "NONE".
     */
    listingType?: pulumi.Input<string>;
    /**
     * The image's operating system.  Example: `Oracle Linux`
     */
    operatingSystem?: pulumi.Input<string>;
    /**
     * The image's operating system version.  Example: `7.2`
     */
    operatingSystemVersion?: pulumi.Input<string>;
    /**
     * The boot volume size for an instance launched from this image (1 MB = 1,048,576 bytes). Note this is not the same as the size of the image when it was exported or the actual size of the image.  Example: `47694`
     */
    sizeInMbs?: pulumi.Input<string>;
    /**
     * The current state of the image.
     */
    state?: pulumi.Input<string>;
    /**
     * The date and time the image was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
     */
    timeCreated?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CoreImage resource.
 */
export interface CoreImageArgs {
    /**
     * (Updatable) The OCID of the compartment you want the image to be created in.
     */
    compartmentId: pulumi.Input<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) A user-friendly name for the image. It does not have to be unique, and it's changeable. Avoid entering confidential information.
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    imageSourceDetails?: pulumi.Input<inputs.CoreImageImageSourceDetails>;
    /**
     * The OCID of the instance you want to use as the basis for the image.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Specifies the configuration mode for launching virtual machine (VM) instances. The configuration modes are:
     */
    launchMode?: pulumi.Input<string>;
}