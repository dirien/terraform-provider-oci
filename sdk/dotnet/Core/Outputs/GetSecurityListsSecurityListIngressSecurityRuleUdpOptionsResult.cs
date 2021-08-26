// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core.Outputs
{

    [OutputType]
    public sealed class GetSecurityListsSecurityListIngressSecurityRuleUdpOptionsResult
    {
        /// <summary>
        /// The maximum port number. Must not be lower than the minimum port number. To specify a single port number, set both the min and max to the same value.
        /// </summary>
        public readonly int Max;
        /// <summary>
        /// The minimum port number. Must not be greater than the maximum port number.
        /// </summary>
        public readonly int Min;
        public readonly Outputs.GetSecurityListsSecurityListIngressSecurityRuleUdpOptionsSourcePortRangeResult SourcePortRange;

        [OutputConstructor]
        private GetSecurityListsSecurityListIngressSecurityRuleUdpOptionsResult(
            int max,

            int min,

            Outputs.GetSecurityListsSecurityListIngressSecurityRuleUdpOptionsSourcePortRangeResult sourcePortRange)
        {
            Max = max;
            Min = min;
            SourcePortRange = sourcePortRange;
        }
    }
}