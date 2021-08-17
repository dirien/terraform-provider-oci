// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Inputs
{

    public sealed class LoggingUnifiedAgentConfigurationServiceConfigurationArgs : Pulumi.ResourceArgs
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
        public Input<Inputs.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationArgs> Destination { get; set; } = null!;

        [Input("sources", required: true)]
        private InputList<Inputs.LoggingUnifiedAgentConfigurationServiceConfigurationSourceArgs>? _sources;

        /// <summary>
        /// (Updatable)
        /// </summary>
        public InputList<Inputs.LoggingUnifiedAgentConfigurationServiceConfigurationSourceArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.LoggingUnifiedAgentConfigurationServiceConfigurationSourceArgs>());
            set => _sources = value;
        }

        public LoggingUnifiedAgentConfigurationServiceConfigurationArgs()
        {
        }
    }
}