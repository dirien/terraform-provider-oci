// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Integration.Inputs
{

    public sealed class IntegrationInstanceNetworkEndpointDetailsGetArgs : Pulumi.ResourceArgs
    {
        [Input("allowlistedHttpIps")]
        private InputList<string>? _allowlistedHttpIps;

        /// <summary>
        /// Source IP addresses or IP address ranges ingress rules.
        /// </summary>
        public InputList<string> AllowlistedHttpIps
        {
            get => _allowlistedHttpIps ?? (_allowlistedHttpIps = new InputList<string>());
            set => _allowlistedHttpIps = value;
        }

        [Input("allowlistedHttpVcns")]
        private InputList<Inputs.IntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnGetArgs>? _allowlistedHttpVcns;

        /// <summary>
        /// Virtual Cloud Networks allowed to access this network endpoint.
        /// </summary>
        public InputList<Inputs.IntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnGetArgs> AllowlistedHttpVcns
        {
            get => _allowlistedHttpVcns ?? (_allowlistedHttpVcns = new InputList<Inputs.IntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcnGetArgs>());
            set => _allowlistedHttpVcns = value;
        }

        /// <summary>
        /// The Integration service's VCN is allow-listed to allow integrations to call back into other integrations
        /// </summary>
        [Input("isIntegrationVcnAllowlisted")]
        public Input<bool>? IsIntegrationVcnAllowlisted { get; set; }

        /// <summary>
        /// The type of network endpoint.
        /// </summary>
        [Input("networkEndpointType", required: true)]
        public Input<string> NetworkEndpointType { get; set; } = null!;

        public IntegrationInstanceNetworkEndpointDetailsGetArgs()
        {
        }
    }
}