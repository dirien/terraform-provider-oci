// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package core

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides the list of Boot Volumes in Oracle Cloud Infrastructure Core service.
//
// Lists the boot volumes in the specified compartment and availability domain.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-oci/sdk/go/oci/core"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := oci_core_volume_group.Test_volume_group.Id
// 		_, err := core.GetBootVolumes(ctx, &core.GetBootVolumesArgs{
// 			AvailabilityDomain: _var.Boot_volume_availability_domain,
// 			CompartmentId:      _var.Compartment_id,
// 			VolumeGroupId:      &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetBootVolumes(ctx *pulumi.Context, args *GetBootVolumesArgs, opts ...pulumi.InvokeOption) (*GetBootVolumesResult, error) {
	var rv GetBootVolumesResult
	err := ctx.Invoke("oci:core/getBootVolumes:getBootVolumes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBootVolumes.
type GetBootVolumesArgs struct {
	// The name of the availability domain.  Example: `Uocm:PHX-AD-1`
	AvailabilityDomain string `pulumi:"availabilityDomain"`
	// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
	CompartmentId string                 `pulumi:"compartmentId"`
	Filters       []GetBootVolumesFilter `pulumi:"filters"`
	// The OCID of the volume group.
	VolumeGroupId *string `pulumi:"volumeGroupId"`
}

// A collection of values returned by getBootVolumes.
type GetBootVolumesResult struct {
	// The availability domain of the boot volume replica.  Example: `Uocm:PHX-AD-1`
	AvailabilityDomain string `pulumi:"availabilityDomain"`
	// The list of boot_volumes.
	BootVolumes []GetBootVolumesBootVolume `pulumi:"bootVolumes"`
	// The OCID of the compartment that contains the boot volume.
	CompartmentId string                 `pulumi:"compartmentId"`
	Filters       []GetBootVolumesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The OCID of the source volume group.
	VolumeGroupId *string `pulumi:"volumeGroupId"`
}