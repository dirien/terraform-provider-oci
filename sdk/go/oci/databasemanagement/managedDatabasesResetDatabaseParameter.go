// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package databasemanagement

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Managed Databases Reset Database Parameter resource in Oracle Cloud Infrastructure Database Management service.
//
// Resets database parameter values to their default or startup values.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/databasemanagement"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := databasemanagement.NewManagedDatabasesResetDatabaseParameter(ctx, "testManagedDatabasesResetDatabaseParameter", &databasemanagement.ManagedDatabasesResetDatabaseParameterArgs{
// 			Credentials: &databasemanagement.ManagedDatabasesResetDatabaseParameterCredentialsArgs{
// 				Password: pulumi.Any(_var.Managed_databases_reset_database_parameter_credentials_password),
// 				Role:     pulumi.Any(_var.Managed_databases_reset_database_parameter_credentials_role),
// 				UserName: pulumi.Any(oci_identity_user.Test_user.Name),
// 			},
// 			ManagedDatabaseId: pulumi.Any(oci_database_management_managed_database.Test_managed_database.Id),
// 			Parameters:        pulumi.Any(_var.Managed_databases_reset_database_parameter_parameters),
// 			Scope:             pulumi.Any(_var.Managed_databases_reset_database_parameter_scope),
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
type ManagedDatabasesResetDatabaseParameter struct {
	pulumi.CustomResourceState

	// The database credentials used to perform management activity.
	Credentials ManagedDatabasesResetDatabaseParameterCredentialsOutput `pulumi:"credentials"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
	ManagedDatabaseId pulumi.StringOutput `pulumi:"managedDatabaseId"`
	// A list of database parameter names.
	Parameters pulumi.StringArrayOutput `pulumi:"parameters"`
	// The clause used to specify when the parameter change takes effect.
	Scope pulumi.StringOutput `pulumi:"scope"`
}

// NewManagedDatabasesResetDatabaseParameter registers a new resource with the given unique name, arguments, and options.
func NewManagedDatabasesResetDatabaseParameter(ctx *pulumi.Context,
	name string, args *ManagedDatabasesResetDatabaseParameterArgs, opts ...pulumi.ResourceOption) (*ManagedDatabasesResetDatabaseParameter, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Credentials == nil {
		return nil, errors.New("invalid value for required argument 'Credentials'")
	}
	if args.ManagedDatabaseId == nil {
		return nil, errors.New("invalid value for required argument 'ManagedDatabaseId'")
	}
	if args.Parameters == nil {
		return nil, errors.New("invalid value for required argument 'Parameters'")
	}
	if args.Scope == nil {
		return nil, errors.New("invalid value for required argument 'Scope'")
	}
	var resource ManagedDatabasesResetDatabaseParameter
	err := ctx.RegisterResource("oci:databasemanagement/managedDatabasesResetDatabaseParameter:ManagedDatabasesResetDatabaseParameter", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedDatabasesResetDatabaseParameter gets an existing ManagedDatabasesResetDatabaseParameter resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedDatabasesResetDatabaseParameter(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedDatabasesResetDatabaseParameterState, opts ...pulumi.ResourceOption) (*ManagedDatabasesResetDatabaseParameter, error) {
	var resource ManagedDatabasesResetDatabaseParameter
	err := ctx.ReadResource("oci:databasemanagement/managedDatabasesResetDatabaseParameter:ManagedDatabasesResetDatabaseParameter", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedDatabasesResetDatabaseParameter resources.
type managedDatabasesResetDatabaseParameterState struct {
	// The database credentials used to perform management activity.
	Credentials *ManagedDatabasesResetDatabaseParameterCredentials `pulumi:"credentials"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
	ManagedDatabaseId *string `pulumi:"managedDatabaseId"`
	// A list of database parameter names.
	Parameters []string `pulumi:"parameters"`
	// The clause used to specify when the parameter change takes effect.
	Scope *string `pulumi:"scope"`
}

type ManagedDatabasesResetDatabaseParameterState struct {
	// The database credentials used to perform management activity.
	Credentials ManagedDatabasesResetDatabaseParameterCredentialsPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
	ManagedDatabaseId pulumi.StringPtrInput
	// A list of database parameter names.
	Parameters pulumi.StringArrayInput
	// The clause used to specify when the parameter change takes effect.
	Scope pulumi.StringPtrInput
}

func (ManagedDatabasesResetDatabaseParameterState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedDatabasesResetDatabaseParameterState)(nil)).Elem()
}

