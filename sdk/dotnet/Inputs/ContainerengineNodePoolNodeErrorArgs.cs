// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Inputs
{

    public sealed class ContainerengineNodePoolNodeErrorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A short error code that defines the upstream error, meant for programmatic parsing. See [API Errors](https://docs.cloud.oracle.com/iaas/Content/API/References/apierrors.htm).
        /// </summary>
        [Input("code")]
        public Input<string>? Code { get; set; }

        /// <summary>
        /// A human-readable error string of the upstream error.
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// The status of the HTTP response encountered in the upstream error.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ContainerengineNodePoolNodeErrorArgs()
        {
        }
    }
}