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
    public sealed class GetCoreInstanceAgentConfigPluginsConfigResult
    {
        /// <summary>
        /// Whether the plugin should be enabled or disabled.
        /// </summary>
        public readonly string DesiredState;
        /// <summary>
        /// The plugin name. To get a list of available plugins, use the [ListInstanceagentAvailablePlugins](https://docs.cloud.oracle.com/iaas/api/#/en/instanceagent/20180530/Plugin/ListInstanceagentAvailablePlugins) operation in the Oracle Cloud Agent API. For more information about the available plugins, see [Managing Plugins with Oracle Cloud Agent](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/manage-plugins.htm).
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetCoreInstanceAgentConfigPluginsConfigResult(
            string desiredState,

            string name)
        {
            DesiredState = desiredState;
            Name = name;
        }
    }
}