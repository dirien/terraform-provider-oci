// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Drg Route Distribution Statement resource in Oracle Cloud Infrastructure Core service.
//
// Adds one route distribution statement to the specified route distribution.
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
// 		_, err := oci.NewCoreDrgRouteDistributionStatement(ctx, "testDrgRouteDistributionStatement", &oci.CoreDrgRouteDistributionStatementArgs{
// 			DrgRouteDistributionId: pulumi.Any(oci_core_drg_route_distribution.Test_drg_route_distribution.Id),
// 			Action:                 pulumi.Any(_var.Drg_route_distribution_statement_statements_action),
// 			MatchCriteria: &CoreDrgRouteDistributionStatementMatchCriteriaArgs{
// 				MatchType:       pulumi.Any(_var.Drg_route_distribution_statement_statements_match_criteria_match_type),
// 				AttachmentType:  pulumi.Any(_var.Drg_route_distribution_statement_statements_match_criteria_attachment_type),
// 				DrgAttachmentId: pulumi.Any(oci_core_drg_attachment.Test_drg_attachment.Id),
// 			},
// 			Priority: pulumi.Any(_var.Drg_route_distribution_statement_statements_priority),
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
// DrgRouteDistributionStatement can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:index/coreDrgRouteDistributionStatement:CoreDrgRouteDistributionStatement test_drg_route_distribution_statement "drgRouteDistributions/{drgRouteDistributionId}/statements/{id}"
// ```
type CoreDrgRouteDistributionStatement struct {
	pulumi.CustomResourceState

	// Accept: import/export the route "as is"
	Action pulumi.StringOutput `pulumi:"action"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.
	DrgRouteDistributionId pulumi.StringOutput `pulumi:"drgRouteDistributionId"`
	// (Updatable) The action is applied only if all of the match criteria is met. If there are no match criteria in a statement, match ALL is implied.
	MatchCriteria CoreDrgRouteDistributionStatementMatchCriteriaOutput `pulumi:"matchCriteria"`
	// (Updatable) This field is used to specify the priority of each statement in a route distribution. The priority will be represented as a number between 0 and 65535 where a lower number indicates a higher priority. When a route is processed, statements are applied in the order defined by their priority. The first matching rule dictates the action that will be taken on the route.
	Priority pulumi.IntOutput `pulumi:"priority"`
}

// NewCoreDrgRouteDistributionStatement registers a new resource with the given unique name, arguments, and options.
func NewCoreDrgRouteDistributionStatement(ctx *pulumi.Context,
	name string, args *CoreDrgRouteDistributionStatementArgs, opts ...pulumi.ResourceOption) (*CoreDrgRouteDistributionStatement, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Action == nil {
		return nil, errors.New("invalid value for required argument 'Action'")
	}
	if args.DrgRouteDistributionId == nil {
		return nil, errors.New("invalid value for required argument 'DrgRouteDistributionId'")
	}
	if args.MatchCriteria == nil {
		return nil, errors.New("invalid value for required argument 'MatchCriteria'")
	}
	if args.Priority == nil {
		return nil, errors.New("invalid value for required argument 'Priority'")
	}
	var resource CoreDrgRouteDistributionStatement
	err := ctx.RegisterResource("oci:index/coreDrgRouteDistributionStatement:CoreDrgRouteDistributionStatement", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCoreDrgRouteDistributionStatement gets an existing CoreDrgRouteDistributionStatement resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCoreDrgRouteDistributionStatement(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CoreDrgRouteDistributionStatementState, opts ...pulumi.ResourceOption) (*CoreDrgRouteDistributionStatement, error) {
	var resource CoreDrgRouteDistributionStatement
	err := ctx.ReadResource("oci:index/coreDrgRouteDistributionStatement:CoreDrgRouteDistributionStatement", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CoreDrgRouteDistributionStatement resources.
type coreDrgRouteDistributionStatementState struct {
	// Accept: import/export the route "as is"
	Action *string `pulumi:"action"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.
	DrgRouteDistributionId *string `pulumi:"drgRouteDistributionId"`
	// (Updatable) The action is applied only if all of the match criteria is met. If there are no match criteria in a statement, match ALL is implied.
	MatchCriteria *CoreDrgRouteDistributionStatementMatchCriteria `pulumi:"matchCriteria"`
	// (Updatable) This field is used to specify the priority of each statement in a route distribution. The priority will be represented as a number between 0 and 65535 where a lower number indicates a higher priority. When a route is processed, statements are applied in the order defined by their priority. The first matching rule dictates the action that will be taken on the route.
	Priority *int `pulumi:"priority"`
}

