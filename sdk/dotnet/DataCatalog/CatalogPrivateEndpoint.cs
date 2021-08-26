// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.DataCatalog
{
    /// <summary>
    /// This resource provides the Catalog Private Endpoint resource in Oracle Cloud Infrastructure Data Catalog service.
    /// 
    /// Create a new private reverse connection endpoint.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Oci = Pulumi.Oci;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testCatalogPrivateEndpoint = new Oci.DataCatalog.CatalogPrivateEndpoint("testCatalogPrivateEndpoint", new Oci.DataCatalog.CatalogPrivateEndpointArgs
    ///         {
    ///             CompartmentId = @var.Compartment_id,
    ///             DnsZones = @var.Catalog_private_endpoint_dns_zones,
    ///             SubnetId = oci_core_subnet.Test_subnet.Id,
    ///             DefinedTags = 
    ///             {
    ///                 { "foo-namespace.bar-key", "value" },
    ///             },
    ///             DisplayName = @var.Catalog_private_endpoint_display_name,
    ///             FreeformTags = 
    ///             {
    ///                 { "bar-key", "value" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// CatalogPrivateEndpoints can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:datacatalog/catalogPrivateEndpoint:CatalogPrivateEndpoint test_catalog_private_endpoint "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:datacatalog/catalogPrivateEndpoint:CatalogPrivateEndpoint")]
    public partial class CatalogPrivateEndpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// The list of catalogs using the private reverse connection endpoint
        /// </summary>
        [Output("attachedCatalogs")]
        public Output<ImmutableArray<string>> AttachedCatalogs { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Compartment identifier.
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Usage of predefined tag keys. These predefined keys are scoped to namespaces. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        [Output("definedTags")]
        public Output<ImmutableDictionary<string, object>> DefinedTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Display name of the private endpoint resource being created.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// (Updatable) List of DNS zones to be used by the data assets to be harvested. Example: custpvtsubnet.oraclevcn.com for data asset: db.custpvtsubnet.oraclevcn.com
        /// </summary>
        [Output("dnsZones")]
        public Output<ImmutableArray<string>> DnsZones { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        [Output("freeformTags")]
        public Output<ImmutableDictionary<string, object>> FreeformTags { get; private set; } = null!;

        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in 'Failed' state.
        /// </summary>
        [Output("lifecycleDetails")]
        public Output<string> LifecycleDetails { get; private set; } = null!;

        /// <summary>
        /// The current state of the private endpoint resource.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The OCID of subnet to which the reverse connection is to be created
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// The time the private endpoint was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// The time the private endpoint was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;


        /// <summary>
        /// Create a CatalogPrivateEndpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CatalogPrivateEndpoint(string name, CatalogPrivateEndpointArgs args, CustomResourceOptions? options = null)
            : base("oci:datacatalog/catalogPrivateEndpoint:CatalogPrivateEndpoint", name, args ?? new CatalogPrivateEndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CatalogPrivateEndpoint(string name, Input<string> id, CatalogPrivateEndpointState? state = null, CustomResourceOptions? options = null)
            : base("oci:datacatalog/catalogPrivateEndpoint:CatalogPrivateEndpoint", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CatalogPrivateEndpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CatalogPrivateEndpoint Get(string name, Input<string> id, CatalogPrivateEndpointState? state = null, CustomResourceOptions? options = null)
        {
            return new CatalogPrivateEndpoint(name, id, state, options);
        }
    }

    public sealed class CatalogPrivateEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Updatable) Compartment identifier.
        /// </summary>
        [Input("compartmentId", required: true)]
        public Input<string> CompartmentId { get; set; } = null!;

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Usage of predefined tag keys. These predefined keys are scoped to namespaces. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) Display name of the private endpoint resource being created.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("dnsZones", required: true)]
        private InputList<string>? _dnsZones;

        /// <summary>
        /// (Updatable) List of DNS zones to be used by the data assets to be harvested. Example: custpvtsubnet.oraclevcn.com for data asset: db.custpvtsubnet.oraclevcn.com
        /// </summary>
        public InputList<string> DnsZones
        {
            get => _dnsZones ?? (_dnsZones = new InputList<string>());
            set => _dnsZones = value;
        }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// The OCID of subnet to which the reverse connection is to be created
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public CatalogPrivateEndpointArgs()
        {
        }
    }

    public sealed class CatalogPrivateEndpointState : Pulumi.ResourceArgs
    {
        [Input("attachedCatalogs")]
        private InputList<string>? _attachedCatalogs;

        /// <summary>
        /// The list of catalogs using the private reverse connection endpoint
        /// </summary>
        public InputList<string> AttachedCatalogs
        {
            get => _attachedCatalogs ?? (_attachedCatalogs = new InputList<string>());
            set => _attachedCatalogs = value;
        }

        /// <summary>
        /// (Updatable) Compartment identifier.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Usage of predefined tag keys. These predefined keys are scoped to namespaces. Example: `{"foo-namespace.bar-key": "value"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) Display name of the private endpoint resource being created.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("dnsZones")]
        private InputList<string>? _dnsZones;

        /// <summary>
        /// (Updatable) List of DNS zones to be used by the data assets to be harvested. Example: custpvtsubnet.oraclevcn.com for data asset: db.custpvtsubnet.oraclevcn.com
        /// </summary>
        public InputList<string> DnsZones
        {
            get => _dnsZones ?? (_dnsZones = new InputList<string>());
            set => _dnsZones = value;
        }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in 'Failed' state.
        /// </summary>
        [Input("lifecycleDetails")]
        public Input<string>? LifecycleDetails { get; set; }

        /// <summary>
        /// The current state of the private endpoint resource.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The OCID of subnet to which the reverse connection is to be created
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// The time the private endpoint was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The time the private endpoint was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        public CatalogPrivateEndpointState()
        {
        }
    }
}