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
    public sealed class MarketplacePublicationIcon
    {
        /// <summary>
        /// The content URL of the upload data.
        /// </summary>
        public readonly string? ContentUrl;
        /// <summary>
        /// The file extension of the upload data.
        /// </summary>
        public readonly string? FileExtension;
        /// <summary>
        /// The MIME type of the upload data.
        /// </summary>
        public readonly string? MimeType;
        /// <summary>
        /// (Updatable) The name of the contact.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private MarketplacePublicationIcon(
            string? contentUrl,

            string? fileExtension,

            string? mimeType,

            string? name)
        {
            ContentUrl = contentUrl;
            FileExtension = fileExtension;
            MimeType = mimeType;
            Name = name;
        }
    }
}