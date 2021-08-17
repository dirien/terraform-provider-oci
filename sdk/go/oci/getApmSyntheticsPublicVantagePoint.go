// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Public Vantage Point resource in Oracle Cloud Infrastructure Apm Synthetics service.
//
// Returns a list of public vantage points.
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
// 		opt0 := _var.Public_vantage_point_display_name
// 		opt1 := _var.Public_vantage_point_name
// 		_, err := oci.GetApmSyntheticsPublicVantagePoint(ctx, &GetApmSyntheticsPublicVantagePointArgs{
// 			ApmDomainId: oci_apm_synthetics_apm_domain.Test_apm_domain.Id,
// 			DisplayName: &opt0,
// 			Name:        &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetApmSyntheticsPublicVantagePoint(ctx *pulumi.Context, args *GetApmSyntheticsPublicVantagePointArgs, opts ...pulumi.InvokeOption) (*GetApmSyntheticsPublicVantagePointResult, error) {
	var rv GetApmSyntheticsPublicVantagePointResult
	err := ctx.Invoke("oci:index/getApmSyntheticsPublicVantagePoint:GetApmSyntheticsPublicVantagePoint", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetApmSyntheticsPublicVantagePoint.
type GetApmSyntheticsPublicVantagePointArgs struct {
	// The APM domain ID the request is intended for.
	ApmDomainId string `pulumi:"apmDomainId"`
	// A filter to return only resources that match the entire display name given.
	DisplayName *string `pulumi:"displayName"`
	// A filter to return only resources that match the entire name given.
	Name *string `pulumi:"name"`
}

// A collection of values returned by GetApmSyntheticsPublicVantagePoint.
type GetApmSyntheticsPublicVantagePointResult struct {
	ApmDomainId string `pulumi:"apmDomainId"`
	// Unique name that can be edited. The name should not contain any confidential information.
	DisplayName *string `pulumi:"displayName"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// List of PublicVantagePointSummary items.
	Items []GetApmSyntheticsPublicVantagePointItem `pulumi:"items"`
	// Unique permanent name of the vantage point.
	Name *string `pulumi:"name"`
}