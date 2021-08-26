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
    public sealed class GetDeploymentSpecificationLoggingPoliciesResult
    {
        /// <summary>
        /// Configures the logging policies for the access logs of an API Deployment.
        /// </summary>
        public readonly Outputs.GetDeploymentSpecificationLoggingPoliciesAccessLogResult AccessLog;
        /// <summary>
        /// Configures the logging policies for the execution logs of an API Deployment.
        /// </summary>
        public readonly Outputs.GetDeploymentSpecificationLoggingPoliciesExecutionLogResult ExecutionLog;

        [OutputConstructor]
        private GetDeploymentSpecificationLoggingPoliciesResult(
            Outputs.GetDeploymentSpecificationLoggingPoliciesAccessLogResult accessLog,

            Outputs.GetDeploymentSpecificationLoggingPoliciesExecutionLogResult executionLog)
        {
            AccessLog = accessLog;
            ExecutionLog = executionLog;
        }
    }
}