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
    public sealed class GetMarketplacePublicationPackageDetailsOperatingSystemResult
    {
        /// <summary>
        /// name of the operating system
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetMarketplacePublicationPackageDetailsOperatingSystemResult(string name)
        {
            Name = name;
        }
    }
}