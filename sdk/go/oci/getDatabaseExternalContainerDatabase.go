// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific External Container Database resource in Oracle Cloud Infrastructure Database service.
//
// Gets information about the specified external container database.
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
// 		_, err := oci.GetDatabaseExternalContainerDatabase(ctx, &GetDatabaseExternalContainerDatabaseArgs{
// 			ExternalContainerDatabaseId: oci_database_external_container_database.Test_external_container_database.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupDatabaseExternalContainerDatabase(ctx *pulumi.Context, args *LookupDatabaseExternalContainerDatabaseArgs, opts ...pulumi.InvokeOption) (*LookupDatabaseExternalContainerDatabaseResult, error) {
	var rv LookupDatabaseExternalContainerDatabaseResult
	err := ctx.Invoke("oci:index/getDatabaseExternalContainerDatabase:GetDatabaseExternalContainerDatabase", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetDatabaseExternalContainerDatabase.
type LookupDatabaseExternalContainerDatabaseArgs struct {
	// The ExternalContainerDatabase [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	ExternalContainerDatabaseId string `pulumi:"externalContainerDatabaseId"`
}

// A collection of values returned by GetDatabaseExternalContainerDatabase.
type LookupDatabaseExternalContainerDatabaseResult struct {
	// The character set of the external database.
	CharacterSet string `pulumi:"characterSet"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId string `pulumi:"compartmentId"`
	// The Oracle Database configuration
	DatabaseConfiguration string `pulumi:"databaseConfiguration"`
	// The Oracle Database edition.
	DatabaseEdition string `pulumi:"databaseEdition"`
	// The configuration of the Database Management service.
	DatabaseManagementConfig GetDatabaseExternalContainerDatabaseDatabaseManagementConfig `pulumi:"databaseManagementConfig"`
	// The Oracle Database version.
	DatabaseVersion string `pulumi:"databaseVersion"`
	// The Oracle Database ID, which identifies an Oracle Database located outside of Oracle Cloud.
	DbId string `pulumi:"dbId"`
	// The database packs licensed for the external Oracle Database.
	DbPacks string `pulumi:"dbPacks"`
	// The `DB_UNIQUE_NAME` of the external database.
	DbUniqueName string `pulumi:"dbUniqueName"`
	// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// The user-friendly name for the external database. The name does not have to be unique.
	DisplayName                 string `pulumi:"displayName"`
	ExternalContainerDatabaseId string `pulumi:"externalContainerDatabaseId"`
	// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure external database resource.
	Id string `pulumi:"id"`
	// Additional information about the current lifecycle state.
	LifecycleDetails string `pulumi:"lifecycleDetails"`
	// The national character of the external database.
	NcharacterSet string `pulumi:"ncharacterSet"`
	// The current state of the Oracle Cloud Infrastructure external database resource.
	State string `pulumi:"state"`
	// The date and time the database was created.
	TimeCreated string `pulumi:"timeCreated"`
	// The time zone of the external database. It is a time zone offset (a character type in the format '[+|-]TZH:TZM') or a time zone region name, depending on how the time zone value was specified when the database was created / last altered.
	TimeZone string `pulumi:"timeZone"`
}