type CoreDrgRouteDistributionStatementState struct {
	// Accept: import/export the route "as is"
	Action pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.
	DrgRouteDistributionId pulumi.StringPtrInput
	// (Updatable) The action is applied only if all of the match criteria is met. If there are no match criteria in a statement, match ALL is implied.
	MatchCriteria CoreDrgRouteDistributionStatementMatchCriteriaPtrInput
	// (Updatable) This field is used to specify the priority of each statement in a route distribution. The priority will be represented as a number between 0 and 65535 where a lower number indicates a higher priority. When a route is processed, statements are applied in the order defined by their priority. The first matching rule dictates the action that will be taken on the route.
	Priority pulumi.IntPtrInput
}

func (CoreDrgRouteDistributionStatementState) ElementType() reflect.Type {
	return reflect.TypeOf((*coreDrgRouteDistributionStatementState)(nil)).Elem()
}

type coreDrgRouteDistributionStatementArgs struct {
	// Accept: import/export the route "as is"
	Action string `pulumi:"action"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.
	DrgRouteDistributionId string `pulumi:"drgRouteDistributionId"`
	// (Updatable) The action is applied only if all of the match criteria is met. If there are no match criteria in a statement, match ALL is implied.
	MatchCriteria CoreDrgRouteDistributionStatementMatchCriteria `pulumi:"matchCriteria"`
	// (Updatable) This field is used to specify the priority of each statement in a route distribution. The priority will be represented as a number between 0 and 65535 where a lower number indicates a higher priority. When a route is processed, statements are applied in the order defined by their priority. The first matching rule dictates the action that will be taken on the route.
	Priority int `pulumi:"priority"`
}

// The set of arguments for constructing a CoreDrgRouteDistributionStatement resource.
type CoreDrgRouteDistributionStatementArgs struct {
	// Accept: import/export the route "as is"
	Action pulumi.StringInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the route distribution.
	DrgRouteDistributionId pulumi.StringInput
	// (Updatable) The action is applied only if all of the match criteria is met. If there are no match criteria in a statement, match ALL is implied.
	MatchCriteria CoreDrgRouteDistributionStatementMatchCriteriaInput
	// (Updatable) This field is used to specify the priority of each statement in a route distribution. The priority will be represented as a number between 0 and 65535 where a lower number indicates a higher priority. When a route is processed, statements are applied in the order defined by their priority. The first matching rule dictates the action that will be taken on the route.
	Priority pulumi.IntInput
}

func (CoreDrgRouteDistributionStatementArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*coreDrgRouteDistributionStatementArgs)(nil)).Elem()
}

type CoreDrgRouteDistributionStatementInput interface {
	pulumi.Input

	ToCoreDrgRouteDistributionStatementOutput() CoreDrgRouteDistributionStatementOutput
	ToCoreDrgRouteDistributionStatementOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementOutput
}

func (*CoreDrgRouteDistributionStatement) ElementType() reflect.Type {
	return reflect.TypeOf((*CoreDrgRouteDistributionStatement)(nil))
}

func (i *CoreDrgRouteDistributionStatement) ToCoreDrgRouteDistributionStatementOutput() CoreDrgRouteDistributionStatementOutput {
	return i.ToCoreDrgRouteDistributionStatementOutputWithContext(context.Background())
}

func (i *CoreDrgRouteDistributionStatement) ToCoreDrgRouteDistributionStatementOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgRouteDistributionStatementOutput)
}

func (i *CoreDrgRouteDistributionStatement) ToCoreDrgRouteDistributionStatementPtrOutput() CoreDrgRouteDistributionStatementPtrOutput {
	return i.ToCoreDrgRouteDistributionStatementPtrOutputWithContext(context.Background())
}

func (i *CoreDrgRouteDistributionStatement) ToCoreDrgRouteDistributionStatementPtrOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgRouteDistributionStatementPtrOutput)
}

type CoreDrgRouteDistributionStatementPtrInput interface {
	pulumi.Input

	ToCoreDrgRouteDistributionStatementPtrOutput() CoreDrgRouteDistributionStatementPtrOutput
	ToCoreDrgRouteDistributionStatementPtrOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementPtrOutput
}

type coreDrgRouteDistributionStatementPtrType CoreDrgRouteDistributionStatementArgs

func (*coreDrgRouteDistributionStatementPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**CoreDrgRouteDistributionStatement)(nil))
}

func (i *coreDrgRouteDistributionStatementPtrType) ToCoreDrgRouteDistributionStatementPtrOutput() CoreDrgRouteDistributionStatementPtrOutput {
	return i.ToCoreDrgRouteDistributionStatementPtrOutputWithContext(context.Background())
}

func (i *coreDrgRouteDistributionStatementPtrType) ToCoreDrgRouteDistributionStatementPtrOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgRouteDistributionStatementPtrOutput)
}

// CoreDrgRouteDistributionStatementArrayInput is an input type that accepts CoreDrgRouteDistributionStatementArray and CoreDrgRouteDistributionStatementArrayOutput values.
// You can construct a concrete instance of `CoreDrgRouteDistributionStatementArrayInput` via:
//
//          CoreDrgRouteDistributionStatementArray{ CoreDrgRouteDistributionStatementArgs{...} }
type CoreDrgRouteDistributionStatementArrayInput interface {
	pulumi.Input

	ToCoreDrgRouteDistributionStatementArrayOutput() CoreDrgRouteDistributionStatementArrayOutput
	ToCoreDrgRouteDistributionStatementArrayOutputWithContext(context.Context) CoreDrgRouteDistributionStatementArrayOutput
}

type CoreDrgRouteDistributionStatementArray []CoreDrgRouteDistributionStatementInput

func (CoreDrgRouteDistributionStatementArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CoreDrgRouteDistributionStatement)(nil)).Elem()
}

func (i CoreDrgRouteDistributionStatementArray) ToCoreDrgRouteDistributionStatementArrayOutput() CoreDrgRouteDistributionStatementArrayOutput {
	return i.ToCoreDrgRouteDistributionStatementArrayOutputWithContext(context.Background())
}

func (i CoreDrgRouteDistributionStatementArray) ToCoreDrgRouteDistributionStatementArrayOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgRouteDistributionStatementArrayOutput)
}

// CoreDrgRouteDistributionStatementMapInput is an input type that accepts CoreDrgRouteDistributionStatementMap and CoreDrgRouteDistributionStatementMapOutput values.
// You can construct a concrete instance of `CoreDrgRouteDistributionStatementMapInput` via:
//
//          CoreDrgRouteDistributionStatementMap{ "key": CoreDrgRouteDistributionStatementArgs{...} }
type CoreDrgRouteDistributionStatementMapInput interface {
	pulumi.Input

	ToCoreDrgRouteDistributionStatementMapOutput() CoreDrgRouteDistributionStatementMapOutput
	ToCoreDrgRouteDistributionStatementMapOutputWithContext(context.Context) CoreDrgRouteDistributionStatementMapOutput
}

type CoreDrgRouteDistributionStatementMap map[string]CoreDrgRouteDistributionStatementInput

func (CoreDrgRouteDistributionStatementMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CoreDrgRouteDistributionStatement)(nil)).Elem()
}

func (i CoreDrgRouteDistributionStatementMap) ToCoreDrgRouteDistributionStatementMapOutput() CoreDrgRouteDistributionStatementMapOutput {
	return i.ToCoreDrgRouteDistributionStatementMapOutputWithContext(context.Background())
}

func (i CoreDrgRouteDistributionStatementMap) ToCoreDrgRouteDistributionStatementMapOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CoreDrgRouteDistributionStatementMapOutput)
}

type CoreDrgRouteDistributionStatementOutput struct {
	*pulumi.OutputState
}

func (CoreDrgRouteDistributionStatementOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CoreDrgRouteDistributionStatement)(nil))
}

func (o CoreDrgRouteDistributionStatementOutput) ToCoreDrgRouteDistributionStatementOutput() CoreDrgRouteDistributionStatementOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementOutput) ToCoreDrgRouteDistributionStatementOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementOutput) ToCoreDrgRouteDistributionStatementPtrOutput() CoreDrgRouteDistributionStatementPtrOutput {
	return o.ToCoreDrgRouteDistributionStatementPtrOutputWithContext(context.Background())
}

func (o CoreDrgRouteDistributionStatementOutput) ToCoreDrgRouteDistributionStatementPtrOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementPtrOutput {
	return o.ApplyT(func(v CoreDrgRouteDistributionStatement) *CoreDrgRouteDistributionStatement {
		return &v
	}).(CoreDrgRouteDistributionStatementPtrOutput)
}

type CoreDrgRouteDistributionStatementPtrOutput struct {
	*pulumi.OutputState
}

func (CoreDrgRouteDistributionStatementPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CoreDrgRouteDistributionStatement)(nil))
}

func (o CoreDrgRouteDistributionStatementPtrOutput) ToCoreDrgRouteDistributionStatementPtrOutput() CoreDrgRouteDistributionStatementPtrOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementPtrOutput) ToCoreDrgRouteDistributionStatementPtrOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementPtrOutput {
	return o
}

type CoreDrgRouteDistributionStatementArrayOutput struct{ *pulumi.OutputState }

func (CoreDrgRouteDistributionStatementArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]CoreDrgRouteDistributionStatement)(nil))
}

func (o CoreDrgRouteDistributionStatementArrayOutput) ToCoreDrgRouteDistributionStatementArrayOutput() CoreDrgRouteDistributionStatementArrayOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementArrayOutput) ToCoreDrgRouteDistributionStatementArrayOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementArrayOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementArrayOutput) Index(i pulumi.IntInput) CoreDrgRouteDistributionStatementOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) CoreDrgRouteDistributionStatement {
		return vs[0].([]CoreDrgRouteDistributionStatement)[vs[1].(int)]
	}).(CoreDrgRouteDistributionStatementOutput)
}

type CoreDrgRouteDistributionStatementMapOutput struct{ *pulumi.OutputState }

func (CoreDrgRouteDistributionStatementMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]CoreDrgRouteDistributionStatement)(nil))
}

func (o CoreDrgRouteDistributionStatementMapOutput) ToCoreDrgRouteDistributionStatementMapOutput() CoreDrgRouteDistributionStatementMapOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementMapOutput) ToCoreDrgRouteDistributionStatementMapOutputWithContext(ctx context.Context) CoreDrgRouteDistributionStatementMapOutput {
	return o
}

func (o CoreDrgRouteDistributionStatementMapOutput) MapIndex(k pulumi.StringInput) CoreDrgRouteDistributionStatementOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) CoreDrgRouteDistributionStatement {
		return vs[0].(map[string]CoreDrgRouteDistributionStatement)[vs[1].(string)]
	}).(CoreDrgRouteDistributionStatementOutput)
}

func init() {
	pulumi.RegisterOutputType(CoreDrgRouteDistributionStatementOutput{})
	pulumi.RegisterOutputType(CoreDrgRouteDistributionStatementPtrOutput{})
	pulumi.RegisterOutputType(CoreDrgRouteDistributionStatementArrayOutput{})
	pulumi.RegisterOutputType(CoreDrgRouteDistributionStatementMapOutput{})
}