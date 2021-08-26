// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Ocvp
{
    /// <summary>
    /// This resource provides the Esxi Host resource in Oracle Cloud Infrastructure Oracle Cloud VMware Solution service.
    /// 
    /// Adds another ESXi host to an existing SDDC. The attributes of the specified
    /// `Sddc` determine the VMware software and other configuration settings used
    /// by the ESXi host.
    /// 
    /// Use the [WorkRequest](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/WorkRequest/) operations to track the
    /// creation of the ESXi host.
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
    ///         var testEsxiHost = new Oci.Ocvp.EsxiHost("testEsxiHost", new Oci.Ocvp.EsxiHostArgs
    ///         {
    ///             SddcId = oci_ocvp_sddc.Test_sddc.Id,
    ///             CurrentSku = @var.Esxi_host_current_sku,
    ///             DefinedTags = 
    ///             {
    ///                 { "Operations.CostCenter", "42" },
    ///             },
    ///             DisplayName = @var.Esxi_host_display_name,
    ///             FreeformTags = 
    ///             {
    ///                 { "Department", "Finance" },
    ///             },
    ///             NextSku = @var.Esxi_host_next_sku,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// EsxiHosts can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:ocvp/esxiHost:EsxiHost test_esxi_host "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:ocvp/esxiHost:EsxiHost")]
    public partial class EsxiHost : Pulumi.CustomResource
    {
        /// <summary>
        /// Current billing cycle end date. If nextSku is different from existing SKU, then we switch to newSKu after this contractEndDate Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Output("billingContractEndDate")]
        public Output<string> BillingContractEndDate { get; private set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the SDDC.
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// In terms of implementation, an ESXi host is a Compute instance that is configured with the chosen bundle of VMware software. The `computeInstanceId` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of that Compute instance.
        /// </summary>
        [Output("computeInstanceId")]
        public Output<string> ComputeInstanceId { get; private set; } = null!;

        /// <summary>
        /// Billing option selected during SDDC creation. Oracle Cloud Infrastructure VMware Solution supports the following billing interval SKUs: HOUR, MONTH, ONE_YEAR, and THREE_YEARS. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Output("currentSku")]
        public Output<string> CurrentSku { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        [Output("definedTags")]
        public Output<ImmutableDictionary<string, object>> DefinedTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) A descriptive name for the ESXi host. It's changeable. Esxi Host name requirements are 1-16 character length limit, Must start with a letter, Must be English letters, numbers, - only, No repeating hyphens, Must be unique within the SDDC.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
        /// </summary>
        [Output("freeformTags")]
        public Output<ImmutableDictionary<string, object>> FreeformTags { get; private set; } = null!;

        /// <summary>
        /// (Updatable) Billing option to switch to once existing billing cycle ends. If nextSku is null or empty, currentSku will be used to continue with next billing term. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Output("nextSku")]
        public Output<string> NextSku { get; private set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the SDDC to add the ESXi host to.
        /// </summary>
        [Output("sddcId")]
        public Output<string> SddcId { get; private set; } = null!;

        /// <summary>
        /// The current state of the ESXi host.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The date and time the ESXi host was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// The date and time the ESXi host was updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </summary>
        [Output("timeUpdated")]
        public Output<string> TimeUpdated { get; private set; } = null!;


        /// <summary>
        /// Create a EsxiHost resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EsxiHost(string name, EsxiHostArgs args, CustomResourceOptions? options = null)
            : base("oci:ocvp/esxiHost:EsxiHost", name, args ?? new EsxiHostArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EsxiHost(string name, Input<string> id, EsxiHostState? state = null, CustomResourceOptions? options = null)
            : base("oci:ocvp/esxiHost:EsxiHost", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EsxiHost resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EsxiHost Get(string name, Input<string> id, EsxiHostState? state = null, CustomResourceOptions? options = null)
        {
            return new EsxiHost(name, id, state, options);
        }
    }

    public sealed class EsxiHostArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Billing option selected during SDDC creation. Oracle Cloud Infrastructure VMware Solution supports the following billing interval SKUs: HOUR, MONTH, ONE_YEAR, and THREE_YEARS. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Input("currentSku")]
        public Input<string>? CurrentSku { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) A descriptive name for the ESXi host. It's changeable. Esxi Host name requirements are 1-16 character length limit, Must start with a letter, Must be English letters, numbers, - only, No repeating hyphens, Must be unique within the SDDC.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// (Updatable) Billing option to switch to once existing billing cycle ends. If nextSku is null or empty, currentSku will be used to continue with next billing term. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Input("nextSku")]
        public Input<string>? NextSku { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the SDDC to add the ESXi host to.
        /// </summary>
        [Input("sddcId", required: true)]
        public Input<string> SddcId { get; set; } = null!;

        public EsxiHostArgs()
        {
        }
    }

    public sealed class EsxiHostState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Current billing cycle end date. If nextSku is different from existing SKU, then we switch to newSKu after this contractEndDate Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Input("billingContractEndDate")]
        public Input<string>? BillingContractEndDate { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the SDDC.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        /// <summary>
        /// In terms of implementation, an ESXi host is a Compute instance that is configured with the chosen bundle of VMware software. The `computeInstanceId` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of that Compute instance.
        /// </summary>
        [Input("computeInstanceId")]
        public Input<string>? ComputeInstanceId { get; set; }

        /// <summary>
        /// Billing option selected during SDDC creation. Oracle Cloud Infrastructure VMware Solution supports the following billing interval SKUs: HOUR, MONTH, ONE_YEAR, and THREE_YEARS. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Input("currentSku")]
        public Input<string>? CurrentSku { get; set; }

        [Input("definedTags")]
        private InputMap<object>? _definedTags;

        /// <summary>
        /// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
        /// </summary>
        public InputMap<object> DefinedTags
        {
            get => _definedTags ?? (_definedTags = new InputMap<object>());
            set => _definedTags = value;
        }

        /// <summary>
        /// (Updatable) A descriptive name for the ESXi host. It's changeable. Esxi Host name requirements are 1-16 character length limit, Must start with a letter, Must be English letters, numbers, - only, No repeating hyphens, Must be unique within the SDDC.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("freeformTags")]
        private InputMap<object>? _freeformTags;

        /// <summary>
        /// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
        /// </summary>
        public InputMap<object> FreeformTags
        {
            get => _freeformTags ?? (_freeformTags = new InputMap<object>());
            set => _freeformTags = value;
        }

        /// <summary>
        /// (Updatable) Billing option to switch to once existing billing cycle ends. If nextSku is null or empty, currentSku will be used to continue with next billing term. [ListSupportedSkus](https://docs.cloud.oracle.com/iaas/api/#/en/vmware/20200501/SupportedSkuSummary/ListSupportedSkus).
        /// </summary>
        [Input("nextSku")]
        public Input<string>? NextSku { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the SDDC to add the ESXi host to.
        /// </summary>
        [Input("sddcId")]
        public Input<string>? SddcId { get; set; }

        /// <summary>
        /// The current state of the ESXi host.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The date and time the ESXi host was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// The date and time the ESXi host was updated, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// </summary>
        [Input("timeUpdated")]
        public Input<string>? TimeUpdated { get; set; }

        public EsxiHostState()
        {
        }
    }
}