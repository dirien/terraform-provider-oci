// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetKmsDecryptedData
    {
        /// <summary>
        /// The `oci.GetKmsDecryptedData` data source provides details about a specific DecryptedData
        /// 
        /// Decrypts data using the given DecryptDataDetails resource.
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Oci = Pulumi.Oci;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var testDecryptedData = Output.Create(Oci.GetKmsDecryptedData.InvokeAsync(new Oci.GetKmsDecryptedDataArgs
        ///         {
        ///             Ciphertext = @var.Decrypted_data_ciphertext,
        ///             CryptoEndpoint = @var.Decrypted_data_crypto_endpoint,
        ///             KeyId = oci_kms_key.Test_key.Id,
        ///             AssociatedData = @var.Decrypted_data_associated_data,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetKmsDecryptedDataResult> InvokeAsync(GetKmsDecryptedDataArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKmsDecryptedDataResult>("oci:index/getKmsDecryptedData:GetKmsDecryptedData", args ?? new GetKmsDecryptedDataArgs(), options.WithVersion());
    }


    public sealed class GetKmsDecryptedDataArgs : Pulumi.InvokeArgs
    {
        [Input("associatedData")]
        private Dictionary<string, object>? _associatedData;

        /// <summary>
        /// Information that can be used to provide an encryption context for the  encrypted data. The length of the string representation of the associatedData must be fewer than 4096 characters.
        /// </summary>
        public Dictionary<string, object> AssociatedData
        {
            get => _associatedData ?? (_associatedData = new Dictionary<string, object>());
            set => _associatedData = value;
        }

        /// <summary>
        /// The encrypted data to decrypt.
        /// </summary>
        [Input("ciphertext", required: true)]
        public string Ciphertext { get; set; } = null!;

        /// <summary>
        /// The service endpoint to perform cryptographic operations against. Cryptographic operations include 'Encrypt,' 'Decrypt,' and 'GenerateDataEncryptionKey' operations. see Vault Crypto endpoint.
        /// </summary>
        [Input("cryptoEndpoint", required: true)]
        public string CryptoEndpoint { get; set; } = null!;

        /// <summary>
        /// The OCID of the key used to encrypt the ciphertext.
        /// </summary>
        [Input("keyId", required: true)]
        public string KeyId { get; set; } = null!;

        public GetKmsDecryptedDataArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetKmsDecryptedDataResult
    {
        public readonly ImmutableDictionary<string, object>? AssociatedData;
        public readonly string Ciphertext;
        public readonly string CryptoEndpoint;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string KeyId;
        /// <summary>
        /// The decrypted data, in the form of a base64-encoded value.
        /// </summary>
        public readonly string Plaintext;
        /// <summary>
        /// Checksum of the decrypted data.
        /// </summary>
        public readonly string PlaintextChecksum;

        [OutputConstructor]
        private GetKmsDecryptedDataResult(
            ImmutableDictionary<string, object>? associatedData,

            string ciphertext,

            string cryptoEndpoint,

            string id,

            string keyId,

            string plaintext,

            string plaintextChecksum)
        {
            AssociatedData = associatedData;
            Ciphertext = ciphertext;
            CryptoEndpoint = cryptoEndpoint;
            Id = id;
            KeyId = keyId;
            Plaintext = plaintext;
            PlaintextChecksum = plaintextChecksum;
        }
    }
}