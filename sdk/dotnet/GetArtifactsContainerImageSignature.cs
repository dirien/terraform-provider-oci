// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetArtifactsContainerImageSignature
    {
        /// <summary>
        /// This data source provides details about a specific Container Image Signature resource in Oracle Cloud Infrastructure Artifacts service.
        /// 
        /// Get container image signature metadata.
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
        ///         var testContainerImageSignature = Output.Create(Oci.GetArtifactsContainerImageSignature.InvokeAsync(new Oci.GetArtifactsContainerImageSignatureArgs
        ///         {
        ///             ImageSignatureId = oci_artifacts_image_signature.Test_image_signature.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetArtifactsContainerImageSignatureResult> InvokeAsync(GetArtifactsContainerImageSignatureArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetArtifactsContainerImageSignatureResult>("oci:index/getArtifactsContainerImageSignature:GetArtifactsContainerImageSignature", args ?? new GetArtifactsContainerImageSignatureArgs(), options.WithVersion());
    }


    public sealed class GetArtifactsContainerImageSignatureArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container image signature.  Example: `ocid1.containersignature.oc1..exampleuniqueID`
        /// </summary>
        [Input("imageSignatureId", required: true)]
        public string ImageSignatureId { get; set; } = null!;

        public GetArtifactsContainerImageSignatureArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetArtifactsContainerImageSignatureResult
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which the container repository exists.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// The id of the user or principal that created the resource.
        /// </summary>
        public readonly string CreatedBy;
        /// <summary>
        /// The last 10 characters of the kmsKeyId, the last 10 characters of the kmsKeyVersionId, the signingAlgorithm, and the last 10 characters of the signatureId.  Example: `wrmz22sixa::qdwyc2ptun::SHA_256_RSA_PKCS_PSS::2vwmobasva`
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container image signature.  Example: `ocid1.containerimagesignature.oc1..exampleuniqueID`
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container image.  Example: `ocid1.containerimage.oc1..exampleuniqueID`
        /// </summary>
        public readonly string ImageId;
        public readonly string ImageSignatureId;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the kmsKeyId used to sign the container image.  Example: `ocid1.key.oc1..exampleuniqueID`
        /// </summary>
        public readonly string KmsKeyId;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the kmsKeyVersionId used to sign the container image.  Example: `ocid1.keyversion.oc1..exampleuniqueID`
        /// </summary>
        public readonly string KmsKeyVersionId;
        /// <summary>
        /// The base64 encoded signature payload that was signed.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The signature of the message field using the kmsKeyId, the kmsKeyVersionId, and the signingAlgorithm.
        /// </summary>
        public readonly string Signature;
        /// <summary>
        /// The algorithm to be used for signing. These are the only supported signing algorithms for container images.
        /// </summary>
        public readonly string SigningAlgorithm;
        /// <summary>
        /// An RFC 3339 timestamp indicating when the image was created.
        /// </summary>
        public readonly string TimeCreated;

        [OutputConstructor]
        private GetArtifactsContainerImageSignatureResult(
            string compartmentId,

            string createdBy,

            string displayName,

            string id,

            string imageId,

            string imageSignatureId,

            string kmsKeyId,

            string kmsKeyVersionId,

            string message,

            string signature,

            string signingAlgorithm,

            string timeCreated)
        {
            CompartmentId = compartmentId;
            CreatedBy = createdBy;
            DisplayName = displayName;
            Id = id;
            ImageId = imageId;
            ImageSignatureId = imageSignatureId;
            KmsKeyId = kmsKeyId;
            KmsKeyVersionId = kmsKeyVersionId;
            Message = message;
            Signature = signature;
            SigningAlgorithm = signingAlgorithm;
            TimeCreated = timeCreated;
        }
    }
}