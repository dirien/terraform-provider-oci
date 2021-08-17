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
    public sealed class GetCloudGuardTargetsTargetCollectionItemTargetDetectorRecipeEffectiveDetectorRuleDetailsConfigurationResult
    {
        /// <summary>
        /// Unique name of the configuration
        /// </summary>
        public readonly string ConfigKey;
        /// <summary>
        /// configuration data type
        /// </summary>
        public readonly string DataType;
        /// <summary>
        /// configuration name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// configuration value
        /// </summary>
        public readonly string Value;
        /// <summary>
        /// List of configuration values
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCloudGuardTargetsTargetCollectionItemTargetDetectorRecipeEffectiveDetectorRuleDetailsConfigurationValueResult> Values;

        [OutputConstructor]
        private GetCloudGuardTargetsTargetCollectionItemTargetDetectorRecipeEffectiveDetectorRuleDetailsConfigurationResult(
            string configKey,

            string dataType,

            string name,

            string value,

            ImmutableArray<Outputs.GetCloudGuardTargetsTargetCollectionItemTargetDetectorRecipeEffectiveDetectorRuleDetailsConfigurationValueResult> values)
        {
            ConfigKey = configKey;
            DataType = dataType;
            Name = name;
            Value = value;
            Values = values;
        }
    }
}