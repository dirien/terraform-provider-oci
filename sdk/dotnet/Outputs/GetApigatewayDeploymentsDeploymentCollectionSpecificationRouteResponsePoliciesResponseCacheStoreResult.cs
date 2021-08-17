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
    public sealed class GetApigatewayDeploymentsDeploymentCollectionSpecificationRouteResponsePoliciesResponseCacheStoreResult
    {
        /// <summary>
        /// Sets the number of seconds for a response from a backend being stored in the Response Cache before it expires.
        /// </summary>
        public readonly int TimeToLiveInSeconds;
        /// <summary>
        /// Type of the Response Cache Store Policy.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetApigatewayDeploymentsDeploymentCollectionSpecificationRouteResponsePoliciesResponseCacheStoreResult(
            int timeToLiveInSeconds,

            string type)
        {
            TimeToLiveInSeconds = timeToLiveInSeconds;
            Type = type;
        }
    }
}