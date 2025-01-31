// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Exadata Infrastructure resource in Oracle Cloud Infrastructure Database service.
//
// Creates an Exadata infrastructure resource. Applies to Exadata Cloud@Customer instances only.
// To create an Exadata Cloud Service infrastructure resource, use the  [CreateCloudExadataInfrastructure](https://docs.cloud.oracle.com/iaas/api/#/en/database/latest/CloudExadataInfrastructure/CreateCloudExadataInfrastructure) operation.
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
// 		_, err := oci.NewDatabaseExadataInfrastructure(ctx, "testExadataInfrastructure", &oci.DatabaseExadataInfrastructureArgs{
// 			AdminNetworkCidr:         pulumi.Any(_var.Exadata_infrastructure_admin_network_cidr),
// 			CloudControlPlaneServer1: pulumi.Any(_var.Exadata_infrastructure_cloud_control_plane_server1),
// 			CloudControlPlaneServer2: pulumi.Any(_var.Exadata_infrastructure_cloud_control_plane_server2),
// 			CompartmentId:            pulumi.Any(_var.Compartment_id),
// 			DisplayName:              pulumi.Any(_var.Exadata_infrastructure_display_name),
// 			DnsServers:               pulumi.Any(_var.Exadata_infrastructure_dns_server),
// 			Gateway:                  pulumi.Any(_var.Exadata_infrastructure_gateway),
// 			InfiniBandNetworkCidr:    pulumi.Any(_var.Exadata_infrastructure_infini_band_network_cidr),
// 			Netmask:                  pulumi.Any(_var.Exadata_infrastructure_netmask),
// 			NtpServers:               pulumi.Any(_var.Exadata_infrastructure_ntp_server),
// 			Shape:                    pulumi.Any(_var.Exadata_infrastructure_shape),
// 			TimeZone:                 pulumi.Any(_var.Exadata_infrastructure_time_zone),
// 			ActivationFile:           pulumi.Any(_var.Exadata_infrastructure_activation_file),
// 			ComputeCount:             pulumi.Any(_var.Exadata_infrastructure_compute_count),
// 			Contacts: DatabaseExadataInfrastructureContactArray{
// 				&DatabaseExadataInfrastructureContactArgs{
// 					Email:                 pulumi.Any(_var.Exadata_infrastructure_contacts_email),
// 					IsPrimary:             pulumi.Any(_var.Exadata_infrastructure_contacts_is_primary),
// 					Name:                  pulumi.Any(_var.Exadata_infrastructure_contacts_name),
// 					IsContactMosValidated: pulumi.Any(_var.Exadata_infrastructure_contacts_is_contact_mos_validated),
// 					PhoneNumber:           pulumi.Any(_var.Exadata_infrastructure_contacts_phone_number),
// 				},
// 			},
// 			CorporateProxy: pulumi.Any(_var.Exadata_infrastructure_corporate_proxy),
// 			DefinedTags:    pulumi.Any(_var.Exadata_infrastructure_defined_tags),
// 			FreeformTags: pulumi.AnyMap{
// 				"Department": pulumi.Any("Finance"),
// 			},
// 			MaintenanceWindow: &DatabaseExadataInfrastructureMaintenanceWindowArgs{
// 				Preference: pulumi.Any(_var.Exadata_infrastructure_maintenance_window_preference),
// 				DaysOfWeeks: DatabaseExadataInfrastructureMaintenanceWindowDaysOfWeekArray{
// 					&DatabaseExadataInfrastructureMaintenanceWindowDaysOfWeekArgs{
// 						Name: pulumi.Any(_var.Exadata_infrastructure_maintenance_window_days_of_week_name),
// 					},
// 				},
// 				HoursOfDays:     pulumi.Any(_var.Exadata_infrastructure_maintenance_window_hours_of_day),
// 				LeadTimeInWeeks: pulumi.Any(_var.Exadata_infrastructure_maintenance_window_lead_time_in_weeks),
// 				Months: DatabaseExadataInfrastructureMaintenanceWindowMonthArray{
// 					&DatabaseExadataInfrastructureMaintenanceWindowMonthArgs{
// 						Name: pulumi.Any(_var.Exadata_infrastructure_maintenance_window_months_name),
// 					},
// 				},
// 				WeeksOfMonths: pulumi.Any(_var.Exadata_infrastructure_maintenance_window_weeks_of_month),
// 			},
// 			StorageCount: pulumi.Any(_var.Exadata_infrastructure_storage_count),
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
// ExadataInfrastructures can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:index/databaseExadataInfrastructure:DatabaseExadataInfrastructure test_exadata_infrastructure "id"
// ```
type DatabaseExadataInfrastructure struct {
	pulumi.CustomResourceState

	// The requested number of additional storage servers activated for the Exadata infrastructure.
	ActivatedStorageCount pulumi.IntOutput `pulumi:"activatedStorageCount"`
	// (Updatable) The activation zip file. If provided in config, exadata infrastructure will be activated after creation. Updates are not allowed on activated exadata infrastructure.
	ActivationFile pulumi.StringPtrOutput `pulumi:"activationFile"`
	// The requested number of additional storage servers for the Exadata infrastructure.
	AdditionalStorageCount pulumi.IntOutput `pulumi:"additionalStorageCount"`
	// (Updatable) The CIDR block for the Exadata administration network.
	AdminNetworkCidr pulumi.StringOutput `pulumi:"adminNetworkCidr"`
	// (Updatable) The IP address for the first control plane server.
	CloudControlPlaneServer1 pulumi.StringOutput `pulumi:"cloudControlPlaneServer1"`
	// (Updatable) The IP address for the second control plane server.
	CloudControlPlaneServer2 pulumi.StringOutput `pulumi:"cloudControlPlaneServer2"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId pulumi.StringOutput `pulumi:"compartmentId"`
	// The number of compute servers for the Exadata infrastructure.
	ComputeCount pulumi.IntOutput `pulumi:"computeCount"`
	// (Updatable) The list of contacts for the Exadata infrastructure.
	Contacts DatabaseExadataInfrastructureContactArrayOutput `pulumi:"contacts"`
	// (Updatable) The corporate network proxy for access to the control plane network. Oracle recommends using an HTTPS proxy when possible for enhanced security.
	CorporateProxy pulumi.StringOutput `pulumi:"corporateProxy"`
	// The number of enabled CPU cores.
	CpusEnabled pulumi.IntOutput     `pulumi:"cpusEnabled"`
	CreateAsync pulumi.BoolPtrOutput `pulumi:"createAsync"`
	// The CSI Number of the Exadata infrastructure.
	CsiNumber pulumi.StringOutput `pulumi:"csiNumber"`
	// Size, in terabytes, of the DATA disk group.
	DataStorageSizeInTbs pulumi.Float64Output `pulumi:"dataStorageSizeInTbs"`
	// The local node storage allocated in GBs.
	DbNodeStorageSizeInGbs pulumi.IntOutput `pulumi:"dbNodeStorageSizeInGbs"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags pulumi.MapOutput `pulumi:"definedTags"`
	// The user-friendly name for the Exadata infrastructure. The name does not need to be unique.
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// (Updatable) The list of DNS server IP addresses. Maximum of 3 allowed.
	DnsServers pulumi.StringArrayOutput `pulumi:"dnsServers"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapOutput `pulumi:"freeformTags"`
	// (Updatable) The gateway for the control plane network.
	Gateway pulumi.StringOutput `pulumi:"gateway"`
	// (Updatable) The CIDR block for the Exadata InfiniBand interconnect.
	InfiniBandNetworkCidr pulumi.StringOutput `pulumi:"infiniBandNetworkCidr"`
	// Additional information about the current lifecycle state.
	LifecycleDetails pulumi.StringOutput `pulumi:"lifecycleDetails"`
	// A field to capture ‘Maintenance SLO Status’ for the Exadata infrastructure with values ‘OK’, ‘DEGRADED’. Default is ‘OK’ when the infrastructure is provisioned.
	MaintenanceSloStatus pulumi.StringOutput `pulumi:"maintenanceSloStatus"`
	// (Updatable) The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
	MaintenanceWindow DatabaseExadataInfrastructureMaintenanceWindowOutput `pulumi:"maintenanceWindow"`
	// The total number of CPU cores available.
	MaxCpuCount pulumi.IntOutput `pulumi:"maxCpuCount"`
	// The total available DATA disk group size.
	MaxDataStorageInTbs pulumi.Float64Output `pulumi:"maxDataStorageInTbs"`
	// The total local node storage available in GBs.
	MaxDbNodeStorageInGbs pulumi.IntOutput `pulumi:"maxDbNodeStorageInGbs"`
	// The total memory available in GBs.
	MaxMemoryInGbs pulumi.IntOutput `pulumi:"maxMemoryInGbs"`
	// The memory allocated in GBs.
	MemorySizeInGbs pulumi.IntOutput `pulumi:"memorySizeInGbs"`
	// (Updatable) The netmask for the control plane network.
	Netmask pulumi.StringOutput `pulumi:"netmask"`
	// (Updatable) The list of NTP server IP addresses. Maximum of 3 allowed.
	NtpServers pulumi.StringArrayOutput `pulumi:"ntpServers"`
	// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
	Shape pulumi.StringOutput `pulumi:"shape"`
	// The current lifecycle state of the Exadata infrastructure.
	State pulumi.StringOutput `pulumi:"state"`
	// The number of storage servers for the Exadata infrastructure.
	StorageCount pulumi.IntOutput `pulumi:"storageCount"`
	// The date and time the Exadata infrastructure was created.
	TimeCreated pulumi.StringOutput `pulumi:"timeCreated"`
	// (Updatable) The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/iaas/Content/Database/References/timezones.htm).
	TimeZone pulumi.StringOutput `pulumi:"timeZone"`
}

// NewDatabaseExadataInfrastructure registers a new resource with the given unique name, arguments, and options.
func NewDatabaseExadataInfrastructure(ctx *pulumi.Context,
	name string, args *DatabaseExadataInfrastructureArgs, opts ...pulumi.ResourceOption) (*DatabaseExadataInfrastructure, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AdminNetworkCidr == nil {
		return nil, errors.New("invalid value for required argument 'AdminNetworkCidr'")
	}
	if args.CloudControlPlaneServer1 == nil {
		return nil, errors.New("invalid value for required argument 'CloudControlPlaneServer1'")
	}
	if args.CloudControlPlaneServer2 == nil {
		return nil, errors.New("invalid value for required argument 'CloudControlPlaneServer2'")
	}
	if args.CompartmentId == nil {
		return nil, errors.New("invalid value for required argument 'CompartmentId'")
	}
	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	if args.DnsServers == nil {
		return nil, errors.New("invalid value for required argument 'DnsServers'")
	}
	if args.Gateway == nil {
		return nil, errors.New("invalid value for required argument 'Gateway'")
	}
	if args.InfiniBandNetworkCidr == nil {
		return nil, errors.New("invalid value for required argument 'InfiniBandNetworkCidr'")
	}
	if args.Netmask == nil {
		return nil, errors.New("invalid value for required argument 'Netmask'")
	}
	if args.NtpServers == nil {
		return nil, errors.New("invalid value for required argument 'NtpServers'")
	}
	if args.Shape == nil {
		return nil, errors.New("invalid value for required argument 'Shape'")
	}
	if args.TimeZone == nil {
		return nil, errors.New("invalid value for required argument 'TimeZone'")
	}
	var resource DatabaseExadataInfrastructure
	err := ctx.RegisterResource("oci:index/databaseExadataInfrastructure:DatabaseExadataInfrastructure", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDatabaseExadataInfrastructure gets an existing DatabaseExadataInfrastructure resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDatabaseExadataInfrastructure(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DatabaseExadataInfrastructureState, opts ...pulumi.ResourceOption) (*DatabaseExadataInfrastructure, error) {
	var resource DatabaseExadataInfrastructure
	err := ctx.ReadResource("oci:index/databaseExadataInfrastructure:DatabaseExadataInfrastructure", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DatabaseExadataInfrastructure resources.
type databaseExadataInfrastructureState struct {
	// The requested number of additional storage servers activated for the Exadata infrastructure.
	ActivatedStorageCount *int `pulumi:"activatedStorageCount"`
	// (Updatable) The activation zip file. If provided in config, exadata infrastructure will be activated after creation. Updates are not allowed on activated exadata infrastructure.
	ActivationFile *string `pulumi:"activationFile"`
	// The requested number of additional storage servers for the Exadata infrastructure.
	AdditionalStorageCount *int `pulumi:"additionalStorageCount"`
	// (Updatable) The CIDR block for the Exadata administration network.
	AdminNetworkCidr *string `pulumi:"adminNetworkCidr"`
	// (Updatable) The IP address for the first control plane server.
	CloudControlPlaneServer1 *string `pulumi:"cloudControlPlaneServer1"`
	// (Updatable) The IP address for the second control plane server.
	CloudControlPlaneServer2 *string `pulumi:"cloudControlPlaneServer2"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId *string `pulumi:"compartmentId"`
	// The number of compute servers for the Exadata infrastructure.
	ComputeCount *int `pulumi:"computeCount"`
	// (Updatable) The list of contacts for the Exadata infrastructure.
	Contacts []DatabaseExadataInfrastructureContact `pulumi:"contacts"`
	// (Updatable) The corporate network proxy for access to the control plane network. Oracle recommends using an HTTPS proxy when possible for enhanced security.
	CorporateProxy *string `pulumi:"corporateProxy"`
	// The number of enabled CPU cores.
	CpusEnabled *int  `pulumi:"cpusEnabled"`
	CreateAsync *bool `pulumi:"createAsync"`
	// The CSI Number of the Exadata infrastructure.
	CsiNumber *string `pulumi:"csiNumber"`
	// Size, in terabytes, of the DATA disk group.
	DataStorageSizeInTbs *float64 `pulumi:"dataStorageSizeInTbs"`
	// The local node storage allocated in GBs.
	DbNodeStorageSizeInGbs *int `pulumi:"dbNodeStorageSizeInGbs"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// The user-friendly name for the Exadata infrastructure. The name does not need to be unique.
	DisplayName *string `pulumi:"displayName"`
	// (Updatable) The list of DNS server IP addresses. Maximum of 3 allowed.
	DnsServers []string `pulumi:"dnsServers"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// (Updatable) The gateway for the control plane network.
	Gateway *string `pulumi:"gateway"`
	// (Updatable) The CIDR block for the Exadata InfiniBand interconnect.
	InfiniBandNetworkCidr *string `pulumi:"infiniBandNetworkCidr"`
	// Additional information about the current lifecycle state.
	LifecycleDetails *string `pulumi:"lifecycleDetails"`
	// A field to capture ‘Maintenance SLO Status’ for the Exadata infrastructure with values ‘OK’, ‘DEGRADED’. Default is ‘OK’ when the infrastructure is provisioned.
	MaintenanceSloStatus *string `pulumi:"maintenanceSloStatus"`
	// (Updatable) The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
	MaintenanceWindow *DatabaseExadataInfrastructureMaintenanceWindow `pulumi:"maintenanceWindow"`
	// The total number of CPU cores available.
	MaxCpuCount *int `pulumi:"maxCpuCount"`
	// The total available DATA disk group size.
	MaxDataStorageInTbs *float64 `pulumi:"maxDataStorageInTbs"`
	// The total local node storage available in GBs.
	MaxDbNodeStorageInGbs *int `pulumi:"maxDbNodeStorageInGbs"`
	// The total memory available in GBs.
	MaxMemoryInGbs *int `pulumi:"maxMemoryInGbs"`
	// The memory allocated in GBs.
	MemorySizeInGbs *int `pulumi:"memorySizeInGbs"`
	// (Updatable) The netmask for the control plane network.
	Netmask *string `pulumi:"netmask"`
	// (Updatable) The list of NTP server IP addresses. Maximum of 3 allowed.
	NtpServers []string `pulumi:"ntpServers"`
	// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
	Shape *string `pulumi:"shape"`
	// The current lifecycle state of the Exadata infrastructure.
	State *string `pulumi:"state"`
	// The number of storage servers for the Exadata infrastructure.
	StorageCount *int `pulumi:"storageCount"`
	// The date and time the Exadata infrastructure was created.
	TimeCreated *string `pulumi:"timeCreated"`
	// (Updatable) The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/iaas/Content/Database/References/timezones.htm).
	TimeZone *string `pulumi:"timeZone"`
}

