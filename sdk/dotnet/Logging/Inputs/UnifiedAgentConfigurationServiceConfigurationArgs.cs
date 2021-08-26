// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Logging.Inputs
{

    public sealed class UnifiedAgentConfigurationServiceConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) Type of Unified Agent service configuration.
        /// </summary>
        [Input("configurationType", required: true)]
        public Input<string> ConfigurationType { get; set; } = null!;

        /// <summary>
        /// (Updatable) Logging destination object.
        /// </summary>
        [Input("destination", required: true)]
        public Input<Inputs.UnifiedAgentConfigurationServiceConfigurationDestinationArgs> Destination { get; set; } = null!;

        [Input("sources", required: true)]
        private InputList<Inputs.UnifiedAgentConfigurationServiceConfigurationSourceArgs>? _sources;

        /// <summary>
        /// (Updatable)
        /// </summary>
        public InputList<Inputs.UnifiedAgentConfigurationServiceConfigurationSourceArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.UnifiedAgentConfigurationServiceConfigurationSourceArgs>());
            set => _sources = value;
        }

        public UnifiedAgentConfigurationServiceConfigurationArgs()
        {
        }
    }
}