// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package database

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the External Pluggable Database Management resource in Oracle Cloud Infrastructure Database service.
//
// Enable Database Management Service for the external pluggable database.
// For more information about the Database Management Service, see
// [Database Management Service](https://docs.cloud.oracle.com/iaas/Content/ExternalDatabase/Concepts/databasemanagementservice.htm).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/database"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := database.NewExternalPluggableDatabaseManagement(ctx, "testExternalPluggableDatabaseManagement", &database.ExternalPluggableDatabaseManagementArgs{
// 			ExternalDatabaseConnectorId: pulumi.Any(oci_database_external_database_connector.Test_external_database_connector.Id),
// 			ExternalPluggableDatabaseId: pulumi.Any(oci_database_external_pluggable_database.Test_external_pluggable_database.Id),
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
// Import is not supported for this resource.
type ExternalPluggableDatabaseManagement struct {
	pulumi.CustomResourceState

	EnableManagement pulumi.BoolOutput `pulumi:"enableManagement"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the [external database connector](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/datatypes/CreateExternalDatabaseConnectorDetails).
	ExternalDatabaseConnectorId pulumi.StringOutput `pulumi:"externalDatabaseConnectorId"`
	// The ExternalPluggableDatabaseId [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalPluggableDatabaseId pulumi.StringOutput `pulumi:"externalPluggableDatabaseId"`
}

// NewExternalPluggableDatabaseManagement registers a new resource with the given unique name, arguments, and options.
func NewExternalPluggableDatabaseManagement(ctx *pulumi.Context,
	name string, args *ExternalPluggableDatabaseManagementArgs, opts ...pulumi.ResourceOption) (*ExternalPluggableDatabaseManagement, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EnableManagement == nil {
		return nil, errors.New("invalid value for required argument 'EnableManagement'")
	}
	if args.ExternalDatabaseConnectorId == nil {
		return nil, errors.New("invalid value for required argument 'ExternalDatabaseConnectorId'")
	}
	if args.ExternalPluggableDatabaseId == nil {
		return nil, errors.New("invalid value for required argument 'ExternalPluggableDatabaseId'")
	}
	var resource ExternalPluggableDatabaseManagement
	err := ctx.RegisterResource("oci:database/externalPluggableDatabaseManagement:ExternalPluggableDatabaseManagement", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetExternalPluggableDatabaseManagement gets an existing ExternalPluggableDatabaseManagement resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetExternalPluggableDatabaseManagement(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ExternalPluggableDatabaseManagementState, opts ...pulumi.ResourceOption) (*ExternalPluggableDatabaseManagement, error) {
	var resource ExternalPluggableDatabaseManagement
	err := ctx.ReadResource("oci:database/externalPluggableDatabaseManagement:ExternalPluggableDatabaseManagement", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ExternalPluggableDatabaseManagement resources.
type externalPluggableDatabaseManagementState struct {
	EnableManagement *bool `pulumi:"enableManagement"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the [external database connector](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/datatypes/CreateExternalDatabaseConnectorDetails).
	ExternalDatabaseConnectorId *string `pulumi:"externalDatabaseConnectorId"`
	// The ExternalPluggableDatabaseId [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalPluggableDatabaseId *string `pulumi:"externalPluggableDatabaseId"`
}

type ExternalPluggableDatabaseManagementState struct {
	EnableManagement pulumi.BoolPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the [external database connector](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/datatypes/CreateExternalDatabaseConnectorDetails).
	ExternalDatabaseConnectorId pulumi.StringPtrInput
	// The ExternalPluggableDatabaseId [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalPluggableDatabaseId pulumi.StringPtrInput
}

func (ExternalPluggableDatabaseManagementState) ElementType() reflect.Type {
	return reflect.TypeOf((*externalPluggableDatabaseManagementState)(nil)).Elem()
}

