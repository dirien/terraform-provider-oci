// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package database

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the list of Vm Cluster Update History Entries in Oracle Cloud Infrastructure Database service.
//
// Gets the history of the maintenance update actions performed on the specified VM cluster. Applies to Exadata Cloud@Customer instances only.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/database"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := _var.Vm_cluster_update_history_entry_state
// 		opt1 := _var.Vm_cluster_update_history_entry_update_type
// 		_, err := database.GetVmClusterUpdateHistoryEntries(ctx, &database.GetVmClusterUpdateHistoryEntriesArgs{
// 			VmClusterId: oci_database_vm_cluster.Test_vm_cluster.Id,
// 			State:       &opt0,
// 			UpdateType:  &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetVmClusterUpdateHistoryEntries(ctx *pulumi.Context, args *GetVmClusterUpdateHistoryEntriesArgs, opts ...pulumi.InvokeOption) (*GetVmClusterUpdateHistoryEntriesResult, error) {
	var rv GetVmClusterUpdateHistoryEntriesResult
	err := ctx.Invoke("oci:database/getVmClusterUpdateHistoryEntries:getVmClusterUpdateHistoryEntries", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVmClusterUpdateHistoryEntries.
type GetVmClusterUpdateHistoryEntriesArgs struct {
	Filters []GetVmClusterUpdateHistoryEntriesFilter `pulumi:"filters"`
	// A filter to return only resources that match the given lifecycle state exactly.
	State *string `pulumi:"state"`
	// A filter to return only resources that match the given update type exactly.
	UpdateType *string `pulumi:"updateType"`
	// The VM cluster [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	VmClusterId string `pulumi:"vmClusterId"`
}

// A collection of values returned by getVmClusterUpdateHistoryEntries.
type GetVmClusterUpdateHistoryEntriesResult struct {
	Filters []GetVmClusterUpdateHistoryEntriesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The current lifecycle state of the maintenance update operation.
	State *string `pulumi:"state"`
	// The type of VM cluster maintenance update.
	UpdateType  *string `pulumi:"updateType"`
	VmClusterId string  `pulumi:"vmClusterId"`
	// The list of vm_cluster_update_history_entries.
	VmClusterUpdateHistoryEntries []GetVmClusterUpdateHistoryEntriesVmClusterUpdateHistoryEntry `pulumi:"vmClusterUpdateHistoryEntries"`
}