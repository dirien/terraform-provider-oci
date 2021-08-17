// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    /// <summary>
    /// This resource provides the ability to associate a route table for a subnet in Oracle Cloud Infrastructure Core service.
    /// 
    /// Attaches the specified `route table` to the specified `subnet`.
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
    ///         var testRouteTableAttachment = new Oci.CoreRouteTableAttachment("testRouteTableAttachment", new Oci.CoreRouteTableAttachmentArgs
    ///         {
    ///             SubnetId = oci_core_subnet.Test_subnet.Id,
    ///             RouteTableId = oci_core_route_table.Test_route_table.Id,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Route Table Attachment can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:index/coreRouteTableAttachment:CoreRouteTableAttachment test_route_table_attachment "{subnetId}/{routeTableId}"
    /// ```
    /// </summary>
    [OciResourceType("oci:index/coreRouteTableAttachment:CoreRouteTableAttachment")]
    public partial class CoreRouteTableAttachment : Pulumi.CustomResource
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table.
        /// </summary>
        [Output("routeTableId")]
        public Output<string> RouteTableId { get; private set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;


        /// <summary>
        /// Create a CoreRouteTableAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CoreRouteTableAttachment(string name, CoreRouteTableAttachmentArgs args, CustomResourceOptions? options = null)
            : base("oci:index/coreRouteTableAttachment:CoreRouteTableAttachment", name, args ?? new CoreRouteTableAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CoreRouteTableAttachment(string name, Input<string> id, CoreRouteTableAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("oci:index/coreRouteTableAttachment:CoreRouteTableAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CoreRouteTableAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CoreRouteTableAttachment Get(string name, Input<string> id, CoreRouteTableAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new CoreRouteTableAttachment(name, id, state, options);
        }
    }

    public sealed class CoreRouteTableAttachmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table.
        /// </summary>
        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public CoreRouteTableAttachmentArgs()
        {
        }
    }

    public sealed class CoreRouteTableAttachmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table.
        /// </summary>
        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public CoreRouteTableAttachmentState()
        {
        }
    }
}