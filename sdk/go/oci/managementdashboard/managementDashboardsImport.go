// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package managementdashboard

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
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/managementdashboard"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := managementdashboard.NewManagementDashboardsImport(ctx, "testManagementDashboardsImport", &managementdashboard.ManagementDashboardsImportArgs{
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
//  $ pulumi import oci:managementdashboard/managementDashboardsImport:ManagementDashboardsImport test_management_dashboards_import "id"
// ```
type ManagementDashboardsImport struct {
	pulumi.CustomResourceState

	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrOutput `pulumi:"importDetails"`
	ImportDetailsFile pulumi.StringPtrOutput `pulumi:"importDetailsFile"`
}

// NewManagementDashboardsImport registers a new resource with the given unique name, arguments, and options.
func NewManagementDashboardsImport(ctx *pulumi.Context,
	name string, args *ManagementDashboardsImportArgs, opts ...pulumi.ResourceOption) (*ManagementDashboardsImport, error) {
	if args == nil {
		args = &ManagementDashboardsImportArgs{}
	}

	var resource ManagementDashboardsImport
	err := ctx.RegisterResource("oci:managementdashboard/managementDashboardsImport:ManagementDashboardsImport", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagementDashboardsImport gets an existing ManagementDashboardsImport resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagementDashboardsImport(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagementDashboardsImportState, opts ...pulumi.ResourceOption) (*ManagementDashboardsImport, error) {
	var resource ManagementDashboardsImport
	err := ctx.ReadResource("oci:managementdashboard/managementDashboardsImport:ManagementDashboardsImport", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagementDashboardsImport resources.
type managementDashboardsImportState struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     *string `pulumi:"importDetails"`
	ImportDetailsFile *string `pulumi:"importDetailsFile"`
}

type ManagementDashboardsImportState struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrInput
	ImportDetailsFile pulumi.StringPtrInput
}

func (ManagementDashboardsImportState) ElementType() reflect.Type {
	return reflect.TypeOf((*managementDashboardsImportState)(nil)).Elem()
}

type managementDashboardsImportArgs struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     *string `pulumi:"importDetails"`
	ImportDetailsFile *string `pulumi:"importDetailsFile"`
}

// The set of arguments for constructing a ManagementDashboardsImport resource.
type ManagementDashboardsImportArgs struct {
	// Array of Dashboards to import. The `importDetails` is mandatory if `importDetailsPath` is not passed. Value should be stringified JSON of [ManagementDashboardImportDetails](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/managementdashboard/20200901/ManagementDashboardImportDetails/)
	ImportDetails     pulumi.StringPtrInput
	ImportDetailsFile pulumi.StringPtrInput
}

func (ManagementDashboardsImportArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managementDashboardsImportArgs)(nil)).Elem()
}

type ManagementDashboardsImportInput interface {
	pulumi.Input

	ToManagementDashboardsImportOutput() ManagementDashboardsImportOutput
	ToManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardsImportOutput
}

func (*ManagementDashboardsImport) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagementDashboardsImport)(nil))
}

func (i *ManagementDashboardsImport) ToManagementDashboardsImportOutput() ManagementDashboardsImportOutput {
	return i.ToManagementDashboardsImportOutputWithContext(context.Background())
}

func (i *ManagementDashboardsImport) ToManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardsImportOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardsImportOutput)
}

func (i *ManagementDashboardsImport) ToManagementDashboardsImportPtrOutput() ManagementDashboardsImportPtrOutput {
	return i.ToManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (i *ManagementDashboardsImport) ToManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardsImportPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardsImportPtrOutput)
}

type ManagementDashboardsImportPtrInput interface {
	pulumi.Input

	ToManagementDashboardsImportPtrOutput() ManagementDashboardsImportPtrOutput
	ToManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardsImportPtrOutput
}

type managementDashboardsImportPtrType ManagementDashboardsImportArgs

func (*managementDashboardsImportPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagementDashboardsImport)(nil))
}

func (i *managementDashboardsImportPtrType) ToManagementDashboardsImportPtrOutput() ManagementDashboardsImportPtrOutput {
	return i.ToManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (i *managementDashboardsImportPtrType) ToManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardsImportPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardsImportPtrOutput)
}

// ManagementDashboardsImportArrayInput is an input type that accepts ManagementDashboardsImportArray and ManagementDashboardsImportArrayOutput values.
// You can construct a concrete instance of `ManagementDashboardsImportArrayInput` via:
//
//          ManagementDashboardsImportArray{ ManagementDashboardsImportArgs{...} }
type ManagementDashboardsImportArrayInput interface {
	pulumi.Input

	ToManagementDashboardsImportArrayOutput() ManagementDashboardsImportArrayOutput
	ToManagementDashboardsImportArrayOutputWithContext(context.Context) ManagementDashboardsImportArrayOutput
}

type ManagementDashboardsImportArray []ManagementDashboardsImportInput

func (ManagementDashboardsImportArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ManagementDashboardsImport)(nil)).Elem()
}

