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
    public sealed class CloudGuardTargetTargetResponderRecipeEffectiveResponderRule
    {
        /// <summary>
        /// (Updatable) compartment associated with condition
        /// </summary>
        public readonly string? CompartmentId;
        /// <summary>
        /// The target description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// (Updatable) Details of ResponderRule.
        /// </summary>
        public readonly Outputs.CloudGuardTargetTargetResponderRecipeEffectiveResponderRuleDetails? Details;
        /// <summary>
        /// (Updatable) DetectorTemplate Identifier
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </summary>
        public readonly string? LifecycleDetails;
        /// <summary>
        /// List of Policy
        /// </summary>
        public readonly ImmutableArray<string> Policies;
        /// <summary>
        /// (Updatable) Identifier for ResponderRule.
        /// </summary>
        public readonly string? ResponderRuleId;
        /// <summary>
        /// (Updatable) The current state of the DetectorRule.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// Supported Execution Modes
        /// </summary>
        public readonly ImmutableArray<string> SupportedModes;
        /// <summary>
        /// The date and time the target was created. Format defined by RFC3339.
        /// </summary>
        public readonly string? TimeCreated;
        /// <summary>
        /// The date and time the target was updated. Format defined by RFC3339.
        /// </summary>
        public readonly string? TimeUpdated;
        /// <summary>
        /// Type of Responder
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private CloudGuardTargetTargetResponderRecipeEffectiveResponderRule(
            string? compartmentId,

            string? description,

            Outputs.CloudGuardTargetTargetResponderRecipeEffectiveResponderRuleDetails? details,

            string? displayName,

            string? lifecycleDetails,

            ImmutableArray<string> policies,

            string? responderRuleId,

            string? state,

            ImmutableArray<string> supportedModes,

            string? timeCreated,

            string? timeUpdated,

            string? type)
        {
            CompartmentId = compartmentId;
            Description = description;
            Details = details;
            DisplayName = displayName;
            LifecycleDetails = lifecycleDetails;
            Policies = policies;
            ResponderRuleId = responderRuleId;
            State = state;
            SupportedModes = supportedModes;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
            Type = type;
        }
    }
}