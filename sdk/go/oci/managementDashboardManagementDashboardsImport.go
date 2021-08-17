// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Management Dashboards Import resource in Oracle Cloud Infrastructure Management Dashboard service.
//
// Imports an array of dashboards and their saved searches. Import is designed to work with exportDashboard. An example using Oracle Cloud Infrastructure CLI is
//     $oci management-dashboard dashboard export --query data --export-dashboard-id "{\"dashboardIds\":[\"ocid1.managementdashboard.oc1..dashboardId1\"]}"  > dashboards.json
//     $oci management-dashboard dashboard import --from-json file://dashboards.json
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
// 		_, err := oci.NewManagementDashboardManagementDashboardsImport(ctx, "testManagementDashboardsImport", &oci.ManagementDashboardManagementDashboardsImportArgs{
// 			ImportDetails:     pulumi.Any(_var.Sample_import_details),
// 			ImportDetailsFile: pulumi.Any(_var.Sample_import_details_file_path),
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
// ManagementDashboardsImport can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:index/managementDashboardManagementDashboardsImport:ManagementDashboardManagementDashboardsImport test_management_dashboards_import "id"
// ```
type ManagementDashboardManagementDashboardsImport struct {
	pulumi.CustomResourceState

	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrOutput `pulumi:"importDetails"`
	ImportDetailsFile pulumi.StringPtrOutput `pulumi:"importDetailsFile"`
}

// NewManagementDashboardManagementDashboardsImport registers a new resource with the given unique name, arguments, and options.
func NewManagementDashboardManagementDashboardsImport(ctx *pulumi.Context,
	name string, args *ManagementDashboardManagementDashboardsImportArgs, opts ...pulumi.ResourceOption) (*ManagementDashboardManagementDashboardsImport, error) {
	if args == nil {
		args = &ManagementDashboardManagementDashboardsImportArgs{}
	}

	var resource ManagementDashboardManagementDashboardsImport
	err := ctx.RegisterResource("oci:index/managementDashboardManagementDashboardsImport:ManagementDashboardManagementDashboardsImport", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagementDashboardManagementDashboardsImport gets an existing ManagementDashboardManagementDashboardsImport resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagementDashboardManagementDashboardsImport(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagementDashboardManagementDashboardsImportState, opts ...pulumi.ResourceOption) (*ManagementDashboardManagementDashboardsImport, error) {
	var resource ManagementDashboardManagementDashboardsImport
	err := ctx.ReadResource("oci:index/managementDashboardManagementDashboardsImport:ManagementDashboardManagementDashboardsImport", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagementDashboardManagementDashboardsImport resources.
type managementDashboardManagementDashboardsImportState struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     *string `pulumi:"importDetails"`
	ImportDetailsFile *string `pulumi:"importDetailsFile"`
}

type ManagementDashboardManagementDashboardsImportState struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrInput
	ImportDetailsFile pulumi.StringPtrInput
}

func (ManagementDashboardManagementDashboardsImportState) ElementType() reflect.Type {
	return reflect.TypeOf((*managementDashboardManagementDashboardsImportState)(nil)).Elem()
}

type managementDashboardManagementDashboardsImportArgs struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     *string `pulumi:"importDetails"`
	ImportDetailsFile *string `pulumi:"importDetailsFile"`
}

// The set of arguments for constructing a ManagementDashboardManagementDashboardsImport resource.
type ManagementDashboardManagementDashboardsImportArgs struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrInput
	ImportDetailsFile pulumi.StringPtrInput
}

func (ManagementDashboardManagementDashboardsImportArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managementDashboardManagementDashboardsImportArgs)(nil)).Elem()
}

type ManagementDashboardManagementDashboardsImportInput interface {
	pulumi.Input

	ToManagementDashboardManagementDashboardsImportOutput() ManagementDashboardManagementDashboardsImportOutput
	ToManagementDashboardManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportOutput
}

func (*ManagementDashboardManagementDashboardsImport) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagementDashboardManagementDashboardsImport)(nil))
}

