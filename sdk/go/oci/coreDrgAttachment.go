// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Drg Attachment resource in Oracle Cloud Infrastructure Core service.
//
// Attaches the specified DRG to the specified network resource. A VCN can be attached to only one DRG
// at a time, but a DRG can be attached to more than one VCN. The response includes a `DrgAttachment`
// object with its own [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm). For more information about DRGs, see
// [Dynamic Routing Gateways (DRGs)](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingDRGs.htm).
//
// You may optionally specify a *display name* for the attachment, otherwise a default is provided.
// It does not have to be unique, and you can change it. Avoid entering confidential information.
//
// For the purposes of access control, the DRG attachment is automatically placed into the currently selected compartment.
// For more information about compartments and access control, see
// [Overview of the IAM Service](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/overview.htm).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := oci.NewCoreDrgAttachment(ctx, "testDrgAttachment", &oci.CoreDrgAttachmentArgs{
// 			DrgId: pulumi.Any(oci_core_drg.Test_drg.Id),
// 			DefinedTags: pulumi.AnyMap{
// 				"Operations.CostCenter": pulumi.Any("42"),
// 			},
// 			DisplayName:     pulumi.Any(_var.Drg_attachment_display_name),
// 			DrgRouteTableId: pulumi.Any(oci_core_drg_route_table.Test_drg_route_table.Id),
// 			FreeformTags: pulumi.AnyMap{
// 				"Department": pulumi.Any("Finance"),
// 			},
// 			NetworkDetails: &CoreDrgAttachmentNetworkDetailsArgs{
// 				Id:           pulumi.Any(_var.Drg_attachment_network_details_id),
// 				Type:         pulumi.Any(_var.Drg_attachment_network_details_type),
// 				RouteTableId: pulumi.Any(oci_core_route_table.Test_route_table.Id),
// 			},
// 			RouteTableId: pulumi.Any(oci_core_route_table.Test_route_table.Id),
// 			VcnId:        pulumi.Any(oci_core_vcn.Test_vcn.Id),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// DrgAttachments can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:index/coreDrgAttachment:CoreDrgAttachment test_drg_attachment "id"
// ```
type CoreDrgAttachment struct {
	pulumi.CustomResourceState

	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the DRG attachment.
	CompartmentId pulumi.StringOutput `pulumi:"compartmentId"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapOutput `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique. Avoid entering confidential information.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
	DrgId pulumi.StringOutput `pulumi:"drgId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
	DrgRouteTableId pulumi.StringOutput `pulumi:"drgRouteTableId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table are advertised to the attachment. If this value is null, no routes are advertised through this attachment.
	// This field cannot be set by the user while creating the resource and gets a default value on creation. This can be only be updated to its default value. If this fields needs to be set to null, removeExportDrgRouteDistributionTrigger needs to be used.
	ExportDrgRouteDistributionId pulumi.StringOutput `pulumi:"exportDrgRouteDistributionId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapOutput `pulumi:"freeformTags"`
	// Indicates whether the DRG attachment and attached network live in a different tenancy than the DRG.  Example: `false`
	IsCrossTenancy pulumi.BoolOutput `pulumi:"isCrossTenancy"`
	// (Updatable)
	NetworkDetails CoreDrgAttachmentNetworkDetailsOutput `pulumi:"networkDetails"`
	// (Updatable) An optional property when set to true during update disables the export of route Distribution by setting exportDrgRouteDistributionId to null.
	RemoveExportDrgRouteDistributionTrigger pulumi.BoolPtrOutput `pulumi:"removeExportDrgRouteDistributionTrigger"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table used by the DRG attachment.
	RouteTableId pulumi.StringOutput `pulumi:"routeTableId"`
	// The DRG attachment's current state.
	State pulumi.StringOutput `pulumi:"state"`
	// The date and time the DRG attachment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated pulumi.StringOutput `pulumi:"timeCreated"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN. This field is deprecated. Instead, use the `networkDetails` field to specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
	VcnId pulumi.StringOutput `pulumi:"vcnId"`
}

