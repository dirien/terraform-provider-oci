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
    public sealed class GetOptimizerProfilesProfileCollectionItemTargetTagsItemResult
    {
        /// <summary>
        /// The name of the tag definition.
        /// </summary>
        public readonly string TagDefinitionName;
        /// <summary>
        /// The name of the tag namespace.
        /// </summary>
        public readonly string TagNamespaceName;
        /// <summary>
        /// The tag value type.
        /// </summary>
        public readonly string TagValueType;
        /// <summary>
        /// The list of tag values.
        /// </summary>
        public readonly ImmutableArray<string> TagValues;

        [OutputConstructor]
        private GetOptimizerProfilesProfileCollectionItemTargetTagsItemResult(
            string tagDefinitionName,

            string tagNamespaceName,

            string tagValueType,

            ImmutableArray<string> tagValues)
        {
            TagDefinitionName = tagDefinitionName;
            TagNamespaceName = tagNamespaceName;
            TagValueType = tagValueType;
            TagValues = tagValues;
        }
    }
}