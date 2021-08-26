// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Api Deployment Specification resource in Oracle Cloud Infrastructure API Gateway service.
//
// Gets an API Deployment specification by identifier.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/apigateway"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := apigateway.GetApiDeploymentSpecification(ctx, &apigateway.GetApiDeploymentSpecificationArgs{
// 			ApiId: oci_apigateway_api.Test_api.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetApiDeploymentSpecification(ctx *pulumi.Context, args *GetApiDeploymentSpecificationArgs, opts ...pulumi.InvokeOption) (*GetApiDeploymentSpecificationResult, error) {
	var rv GetApiDeploymentSpecificationResult
	err := ctx.Invoke("oci:apigateway/getApiDeploymentSpecification:getApiDeploymentSpecification", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getApiDeploymentSpecification.
type GetApiDeploymentSpecificationArgs struct {
	// The ocid of the API.
	ApiId string `pulumi:"apiId"`
}

// A collection of values returned by getApiDeploymentSpecification.
type GetApiDeploymentSpecificationResult struct {
	ApiId string `pulumi:"apiId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Policies controlling the pushing of logs to Oracle Cloud Infrastructure Public Logging.
	LoggingPolicies []GetApiDeploymentSpecificationLoggingPolicy `pulumi:"loggingPolicies"`
	// Behavior applied to any requests received by the API on this route.
	RequestPolicies []GetApiDeploymentSpecificationRequestPolicy `pulumi:"requestPolicies"`
	// A list of routes that this API exposes.
	Routes []GetApiDeploymentSpecificationRoute `pulumi:"routes"`
}