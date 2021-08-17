// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Console History Content resource in Oracle Cloud Infrastructure Core service.
//
// Gets the actual console history data (not the metadata).
// See [CaptureConsoleHistory](https://docs.cloud.oracle.com/iaas/api/#/en/iaas/latest/ConsoleHistory/CaptureConsoleHistory)
// for details about using the console history operations.
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
// 		opt0 := _var.Console_history_content_length
// 		opt1 := _var.Console_history_content_offset
// 		_, err := oci.GetCoreConsoleHistoryData(ctx, &GetCoreConsoleHistoryDataArgs{
// 			ConsoleHistoryId: oci_core_console_history.Test_console_history.Id,
// 			Length:           &opt0,
// 			Offset:           &opt1,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetCoreConsoleHistoryData(ctx *pulumi.Context, args *GetCoreConsoleHistoryDataArgs, opts ...pulumi.InvokeOption) (*GetCoreConsoleHistoryDataResult, error) {
	var rv GetCoreConsoleHistoryDataResult
	err := ctx.Invoke("oci:index/getCoreConsoleHistoryData:GetCoreConsoleHistoryData", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetCoreConsoleHistoryData.
type GetCoreConsoleHistoryDataArgs struct {
	// The OCID of the console history.
	ConsoleHistoryId string `pulumi:"consoleHistoryId"`
	// Length of the snapshot data to retrieve. Cannot be less than 10240.
	Length *int `pulumi:"length"`
	// Offset of the snapshot data to retrieve.
	Offset *int `pulumi:"offset"`
}

// A collection of values returned by GetCoreConsoleHistoryData.
type GetCoreConsoleHistoryDataResult struct {
	ConsoleHistoryId string `pulumi:"consoleHistoryId"`
	// The console history data.
	Data string `pulumi:"data"`
	// The provider-assigned unique ID for this managed resource.
	Id     string `pulumi:"id"`
	Length *int   `pulumi:"length"`
	Offset *int   `pulumi:"offset"`
}