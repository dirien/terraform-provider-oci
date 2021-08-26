// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Identity.Outputs
{

    [OutputType]
    public sealed class GetNetworkSourcesNetworkSourceResult
    {
        /// <summary>
        /// The OCID of the compartment (remember that the tenancy is simply the root compartment).
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// The description you assign to the network source. Does not have to be unique, and it's changeable.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// The OCID of the network source.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The detailed status of INACTIVE lifecycleState.
        /// </summary>
        public readonly string InactiveState;
        /// <summary>
        /// A filter to only return resources that match the given name exactly.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A list of allowed public IP addresses and CIDR ranges.
        /// </summary>
        public readonly ImmutableArray<string> PublicSourceLists;
        /// <summary>
        /// A list of services allowed to make on-behalf-of requests. These requests can have different source IPs than those specified in the network source. Currently, only `all` and `none` are supported. The default is `all`.
        /// </summary>
        public readonly ImmutableArray<string> Services;
        /// <summary>
        /// A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Date and time the group was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// A list of allowed VCN OCID and IP range pairs. Example:`"vcnId": "ocid1.vcn.oc1.iad.aaaaaaaaexampleuniqueID", "ipRanges": [ "129.213.39.0/24" ]`
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNetworkSourcesNetworkSourceVirtualSourceListResult> VirtualSourceLists;

        [OutputConstructor]
        private GetNetworkSourcesNetworkSourceResult(
            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string description,

            ImmutableDictionary<string, object> freeformTags,

            string id,

            string inactiveState,

            string name,

            ImmutableArray<string> publicSourceLists,

            ImmutableArray<string> services,

            string state,

            string timeCreated,

            ImmutableArray<Outputs.GetNetworkSourcesNetworkSourceVirtualSourceListResult> virtualSourceLists)
        {
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            Description = description;
            FreeformTags = freeformTags;
            Id = id;
            InactiveState = inactiveState;
            Name = name;
            PublicSourceLists = publicSourceLists;
            Services = services;
            State = state;
            TimeCreated = timeCreated;
            VirtualSourceLists = virtualSourceLists;
        }
    }
}