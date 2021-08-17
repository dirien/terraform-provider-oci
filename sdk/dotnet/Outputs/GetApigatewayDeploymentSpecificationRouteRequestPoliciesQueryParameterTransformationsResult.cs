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
    public sealed class GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsResult
    {
        /// <summary>
        /// Filter parameters from the query string as they pass through the gateway.  The gateway applies filters after other transformations, so any parameters set or renamed must also be listed here when using an ALLOW type policy.
        /// </summary>
        public readonly Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersResult FilterQueryParameters;
        /// <summary>
        /// Rename parameters on the query string as they pass through the gateway.
        /// </summary>
        public readonly Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsRenameQueryParametersResult RenameQueryParameters;
        /// <summary>
        /// Set parameters on the query string as they pass through the gateway.
        /// </summary>
        public readonly Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsSetQueryParametersResult SetQueryParameters;

        [OutputConstructor]
        private GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsResult(
            Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersResult filterQueryParameters,

            Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsRenameQueryParametersResult renameQueryParameters,

            Outputs.GetApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsSetQueryParametersResult setQueryParameters)
        {
            FilterQueryParameters = filterQueryParameters;
            RenameQueryParameters = renameQueryParameters;
            SetQueryParameters = setQueryParameters;
        }
    }
}