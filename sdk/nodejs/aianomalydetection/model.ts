// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * This resource provides the Model resource in Oracle Cloud Infrastructure Ai Anomaly Detection service.
 *
 * Creates a new Model.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testModel = new oci.aianomalydetection.Model("testModel", {
 *     compartmentId: _var.compartment_id,
 *     modelTrainingDetails: {
 *         dataAssetIds: _var.model_model_training_details_data_asset_ids,
 *         targetFap: _var.model_model_training_details_target_fap,
 *         trainingFraction: _var.model_model_training_details_training_fraction,
 *     },
 *     projectId: oci_ai_anomaly_detection_project.test_project.id,
 *     definedTags: {
 *         "foo-namespace.bar-key": "value",
 *     },
 *     description: _var.model_description,
 *     displayName: _var.model_display_name,
 *     freeformTags: {
 *         "bar-key": "value",
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * Models can be imported using the `id`, e.g.
 *
 * ```sh
 *  $ pulumi import oci:aianomalydetection/model:Model test_model "id"
 * ```
 */
export class Model extends pulumi.CustomResource {
    /**
     * Get an existing Model resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ModelState, opts?: pulumi.CustomResourceOptions): Model {
        return new Model(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:aianomalydetection/model:Model';

    /**
     * Returns true if the given object is an instance of Model.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Model {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Model.__pulumiType;
    }

    /**
     * (Updatable) The OCID for the ai model's compartment.
     */
    public readonly compartmentId!: pulumi.Output<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    public readonly definedTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * (Updatable) A short description of the ai model.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * (Updatable) A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    public readonly freeformTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
     */
    public /*out*/ readonly lifecycleDetails!: pulumi.Output<string>;
    /**
     * Specifies the details of the MSET model during the create call.
     */
    public readonly modelTrainingDetails!: pulumi.Output<outputs.aianomalydetection.ModelModelTrainingDetails>;
    /**
     * Specifies the details for an Anomaly Detection model trained with MSET.
     */
    public /*out*/ readonly modelTrainingResults!: pulumi.Output<outputs.aianomalydetection.ModelModelTrainingResults>;
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project to associate with the model.
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * The state of the model.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
     */
    public /*out*/ readonly systemTags!: pulumi.Output<{[key: string]: any}>;
    /**
     * The time the the Model was created. An RFC3339 formatted datetime string.
     */
    public /*out*/ readonly timeCreated!: pulumi.Output<string>;
    /**
     * The time the Model was updated. An RFC3339 formatted datetime string.
     */
    public /*out*/ readonly timeUpdated!: pulumi.Output<string>;

    /**
     * Create a Model resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModelArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ModelArgs | ModelState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ModelState | undefined;
            inputs["compartmentId"] = state ? state.compartmentId : undefined;
            inputs["definedTags"] = state ? state.definedTags : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["freeformTags"] = state ? state.freeformTags : undefined;
            inputs["lifecycleDetails"] = state ? state.lifecycleDetails : undefined;
            inputs["modelTrainingDetails"] = state ? state.modelTrainingDetails : undefined;
            inputs["modelTrainingResults"] = state ? state.modelTrainingResults : undefined;
            inputs["projectId"] = state ? state.projectId : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["systemTags"] = state ? state.systemTags : undefined;
            inputs["timeCreated"] = state ? state.timeCreated : undefined;
            inputs["timeUpdated"] = state ? state.timeUpdated : undefined;
        } else {
            const args = argsOrState as ModelArgs | undefined;
            if ((!args || args.compartmentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'compartmentId'");
            }
            if ((!args || args.modelTrainingDetails === undefined) && !opts.urn) {
                throw new Error("Missing required property 'modelTrainingDetails'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            inputs["compartmentId"] = args ? args.compartmentId : undefined;
            inputs["definedTags"] = args ? args.definedTags : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["freeformTags"] = args ? args.freeformTags : undefined;
            inputs["modelTrainingDetails"] = args ? args.modelTrainingDetails : undefined;
            inputs["projectId"] = args ? args.projectId : undefined;
            inputs["lifecycleDetails"] = undefined /*out*/;
            inputs["modelTrainingResults"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["systemTags"] = undefined /*out*/;
            inputs["timeCreated"] = undefined /*out*/;
            inputs["timeUpdated"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Model.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Model resources.
 */
export interface ModelState {
    /**
     * (Updatable) The OCID for the ai model's compartment.
     */
    compartmentId?: pulumi.Input<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) A short description of the ai model.
     */
    description?: pulumi.Input<string>;
    /**
     * (Updatable) A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
     */
    lifecycleDetails?: pulumi.Input<string>;
    /**
     * Specifies the details of the MSET model during the create call.
     */
    modelTrainingDetails?: pulumi.Input<inputs.aianomalydetection.ModelModelTrainingDetails>;
    /**
     * Specifies the details for an Anomaly Detection model trained with MSET.
     */
    modelTrainingResults?: pulumi.Input<inputs.aianomalydetection.ModelModelTrainingResults>;
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project to associate with the model.
     */
    projectId?: pulumi.Input<string>;
    /**
     * The state of the model.
     */
    state?: pulumi.Input<string>;
    /**
     * Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
     */
    systemTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The time the the Model was created. An RFC3339 formatted datetime string.
     */
    timeCreated?: pulumi.Input<string>;
    /**
     * The time the Model was updated. An RFC3339 formatted datetime string.
     */
    timeUpdated?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Model resource.
 */
export interface ModelArgs {
    /**
     * (Updatable) The OCID for the ai model's compartment.
     */
    compartmentId: pulumi.Input<string>;
    /**
     * (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
     */
    definedTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * (Updatable) A short description of the ai model.
     */
    description?: pulumi.Input<string>;
    /**
     * (Updatable) A user-friendly display name for the resource. It does not have to be unique and can be modified. Avoid entering confidential information.
     */
    displayName?: pulumi.Input<string>;
    /**
     * (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
     */
    freeformTags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the details of the MSET model during the create call.
     */
    modelTrainingDetails: pulumi.Input<inputs.aianomalydetection.ModelModelTrainingDetails>;
    /**
     * The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project to associate with the model.
     */
    projectId: pulumi.Input<string>;
}