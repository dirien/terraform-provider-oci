// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.ApiGateway.Outputs
{

    [OutputType]
    public sealed class DeploymentSpecificationRouteRequestPoliciesHeaderTransformationsRenameHeaders
    {
        /// <summary>
        /// (Updatable) The list of headers.
        /// </summary>
        public readonly ImmutableArray<Outputs.DeploymentSpecificationRouteRequestPoliciesHeaderTransformationsRenameHeadersItem> Items;

        [OutputConstructor]
        private DeploymentSpecificationRouteRequestPoliciesHeaderTransformationsRenameHeaders(ImmutableArray<Outputs.DeploymentSpecificationRouteRequestPoliciesHeaderTransformationsRenameHeadersItem> items)
        {
            Items = items;
        }
    }
}