func (i *ManagementDashboardManagementDashboardsImport) ToManagementDashboardManagementDashboardsImportOutput() ManagementDashboardManagementDashboardsImportOutput {
	return i.ToManagementDashboardManagementDashboardsImportOutputWithContext(context.Background())
}

func (i *ManagementDashboardManagementDashboardsImport) ToManagementDashboardManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardManagementDashboardsImportOutput)
}

func (i *ManagementDashboardManagementDashboardsImport) ToManagementDashboardManagementDashboardsImportPtrOutput() ManagementDashboardManagementDashboardsImportPtrOutput {
	return i.ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (i *ManagementDashboardManagementDashboardsImport) ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardManagementDashboardsImportPtrOutput)
}

type ManagementDashboardManagementDashboardsImportPtrInput interface {
	pulumi.Input

	ToManagementDashboardManagementDashboardsImportPtrOutput() ManagementDashboardManagementDashboardsImportPtrOutput
	ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportPtrOutput
}

type managementDashboardManagementDashboardsImportPtrType ManagementDashboardManagementDashboardsImportArgs

func (*managementDashboardManagementDashboardsImportPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagementDashboardManagementDashboardsImport)(nil))
}

func (i *managementDashboardManagementDashboardsImportPtrType) ToManagementDashboardManagementDashboardsImportPtrOutput() ManagementDashboardManagementDashboardsImportPtrOutput {
	return i.ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (i *managementDashboardManagementDashboardsImportPtrType) ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardManagementDashboardsImportPtrOutput)
}

// ManagementDashboardManagementDashboardsImportArrayInput is an input type that accepts ManagementDashboardManagementDashboardsImportArray and ManagementDashboardManagementDashboardsImportArrayOutput values.
// You can construct a concrete instance of `ManagementDashboardManagementDashboardsImportArrayInput` via:
//
//          ManagementDashboardManagementDashboardsImportArray{ ManagementDashboardManagementDashboardsImportArgs{...} }
type ManagementDashboardManagementDashboardsImportArrayInput interface {
	pulumi.Input

	ToManagementDashboardManagementDashboardsImportArrayOutput() ManagementDashboardManagementDashboardsImportArrayOutput
	ToManagementDashboardManagementDashboardsImportArrayOutputWithContext(context.Context) ManagementDashboardManagementDashboardsImportArrayOutput
}

type ManagementDashboardManagementDashboardsImportArray []ManagementDashboardManagementDashboardsImportInput

func (ManagementDashboardManagementDashboardsImportArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagementDashboardManagementDashboardsImport)(nil)).Elem()
}

func (i ManagementDashboardManagementDashboardsImportArray) ToManagementDashboardManagementDashboardsImportArrayOutput() ManagementDashboardManagementDashboardsImportArrayOutput {
	return i.ToManagementDashboardManagementDashboardsImportArrayOutputWithContext(context.Background())
}

func (i ManagementDashboardManagementDashboardsImportArray) ToManagementDashboardManagementDashboardsImportArrayOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardManagementDashboardsImportArrayOutput)
}

// ManagementDashboardManagementDashboardsImportMapInput is an input type that accepts ManagementDashboardManagementDashboardsImportMap and ManagementDashboardManagementDashboardsImportMapOutput values.
// You can construct a concrete instance of `ManagementDashboardManagementDashboardsImportMapInput` via:
//
//          ManagementDashboardManagementDashboardsImportMap{ "key": ManagementDashboardManagementDashboardsImportArgs{...} }
type ManagementDashboardManagementDashboardsImportMapInput interface {
	pulumi.Input

	ToManagementDashboardManagementDashboardsImportMapOutput() ManagementDashboardManagementDashboardsImportMapOutput
	ToManagementDashboardManagementDashboardsImportMapOutputWithContext(context.Context) ManagementDashboardManagementDashboardsImportMapOutput
}

type ManagementDashboardManagementDashboardsImportMap map[string]ManagementDashboardManagementDashboardsImportInput

func (ManagementDashboardManagementDashboardsImportMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagementDashboardManagementDashboardsImport)(nil)).Elem()
}

