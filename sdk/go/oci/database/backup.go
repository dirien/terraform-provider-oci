// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package database

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Backup resource in Oracle Cloud Infrastructure Database service.
//
// Creates a new backup in the specified database based on the request parameters you provide. If you previously used RMAN or dbcli to configure backups and then you switch to using the Console or the API for backups, a new backup configuration is created and associated with your database. This means that you can no longer rely on your previously configured unmanaged backups to work.
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
// 		_, err := database.NewBackup(ctx, "testBackup", &database.BackupArgs{
// 			DatabaseId:  pulumi.Any(oci_database_database.Test_database.Id),
// 			DisplayName: pulumi.Any(_var.Backup_display_name),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// Backups can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:database/backup:Backup test_backup "id"
// ```
type Backup struct {
	pulumi.CustomResourceState

	// The name of the availability domain where the database backup is stored.
	AvailabilityDomain pulumi.StringOutput `pulumi:"availabilityDomain"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId pulumi.StringOutput `pulumi:"compartmentId"`
	// The Oracle Database edition of the DB system from which the database backup was taken.
	DatabaseEdition pulumi.StringOutput `pulumi:"databaseEdition"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId pulumi.StringOutput `pulumi:"databaseId"`
	// The size of the database in gigabytes at the time the backup was taken.
	DatabaseSizeInGbs pulumi.Float64Output `pulumi:"databaseSizeInGbs"`
	// The user-friendly name for the backup. The name does not have to be unique.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
	KmsKeyId pulumi.StringOutput `pulumi:"kmsKeyId"`
	// Additional information about the current lifecycle state.
	LifecycleDetails pulumi.StringOutput `pulumi:"lifecycleDetails"`
	// Shape of the backup's source database.
	Shape pulumi.StringOutput `pulumi:"shape"`
	// The current state of the backup.
	State pulumi.StringOutput `pulumi:"state"`
	// The date and time the backup was completed.
	TimeEnded pulumi.StringOutput `pulumi:"timeEnded"`
	// The date and time the backup started.
	TimeStarted pulumi.StringOutput `pulumi:"timeStarted"`
	// The type of backup.
	Type pulumi.StringOutput `pulumi:"type"`
	// Version of the backup's source database
	Version pulumi.StringOutput `pulumi:"version"`
}

// NewBackup registers a new resource with the given unique name, arguments, and options.
func NewBackup(ctx *pulumi.Context,
	name string, args *BackupArgs, opts ...pulumi.ResourceOption) (*Backup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DatabaseId == nil {
		return nil, errors.New("invalid value for required argument 'DatabaseId'")
	}
	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	var resource Backup
	err := ctx.RegisterResource("oci:database/backup:Backup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBackup gets an existing Backup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBackup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BackupState, opts ...pulumi.ResourceOption) (*Backup, error) {
	var resource Backup
	err := ctx.ReadResource("oci:database/backup:Backup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Backup resources.
type backupState struct {
	// The name of the availability domain where the database backup is stored.
	AvailabilityDomain *string `pulumi:"availabilityDomain"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId *string `pulumi:"compartmentId"`
	// The Oracle Database edition of the DB system from which the database backup was taken.
	DatabaseEdition *string `pulumi:"databaseEdition"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId *string `pulumi:"databaseId"`
	// The size of the database in gigabytes at the time the backup was taken.
	DatabaseSizeInGbs *float64 `pulumi:"databaseSizeInGbs"`
	// The user-friendly name for the backup. The name does not have to be unique.
	DisplayName *string `pulumi:"displayName"`
	// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
	KmsKeyId *string `pulumi:"kmsKeyId"`
	// Additional information about the current lifecycle state.
	LifecycleDetails *string `pulumi:"lifecycleDetails"`
	// Shape of the backup's source database.
	Shape *string `pulumi:"shape"`
	// The current state of the backup.
	State *string `pulumi:"state"`
	// The date and time the backup was completed.
	TimeEnded *string `pulumi:"timeEnded"`
	// The date and time the backup started.
	TimeStarted *string `pulumi:"timeStarted"`
	// The type of backup.
	Type *string `pulumi:"type"`
	// Version of the backup's source database
	Version *string `pulumi:"version"`
}

type BackupState struct {
	// The name of the availability domain where the database backup is stored.
	AvailabilityDomain pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId pulumi.StringPtrInput
	// The Oracle Database edition of the DB system from which the database backup was taken.
	DatabaseEdition pulumi.StringPtrInput
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId pulumi.StringPtrInput
	// The size of the database in gigabytes at the time the backup was taken.
	DatabaseSizeInGbs pulumi.Float64PtrInput
	// The user-friendly name for the backup. The name does not have to be unique.
	DisplayName pulumi.StringPtrInput
	// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
	KmsKeyId pulumi.StringPtrInput
	// Additional information about the current lifecycle state.
	LifecycleDetails pulumi.StringPtrInput
	// Shape of the backup's source database.
	Shape pulumi.StringPtrInput
	// The current state of the backup.
	State pulumi.StringPtrInput
	// The date and time the backup was completed.
	TimeEnded pulumi.StringPtrInput
	// The date and time the backup started.
	TimeStarted pulumi.StringPtrInput
	// The type of backup.
	Type pulumi.StringPtrInput
	// Version of the backup's source database
	Version pulumi.StringPtrInput
}

func (BackupState) ElementType() reflect.Type {
	return reflect.TypeOf((*backupState)(nil)).Elem()
}

type backupArgs struct {
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId string `pulumi:"databaseId"`
	// The user-friendly name for the backup. The name does not have to be unique.
	DisplayName string `pulumi:"displayName"`
}

// The set of arguments for constructing a Backup resource.
type BackupArgs struct {
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database.
	DatabaseId pulumi.StringInput
	// The user-friendly name for the backup. The name does not have to be unique.
	DisplayName pulumi.StringInput
}

func (BackupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*backupArgs)(nil)).Elem()
}

type BackupInput interface {
	pulumi.Input

	ToBackupOutput() BackupOutput
	ToBackupOutputWithContext(ctx context.Context) BackupOutput
}

func (*Backup) ElementType() reflect.Type {
	return reflect.TypeOf((*Backup)(nil))
}

func (i *Backup) ToBackupOutput() BackupOutput {
	return i.ToBackupOutputWithContext(context.Background())
}

func (i *Backup) ToBackupOutputWithContext(ctx context.Context) BackupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupOutput)
}

