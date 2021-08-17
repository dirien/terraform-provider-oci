// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the list of Load Balancer Routing Policies in Oracle Cloud Infrastructure Load Balancer service.
//
// Lists all routing policies associated with the specified load balancer.
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
// 		_, err := oci.GetLoadBalancerLoadBalancerRoutingPolicies(ctx, &GetLoadBalancerLoadBalancerRoutingPoliciesArgs{
// 			LoadBalancerId: oci_load_balancer_load_balancer.Test_load_balancer.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetLoadBalancerLoadBalancerRoutingPolicies(ctx *pulumi.Context, args *GetLoadBalancerLoadBalancerRoutingPoliciesArgs, opts ...pulumi.InvokeOption) (*GetLoadBalancerLoadBalancerRoutingPoliciesResult, error) {
	var rv GetLoadBalancerLoadBalancerRoutingPoliciesResult
	err := ctx.Invoke("oci:index/getLoadBalancerLoadBalancerRoutingPolicies:GetLoadBalancerLoadBalancerRoutingPolicies", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetLoadBalancerLoadBalancerRoutingPolicies.
type GetLoadBalancerLoadBalancerRoutingPoliciesArgs struct {
	Filters []GetLoadBalancerLoadBalancerRoutingPoliciesFilter `pulumi:"filters"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the load balancer associated with the routing policies.
	LoadBalancerId string `pulumi:"loadBalancerId"`
}

// A collection of values returned by GetLoadBalancerLoadBalancerRoutingPolicies.
type GetLoadBalancerLoadBalancerRoutingPoliciesResult struct {
	Filters []GetLoadBalancerLoadBalancerRoutingPoliciesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id             string `pulumi:"id"`
	LoadBalancerId string `pulumi:"loadBalancerId"`
	// The list of routing_policies.
	RoutingPolicies []GetLoadBalancerLoadBalancerRoutingPoliciesRoutingPolicy `pulumi:"routingPolicies"`
}