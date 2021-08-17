// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Compute Global Image Capability Schema resource in Oracle Cloud Infrastructure Core service.
//
// Gets the specified Compute Global Image Capability Schema
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
// 		_, err := oci.GetCoreComputeGlobalImageCapabilitySchema(ctx, &GetCoreComputeGlobalImageCapabilitySchemaArgs{
// 			ComputeGlobalImageCapabilitySchemaId: oci_core_compute_global_image_capability_schema.Test_compute_global_image_capability_schema.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetCoreComputeGlobalImageCapabilitySchema(ctx *pulumi.Context, args *GetCoreComputeGlobalImageCapabilitySchemaArgs, opts ...pulumi.InvokeOption) (*GetCoreComputeGlobalImageCapabilitySchemaResult, error) {
	var rv GetCoreComputeGlobalImageCapabilitySchemaResult
	err := ctx.Invoke("oci:index/getCoreComputeGlobalImageCapabilitySchema:GetCoreComputeGlobalImageCapabilitySchema", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetCoreComputeGlobalImageCapabilitySchema.
type GetCoreComputeGlobalImageCapabilitySchemaArgs struct {
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compute global image capability schema
	ComputeGlobalImageCapabilitySchemaId string `pulumi:"computeGlobalImageCapabilitySchemaId"`
}

// A collection of values returned by GetCoreComputeGlobalImageCapabilitySchema.
type GetCoreComputeGlobalImageCapabilitySchemaResult struct {
	// The OCID of the compartment containing the compute global image capability schema
	CompartmentId                        string `pulumi:"compartmentId"`
	ComputeGlobalImageCapabilitySchemaId string `pulumi:"computeGlobalImageCapabilitySchemaId"`
	// The name of the global capabilities version resource that is considered the current version.
	CurrentVersionName string `pulumi:"currentVersionName"`
	// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Operations.CostCenter": "42"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// A user-friendly name for the compute global image capability schema.
	DisplayName string `pulumi:"displayName"`
	// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The date and time the compute global image capability schema was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
	TimeCreated string `pulumi:"timeCreated"`
}