type DatabaseExadataInfrastructureState struct {
	// The requested number of additional storage servers activated for the Exadata infrastructure.
	ActivatedStorageCount pulumi.IntPtrInput
	// (Updatable) The activation zip file. If provided in config, exadata infrastructure will be activated after creation. Updates are not allowed on activated exadata infrastructure.
	ActivationFile pulumi.StringPtrInput
	// The requested number of additional storage servers for the Exadata infrastructure.
	AdditionalStorageCount pulumi.IntPtrInput
	// (Updatable) The CIDR block for the Exadata administration network.
	AdminNetworkCidr pulumi.StringPtrInput
	// (Updatable) The IP address for the first control plane server.
	CloudControlPlaneServer1 pulumi.StringPtrInput
	// (Updatable) The IP address for the second control plane server.
	CloudControlPlaneServer2 pulumi.StringPtrInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId pulumi.StringPtrInput
	// The number of compute servers for the Exadata infrastructure.
	ComputeCount pulumi.IntPtrInput
	// (Updatable) The list of contacts for the Exadata infrastructure.
	Contacts DatabaseExadataInfrastructureContactArrayInput
	// (Updatable) The corporate network proxy for access to the control plane network. Oracle recommends using an HTTPS proxy when possible for enhanced security.
	CorporateProxy pulumi.StringPtrInput
	// The number of enabled CPU cores.
	CpusEnabled pulumi.IntPtrInput
	CreateAsync pulumi.BoolPtrInput
	// The CSI Number of the Exadata infrastructure.
	CsiNumber pulumi.StringPtrInput
	// Size, in terabytes, of the DATA disk group.
	DataStorageSizeInTbs pulumi.Float64PtrInput
	// The local node storage allocated in GBs.
	DbNodeStorageSizeInGbs pulumi.IntPtrInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags pulumi.MapInput
	// The user-friendly name for the Exadata infrastructure. The name does not need to be unique.
	DisplayName pulumi.StringPtrInput
	// (Updatable) The list of DNS server IP addresses. Maximum of 3 allowed.
	DnsServers pulumi.StringArrayInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// (Updatable) The gateway for the control plane network.
	Gateway pulumi.StringPtrInput
	// (Updatable) The CIDR block for the Exadata InfiniBand interconnect.
	InfiniBandNetworkCidr pulumi.StringPtrInput
	// Additional information about the current lifecycle state.
	LifecycleDetails pulumi.StringPtrInput
	// A field to capture ‘Maintenance SLO Status’ for the Exadata infrastructure with values ‘OK’, ‘DEGRADED’. Default is ‘OK’ when the infrastructure is provisioned.
	MaintenanceSloStatus pulumi.StringPtrInput
	// (Updatable) The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
	MaintenanceWindow DatabaseExadataInfrastructureMaintenanceWindowPtrInput
	// The total number of CPU cores available.
	MaxCpuCount pulumi.IntPtrInput
	// The total available DATA disk group size.
	MaxDataStorageInTbs pulumi.Float64PtrInput
	// The total local node storage available in GBs.
	MaxDbNodeStorageInGbs pulumi.IntPtrInput
	// The total memory available in GBs.
	MaxMemoryInGbs pulumi.IntPtrInput
	// The memory allocated in GBs.
	MemorySizeInGbs pulumi.IntPtrInput
	// (Updatable) The netmask for the control plane network.
	Netmask pulumi.StringPtrInput
	// (Updatable) The list of NTP server IP addresses. Maximum of 3 allowed.
	NtpServers pulumi.StringArrayInput
	// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
	Shape pulumi.StringPtrInput
	// The current lifecycle state of the Exadata infrastructure.
	State pulumi.StringPtrInput
	// The number of storage servers for the Exadata infrastructure.
	StorageCount pulumi.IntPtrInput
	// The date and time the Exadata infrastructure was created.
	TimeCreated pulumi.StringPtrInput
	// (Updatable) The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/iaas/Content/Database/References/timezones.htm).
	TimeZone pulumi.StringPtrInput
}