// NewCoreDrgAttachment registers a new resource with the given unique name, arguments, and options.
func NewCoreDrgAttachment(ctx *pulumi.Context,
	name string, args *CoreDrgAttachmentArgs, opts ...pulumi.ResourceOption) (*CoreDrgAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DrgId == nil {
		return nil, errors.New("invalid value for required argument 'DrgId'")
	}
	var resource CoreDrgAttachment
	err := ctx.RegisterResource("oci:index/coreDrgAttachment:CoreDrgAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCoreDrgAttachment gets an existing CoreDrgAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCoreDrgAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CoreDrgAttachmentState, opts ...pulumi.ResourceOption) (*CoreDrgAttachment, error) {
	var resource CoreDrgAttachment
	err := ctx.ReadResource("oci:index/coreDrgAttachment:CoreDrgAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CoreDrgAttachment resources.
type coreDrgAttachmentState struct {
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the DRG attachment.
	CompartmentId *string `pulumi:"compartmentId"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique. Avoid entering confidential information.
	DisplayName *string `pulumi:"displayName"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
	DrgId *string `pulumi:"drgId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
	DrgRouteTableId *string `pulumi:"drgRouteTableId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table are advertised to the attachment. If this value is null, no routes are advertised through this attachment.
	// This field cannot be set by the user while creating the resource and gets a default value on creation. This can be only be updated to its default value. If this fields needs to be set to null, removeExportDrgRouteDistributionTrigger needs to be used.
	ExportDrgRouteDistributionId *string `pulumi:"exportDrgRouteDistributionId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// Indicates whether the DRG attachment and attached network live in a different tenancy than the DRG.  Example: `false`
	IsCrossTenancy *bool `pulumi:"isCrossTenancy"`
	// (Updatable)
	NetworkDetails *CoreDrgAttachmentNetworkDetails `pulumi:"networkDetails"`
	// (Updatable) An optional property when set to true during update disables the export of route Distribution by setting exportDrgRouteDistributionId to null.
	RemoveExportDrgRouteDistributionTrigger *bool `pulumi:"removeExportDrgRouteDistributionTrigger"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table used by the DRG attachment.
	RouteTableId *string `pulumi:"routeTableId"`
	// The DRG attachment's current state.
	State *string `pulumi:"state"`
	// The date and time the DRG attachment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated *string `pulumi:"timeCreated"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN. This field is deprecated. Instead, use the `networkDetails` field to specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
	VcnId *string `pulumi:"vcnId"`
}

type CoreDrgAttachmentState struct {
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the DRG attachment.
	CompartmentId pulumi.StringPtrInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapInput
	// (Updatable) A user-friendly name. Does not have to be unique. Avoid entering confidential information.
	DisplayName pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
	DrgId pulumi.StringPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
	DrgRouteTableId pulumi.StringPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table are advertised to the attachment. If this value is null, no routes are advertised through this attachment.
	// This field cannot be set by the user while creating the resource and gets a default value on creation. This can be only be updated to its default value. If this fields needs to be set to null, removeExportDrgRouteDistributionTrigger needs to be used.
	ExportDrgRouteDistributionId pulumi.StringPtrInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// Indicates whether the DRG attachment and attached network live in a different tenancy than the DRG.  Example: `false`
	IsCrossTenancy pulumi.BoolPtrInput
	// (Updatable)
	NetworkDetails CoreDrgAttachmentNetworkDetailsPtrInput
	// (Updatable) An optional property when set to true during update disables the export of route Distribution by setting exportDrgRouteDistributionId to null.
	RemoveExportDrgRouteDistributionTrigger pulumi.BoolPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table used by the DRG attachment.
	RouteTableId pulumi.StringPtrInput
	// The DRG attachment's current state.
	State pulumi.StringPtrInput
	// The date and time the DRG attachment was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN. This field is deprecated. Instead, use the `networkDetails` field to specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
	VcnId pulumi.StringPtrInput
}

func (CoreDrgAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*coreDrgAttachmentState)(nil)).Elem()
}

type coreDrgAttachmentArgs struct {
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique. Avoid entering confidential information.
	DisplayName *string `pulumi:"displayName"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
	DrgId string `pulumi:"drgId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
	DrgRouteTableId *string `pulumi:"drgRouteTableId"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table are advertised to the attachment. If this value is null, no routes are advertised through this attachment.
	// This field cannot be set by the user while creating the resource and gets a default value on creation. This can be only be updated to its default value. If this fields needs to be set to null, removeExportDrgRouteDistributionTrigger needs to be used.
	ExportDrgRouteDistributionId *string `pulumi:"exportDrgRouteDistributionId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// (Updatable)
	NetworkDetails *CoreDrgAttachmentNetworkDetails `pulumi:"networkDetails"`
	// (Updatable) An optional property when set to true during update disables the export of route Distribution by setting exportDrgRouteDistributionId to null.
	RemoveExportDrgRouteDistributionTrigger *bool `pulumi:"removeExportDrgRouteDistributionTrigger"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table used by the DRG attachment.
	RouteTableId *string `pulumi:"routeTableId"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN. This field is deprecated. Instead, use the `networkDetails` field to specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
	VcnId *string `pulumi:"vcnId"`
}

// The set of arguments for constructing a CoreDrgAttachment resource.
type CoreDrgAttachmentArgs struct {
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapInput
	// (Updatable) A user-friendly name. Does not have to be unique. Avoid entering confidential information.
	DisplayName pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
	DrgId pulumi.StringInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG route table that is assigned to this attachment.
	DrgRouteTableId pulumi.StringPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the export route distribution used to specify how routes in the assigned DRG route table are advertised to the attachment. If this value is null, no routes are advertised through this attachment.
	// This field cannot be set by the user while creating the resource and gets a default value on creation. This can be only be updated to its default value. If this fields needs to be set to null, removeExportDrgRouteDistributionTrigger needs to be used.
	ExportDrgRouteDistributionId pulumi.StringPtrInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// (Updatable)
	NetworkDetails CoreDrgAttachmentNetworkDetailsPtrInput
	// (Updatable) An optional property when set to true during update disables the export of route Distribution by setting exportDrgRouteDistributionId to null.
	RemoveExportDrgRouteDistributionTrigger pulumi.BoolPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route table used by the DRG attachment.
	RouteTableId pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN. This field is deprecated. Instead, use the `networkDetails` field to specify the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the attached resource.
	VcnId pulumi.StringPtrInput
}

func (CoreDrgAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*coreDrgAttachmentArgs)(nil)).Elem()
}

