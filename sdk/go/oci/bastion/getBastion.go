// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package bastion

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Bastion resource in Oracle Cloud Infrastructure Bastion service.
//
// Retrieves a bastion identified by the bastion ID. A bastion provides secured, public access to target resources in the cloud that you cannot otherwise reach from the internet.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/bastion"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := bastion.LookupBastion(ctx, &bastion.LookupBastionArgs{
// 			BastionId: oci_bastion_bastion.Test_bastion.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupBastion(ctx *pulumi.Context, args *LookupBastionArgs, opts ...pulumi.InvokeOption) (*LookupBastionResult, error) {
	var rv LookupBastionResult
	err := ctx.Invoke("oci:bastion/getBastion:getBastion", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBastion.
type LookupBastionArgs struct {
	// The unique identifier (OCID) of the bastion.
	BastionId string `pulumi:"bastionId"`
}

// A collection of values returned by getBastion.
type LookupBastionResult struct {
	BastionId string `pulumi:"bastionId"`
	// The type of bastion.
	BastionType string `pulumi:"bastionType"`
	// A list of address ranges in CIDR notation that you want to allow to connect to sessions hosted by this bastion.
	ClientCidrBlockAllowLists []string `pulumi:"clientCidrBlockAllowLists"`
	// The unique identifier (OCID) of the compartment where the bastion is located.
	CompartmentId string `pulumi:"compartmentId"`
	// Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// The unique identifier (OCID) of the bastion, which can't be changed after creation.
	Id string `pulumi:"id"`
	// A message describing the current state in more detail.
	LifecycleDetails string `pulumi:"lifecycleDetails"`
	// The maximum amount of time that any session on the bastion can remain active.
	MaxSessionTtlInSeconds int `pulumi:"maxSessionTtlInSeconds"`
	// The maximum number of active sessions allowed on the bastion.
	MaxSessionsAllowed int `pulumi:"maxSessionsAllowed"`
	// The name of the bastion, which can't be changed after creation.
	Name string `pulumi:"name"`
	// The phonebook entry of the customer's team, which can't be changed after creation. Not applicable to `standard` bastions.
	PhoneBookEntry string `pulumi:"phoneBookEntry"`
	// The private IP address of the created private endpoint.
	PrivateEndpointIpAddress string `pulumi:"privateEndpointIpAddress"`
	// The current state of the bastion.
	State string `pulumi:"state"`
	// A list of IP addresses of the hosts that the bastion has access to. Not applicable to `standard` bastions.
	StaticJumpHostIpAddresses []string `pulumi:"staticJumpHostIpAddresses"`
	// Usage of system tag keys. These predefined keys are scoped to namespaces. Example: `{"orcl-cloud.free-tier-retained": "true"}`
	SystemTags map[string]interface{} `pulumi:"systemTags"`
	// The unique identifier (OCID) of the subnet that the bastion connects to.
	TargetSubnetId string `pulumi:"targetSubnetId"`
	// The unique identifier (OCID) of the virtual cloud network (VCN) that the bastion connects to.
	TargetVcnId string `pulumi:"targetVcnId"`
	// The time the bastion was created. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339). Example: `2020-01-25T21:10:29.600Z`
	TimeCreated string `pulumi:"timeCreated"`
	// The time the bastion was updated. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339). Example: `2020-01-25T21:10:29.600Z`
	TimeUpdated string `pulumi:"timeUpdated"`
}