type managedDatabasesResetDatabaseParameterArgs struct {
	// The database credentials used to perform management activity.
	Credentials ManagedDatabasesResetDatabaseParameterCredentials `pulumi:"credentials"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
	ManagedDatabaseId string `pulumi:"managedDatabaseId"`
	// A list of database parameter names.
	Parameters []string `pulumi:"parameters"`
	// The clause used to specify when the parameter change takes effect.
	Scope string `pulumi:"scope"`
}

// The set of arguments for constructing a ManagedDatabasesResetDatabaseParameter resource.
type ManagedDatabasesResetDatabaseParameterArgs struct {
	// The database credentials used to perform management activity.
	Credentials ManagedDatabasesResetDatabaseParameterCredentialsInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
	ManagedDatabaseId pulumi.StringInput
	// A list of database parameter names.
	Parameters pulumi.StringArrayInput
	// The clause used to specify when the parameter change takes effect.
	Scope pulumi.StringInput
}

func (ManagedDatabasesResetDatabaseParameterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedDatabasesResetDatabaseParameterArgs)(nil)).Elem()
}

type ManagedDatabasesResetDatabaseParameterInput interface {
	pulumi.Input

	ToManagedDatabasesResetDatabaseParameterOutput() ManagedDatabasesResetDatabaseParameterOutput
	ToManagedDatabasesResetDatabaseParameterOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterOutput
}

func (*ManagedDatabasesResetDatabaseParameter) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedDatabasesResetDatabaseParameter)(nil))
}

func (i *ManagedDatabasesResetDatabaseParameter) ToManagedDatabasesResetDatabaseParameterOutput() ManagedDatabasesResetDatabaseParameterOutput {
	return i.ToManagedDatabasesResetDatabaseParameterOutputWithContext(context.Background())
}

func (i *ManagedDatabasesResetDatabaseParameter) ToManagedDatabasesResetDatabaseParameterOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabasesResetDatabaseParameterOutput)
}

func (i *ManagedDatabasesResetDatabaseParameter) ToManagedDatabasesResetDatabaseParameterPtrOutput() ManagedDatabasesResetDatabaseParameterPtrOutput {
	return i.ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(context.Background())
}

func (i *ManagedDatabasesResetDatabaseParameter) ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabasesResetDatabaseParameterPtrOutput)
}

type ManagedDatabasesResetDatabaseParameterPtrInput interface {
	pulumi.Input

	ToManagedDatabasesResetDatabaseParameterPtrOutput() ManagedDatabasesResetDatabaseParameterPtrOutput
	ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterPtrOutput
}

type managedDatabasesResetDatabaseParameterPtrType ManagedDatabasesResetDatabaseParameterArgs

func (*managedDatabasesResetDatabaseParameterPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedDatabasesResetDatabaseParameter)(nil))
}

func (i *managedDatabasesResetDatabaseParameterPtrType) ToManagedDatabasesResetDatabaseParameterPtrOutput() ManagedDatabasesResetDatabaseParameterPtrOutput {
	return i.ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(context.Background())
}

func (i *managedDatabasesResetDatabaseParameterPtrType) ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabasesResetDatabaseParameterPtrOutput)
}

// ManagedDatabasesResetDatabaseParameterArrayInput is an input type that accepts ManagedDatabasesResetDatabaseParameterArray and ManagedDatabasesResetDatabaseParameterArrayOutput values.
// You can construct a concrete instance of `ManagedDatabasesResetDatabaseParameterArrayInput` via:
//
//          ManagedDatabasesResetDatabaseParameterArray{ ManagedDatabasesResetDatabaseParameterArgs{...} }
type ManagedDatabasesResetDatabaseParameterArrayInput interface {
	pulumi.Input

	ToManagedDatabasesResetDatabaseParameterArrayOutput() ManagedDatabasesResetDatabaseParameterArrayOutput
	ToManagedDatabasesResetDatabaseParameterArrayOutputWithContext(context.Context) ManagedDatabasesResetDatabaseParameterArrayOutput
}

type ManagedDatabasesResetDatabaseParameterArray []ManagedDatabasesResetDatabaseParameterInput

func (ManagedDatabasesResetDatabaseParameterArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagedDatabasesResetDatabaseParameter)(nil)).Elem()
}

func (i ManagedDatabasesResetDatabaseParameterArray) ToManagedDatabasesResetDatabaseParameterArrayOutput() ManagedDatabasesResetDatabaseParameterArrayOutput {
	return i.ToManagedDatabasesResetDatabaseParameterArrayOutputWithContext(context.Background())
}

func (i ManagedDatabasesResetDatabaseParameterArray) ToManagedDatabasesResetDatabaseParameterArrayOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabasesResetDatabaseParameterArrayOutput)
}

// ManagedDatabasesResetDatabaseParameterMapInput is an input type that accepts ManagedDatabasesResetDatabaseParameterMap and ManagedDatabasesResetDatabaseParameterMapOutput values.
// You can construct a concrete instance of `ManagedDatabasesResetDatabaseParameterMapInput` via:
//
//          ManagedDatabasesResetDatabaseParameterMap{ "key": ManagedDatabasesResetDatabaseParameterArgs{...} }
type ManagedDatabasesResetDatabaseParameterMapInput interface {
	pulumi.Input

	ToManagedDatabasesResetDatabaseParameterMapOutput() ManagedDatabasesResetDatabaseParameterMapOutput
	ToManagedDatabasesResetDatabaseParameterMapOutputWithContext(context.Context) ManagedDatabasesResetDatabaseParameterMapOutput
}

type ManagedDatabasesResetDatabaseParameterMap map[string]ManagedDatabasesResetDatabaseParameterInput

func (ManagedDatabasesResetDatabaseParameterMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagedDatabasesResetDatabaseParameter)(nil)).Elem()
}

func (i ManagedDatabasesResetDatabaseParameterMap) ToManagedDatabasesResetDatabaseParameterMapOutput() ManagedDatabasesResetDatabaseParameterMapOutput {
	return i.ToManagedDatabasesResetDatabaseParameterMapOutputWithContext(context.Background())
}

func (i ManagedDatabasesResetDatabaseParameterMap) ToManagedDatabasesResetDatabaseParameterMapOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedDatabasesResetDatabaseParameterMapOutput)
}

type ManagedDatabasesResetDatabaseParameterOutput struct {
	*pulumi.OutputState
}

func (ManagedDatabasesResetDatabaseParameterOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedDatabasesResetDatabaseParameter)(nil))
}

func (o ManagedDatabasesResetDatabaseParameterOutput) ToManagedDatabasesResetDatabaseParameterOutput() ManagedDatabasesResetDatabaseParameterOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterOutput) ToManagedDatabasesResetDatabaseParameterOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterOutput) ToManagedDatabasesResetDatabaseParameterPtrOutput() ManagedDatabasesResetDatabaseParameterPtrOutput {
	return o.ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(context.Background())
}

func (o ManagedDatabasesResetDatabaseParameterOutput) ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterPtrOutput {
	return o.ApplyT(func(v ManagedDatabasesResetDatabaseParameter) *ManagedDatabasesResetDatabaseParameter {
		return &v
	}).(ManagedDatabasesResetDatabaseParameterPtrOutput)
}

type ManagedDatabasesResetDatabaseParameterPtrOutput struct {
	*pulumi.OutputState
}

func (ManagedDatabasesResetDatabaseParameterPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagedDatabasesResetDatabaseParameter)(nil))
}

func (o ManagedDatabasesResetDatabaseParameterPtrOutput) ToManagedDatabasesResetDatabaseParameterPtrOutput() ManagedDatabasesResetDatabaseParameterPtrOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterPtrOutput) ToManagedDatabasesResetDatabaseParameterPtrOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterPtrOutput {
	return o
}

type ManagedDatabasesResetDatabaseParameterArrayOutput struct{ *pulumi.OutputState }

func (ManagedDatabasesResetDatabaseParameterArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ManagedDatabasesResetDatabaseParameter)(nil))
}

func (o ManagedDatabasesResetDatabaseParameterArrayOutput) ToManagedDatabasesResetDatabaseParameterArrayOutput() ManagedDatabasesResetDatabaseParameterArrayOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterArrayOutput) ToManagedDatabasesResetDatabaseParameterArrayOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterArrayOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterArrayOutput) Index(i pulumi.IntInput) ManagedDatabasesResetDatabaseParameterOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ManagedDatabasesResetDatabaseParameter {
		return vs[0].([]ManagedDatabasesResetDatabaseParameter)[vs[1].(int)]
	}).(ManagedDatabasesResetDatabaseParameterOutput)
}

type ManagedDatabasesResetDatabaseParameterMapOutput struct{ *pulumi.OutputState }

func (ManagedDatabasesResetDatabaseParameterMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]ManagedDatabasesResetDatabaseParameter)(nil))
}

func (o ManagedDatabasesResetDatabaseParameterMapOutput) ToManagedDatabasesResetDatabaseParameterMapOutput() ManagedDatabasesResetDatabaseParameterMapOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterMapOutput) ToManagedDatabasesResetDatabaseParameterMapOutputWithContext(ctx context.Context) ManagedDatabasesResetDatabaseParameterMapOutput {
	return o
}

func (o ManagedDatabasesResetDatabaseParameterMapOutput) MapIndex(k pulumi.StringInput) ManagedDatabasesResetDatabaseParameterOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) ManagedDatabasesResetDatabaseParameter {
		return vs[0].(map[string]ManagedDatabasesResetDatabaseParameter)[vs[1].(string)]
	}).(ManagedDatabasesResetDatabaseParameterOutput)
}

func init() {
	pulumi.RegisterOutputType(ManagedDatabasesResetDatabaseParameterOutput{})
	pulumi.RegisterOutputType(ManagedDatabasesResetDatabaseParameterPtrOutput{})
	pulumi.RegisterOutputType(ManagedDatabasesResetDatabaseParameterArrayOutput{})
	pulumi.RegisterOutputType(ManagedDatabasesResetDatabaseParameterMapOutput{})
}