type CoreDrgAttachmentInput interface {
	pulumi.Input

	ToCoreDrgAttachmentOutput() CoreDrgAttachmentOutput
	ToCoreDrgAttachmentOutputWithContext(ctx context.Context) CoreDrgAttachmentOutput
}

func (*CoreDrgAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((*CoreDrgAttachment)(nil))
}

func (i *CoreDrgAttachment) ToCoreDrgAttachmentOutput() CoreDrgAttachmentOutput {
	return i.ToCoreDrgAttachmentOutputWithContext(context.Background())
}

func (i *CoreDrgAttachment) ToCoreDrgAttachmentOutputWithContext(ctx context.Context) CoreDrgAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgAttachmentOutput)
}

func (i *CoreDrgAttachment) ToCoreDrgAttachmentPtrOutput() CoreDrgAttachmentPtrOutput {
	return i.ToCoreDrgAttachmentPtrOutputWithContext(context.Background())
}

func (i *CoreDrgAttachment) ToCoreDrgAttachmentPtrOutputWithContext(ctx context.Context) CoreDrgAttachmentPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgAttachmentPtrOutput)
}

type CoreDrgAttachmentPtrInput interface {
	pulumi.Input

	ToCoreDrgAttachmentPtrOutput() CoreDrgAttachmentPtrOutput
	ToCoreDrgAttachmentPtrOutputWithContext(ctx context.Context) CoreDrgAttachmentPtrOutput
}

type coreDrgAttachmentPtrType CoreDrgAttachmentArgs

func (*coreDrgAttachmentPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**CoreDrgAttachment)(nil))
}

func (i *coreDrgAttachmentPtrType) ToCoreDrgAttachmentPtrOutput() CoreDrgAttachmentPtrOutput {
	return i.ToCoreDrgAttachmentPtrOutputWithContext(context.Background())
}

func (i *coreDrgAttachmentPtrType) ToCoreDrgAttachmentPtrOutputWithContext(ctx context.Context) CoreDrgAttachmentPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgAttachmentPtrOutput)
}

// CoreDrgAttachmentArrayInput is an input type that accepts CoreDrgAttachmentArray and CoreDrgAttachmentArrayOutput values.
// You can construct a concrete instance of `CoreDrgAttachmentArrayInput` via:
//
//          CoreDrgAttachmentArray{ CoreDrgAttachmentArgs{...} }
type CoreDrgAttachmentArrayInput interface {
	pulumi.Input

	ToCoreDrgAttachmentArrayOutput() CoreDrgAttachmentArrayOutput
	ToCoreDrgAttachmentArrayOutputWithContext(context.Context) CoreDrgAttachmentArrayOutput
}

type CoreDrgAttachmentArray []CoreDrgAttachmentInput

func (CoreDrgAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CoreDrgAttachment)(nil)).Elem()
}

func (i CoreDrgAttachmentArray) ToCoreDrgAttachmentArrayOutput() CoreDrgAttachmentArrayOutput {
	return i.ToCoreDrgAttachmentArrayOutputWithContext(context.Background())
}

func (i CoreDrgAttachmentArray) ToCoreDrgAttachmentArrayOutputWithContext(ctx context.Context) CoreDrgAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgAttachmentArrayOutput)
}