func (i ManagementDashboardManagementDashboardsImportMap) ToManagementDashboardManagementDashboardsImportMapOutput() ManagementDashboardManagementDashboardsImportMapOutput {
	return i.ToManagementDashboardManagementDashboardsImportMapOutputWithContext(context.Background())
}

func (i ManagementDashboardManagementDashboardsImportMap) ToManagementDashboardManagementDashboardsImportMapOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardManagementDashboardsImportMapOutput)
}

type ManagementDashboardManagementDashboardsImportOutput struct {
	*pulumi.OutputState
}

func (ManagementDashboardManagementDashboardsImportOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagementDashboardManagementDashboardsImport)(nil))
}

func (o ManagementDashboardManagementDashboardsImportOutput) ToManagementDashboardManagementDashboardsImportOutput() ManagementDashboardManagementDashboardsImportOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportOutput) ToManagementDashboardManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportOutput) ToManagementDashboardManagementDashboardsImportPtrOutput() ManagementDashboardManagementDashboardsImportPtrOutput {
	return o.ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (o ManagementDashboardManagementDashboardsImportOutput) ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportPtrOutput {
	return o.ApplyT(func(v ManagementDashboardManagementDashboardsImport) *ManagementDashboardManagementDashboardsImport {
		return &v
	}).(ManagementDashboardManagementDashboardsImportPtrOutput)
}

type ManagementDashboardManagementDashboardsImportPtrOutput struct {
	*pulumi.OutputState
}

func (ManagementDashboardManagementDashboardsImportPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagementDashboardManagementDashboardsImport)(nil))
}

func (o ManagementDashboardManagementDashboardsImportPtrOutput) ToManagementDashboardManagementDashboardsImportPtrOutput() ManagementDashboardManagementDashboardsImportPtrOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportPtrOutput) ToManagementDashboardManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportPtrOutput {
	return o
}

type ManagementDashboardManagementDashboardsImportArrayOutput struct{ *pulumi.OutputState }

func (ManagementDashboardManagementDashboardsImportArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ManagementDashboardManagementDashboardsImport)(nil))
}

func (o ManagementDashboardManagementDashboardsImportArrayOutput) ToManagementDashboardManagementDashboardsImportArrayOutput() ManagementDashboardManagementDashboardsImportArrayOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportArrayOutput) ToManagementDashboardManagementDashboardsImportArrayOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportArrayOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportArrayOutput) Index(i pulumi.IntInput) ManagementDashboardManagementDashboardsImportOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ManagementDashboardManagementDashboardsImport {
		return vs[0].([]ManagementDashboardManagementDashboardsImport)[vs[1].(int)]
	}).(ManagementDashboardManagementDashboardsImportOutput)
}

type ManagementDashboardManagementDashboardsImportMapOutput struct{ *pulumi.OutputState }

func (ManagementDashboardManagementDashboardsImportMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]ManagementDashboardManagementDashboardsImport)(nil))
}

func (o ManagementDashboardManagementDashboardsImportMapOutput) ToManagementDashboardManagementDashboardsImportMapOutput() ManagementDashboardManagementDashboardsImportMapOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportMapOutput) ToManagementDashboardManagementDashboardsImportMapOutputWithContext(ctx context.Context) ManagementDashboardManagementDashboardsImportMapOutput {
	return o
}

func (o ManagementDashboardManagementDashboardsImportMapOutput) MapIndex(k pulumi.StringInput) ManagementDashboardManagementDashboardsImportOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) ManagementDashboardManagementDashboardsImport {
		return vs[0].(map[string]ManagementDashboardManagementDashboardsImport)[vs[1].(string)]
	}).(ManagementDashboardManagementDashboardsImportOutput)
}

func init() {
	pulumi.RegisterOutputType(ManagementDashboardManagementDashboardsImportOutput{})
	pulumi.RegisterOutputType(ManagementDashboardManagementDashboardsImportPtrOutput{})
	pulumi.RegisterOutputType(ManagementDashboardManagementDashboardsImportArrayOutput{})
	pulumi.RegisterOutputType(ManagementDashboardManagementDashboardsImportMapOutput{})
}