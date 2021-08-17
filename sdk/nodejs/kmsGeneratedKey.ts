// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * This resource provides the Generated Key resource in Oracle Cloud Infrastructure Kms service.
 *
 * Generates a key that you can use to encrypt or decrypt data.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as oci from "@pulumi/oci";
 *
 * const testGeneratedKey = new oci.KmsGeneratedKey("testGeneratedKey", {
 *     cryptoEndpoint: _var.generated_key_crypto_endpoint,
 *     includePlaintextKey: _var.generated_key_include_plaintext_key,
 *     keyId: oci_kms_key.test_key.id,
 *     keyShape: {
 *         algorithm: _var.generated_key_key_shape_algorithm,
 *         length: _var.generated_key_key_shape_length,
 *         curveId: oci_kms_curve.test_curve.id,
 *     },
 *     associatedData: _var.generated_key_associated_data,
 *     loggingContext: _var.generated_key_logging_context,
 * });
 * ```
 *
 * ## Import
 *
 * Import is not supported for this resource.
 */
export class KmsGeneratedKey extends pulumi.CustomResource {
    /**
     * Get an existing KmsGeneratedKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KmsGeneratedKeyState, opts?: pulumi.CustomResourceOptions): KmsGeneratedKey {
        return new KmsGeneratedKey(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'oci:index/kmsGeneratedKey:KmsGeneratedKey';

    /**
     * Returns true if the given object is an instance of KmsGeneratedKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KmsGeneratedKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KmsGeneratedKey.__pulumiType;
    }

    /**
     * Information that can be used to provide an encryption context for the encrypted data. The length of the string representation of the associated data must be fewer than 4096 characters.
     */
    public readonly associatedData!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The encrypted data encryption key generated from a master encryption key.
     */
    public /*out*/ readonly ciphertext!: pulumi.Output<string>;
    /**
     * The service endpoint to perform cryptographic operations against. Cryptographic operations include 'Encrypt,' 'Decrypt,' and 'GenerateDataEncryptionKey' operations. see Vault Crypto endpoint.
     */
    public readonly cryptoEndpoint!: pulumi.Output<string>;
    /**
     * If true, the generated key is also returned unencrypted.
     */
    public readonly includePlaintextKey!: pulumi.Output<boolean>;
    /**
     * The OCID of the master encryption key to encrypt the generated data encryption key with.
     */
    public readonly keyId!: pulumi.Output<string>;
    /**
     * The cryptographic properties of a key.
     */
    public readonly keyShape!: pulumi.Output<outputs.KmsGeneratedKeyKeyShape>;
    /**
     * Information that provides context for audit logging. You can provide this additional data by formatting it as key-value pairs to include in audit logs when audit logging is enabled.
     */
    public readonly loggingContext!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The plaintext data encryption key, a base64-encoded sequence of random bytes, which is included if the [GenerateDataEncryptionKey](https://docs.cloud.oracle.com/iaas/api/#/en/key/latest/GeneratedKey/GenerateDataEncryptionKey) request includes the `includePlaintextKey` parameter and sets its value to "true".
     */
    public /*out*/ readonly plaintext!: pulumi.Output<string>;
    /**
     * The checksum of the plaintext data encryption key, which is included if the [GenerateDataEncryptionKey](https://docs.cloud.oracle.com/iaas/api/#/en/key/latest/GeneratedKey/GenerateDataEncryptionKey) request includes the `includePlaintextKey` parameter and sets its value to "true".
     */
    public /*out*/ readonly plaintextChecksum!: pulumi.Output<string>;

    /**
     * Create a KmsGeneratedKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KmsGeneratedKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KmsGeneratedKeyArgs | KmsGeneratedKeyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KmsGeneratedKeyState | undefined;
            inputs["associatedData"] = state ? state.associatedData : undefined;
            inputs["ciphertext"] = state ? state.ciphertext : undefined;
            inputs["cryptoEndpoint"] = state ? state.cryptoEndpoint : undefined;
            inputs["includePlaintextKey"] = state ? state.includePlaintextKey : undefined;
            inputs["keyId"] = state ? state.keyId : undefined;
            inputs["keyShape"] = state ? state.keyShape : undefined;
            inputs["loggingContext"] = state ? state.loggingContext : undefined;
            inputs["plaintext"] = state ? state.plaintext : undefined;
            inputs["plaintextChecksum"] = state ? state.plaintextChecksum : undefined;
        } else {
            const args = argsOrState as KmsGeneratedKeyArgs | undefined;
            if ((!args || args.cryptoEndpoint === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cryptoEndpoint'");
            }
            if ((!args || args.includePlaintextKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'includePlaintextKey'");
            }
            if ((!args || args.keyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'keyId'");
            }
            if ((!args || args.keyShape === undefined) && !opts.urn) {
                throw new Error("Missing required property 'keyShape'");
            }
            inputs["associatedData"] = args ? args.associatedData : undefined;
            inputs["cryptoEndpoint"] = args ? args.cryptoEndpoint : undefined;
            inputs["includePlaintextKey"] = args ? args.includePlaintextKey : undefined;
            inputs["keyId"] = args ? args.keyId : undefined;
            inputs["keyShape"] = args ? args.keyShape : undefined;
            inputs["loggingContext"] = args ? args.loggingContext : undefined;
            inputs["ciphertext"] = undefined /*out*/;
            inputs["plaintext"] = undefined /*out*/;
            inputs["plaintextChecksum"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(KmsGeneratedKey.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KmsGeneratedKey resources.
 */
export interface KmsGeneratedKeyState {
    /**
     * Information that can be used to provide an encryption context for the encrypted data. The length of the string representation of the associated data must be fewer than 4096 characters.
     */
    associatedData?: pulumi.Input<{[key: string]: any}>;
    /**
     * The encrypted data encryption key generated from a master encryption key.
     */
    ciphertext?: pulumi.Input<string>;
    /**
     * The service endpoint to perform cryptographic operations against. Cryptographic operations include 'Encrypt,' 'Decrypt,' and 'GenerateDataEncryptionKey' operations. see Vault Crypto endpoint.
     */
    cryptoEndpoint?: pulumi.Input<string>;
    /**
     * If true, the generated key is also returned unencrypted.
     */
    includePlaintextKey?: pulumi.Input<boolean>;
    /**
     * The OCID of the master encryption key to encrypt the generated data encryption key with.
     */
    keyId?: pulumi.Input<string>;
    /**
     * The cryptographic properties of a key.
     */
    keyShape?: pulumi.Input<inputs.KmsGeneratedKeyKeyShape>;
    /**
     * Information that provides context for audit logging. You can provide this additional data by formatting it as key-value pairs to include in audit logs when audit logging is enabled.
     */
    loggingContext?: pulumi.Input<{[key: string]: any}>;
    /**
     * The plaintext data encryption key, a base64-encoded sequence of random bytes, which is included if the [GenerateDataEncryptionKey](https://docs.cloud.oracle.com/iaas/api/#/en/key/latest/GeneratedKey/GenerateDataEncryptionKey) request includes the `includePlaintextKey` parameter and sets its value to "true".
     */
    plaintext?: pulumi.Input<string>;
    /**
     * The checksum of the plaintext data encryption key, which is included if the [GenerateDataEncryptionKey](https://docs.cloud.oracle.com/iaas/api/#/en/key/latest/GeneratedKey/GenerateDataEncryptionKey) request includes the `includePlaintextKey` parameter and sets its value to "true".
     */
    plaintextChecksum?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KmsGeneratedKey resource.
 */
export interface KmsGeneratedKeyArgs {
    /**
     * Information that can be used to provide an encryption context for the encrypted data. The length of the string representation of the associated data must be fewer than 4096 characters.
     */
    associatedData?: pulumi.Input<{[key: string]: any}>;
    /**
     * The service endpoint to perform cryptographic operations against. Cryptographic operations include 'Encrypt,' 'Decrypt,' and 'GenerateDataEncryptionKey' operations. see Vault Crypto endpoint.
     */
    cryptoEndpoint: pulumi.Input<string>;
    /**
     * If true, the generated key is also returned unencrypted.
     */
    includePlaintextKey: pulumi.Input<boolean>;
    /**
     * The OCID of the master encryption key to encrypt the generated data encryption key with.
     */
    keyId: pulumi.Input<string>;
    /**
     * The cryptographic properties of a key.
     */
    keyShape: pulumi.Input<inputs.KmsGeneratedKeyKeyShape>;
    /**
     * Information that provides context for audit logging. You can provide this additional data by formatting it as key-value pairs to include in audit logs when audit logging is enabled.
     */
    loggingContext?: pulumi.Input<{[key: string]: any}>;
}