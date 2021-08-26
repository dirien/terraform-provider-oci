// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package computeinstanceagent

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the list of Instance Agent Plugins in Oracle Cloud Infrastructure Compute Instance Agent service.
//
// The API to get one or more plugin information.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/computeinstanceagent"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := _var.Instance_agent_plugin_name
// 		opt1 := _var.Instance_agent_plugin_status
// 		_, err := computeinstanceagent.GetInstanceAgentPlugins(ctx, &computeinstanceagent.GetInstanceAgentPluginsArgs{
// 			InstanceagentId: oci_computeinstanceagent_instanceagent.Test_instanceagent.Id,
// 			Name:            &opt0,
// 			Status:          &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetInstanceAgentPlugins(ctx *pulumi.Context, args *GetInstanceAgentPluginsArgs, opts ...pulumi.InvokeOption) (*GetInstanceAgentPluginsResult, error) {
	var rv GetInstanceAgentPluginsResult
	err := ctx.Invoke("oci:computeinstanceagent/getInstanceAgentPlugins:getInstanceAgentPlugins", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstanceAgentPlugins.
type GetInstanceAgentPluginsArgs struct {
	CompartmentId string                          `pulumi:"compartmentId"`
	Filters       []GetInstanceAgentPluginsFilter `pulumi:"filters"`
	// The OCID of the instance.
	InstanceagentId string `pulumi:"instanceagentId"`
	// The plugin name
	Name *string `pulumi:"name"`
	// The plugin status
	Status *string `pulumi:"status"`
}

// A collection of values returned by getInstanceAgentPlugins.
type GetInstanceAgentPluginsResult struct {
	CompartmentId string                          `pulumi:"compartmentId"`
	Filters       []GetInstanceAgentPluginsFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The list of instance_agent_plugins.
	InstanceAgentPlugins []GetInstanceAgentPluginsInstanceAgentPlugin `pulumi:"instanceAgentPlugins"`
	InstanceagentId      string                                       `pulumi:"instanceagentId"`
	// The plugin name
	Name *string `pulumi:"name"`
	// The plugin status Specified the plugin state on the instance * `RUNNING` - The plugin is in running state * `STOPPED` - The plugin is in stopped state * `NOT_SUPPORTED` - The plugin is not supported on this platform * `INVALID` - The plugin state is not recognizable by the service
	Status *string `pulumi:"status"`
}