func (i *Backup) ToBackupPtrOutput() BackupPtrOutput {
	return i.ToBackupPtrOutputWithContext(context.Background())
}

func (i *Backup) ToBackupPtrOutputWithContext(ctx context.Context) BackupPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupPtrOutput)
}

type BackupPtrInput interface {
	pulumi.Input

	ToBackupPtrOutput() BackupPtrOutput
	ToBackupPtrOutputWithContext(ctx context.Context) BackupPtrOutput
}

type backupPtrType BackupArgs

func (*backupPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**Backup)(nil))
}

func (i *backupPtrType) ToBackupPtrOutput() BackupPtrOutput {
	return i.ToBackupPtrOutputWithContext(context.Background())
}

func (i *backupPtrType) ToBackupPtrOutputWithContext(ctx context.Context) BackupPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupPtrOutput)
}

// BackupArrayInput is an input type that accepts BackupArray and BackupArrayOutput values.
// You can construct a concrete instance of `BackupArrayInput` via:
//
//          BackupArray{ BackupArgs{...} }
type BackupArrayInput interface {
	pulumi.Input

	ToBackupArrayOutput() BackupArrayOutput
	ToBackupArrayOutputWithContext(context.Context) BackupArrayOutput
}

type BackupArray []BackupInput

func (BackupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Backup)(nil)).Elem()
}

func (i BackupArray) ToBackupArrayOutput() BackupArrayOutput {
	return i.ToBackupArrayOutputWithContext(context.Background())
}

func (i BackupArray) ToBackupArrayOutputWithContext(ctx context.Context) BackupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupArrayOutput)
}

// BackupMapInput is an input type that accepts BackupMap and BackupMapOutput values.
// You can construct a concrete instance of `BackupMapInput` via:
//
//          BackupMap{ "key": BackupArgs{...} }
type BackupMapInput interface {
	pulumi.Input

	ToBackupMapOutput() BackupMapOutput
	ToBackupMapOutputWithContext(context.Context) BackupMapOutput
}

type BackupMap map[string]BackupInput

func (BackupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Backup)(nil)).Elem()
}

func (i BackupMap) ToBackupMapOutput() BackupMapOutput {
	return i.ToBackupMapOutputWithContext(context.Background())
}

func (i BackupMap) ToBackupMapOutputWithContext(ctx context.Context) BackupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BackupMapOutput)
}

type BackupOutput struct {
	*pulumi.OutputState
}

func (BackupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Backup)(nil))
}

func (o BackupOutput) ToBackupOutput() BackupOutput {
	return o
}

func (o BackupOutput) ToBackupOutputWithContext(ctx context.Context) BackupOutput {
	return o
}

func (o BackupOutput) ToBackupPtrOutput() BackupPtrOutput {
	return o.ToBackupPtrOutputWithContext(context.Background())
}

func (o BackupOutput) ToBackupPtrOutputWithContext(ctx context.Context) BackupPtrOutput {
	return o.ApplyT(func(v Backup) *Backup {
		return &v
	}).(BackupPtrOutput)
}

type BackupPtrOutput struct {
	*pulumi.OutputState
}

func (BackupPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Backup)(nil))
}

func (o BackupPtrOutput) ToBackupPtrOutput() BackupPtrOutput {
	return o
}

func (o BackupPtrOutput) ToBackupPtrOutputWithContext(ctx context.Context) BackupPtrOutput {
	return o
}

type BackupArrayOutput struct{ *pulumi.OutputState }

func (BackupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]Backup)(nil))
}

func (o BackupArrayOutput) ToBackupArrayOutput() BackupArrayOutput {
	return o
}

func (o BackupArrayOutput) ToBackupArrayOutputWithContext(ctx context.Context) BackupArrayOutput {
	return o
}

func (o BackupArrayOutput) Index(i pulumi.IntInput) BackupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) Backup {
		return vs[0].([]Backup)[vs[1].(int)]
	}).(BackupOutput)
}

type BackupMapOutput struct{ *pulumi.OutputState }

func (BackupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]Backup)(nil))
}

func (o BackupMapOutput) ToBackupMapOutput() BackupMapOutput {
	return o
}

func (o BackupMapOutput) ToBackupMapOutputWithContext(ctx context.Context) BackupMapOutput {
	return o
}

func (o BackupMapOutput) MapIndex(k pulumi.StringInput) BackupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) Backup {
		return vs[0].(map[string]Backup)[vs[1].(string)]
	}).(BackupOutput)
}

func init() {
	pulumi.RegisterOutputType(BackupOutput{})
	pulumi.RegisterOutputType(BackupPtrOutput{})
	pulumi.RegisterOutputType(BackupArrayOutput{})
	pulumi.RegisterOutputType(BackupMapOutput{})
}