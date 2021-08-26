// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package core

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Remote Peering Connection resource in Oracle Cloud Infrastructure Core service.
//
// Creates a new remote peering connection (RPC) for the specified DRG.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/core"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := core.NewRemotePeeringConnection(ctx, "testRemotePeeringConnection", &core.RemotePeeringConnectionArgs{
// 			CompartmentId: pulumi.Any(_var.Compartment_id),
// 			DrgId:         pulumi.Any(oci_core_drg.Test_drg.Id),
// 			DefinedTags: pulumi.AnyMap{
// 				"Operations.CostCenter": pulumi.Any("42"),
// 			},
// 			DisplayName: pulumi.Any(_var.Remote_peering_connection_display_name),
// 			FreeformTags: pulumi.AnyMap{
// 				"Department": pulumi.Any("Finance"),
// 			},
// 			PeerId:         pulumi.Any(oci_core_remote_peering_connection.Test_remote_peering_connection2.Id),
// 			PeerRegionName: pulumi.Any(_var.Remote_peering_connection_peer_region_name),
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
// RemotePeeringConnections can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:core/remotePeeringConnection:RemotePeeringConnection test_remote_peering_connection "id"
// ```
type RemotePeeringConnection struct {
	pulumi.CustomResourceState

	// (Updatable) The OCID of the compartment to contain the RPC.
	CompartmentId pulumi.StringOutput `pulumi:"compartmentId"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapOutput `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// The OCID of the DRG the RPC belongs to.
	DrgId pulumi.StringOutput `pulumi:"drgId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapOutput `pulumi:"freeformTags"`
	// Whether the VCN at the other end of the peering is in a different tenancy.  Example: `false`
	IsCrossTenancyPeering pulumi.BoolOutput `pulumi:"isCrossTenancyPeering"`
	// The OCID of the RPC you want to peer with.
	PeerId pulumi.StringOutput `pulumi:"peerId"`
	// The name of the region that contains the RPC you want to peer with.  Example: `us-ashburn-1`
	PeerRegionName pulumi.StringOutput `pulumi:"peerRegionName"`
	// If this RPC is peered, this value is the OCID of the other RPC's tenancy.
	PeerTenancyId pulumi.StringOutput `pulumi:"peerTenancyId"`
	// Whether the RPC is peered with another RPC. `NEW` means the RPC has not yet been peered. `PENDING` means the peering is being established. `REVOKED` means the RPC at the other end of the peering has been deleted.
	PeeringStatus pulumi.StringOutput `pulumi:"peeringStatus"`
	// The RPC's current lifecycle state.
	State pulumi.StringOutput `pulumi:"state"`
	// The date and time the RPC was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated pulumi.StringOutput `pulumi:"timeCreated"`
}

// NewRemotePeeringConnection registers a new resource with the given unique name, arguments, and options.
func NewRemotePeeringConnection(ctx *pulumi.Context,
	name string, args *RemotePeeringConnectionArgs, opts ...pulumi.ResourceOption) (*RemotePeeringConnection, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CompartmentId == nil {
		return nil, errors.New("invalid value for required argument 'CompartmentId'")
	}
	if args.DrgId == nil {
		return nil, errors.New("invalid value for required argument 'DrgId'")
	}
	var resource RemotePeeringConnection
	err := ctx.RegisterResource("oci:core/remotePeeringConnection:RemotePeeringConnection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRemotePeeringConnection gets an existing RemotePeeringConnection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRemotePeeringConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RemotePeeringConnectionState, opts ...pulumi.ResourceOption) (*RemotePeeringConnection, error) {
	var resource RemotePeeringConnection
	err := ctx.ReadResource("oci:core/remotePeeringConnection:RemotePeeringConnection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RemotePeeringConnection resources.
type remotePeeringConnectionState struct {
	// (Updatable) The OCID of the compartment to contain the RPC.
	CompartmentId *string `pulumi:"compartmentId"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
	DisplayName *string `pulumi:"displayName"`
	// The OCID of the DRG the RPC belongs to.
	DrgId *string `pulumi:"drgId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// Whether the VCN at the other end of the peering is in a different tenancy.  Example: `false`
	IsCrossTenancyPeering *bool `pulumi:"isCrossTenancyPeering"`
	// The OCID of the RPC you want to peer with.
	PeerId *string `pulumi:"peerId"`
	// The name of the region that contains the RPC you want to peer with.  Example: `us-ashburn-1`
	PeerRegionName *string `pulumi:"peerRegionName"`
	// If this RPC is peered, this value is the OCID of the other RPC's tenancy.
	PeerTenancyId *string `pulumi:"peerTenancyId"`
	// Whether the RPC is peered with another RPC. `NEW` means the RPC has not yet been peered. `PENDING` means the peering is being established. `REVOKED` means the RPC at the other end of the peering has been deleted.
	PeeringStatus *string `pulumi:"peeringStatus"`
	// The RPC's current lifecycle state.
	State *string `pulumi:"state"`
	// The date and time the RPC was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated *string `pulumi:"timeCreated"`
}

type RemotePeeringConnectionState struct {
	// (Updatable) The OCID of the compartment to contain the RPC.
	CompartmentId pulumi.StringPtrInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapInput
	// (Updatable) A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
	DisplayName pulumi.StringPtrInput
	// The OCID of the DRG the RPC belongs to.
	DrgId pulumi.StringPtrInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// Whether the VCN at the other end of the peering is in a different tenancy.  Example: `false`
	IsCrossTenancyPeering pulumi.BoolPtrInput
	// The OCID of the RPC you want to peer with.
	PeerId pulumi.StringPtrInput
	// The name of the region that contains the RPC you want to peer with.  Example: `us-ashburn-1`
	PeerRegionName pulumi.StringPtrInput
	// If this RPC is peered, this value is the OCID of the other RPC's tenancy.
	PeerTenancyId pulumi.StringPtrInput
	// Whether the RPC is peered with another RPC. `NEW` means the RPC has not yet been peered. `PENDING` means the peering is being established. `REVOKED` means the RPC at the other end of the peering has been deleted.
	PeeringStatus pulumi.StringPtrInput
	// The RPC's current lifecycle state.
	State pulumi.StringPtrInput
	// The date and time the RPC was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated pulumi.StringPtrInput
}

func (RemotePeeringConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*remotePeeringConnectionState)(nil)).Elem()
}

type remotePeeringConnectionArgs struct {
	// (Updatable) The OCID of the compartment to contain the RPC.
	CompartmentId string `pulumi:"compartmentId"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
	DisplayName *string `pulumi:"displayName"`
	// The OCID of the DRG the RPC belongs to.
	DrgId string `pulumi:"drgId"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// The OCID of the RPC you want to peer with.
	PeerId *string `pulumi:"peerId"`
	// The name of the region that contains the RPC you want to peer with.  Example: `us-ashburn-1`
	PeerRegionName *string `pulumi:"peerRegionName"`
}

// The set of arguments for constructing a RemotePeeringConnection resource.
type RemotePeeringConnectionArgs struct {
	// (Updatable) The OCID of the compartment to contain the RPC.
	CompartmentId pulumi.StringInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags pulumi.MapInput
	// (Updatable) A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
	DisplayName pulumi.StringPtrInput
	// The OCID of the DRG the RPC belongs to.
	DrgId pulumi.StringInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// The OCID of the RPC you want to peer with.
	PeerId pulumi.StringPtrInput
	// The name of the region that contains the RPC you want to peer with.  Example: `us-ashburn-1`
	PeerRegionName pulumi.StringPtrInput
}

func (RemotePeeringConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*remotePeeringConnectionArgs)(nil)).Elem()
}

type RemotePeeringConnectionInput interface {
	pulumi.Input

	ToRemotePeeringConnectionOutput() RemotePeeringConnectionOutput
	ToRemotePeeringConnectionOutputWithContext(ctx context.Context) RemotePeeringConnectionOutput
}

func (*RemotePeeringConnection) ElementType() reflect.Type {
	return reflect.TypeOf((*RemotePeeringConnection)(nil))
}

func (i *RemotePeeringConnection) ToRemotePeeringConnectionOutput() RemotePeeringConnectionOutput {
	return i.ToRemotePeeringConnectionOutputWithContext(context.Background())
}

func (i *RemotePeeringConnection) ToRemotePeeringConnectionOutputWithContext(ctx context.Context) RemotePeeringConnectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemotePeeringConnectionOutput)
}

func (i *RemotePeeringConnection) ToRemotePeeringConnectionPtrOutput() RemotePeeringConnectionPtrOutput {
	return i.ToRemotePeeringConnectionPtrOutputWithContext(context.Background())
}

func (i *RemotePeeringConnection) ToRemotePeeringConnectionPtrOutputWithContext(ctx context.Context) RemotePeeringConnectionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemotePeeringConnectionPtrOutput)
}

type RemotePeeringConnectionPtrInput interface {
	pulumi.Input

	ToRemotePeeringConnectionPtrOutput() RemotePeeringConnectionPtrOutput
	ToRemotePeeringConnectionPtrOutputWithContext(ctx context.Context) RemotePeeringConnectionPtrOutput
}

type remotePeeringConnectionPtrType RemotePeeringConnectionArgs

func (*remotePeeringConnectionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**RemotePeeringConnection)(nil))
}

func (i *remotePeeringConnectionPtrType) ToRemotePeeringConnectionPtrOutput() RemotePeeringConnectionPtrOutput {
	return i.ToRemotePeeringConnectionPtrOutputWithContext(context.Background())
}

func (i *remotePeeringConnectionPtrType) ToRemotePeeringConnectionPtrOutputWithContext(ctx context.Context) RemotePeeringConnectionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemotePeeringConnectionPtrOutput)
}

// RemotePeeringConnectionArrayInput is an input type that accepts RemotePeeringConnectionArray and RemotePeeringConnectionArrayOutput values.
// You can construct a concrete instance of `RemotePeeringConnectionArrayInput` via:
//
//          RemotePeeringConnectionArray{ RemotePeeringConnectionArgs{...} }
type RemotePeeringConnectionArrayInput interface {
	pulumi.Input

	ToRemotePeeringConnectionArrayOutput() RemotePeeringConnectionArrayOutput
	ToRemotePeeringConnectionArrayOutputWithContext(context.Context) RemotePeeringConnectionArrayOutput
}

type RemotePeeringConnectionArray []RemotePeeringConnectionInput

func (RemotePeeringConnectionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RemotePeeringConnection)(nil)).Elem()
}

func (i RemotePeeringConnectionArray) ToRemotePeeringConnectionArrayOutput() RemotePeeringConnectionArrayOutput {
	return i.ToRemotePeeringConnectionArrayOutputWithContext(context.Background())
}

func (i RemotePeeringConnectionArray) ToRemotePeeringConnectionArrayOutputWithContext(ctx context.Context) RemotePeeringConnectionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemotePeeringConnectionArrayOutput)
}

// RemotePeeringConnectionMapInput is an input type that accepts RemotePeeringConnectionMap and RemotePeeringConnectionMapOutput values.
// You can construct a concrete instance of `RemotePeeringConnectionMapInput` via:
//
//          RemotePeeringConnectionMap{ "key": RemotePeeringConnectionArgs{...} }
type RemotePeeringConnectionMapInput interface {
	pulumi.Input

	ToRemotePeeringConnectionMapOutput() RemotePeeringConnectionMapOutput
	ToRemotePeeringConnectionMapOutputWithContext(context.Context) RemotePeeringConnectionMapOutput
}

type RemotePeeringConnectionMap map[string]RemotePeeringConnectionInput

func (RemotePeeringConnectionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RemotePeeringConnection)(nil)).Elem()
}

func (i RemotePeeringConnectionMap) ToRemotePeeringConnectionMapOutput() RemotePeeringConnectionMapOutput {
	return i.ToRemotePeeringConnectionMapOutputWithContext(context.Background())
}

func (i RemotePeeringConnectionMap) ToRemotePeeringConnectionMapOutputWithContext(ctx context.Context) RemotePeeringConnectionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RemotePeeringConnectionMapOutput)
}

type RemotePeeringConnectionOutput struct {
	*pulumi.OutputState
}

func (RemotePeeringConnectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*RemotePeeringConnection)(nil))
}

func (o RemotePeeringConnectionOutput) ToRemotePeeringConnectionOutput() RemotePeeringConnectionOutput {
	return o
}

func (o RemotePeeringConnectionOutput) ToRemotePeeringConnectionOutputWithContext(ctx context.Context) RemotePeeringConnectionOutput {
	return o
}

func (o RemotePeeringConnectionOutput) ToRemotePeeringConnectionPtrOutput() RemotePeeringConnectionPtrOutput {
	return o.ToRemotePeeringConnectionPtrOutputWithContext(context.Background())
}

func (o RemotePeeringConnectionOutput) ToRemotePeeringConnectionPtrOutputWithContext(ctx context.Context) RemotePeeringConnectionPtrOutput {
	return o.ApplyT(func(v RemotePeeringConnection) *RemotePeeringConnection {
		return &v
	}).(RemotePeeringConnectionPtrOutput)
}

type RemotePeeringConnectionPtrOutput struct {
	*pulumi.OutputState
}

func (RemotePeeringConnectionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RemotePeeringConnection)(nil))
}

func (o RemotePeeringConnectionPtrOutput) ToRemotePeeringConnectionPtrOutput() RemotePeeringConnectionPtrOutput {
	return o
}

func (o RemotePeeringConnectionPtrOutput) ToRemotePeeringConnectionPtrOutputWithContext(ctx context.Context) RemotePeeringConnectionPtrOutput {
	return o
}

type RemotePeeringConnectionArrayOutput struct{ *pulumi.OutputState }

func (RemotePeeringConnectionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]RemotePeeringConnection)(nil))
}

func (o RemotePeeringConnectionArrayOutput) ToRemotePeeringConnectionArrayOutput() RemotePeeringConnectionArrayOutput {
	return o
}

func (o RemotePeeringConnectionArrayOutput) ToRemotePeeringConnectionArrayOutputWithContext(ctx context.Context) RemotePeeringConnectionArrayOutput {
	return o
}

func (o RemotePeeringConnectionArrayOutput) Index(i pulumi.IntInput) RemotePeeringConnectionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) RemotePeeringConnection {
		return vs[0].([]RemotePeeringConnection)[vs[1].(int)]
	}).(RemotePeeringConnectionOutput)
}

type RemotePeeringConnectionMapOutput struct{ *pulumi.OutputState }

func (RemotePeeringConnectionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]RemotePeeringConnection)(nil))
}

func (o RemotePeeringConnectionMapOutput) ToRemotePeeringConnectionMapOutput() RemotePeeringConnectionMapOutput {
	return o
}

func (o RemotePeeringConnectionMapOutput) ToRemotePeeringConnectionMapOutputWithContext(ctx context.Context) RemotePeeringConnectionMapOutput {
	return o
}

func (o RemotePeeringConnectionMapOutput) MapIndex(k pulumi.StringInput) RemotePeeringConnectionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) RemotePeeringConnection {
		return vs[0].(map[string]RemotePeeringConnection)[vs[1].(string)]
	}).(RemotePeeringConnectionOutput)
}

func init() {
	pulumi.RegisterOutputType(RemotePeeringConnectionOutput{})
	pulumi.RegisterOutputType(RemotePeeringConnectionPtrOutput{})
	pulumi.RegisterOutputType(RemotePeeringConnectionArrayOutput{})
	pulumi.RegisterOutputType(RemotePeeringConnectionMapOutput{})
}