// CoreDrgAttachmentMapInput is an input type that accepts CoreDrgAttachmentMap and CoreDrgAttachmentMapOutput values.
// You can construct a concrete instance of `CoreDrgAttachmentMapInput` via:
//
//          CoreDrgAttachmentMap{ "key": CoreDrgAttachmentArgs{...} }
type CoreDrgAttachmentMapInput interface {
	pulumi.Input

	ToCoreDrgAttachmentMapOutput() CoreDrgAttachmentMapOutput
	ToCoreDrgAttachmentMapOutputWithContext(context.Context) CoreDrgAttachmentMapOutput
}

type CoreDrgAttachmentMap map[string]CoreDrgAttachmentInput

func (CoreDrgAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CoreDrgAttachment)(nil)).Elem()
}

func (i CoreDrgAttachmentMap) ToCoreDrgAttachmentMapOutput() CoreDrgAttachmentMapOutput {
	return i.ToCoreDrgAttachmentMapOutputWithContext(context.Background())
}

func (i CoreDrgAttachmentMap) ToCoreDrgAttachmentMapOutputWithContext(ctx context.Context) CoreDrgAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgAttachmentMapOutput)
}

type CoreDrgAttachmentOutput struct {
	*pulumi.OutputState
}

func (CoreDrgAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CoreDrgAttachment)(nil))
}

func (o CoreDrgAttachmentOutput) ToCoreDrgAttachmentOutput() CoreDrgAttachmentOutput {
	return o
}

func (o CoreDrgAttachmentOutput) ToCoreDrgAttachmentOutputWithContext(ctx context.Context) CoreDrgAttachmentOutput {
	return o
}

func (o CoreDrgAttachmentOutput) ToCoreDrgAttachmentPtrOutput() CoreDrgAttachmentPtrOutput {
	return o.ToCoreDrgAttachmentPtrOutputWithContext(context.Background())
}

func (o CoreDrgAttachmentOutput) ToCoreDrgAttachmentPtrOutputWithContext(ctx context.Context) CoreDrgAttachmentPtrOutput {
	return o.ApplyT(func(v CoreDrgAttachment) *CoreDrgAttachment {
		return &v
	}).(CoreDrgAttachmentPtrOutput)
}

type CoreDrgAttachmentPtrOutput struct {
	*pulumi.OutputState
}

func (CoreDrgAttachmentPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CoreDrgAttachment)(nil))
}

func (o CoreDrgAttachmentPtrOutput) ToCoreDrgAttachmentPtrOutput() CoreDrgAttachmentPtrOutput {
	return o
}

func (o CoreDrgAttachmentPtrOutput) ToCoreDrgAttachmentPtrOutputWithContext(ctx context.Context) CoreDrgAttachmentPtrOutput {
	return o
}

type CoreDrgAttachmentArrayOutput struct{ *pulumi.OutputState }

func (CoreDrgAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]CoreDrgAttachment)(nil))
}

func (o CoreDrgAttachmentArrayOutput) ToCoreDrgAttachmentArrayOutput() CoreDrgAttachmentArrayOutput {
	return o
}

func (o CoreDrgAttachmentArrayOutput) ToCoreDrgAttachmentArrayOutputWithContext(ctx context.Context) CoreDrgAttachmentArrayOutput {
	return o
}

func (o CoreDrgAttachmentArrayOutput) Index(i pulumi.IntInput) CoreDrgAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) CoreDrgAttachment {
		return vs[0].([]CoreDrgAttachment)[vs[1].(int)]
	}).(CoreDrgAttachmentOutput)
}

type CoreDrgAttachmentMapOutput struct{ *pulumi.OutputState }

func (CoreDrgAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]CoreDrgAttachment)(nil))
}

func (o CoreDrgAttachmentMapOutput) ToCoreDrgAttachmentMapOutput() CoreDrgAttachmentMapOutput {
	return o
}

func (o CoreDrgAttachmentMapOutput) ToCoreDrgAttachmentMapOutputWithContext(ctx context.Context) CoreDrgAttachmentMapOutput {
	return o
}

func (o CoreDrgAttachmentMapOutput) MapIndex(k pulumi.StringInput) CoreDrgAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) CoreDrgAttachment {
		return vs[0].(map[string]CoreDrgAttachment)[vs[1].(string)]
	}).(CoreDrgAttachmentOutput)
}

func init() {
	pulumi.RegisterOutputType(CoreDrgAttachmentOutput{})
	pulumi.RegisterOutputType(CoreDrgAttachmentPtrOutput{})
	pulumi.RegisterOutputType(CoreDrgAttachmentArrayOutput{})
	pulumi.RegisterOutputType(CoreDrgAttachmentMapOutput{})
}