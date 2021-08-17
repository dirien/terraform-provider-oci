// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Inputs
{

    public sealed class CloudGuardTargetTargetDetectorRecipeEffectiveDetectorRuleGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The target description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// (Updatable) Details of ResponderRule.
        /// </summary>
        [Input("details")]
        public Input<Inputs.CloudGuardTargetTargetDetectorRecipeEffectiveDetectorRuleDetailsGetArgs>? Details { get; set; }

        /// <summary>
        /// detector for the rule
        /// </summary>
        [Input("detector")]
        public Input<string>? Detector { get; set; }

        /// <summary>
        /// (Updatable) Identifier for DetectorRule.
        /// </summary>
        [Input("detectorRuleId")]
        public Input<string>? DetectorRuleId { get; set; }

        /// <summary>
        /// (Updatable) DetectorTemplate Identifier
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        [Input("managedListTypes")]
        private InputList<string>? _managedListTypes;

        /// <summary>
        /// List of cloudguard managed list types related to this rule
        /// </summary>
        public InputList<string> ManagedListTypes
        {
            get => _managedListTypes ?? (_managedListTypes = new InputList<string>());
            set => _managedListTypes = value;
        }

        /// <summary>
        /// Recommendation for TargetDetectorRecipeDetectorRule
        /// </summary>
        [Input("recommendation")]
        public Input<string>? Recommendation { get; set; }

        /// <summary>
        /// resource type of the configuration to which the rule is applied
        /// </summary>
        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        /// <summary>
        /// service type of the configuration to which the rule is applied
        /// </summary>
        [Input("serviceType")]
        public Input<string>? ServiceType { get; set; }

        /// <summary>
        /// (Updatable) The current state of the DetectorRule.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The date and time the target was created. Format defined by RFC3339.
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The date and time the target was updated. Format defined by RFC3339.
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        public CloudGuardTargetTargetDetectorRecipeEffectiveDetectorRuleGetArgs()
        {
        }
    }
}