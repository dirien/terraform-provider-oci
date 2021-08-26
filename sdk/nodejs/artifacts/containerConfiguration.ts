// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * This resource provides the Container Configuration resource in Oracle Cloud Infrastructure Artifacts service.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testContainerConfiguration = new oci.artifacts.ContainerConfiguration("test_container_configuration", {});
 * ```
 *
 * ## Import
 *
 * ContainerConfiguration can be imported using the `id`, e.g.
 *
 * ```sh
 *  $ pulumi import oci:artifacts/containerConfiguration:ContainerConfiguration test_container_configuration "container/configuration/compartmentId/{compartmentId}"
 * ```
 */
export class ContainerConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing ContainerConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ContainerConfigurationState, opts?: pulumi.CustomResourceOptions): ContainerConfiguration {
        return new ContainerConfiguration(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:artifacts/containerConfiguration:ContainerConfiguration';

    /**
     * Returns true if the given object is an instance of ContainerConfiguration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ContainerConfiguration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ContainerConfiguration.__pulumiType;
    }

    public readonly compartmentId!: pulumi.Output<string>;
    /**
     * Whether to create a new container repository when a container is pushed to a new repository path. Repositories created in this way belong to the root compartment.
     */
    public readonly isRepositoryCreatedOnFirstPush!: pulumi.Output<boolean>;
    /**
     * The tenancy namespace used in the container repository path.
     */
    public /*out*/ readonly namespace!: pulumi.Output<string>;

    /**
     * Create a ContainerConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerConfigurationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ContainerConfigurationArgs | ContainerConfigurationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ContainerConfigurationState | undefined;
            inputs["compartmentId"] = state ? state.compartmentId : undefined;
            inputs["isRepositoryCreatedOnFirstPush"] = state ? state.isRepositoryCreatedOnFirstPush : undefined;
            inputs["namespace"] = state ? state.namespace : undefined;
        } else {
            const args = argsOrState as ContainerConfigurationArgs | undefined;
            if ((!args || args.compartmentId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'compartmentId'");
            }
            if ((!args || args.isRepositoryCreatedOnFirstPush === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isRepositoryCreatedOnFirstPush'");
            }
            inputs["compartmentId"] = args ? args.compartmentId : undefined;
            inputs["isRepositoryCreatedOnFirstPush"] = args ? args.isRepositoryCreatedOnFirstPush : undefined;
            inputs["namespace"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(ContainerConfiguration.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ContainerConfiguration resources.
 */
export interface ContainerConfigurationState {
    compartmentId?: pulumi.Input<string>;
    /**
     * Whether to create a new container repository when a container is pushed to a new repository path. Repositories created in this way belong to the root compartment.
     */
    isRepositoryCreatedOnFirstPush?: pulumi.Input<boolean>;
    /**
     * The tenancy namespace used in the container repository path.
     */
    namespace?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ContainerConfiguration resource.
 */
export interface ContainerConfigurationArgs {
    compartmentId: pulumi.Input<string>;
    /**
     * Whether to create a new container repository when a container is pushed to a new repository path. Repositories created in this way belong to the root compartment.
     */
    isRepositoryCreatedOnFirstPush: pulumi.Input<boolean>;
}