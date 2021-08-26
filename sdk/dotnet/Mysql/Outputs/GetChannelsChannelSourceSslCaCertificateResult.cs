// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Mysql.Outputs
{

    [OutputType]
    public sealed class GetChannelsChannelSourceSslCaCertificateResult
    {
        /// <summary>
        /// The type of CA certificate.
        /// </summary>
        public readonly string CertificateType;
        /// <summary>
        /// The string containing the CA certificate in PEM format.
        /// </summary>
        public readonly string Contents;

        [OutputConstructor]
        private GetChannelsChannelSourceSslCaCertificateResult(
            string certificateType,

            string contents)
        {
            CertificateType = certificateType;
            Contents = contents;
        }
    }
}