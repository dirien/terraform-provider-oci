// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Target resource in Oracle Cloud Infrastructure Cloud Guard service.
//
// Returns a Target identified by targetId
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
// 		_, err := oci.GetCloudGuardTarget(ctx, &GetCloudGuardTargetArgs{
// 			TargetId: oci_cloud_guard_target.Test_target.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupCloudGuardTarget(ctx *pulumi.Context, args *LookupCloudGuardTargetArgs, opts ...pulumi.InvokeOption) (*LookupCloudGuardTargetResult, error) {
	var rv LookupCloudGuardTargetResult
	err := ctx.Invoke("oci:index/getCloudGuardTarget:GetCloudGuardTarget", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetCloudGuardTarget.
type LookupCloudGuardTargetArgs struct {
	// OCID of target
	TargetId string `pulumi:"targetId"`
}

// A collection of values returned by GetCloudGuardTarget.
type LookupCloudGuardTargetResult struct {
	// Compartment Identifier
	CompartmentId string `pulumi:"compartmentId"`
	// Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// ResponderRule Description
	Description string `pulumi:"description"`
	// ResponderRule Display Name
	DisplayName string `pulumi:"displayName"`
	// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// Unique identifier of TargetResponderRecipe that is immutable on creation
	Id string `pulumi:"id"`
	// List of inherited compartments
	InheritedByCompartments []string `pulumi:"inheritedByCompartments"`
	// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
	LifecyleDetails string `pulumi:"lifecyleDetails"`
	// Total number of recipes attached to target
	RecipeCount int `pulumi:"recipeCount"`
	// The current state of the ResponderRule.
	State string `pulumi:"state"`
	// System tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). System tags can be viewed by users, but can only be created by the system.  Example: `{"orcl-cloud.free-tier-retained": "true"}`
	SystemTags map[string]interface{} `pulumi:"systemTags"`
	// List of detector recipes associated with target
	TargetDetectorRecipes []GetCloudGuardTargetTargetDetectorRecipe `pulumi:"targetDetectorRecipes"`
	TargetId              string                                    `pulumi:"targetId"`
	// Resource ID which the target uses to monitor
	TargetResourceId string `pulumi:"targetResourceId"`
	// possible type of targets
	TargetResourceType string `pulumi:"targetResourceType"`
	// List of responder recipes associated with target
	TargetResponderRecipes []GetCloudGuardTargetTargetResponderRecipe `pulumi:"targetResponderRecipes"`
	// The date and time the target was created. Format defined by RFC3339.
	TimeCreated string `pulumi:"timeCreated"`
	// The date and time the target was updated. Format defined by RFC3339.
	TimeUpdated string `pulumi:"timeUpdated"`
}