func (DatabaseExadataInfrastructureState) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseExadataInfrastructureState)(nil)).Elem()
}

type databaseExadataInfrastructureArgs struct {
	// (Updatable) The activation zip file. If provided in config, exadata infrastructure will be activated after creation. Updates are not allowed on activated exadata infrastructure.
	ActivationFile *string `pulumi:"activationFile"`
	// The requested number of additional storage servers for the Exadata infrastructure.
	AdditionalStorageCount *int `pulumi:"additionalStorageCount"`
	// (Updatable) The CIDR block for the Exadata administration network.
	AdminNetworkCidr string `pulumi:"adminNetworkCidr"`
	// (Updatable) The IP address for the first control plane server.
	CloudControlPlaneServer1 string `pulumi:"cloudControlPlaneServer1"`
	// (Updatable) The IP address for the second control plane server.
	CloudControlPlaneServer2 string `pulumi:"cloudControlPlaneServer2"`
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId string `pulumi:"compartmentId"`
	// The number of compute servers for the Exadata infrastructure.
	ComputeCount *int `pulumi:"computeCount"`
	// (Updatable) The list of contacts for the Exadata infrastructure.
	Contacts []DatabaseExadataInfrastructureContact `pulumi:"contacts"`
	// (Updatable) The corporate network proxy for access to the control plane network. Oracle recommends using an HTTPS proxy when possible for enhanced security.
	CorporateProxy *string `pulumi:"corporateProxy"`
	CreateAsync    *bool   `pulumi:"createAsync"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// The user-friendly name for the Exadata infrastructure. The name does not need to be unique.
	DisplayName string `pulumi:"displayName"`
	// (Updatable) The list of DNS server IP addresses. Maximum of 3 allowed.
	DnsServers []string `pulumi:"dnsServers"`
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// (Updatable) The gateway for the control plane network.
	Gateway string `pulumi:"gateway"`
	// (Updatable) The CIDR block for the Exadata InfiniBand interconnect.
	InfiniBandNetworkCidr string `pulumi:"infiniBandNetworkCidr"`
	// (Updatable) The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
	MaintenanceWindow *DatabaseExadataInfrastructureMaintenanceWindow `pulumi:"maintenanceWindow"`
	// (Updatable) The netmask for the control plane network.
	Netmask string `pulumi:"netmask"`
	// (Updatable) The list of NTP server IP addresses. Maximum of 3 allowed.
	NtpServers []string `pulumi:"ntpServers"`
	// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
	Shape string `pulumi:"shape"`
	// The number of storage servers for the Exadata infrastructure.
	StorageCount *int `pulumi:"storageCount"`
	// (Updatable) The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/iaas/Content/Database/References/timezones.htm).
	TimeZone string `pulumi:"timeZone"`
}

// The set of arguments for constructing a DatabaseExadataInfrastructure resource.
type DatabaseExadataInfrastructureArgs struct {
	// (Updatable) The activation zip file. If provided in config, exadata infrastructure will be activated after creation. Updates are not allowed on activated exadata infrastructure.
	ActivationFile pulumi.StringPtrInput
	// The requested number of additional storage servers for the Exadata infrastructure.
	AdditionalStorageCount pulumi.IntPtrInput
	// (Updatable) The CIDR block for the Exadata administration network.
	AdminNetworkCidr pulumi.StringInput
	// (Updatable) The IP address for the first control plane server.
	CloudControlPlaneServer1 pulumi.StringInput
	// (Updatable) The IP address for the second control plane server.
	CloudControlPlaneServer2 pulumi.StringInput
	// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId pulumi.StringInput
	// The number of compute servers for the Exadata infrastructure.
	ComputeCount pulumi.IntPtrInput
	// (Updatable) The list of contacts for the Exadata infrastructure.
	Contacts DatabaseExadataInfrastructureContactArrayInput
	// (Updatable) The corporate network proxy for access to the control plane network. Oracle recommends using an HTTPS proxy when possible for enhanced security.
	CorporateProxy pulumi.StringPtrInput
	CreateAsync    pulumi.BoolPtrInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
	DefinedTags pulumi.MapInput
	// The user-friendly name for the Exadata infrastructure. The name does not need to be unique.
	DisplayName pulumi.StringInput
	// (Updatable) The list of DNS server IP addresses. Maximum of 3 allowed.
	DnsServers pulumi.StringArrayInput
	// (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).  Example: `{"Department": "Finance"}`
	FreeformTags pulumi.MapInput
	// (Updatable) The gateway for the control plane network.
	Gateway pulumi.StringInput
	// (Updatable) The CIDR block for the Exadata InfiniBand interconnect.
	InfiniBandNetworkCidr pulumi.StringInput
	// (Updatable) The scheduling details for the quarterly maintenance window. Patching and system updates take place during the maintenance window.
	MaintenanceWindow DatabaseExadataInfrastructureMaintenanceWindowPtrInput
	// (Updatable) The netmask for the control plane network.
	Netmask pulumi.StringInput
	// (Updatable) The list of NTP server IP addresses. Maximum of 3 allowed.
	NtpServers pulumi.StringArrayInput
	// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
	Shape pulumi.StringInput
	// The number of storage servers for the Exadata infrastructure.
	StorageCount pulumi.IntPtrInput
	// (Updatable) The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/iaas/Content/Database/References/timezones.htm).
	TimeZone pulumi.StringInput
}

func (DatabaseExadataInfrastructureArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*databaseExadataInfrastructureArgs)(nil)).Elem()
}

type DatabaseExadataInfrastructureInput interface {
	pulumi.Input

	ToDatabaseExadataInfrastructureOutput() DatabaseExadataInfrastructureOutput
	ToDatabaseExadataInfrastructureOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureOutput
}

func (*DatabaseExadataInfrastructure) ElementType() reflect.Type {
	return reflect.TypeOf((*DatabaseExadataInfrastructure)(nil))
}

func (i *DatabaseExadataInfrastructure) ToDatabaseExadataInfrastructureOutput() DatabaseExadataInfrastructureOutput {
	return i.ToDatabaseExadataInfrastructureOutputWithContext(context.Background())
}

func (i *DatabaseExadataInfrastructure) ToDatabaseExadataInfrastructureOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseExadataInfrastructureOutput)
}

func (i *DatabaseExadataInfrastructure) ToDatabaseExadataInfrastructurePtrOutput() DatabaseExadataInfrastructurePtrOutput {
	return i.ToDatabaseExadataInfrastructurePtrOutputWithContext(context.Background())
}

func (i *DatabaseExadataInfrastructure) ToDatabaseExadataInfrastructurePtrOutputWithContext(ctx context.Context) DatabaseExadataInfrastructurePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseExadataInfrastructurePtrOutput)
}

type DatabaseExadataInfrastructurePtrInput interface {
	pulumi.Input

	ToDatabaseExadataInfrastructurePtrOutput() DatabaseExadataInfrastructurePtrOutput
	ToDatabaseExadataInfrastructurePtrOutputWithContext(ctx context.Context) DatabaseExadataInfrastructurePtrOutput
}

type databaseExadataInfrastructurePtrType DatabaseExadataInfrastructureArgs

func (*databaseExadataInfrastructurePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabaseExadataInfrastructure)(nil))
}

func (i *databaseExadataInfrastructurePtrType) ToDatabaseExadataInfrastructurePtrOutput() DatabaseExadataInfrastructurePtrOutput {
	return i.ToDatabaseExadataInfrastructurePtrOutputWithContext(context.Background())
}

func (i *databaseExadataInfrastructurePtrType) ToDatabaseExadataInfrastructurePtrOutputWithContext(ctx context.Context) DatabaseExadataInfrastructurePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseExadataInfrastructurePtrOutput)
}

// DatabaseExadataInfrastructureArrayInput is an input type that accepts DatabaseExadataInfrastructureArray and DatabaseExadataInfrastructureArrayOutput values.
// You can construct a concrete instance of `DatabaseExadataInfrastructureArrayInput` via:
//
//          DatabaseExadataInfrastructureArray{ DatabaseExadataInfrastructureArgs{...} }
type DatabaseExadataInfrastructureArrayInput interface {
	pulumi.Input

	ToDatabaseExadataInfrastructureArrayOutput() DatabaseExadataInfrastructureArrayOutput
	ToDatabaseExadataInfrastructureArrayOutputWithContext(context.Context) DatabaseExadataInfrastructureArrayOutput
}

type DatabaseExadataInfrastructureArray []DatabaseExadataInfrastructureInput

func (DatabaseExadataInfrastructureArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DatabaseExadataInfrastructure)(nil)).Elem()
}

func (i DatabaseExadataInfrastructureArray) ToDatabaseExadataInfrastructureArrayOutput() DatabaseExadataInfrastructureArrayOutput {
	return i.ToDatabaseExadataInfrastructureArrayOutputWithContext(context.Background())
}

func (i DatabaseExadataInfrastructureArray) ToDatabaseExadataInfrastructureArrayOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseExadataInfrastructureArrayOutput)
}

// DatabaseExadataInfrastructureMapInput is an input type that accepts DatabaseExadataInfrastructureMap and DatabaseExadataInfrastructureMapOutput values.
// You can construct a concrete instance of `DatabaseExadataInfrastructureMapInput` via:
//
//          DatabaseExadataInfrastructureMap{ "key": DatabaseExadataInfrastructureArgs{...} }
type DatabaseExadataInfrastructureMapInput interface {
	pulumi.Input

	ToDatabaseExadataInfrastructureMapOutput() DatabaseExadataInfrastructureMapOutput
	ToDatabaseExadataInfrastructureMapOutputWithContext(context.Context) DatabaseExadataInfrastructureMapOutput
}

type DatabaseExadataInfrastructureMap map[string]DatabaseExadataInfrastructureInput

func (DatabaseExadataInfrastructureMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DatabaseExadataInfrastructure)(nil)).Elem()
}

func (i DatabaseExadataInfrastructureMap) ToDatabaseExadataInfrastructureMapOutput() DatabaseExadataInfrastructureMapOutput {
	return i.ToDatabaseExadataInfrastructureMapOutputWithContext(context.Background())
}

func (i DatabaseExadataInfrastructureMap) ToDatabaseExadataInfrastructureMapOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DatabaseExadataInfrastructureMapOutput)
}

type DatabaseExadataInfrastructureOutput struct {
	*pulumi.OutputState
}

func (DatabaseExadataInfrastructureOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DatabaseExadataInfrastructure)(nil))
}

func (o DatabaseExadataInfrastructureOutput) ToDatabaseExadataInfrastructureOutput() DatabaseExadataInfrastructureOutput {
	return o
}

func (o DatabaseExadataInfrastructureOutput) ToDatabaseExadataInfrastructureOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureOutput {
	return o
}

func (o DatabaseExadataInfrastructureOutput) ToDatabaseExadataInfrastructurePtrOutput() DatabaseExadataInfrastructurePtrOutput {
	return o.ToDatabaseExadataInfrastructurePtrOutputWithContext(context.Background())
}

func (o DatabaseExadataInfrastructureOutput) ToDatabaseExadataInfrastructurePtrOutputWithContext(ctx context.Context) DatabaseExadataInfrastructurePtrOutput {
	return o.ApplyT(func(v DatabaseExadataInfrastructure) *DatabaseExadataInfrastructure {
		return &v
	}).(DatabaseExadataInfrastructurePtrOutput)
}

type DatabaseExadataInfrastructurePtrOutput struct {
	*pulumi.OutputState
}

func (DatabaseExadataInfrastructurePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DatabaseExadataInfrastructure)(nil))
}

func (o DatabaseExadataInfrastructurePtrOutput) ToDatabaseExadataInfrastructurePtrOutput() DatabaseExadataInfrastructurePtrOutput {
	return o
}

func (o DatabaseExadataInfrastructurePtrOutput) ToDatabaseExadataInfrastructurePtrOutputWithContext(ctx context.Context) DatabaseExadataInfrastructurePtrOutput {
	return o
}

type DatabaseExadataInfrastructureArrayOutput struct{ *pulumi.OutputState }

func (DatabaseExadataInfrastructureArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]DatabaseExadataInfrastructure)(nil))
}

func (o DatabaseExadataInfrastructureArrayOutput) ToDatabaseExadataInfrastructureArrayOutput() DatabaseExadataInfrastructureArrayOutput {
	return o
}

func (o DatabaseExadataInfrastructureArrayOutput) ToDatabaseExadataInfrastructureArrayOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureArrayOutput {
	return o
}

func (o DatabaseExadataInfrastructureArrayOutput) Index(i pulumi.IntInput) DatabaseExadataInfrastructureOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) DatabaseExadataInfrastructure {
		return vs[0].([]DatabaseExadataInfrastructure)[vs[1].(int)]
	}).(DatabaseExadataInfrastructureOutput)
}

type DatabaseExadataInfrastructureMapOutput struct{ *pulumi.OutputState }

func (DatabaseExadataInfrastructureMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]DatabaseExadataInfrastructure)(nil))
}

func (o DatabaseExadataInfrastructureMapOutput) ToDatabaseExadataInfrastructureMapOutput() DatabaseExadataInfrastructureMapOutput {
	return o
}

func (o DatabaseExadataInfrastructureMapOutput) ToDatabaseExadataInfrastructureMapOutputWithContext(ctx context.Context) DatabaseExadataInfrastructureMapOutput {
	return o
}

func (o DatabaseExadataInfrastructureMapOutput) MapIndex(k pulumi.StringInput) DatabaseExadataInfrastructureOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) DatabaseExadataInfrastructure {
		return vs[0].(map[string]DatabaseExadataInfrastructure)[vs[1].(string)]
	}).(DatabaseExadataInfrastructureOutput)
}

func init() {
	pulumi.RegisterOutputType(DatabaseExadataInfrastructureOutput{})
	pulumi.RegisterOutputType(DatabaseExadataInfrastructurePtrOutput{})
	pulumi.RegisterOutputType(DatabaseExadataInfrastructureArrayOutput{})
	pulumi.RegisterOutputType(DatabaseExadataInfrastructureMapOutput{})
}
