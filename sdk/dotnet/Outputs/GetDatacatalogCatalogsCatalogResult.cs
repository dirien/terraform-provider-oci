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
    public sealed class GetDatacatalogCatalogsCatalogResult
    {
        /// <summary>
        /// The list of private reverse connection endpoints attached to the catalog
        /// </summary>
        public readonly ImmutableArray<string> AttachedCatalogPrivateEndpoints;
        /// <summary>
        /// The OCID of the compartment where you want to list resources.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> DefinedTags;
        /// <summary>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public readonly ImmutableDictionary<string, object> FreeformTags;
        /// <summary>
        /// Unique identifier that is immutable on creation.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// An message describing the current state in more detail.  For example, it can be used to provide actionable information for a resource in 'Failed' state.
        /// </summary>
        public readonly string LifecycleDetails;
        /// <summary>
        /// The number of data objects added to the data catalog. Please see the data catalog documentation for further information on how this is calculated.
        /// </summary>
        public readonly int NumberOfObjects;
        /// <summary>
        /// The REST front endpoint URL to the data catalog instance.
        /// </summary>
        public readonly string ServiceApiUrl;
        /// <summary>
        /// The console front endpoint URL to the data catalog instance.
        /// </summary>
        public readonly string ServiceConsoleUrl;
        /// <summary>
        /// A filter to return only resources that match the specified lifecycle state. The value is case insensitive.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The time the data catalog was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// The time the data catalog was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        public readonly string TimeUpdated;

        [OutputConstructor]
        private GetDatacatalogCatalogsCatalogResult(
            ImmutableArray<string> attachedCatalogPrivateEndpoints,

            string compartmentId,

            ImmutableDictionary<string, object> definedTags,

            string displayName,

            ImmutableDictionary<string, object> freeformTags,

            string id,

            string lifecycleDetails,

            int numberOfObjects,

            string serviceApiUrl,

            string serviceConsoleUrl,

            string state,

            string timeCreated,

            string timeUpdated)
        {
            AttachedCatalogPrivateEndpoints = attachedCatalogPrivateEndpoints;
            CompartmentId = compartmentId;
            DefinedTags = definedTags;
            DisplayName = displayName;
            FreeformTags = freeformTags;
            Id = id;
            LifecycleDetails = lifecycleDetails;
            NumberOfObjects = numberOfObjects;
            ServiceApiUrl = serviceApiUrl;
            ServiceConsoleUrl = serviceConsoleUrl;
            State = state;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
        }
    }
}