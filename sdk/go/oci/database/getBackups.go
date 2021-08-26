// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package database

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the list of Backups in Oracle Cloud Infrastructure Database service.
//
// Gets a list of backups based on the `databaseId` or `compartmentId` specified. Either one of these query parameters must be provided.
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
// 		opt0 := _var.Compartment_id
// 		opt1 := oci_database_database.Test_database.Id
// 		_, err := database.GetBackups(ctx, &database.GetBackupsArgs{
// 			CompartmentId: &opt0,
// 			DatabaseId:    &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetBackups(ctx *pulumi.Context, args *GetBackupsArgs, opts ...pulumi.InvokeOption) (*GetBackupsResult, error) {
	var rv GetBackupsResult
	err := ctx.Invoke("oci:database/getBackups:getBackups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackups.
type GetBackupsArgs struct {
	// The compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	CompartmentId *string `pulumi:"compartmentId"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId *string            `pulumi:"databaseId"`
	Filters    []GetBackupsFilter `pulumi:"filters"`
}

// A collection of values returned by getBackups.
type GetBackupsResult struct {
	// The list of backups.
	Backups []GetBackupsBackup `pulumi:"backups"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId *string `pulumi:"compartmentId"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId *string            `pulumi:"databaseId"`
	Filters    []GetBackupsFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}