type externalPluggableDatabaseManagementArgs struct {
	EnableManagement bool `pulumi:"enableManagement"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the [external database connector](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/datatypes/CreateExternalDatabaseConnectorDetails).
	ExternalDatabaseConnectorId string `pulumi:"externalDatabaseConnectorId"`
	// The ExternalPluggableDatabaseId [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalPluggableDatabaseId string `pulumi:"externalPluggableDatabaseId"`
}

// The set of arguments for constructing a ExternalPluggableDatabaseManagement resource.
type ExternalPluggableDatabaseManagementArgs struct {
	EnableManagement pulumi.BoolInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the [external database connector](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/datatypes/CreateExternalDatabaseConnectorDetails).
	ExternalDatabaseConnectorId pulumi.StringInput
	// The ExternalPluggableDatabaseId [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalPluggableDatabaseId pulumi.StringInput
}

func (ExternalPluggableDatabaseManagementArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*externalPluggableDatabaseManagementArgs)(nil)).Elem()
}

type ExternalPluggableDatabaseManagementInput interface {
	pulumi.Input

	ToExternalPluggableDatabaseManagementOutput() ExternalPluggableDatabaseManagementOutput
	ToExternalPluggableDatabaseManagementOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementOutput
}

func (*ExternalPluggableDatabaseManagement) ElementType() reflect.Type {
	return reflect.TypeOf((*ExternalPluggableDatabaseManagement)(nil))
}

func (i *ExternalPluggableDatabaseManagement) ToExternalPluggableDatabaseManagementOutput() ExternalPluggableDatabaseManagementOutput {
	return i.ToExternalPluggableDatabaseManagementOutputWithContext(context.Background())
}

func (i *ExternalPluggableDatabaseManagement) ToExternalPluggableDatabaseManagementOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExternalPluggableDatabaseManagementOutput)
}

func (i *ExternalPluggableDatabaseManagement) ToExternalPluggableDatabaseManagementPtrOutput() ExternalPluggableDatabaseManagementPtrOutput {
	return i.ToExternalPluggableDatabaseManagementPtrOutputWithContext(context.Background())
}

func (i *ExternalPluggableDatabaseManagement) ToExternalPluggableDatabaseManagementPtrOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExternalPluggableDatabaseManagementPtrOutput)
}

type ExternalPluggableDatabaseManagementPtrInput interface {
	pulumi.Input

	ToExternalPluggableDatabaseManagementPtrOutput() ExternalPluggableDatabaseManagementPtrOutput
	ToExternalPluggableDatabaseManagementPtrOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementPtrOutput
}

type externalPluggableDatabaseManagementPtrType ExternalPluggableDatabaseManagementArgs

func (*externalPluggableDatabaseManagementPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ExternalPluggableDatabaseManagement)(nil))
}

func (i *externalPluggableDatabaseManagementPtrType) ToExternalPluggableDatabaseManagementPtrOutput() ExternalPluggableDatabaseManagementPtrOutput {
	return i.ToExternalPluggableDatabaseManagementPtrOutputWithContext(context.Background())
}

func (i *externalPluggableDatabaseManagementPtrType) ToExternalPluggableDatabaseManagementPtrOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExternalPluggableDatabaseManagementPtrOutput)
}

// ExternalPluggableDatabaseManagementArrayInput is an input type that accepts ExternalPluggableDatabaseManagementArray and ExternalPluggableDatabaseManagementArrayOutput values.
// You can construct a concrete instance of `ExternalPluggableDatabaseManagementArrayInput` via:
//
//          ExternalPluggableDatabaseManagementArray{ ExternalPluggableDatabaseManagementArgs{...} }
type ExternalPluggableDatabaseManagementArrayInput interface {
	pulumi.Input

	ToExternalPluggableDatabaseManagementArrayOutput() ExternalPluggableDatabaseManagementArrayOutput
	ToExternalPluggableDatabaseManagementArrayOutputWithContext(context.Context) ExternalPluggableDatabaseManagementArrayOutput
}

type ExternalPluggableDatabaseManagementArray []ExternalPluggableDatabaseManagementInput

func (ExternalPluggableDatabaseManagementArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ExternalPluggableDatabaseManagement)(nil)).Elem()
}

func (i ExternalPluggableDatabaseManagementArray) ToExternalPluggableDatabaseManagementArrayOutput() ExternalPluggableDatabaseManagementArrayOutput {
	return i.ToExternalPluggableDatabaseManagementArrayOutputWithContext(context.Background())
}

func (i ExternalPluggableDatabaseManagementArray) ToExternalPluggableDatabaseManagementArrayOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExternalPluggableDatabaseManagementArrayOutput)
}

// ExternalPluggableDatabaseManagementMapInput is an input type that accepts ExternalPluggableDatabaseManagementMap and ExternalPluggableDatabaseManagementMapOutput values.
// You can construct a concrete instance of `ExternalPluggableDatabaseManagementMapInput` via:
//
//          ExternalPluggableDatabaseManagementMap{ "key": ExternalPluggableDatabaseManagementArgs{...} }
type ExternalPluggableDatabaseManagementMapInput interface {
	pulumi.Input

	ToExternalPluggableDatabaseManagementMapOutput() ExternalPluggableDatabaseManagementMapOutput
	ToExternalPluggableDatabaseManagementMapOutputWithContext(context.Context) ExternalPluggableDatabaseManagementMapOutput
}

type ExternalPluggableDatabaseManagementMap map[string]ExternalPluggableDatabaseManagementInput

func (ExternalPluggableDatabaseManagementMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ExternalPluggableDatabaseManagement)(nil)).Elem()
}

func (i ExternalPluggableDatabaseManagementMap) ToExternalPluggableDatabaseManagementMapOutput() ExternalPluggableDatabaseManagementMapOutput {
	return i.ToExternalPluggableDatabaseManagementMapOutputWithContext(context.Background())
}

func (i ExternalPluggableDatabaseManagementMap) ToExternalPluggableDatabaseManagementMapOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExternalPluggableDatabaseManagementMapOutput)
}

type ExternalPluggableDatabaseManagementOutput struct {
	*pulumi.OutputState
}

func (ExternalPluggableDatabaseManagementOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExternalPluggableDatabaseManagement)(nil))
}

func (o ExternalPluggableDatabaseManagementOutput) ToExternalPluggableDatabaseManagementOutput() ExternalPluggableDatabaseManagementOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementOutput) ToExternalPluggableDatabaseManagementOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementOutput) ToExternalPluggableDatabaseManagementPtrOutput() ExternalPluggableDatabaseManagementPtrOutput {
	return o.ToExternalPluggableDatabaseManagementPtrOutputWithContext(context.Background())
}

func (o ExternalPluggableDatabaseManagementOutput) ToExternalPluggableDatabaseManagementPtrOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementPtrOutput {
	return o.ApplyT(func(v ExternalPluggableDatabaseManagement) *ExternalPluggableDatabaseManagement {
		return &v
	}).(ExternalPluggableDatabaseManagementPtrOutput)
}

type ExternalPluggableDatabaseManagementPtrOutput struct {
	*pulumi.OutputState
}

func (ExternalPluggableDatabaseManagementPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ExternalPluggableDatabaseManagement)(nil))
}

func (o ExternalPluggableDatabaseManagementPtrOutput) ToExternalPluggableDatabaseManagementPtrOutput() ExternalPluggableDatabaseManagementPtrOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementPtrOutput) ToExternalPluggableDatabaseManagementPtrOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementPtrOutput {
	return o
}

type ExternalPluggableDatabaseManagementArrayOutput struct{ *pulumi.OutputState }

func (ExternalPluggableDatabaseManagementArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ExternalPluggableDatabaseManagement)(nil))
}

func (o ExternalPluggableDatabaseManagementArrayOutput) ToExternalPluggableDatabaseManagementArrayOutput() ExternalPluggableDatabaseManagementArrayOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementArrayOutput) ToExternalPluggableDatabaseManagementArrayOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementArrayOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementArrayOutput) Index(i pulumi.IntInput) ExternalPluggableDatabaseManagementOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ExternalPluggableDatabaseManagement {
		return vs[0].([]ExternalPluggableDatabaseManagement)[vs[1].(int)]
	}).(ExternalPluggableDatabaseManagementOutput)
}

type ExternalPluggableDatabaseManagementMapOutput struct{ *pulumi.OutputState }

func (ExternalPluggableDatabaseManagementMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]ExternalPluggableDatabaseManagement)(nil))
}

func (o ExternalPluggableDatabaseManagementMapOutput) ToExternalPluggableDatabaseManagementMapOutput() ExternalPluggableDatabaseManagementMapOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementMapOutput) ToExternalPluggableDatabaseManagementMapOutputWithContext(ctx context.Context) ExternalPluggableDatabaseManagementMapOutput {
	return o
}

func (o ExternalPluggableDatabaseManagementMapOutput) MapIndex(k pulumi.StringInput) ExternalPluggableDatabaseManagementOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) ExternalPluggableDatabaseManagement {
		return vs[0].(map[string]ExternalPluggableDatabaseManagement)[vs[1].(string)]
	}).(ExternalPluggableDatabaseManagementOutput)
}

func init() {
	pulumi.RegisterOutputType(ExternalPluggableDatabaseManagementOutput{})
	pulumi.RegisterOutputType(ExternalPluggableDatabaseManagementPtrOutput{})
	pulumi.RegisterOutputType(ExternalPluggableDatabaseManagementArrayOutput{})
	pulumi.RegisterOutputType(ExternalPluggableDatabaseManagementMapOutput{})
}