func (i ManagementDashboardsImportArray) ToManagementDashboardsImportArrayOutput() ManagementDashboardsImportArrayOutput {
	return i.ToManagementDashboardsImportArrayOutputWithContext(context.Background())
}

func (i ManagementDashboardsImportArray) ToManagementDashboardsImportArrayOutputWithContext(ctx context.Context) ManagementDashboardsImportArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardsImportArrayOutput)
}

// ManagementDashboardsImportMapInput is an input type that accepts ManagementDashboardsImportMap and ManagementDashboardsImportMapOutput values.
// You can construct a concrete instance of `ManagementDashboardsImportMapInput` via:
//
//          ManagementDashboardsImportMap{ "key": ManagementDashboardsImportArgs{...} }
type ManagementDashboardsImportMapInput interface {
	pulumi.Input

	ToManagementDashboardsImportMapOutput() ManagementDashboardsImportMapOutput
	ToManagementDashboardsImportMapOutputWithContext(context.Context) ManagementDashboardsImportMapOutput
}

type ManagementDashboardsImportMap map[string]ManagementDashboardsImportInput

func (ManagementDashboardsImportMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ManagementDashboardsImport)(nil)).Elem()
}

func (i ManagementDashboardsImportMap) ToManagementDashboardsImportMapOutput() ManagementDashboardsImportMapOutput {
	return i.ToManagementDashboardsImportMapOutputWithContext(context.Background())
}

func (i ManagementDashboardsImportMap) ToManagementDashboardsImportMapOutputWithContext(ctx context.Context) ManagementDashboardsImportMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagementDashboardsImportMapOutput)
}

type ManagementDashboardsImportOutput struct {
	*pulumi.OutputState
}

func (ManagementDashboardsImportOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagementDashboardsImport)(nil))
}

func (o ManagementDashboardsImportOutput) ToManagementDashboardsImportOutput() ManagementDashboardsImportOutput {
	return o
}

func (o ManagementDashboardsImportOutput) ToManagementDashboardsImportOutputWithContext(ctx context.Context) ManagementDashboardsImportOutput {
	return o
}

func (o ManagementDashboardsImportOutput) ToManagementDashboardsImportPtrOutput() ManagementDashboardsImportPtrOutput {
	return o.ToManagementDashboardsImportPtrOutputWithContext(context.Background())
}

func (o ManagementDashboardsImportOutput) ToManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardsImportPtrOutput {
	return o.ApplyT(func(v ManagementDashboardsImport) *ManagementDashboardsImport {
		return &v
	}).(ManagementDashboardsImportPtrOutput)
}

type ManagementDashboardsImportPtrOutput struct {
	*pulumi.OutputState
}

func (ManagementDashboardsImportPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ManagementDashboardsImport)(nil))
}

func (o ManagementDashboardsImportPtrOutput) ToManagementDashboardsImportPtrOutput() ManagementDashboardsImportPtrOutput {
	return o
}

func (o ManagementDashboardsImportPtrOutput) ToManagementDashboardsImportPtrOutputWithContext(ctx context.Context) ManagementDashboardsImportPtrOutput {
	return o
}

type ManagementDashboardsImportArrayOutput struct{ *pulumi.OutputState }

func (ManagementDashboardsImportArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ManagementDashboardsImport)(nil))
}

func (o ManagementDashboardsImportArrayOutput) ToManagementDashboardsImportArrayOutput() ManagementDashboardsImportArrayOutput {
	return o
}

func (o ManagementDashboardsImportArrayOutput) ToManagementDashboardsImportArrayOutputWithContext(ctx context.Context) ManagementDashboardsImportArrayOutput {
	return o
}

func (o ManagementDashboardsImportArrayOutput) Index(i pulumi.IntInput) ManagementDashboardsImportOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ManagementDashboardsImport {
		return vs[0].([]ManagementDashboardsImport)[vs[1].(int)]
	}).(ManagementDashboardsImportOutput)
}

type ManagementDashboardsImportMapOutput struct{ *pulumi.OutputState }

func (ManagementDashboardsImportMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]ManagementDashboardsImport)(nil))
}

func (o ManagementDashboardsImportMapOutput) ToManagementDashboardsImportMapOutput() ManagementDashboardsImportMapOutput {
	return o
}

func (o ManagementDashboardsImportMapOutput) ToManagementDashboardsImportMapOutputWithContext(ctx context.Context) ManagementDashboardsImportMapOutput {
	return o
}

func (o ManagementDashboardsImportMapOutput) MapIndex(k pulumi.StringInput) ManagementDashboardsImportOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) ManagementDashboardsImport {
		return vs[0].(map[string]ManagementDashboardsImport)[vs[1].(string)]
	}).(ManagementDashboardsImportOutput)
}

func init() {
	pulumi.RegisterOutputType(ManagementDashboardsImportOutput{})
	pulumi.RegisterOutputType(ManagementDashboardsImportPtrOutput{})
	pulumi.RegisterOutputType(ManagementDashboardsImportArrayOutput{})
	pulumi.RegisterOutputType(ManagementDashboardsImportMapOutput{})
}