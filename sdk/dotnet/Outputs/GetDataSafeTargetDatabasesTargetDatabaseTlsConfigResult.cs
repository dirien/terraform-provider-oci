// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Outputs
{

    [OutputType]
    public sealed class GetDataSafeTargetDatabasesTargetDatabaseTlsConfigResult
    {
        /// <summary>
        /// The format of the certificate store.
        /// </summary>
        public readonly string CertificateStoreType;
        /// <summary>
        /// Base64 encoded string of key store file content.
        /// </summary>
        public readonly string KeyStoreContent;
        /// <summary>
        /// Status to represent whether the database connection is TLS enabled or not.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The password to read the trust store and key store files, if they are password protected.
        /// </summary>
        public readonly string StorePassword;
        /// <summary>
        /// Base64 encoded string of trust store file content.
        /// </summary>
        public readonly string TrustStoreContent;

        [OutputConstructor]
        private GetDataSafeTargetDatabasesTargetDatabaseTlsConfigResult(
            string certificateStoreType,

            string keyStoreContent,

            string status,

            string storePassword,

            string trustStoreContent)
        {
            CertificateStoreType = certificateStoreType;
            KeyStoreContent = keyStoreContent;
            Status = status;
            StorePassword = storePassword;
            TrustStoreContent = trustStoreContent;
        }
    }
}