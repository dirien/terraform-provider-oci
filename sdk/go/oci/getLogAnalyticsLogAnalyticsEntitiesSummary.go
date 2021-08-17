// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This data source provides details about a specific Log Analytics Entities Summary resource in Oracle Cloud Infrastructure Log Analytics service.
//
// Returns log analytics entities count summary report.
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
// 		_, err := oci.GetLogAnalyticsLogAnalyticsEntitiesSummary(ctx, &GetLogAnalyticsLogAnalyticsEntitiesSummaryArgs{
// 			CompartmentId: _var.Compartment_id,
// 			Namespace:     _var.Log_analytics_entities_summary_namespace,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetLogAnalyticsLogAnalyticsEntitiesSummary(ctx *pulumi.Context, args *GetLogAnalyticsLogAnalyticsEntitiesSummaryArgs, opts ...pulumi.InvokeOption) (*GetLogAnalyticsLogAnalyticsEntitiesSummaryResult, error) {
	var rv GetLogAnalyticsLogAnalyticsEntitiesSummaryResult
	err := ctx.Invoke("oci:index/getLogAnalyticsLogAnalyticsEntitiesSummary:GetLogAnalyticsLogAnalyticsEntitiesSummary", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking GetLogAnalyticsLogAnalyticsEntitiesSummary.
type GetLogAnalyticsLogAnalyticsEntitiesSummaryArgs struct {
	// The ID of the compartment in which to list resources.
	CompartmentId string `pulumi:"compartmentId"`
	// The Logging Analytics namespace used for the request.
	Namespace string `pulumi:"namespace"`
}

// A collection of values returned by GetLogAnalyticsLogAnalyticsEntitiesSummary.
type GetLogAnalyticsLogAnalyticsEntitiesSummaryResult struct {
	// Total number of ACTIVE entities
	ActiveEntitiesCount int `pulumi:"activeEntitiesCount"`
	// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
	CompartmentId string `pulumi:"compartmentId"`
	// Entities with log collection enabled
	EntitiesWithHasLogsCollectedCount int `pulumi:"entitiesWithHasLogsCollectedCount"`
	// Entities with management agent
	EntitiesWithManagementAgentCount int `pulumi:"entitiesWithManagementAgentCount"`
	// The provider-assigned unique ID for this managed resource.
	Id        string `pulumi:"id"`
	Namespace string `pulumi:"namespace"`
}