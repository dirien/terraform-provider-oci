// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package oci

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource provides the Blockchain Platform resource in Oracle Cloud Infrastructure Blockchain service.
//
// Creates a new Blockchain Platform.
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
// 		_, err := oci.NewBlockchainBlockchainPlatform(ctx, "testBlockchainPlatform", &oci.BlockchainBlockchainPlatformArgs{
// 			CompartmentId:     pulumi.Any(_var.Compartment_id),
// 			ComputeShape:      pulumi.Any(_var.Blockchain_platform_compute_shape),
// 			DisplayName:       pulumi.Any(_var.Blockchain_platform_display_name),
// 			IdcsAccessToken:   pulumi.Any(_var.Blockchain_platform_idcs_access_token),
// 			PlatformRole:      pulumi.Any(_var.Blockchain_platform_platform_role),
// 			CaCertArchiveText: pulumi.Any(_var.Blockchain_platform_ca_cert_archive_text),
// 			DefinedTags: pulumi.AnyMap{
// 				"foo-namespace.bar-key": pulumi.Any("value"),
// 			},
// 			Description:     pulumi.Any(_var.Blockchain_platform_description),
// 			FederatedUserId: pulumi.Any(oci_identity_user.Test_user.Id),
// 			FreeformTags: pulumi.AnyMap{
// 				"bar-key": pulumi.Any("value"),
// 			},
// 			IsByol: pulumi.Any(_var.Blockchain_platform_is_byol),
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
// BlockchainPlatforms can be imported using the `id`, e.g.
//
// ```sh
//  $ pulumi import oci:index/blockchainBlockchainPlatform:BlockchainBlockchainPlatform test_blockchain_platform "id"
// ```
type BlockchainBlockchainPlatform struct {
	pulumi.CustomResourceState

	// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file. The Archive file is a zip file containing third part CA Certificates, the ca key and certificate files used when issuing enrollment certificates (ECerts) and transaction certificates (TCerts). The chainfile (if it exists) contains the certificate chain which should be trusted for this CA, where the 1st in the chain is always the root CA certificate. File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
	CaCertArchiveText pulumi.StringOutput `pulumi:"caCertArchiveText"`
	// (Updatable) Compartment Identifier
	CompartmentId pulumi.StringOutput `pulumi:"compartmentId"`
	// Blockchain Platform component details.
	ComponentDetails BlockchainBlockchainPlatformComponentDetailsOutput `pulumi:"componentDetails"`
	// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE
	ComputeShape pulumi.StringOutput `pulumi:"computeShape"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags pulumi.MapOutput `pulumi:"definedTags"`
	// (Updatable) Platform Instance Description
	Description pulumi.StringOutput `pulumi:"description"`
	// Platform Instance Display name, can be renamed
	DisplayName pulumi.StringOutput `pulumi:"displayName"`
	// Identifier for a federated user
	FederatedUserId pulumi.StringOutput `pulumi:"federatedUserId"`
	// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags pulumi.MapOutput `pulumi:"freeformTags"`
	// List of OcpuUtilization for all hosts
	HostOcpuUtilizationInfos BlockchainBlockchainPlatformHostOcpuUtilizationInfoArrayOutput `pulumi:"hostOcpuUtilizationInfos"`
	// IDCS access token with Identity Domain Administrator role
	IdcsAccessToken pulumi.StringOutput `pulumi:"idcsAccessToken"`
	// Bring your own license
	IsByol pulumi.BoolOutput `pulumi:"isByol"`
	// True for multi-AD blockchain plaforms, false for single-AD
	IsMultiAd pulumi.BoolOutput `pulumi:"isMultiAd"`
	// An message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
	LifecycleDetails pulumi.StringOutput `pulumi:"lifecycleDetails"`
	// (Updatable) Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
	LoadBalancerShape pulumi.StringOutput `pulumi:"loadBalancerShape"`
	// Role of platform - founder or participant
	PlatformRole pulumi.StringOutput `pulumi:"platformRole"`
	// Type of Platform shape - DEFAULT or CUSTOM
	PlatformShapeType pulumi.StringOutput `pulumi:"platformShapeType"`
	// Number of replicas of service components like Rest Proxy, CA and Console
	Replicas BlockchainBlockchainPlatformReplicasOutput `pulumi:"replicas"`
	// Service endpoint URL, valid post-provisioning
	ServiceEndpoint pulumi.StringOutput `pulumi:"serviceEndpoint"`
	// The version of the Platform Instance.
	ServiceVersion pulumi.StringOutput `pulumi:"serviceVersion"`
	// The current state of the Platform Instance.
	State pulumi.StringOutput `pulumi:"state"`
	// Storage size in TBs
	StorageSizeInTbs pulumi.Float64Output `pulumi:"storageSizeInTbs"`
	// Storage used in TBs
	StorageUsedInTbs pulumi.Float64Output `pulumi:"storageUsedInTbs"`
	// The time the the Platform Instance was created. An RFC3339 formatted datetime string
	TimeCreated pulumi.StringOutput `pulumi:"timeCreated"`
	// The time the Platform Instance was updated. An RFC3339 formatted datetime string
	TimeUpdated pulumi.StringOutput `pulumi:"timeUpdated"`
	// Number of total OCPUs allocated to the platform cluster
	TotalOcpuCapacity pulumi.IntOutput `pulumi:"totalOcpuCapacity"`
}

// NewBlockchainBlockchainPlatform registers a new resource with the given unique name, arguments, and options.
func NewBlockchainBlockchainPlatform(ctx *pulumi.Context,
	name string, args *BlockchainBlockchainPlatformArgs, opts ...pulumi.ResourceOption) (*BlockchainBlockchainPlatform, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CompartmentId == nil {
		return nil, errors.New("invalid value for required argument 'CompartmentId'")
	}
	if args.ComputeShape == nil {
		return nil, errors.New("invalid value for required argument 'ComputeShape'")
	}
	if args.DisplayName == nil {
		return nil, errors.New("invalid value for required argument 'DisplayName'")
	}
	if args.IdcsAccessToken == nil {
		return nil, errors.New("invalid value for required argument 'IdcsAccessToken'")
	}
	if args.PlatformRole == nil {
		return nil, errors.New("invalid value for required argument 'PlatformRole'")
	}
	var resource BlockchainBlockchainPlatform
	err := ctx.RegisterResource("oci:index/blockchainBlockchainPlatform:BlockchainBlockchainPlatform", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBlockchainBlockchainPlatform gets an existing BlockchainBlockchainPlatform resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBlockchainBlockchainPlatform(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BlockchainBlockchainPlatformState, opts ...pulumi.ResourceOption) (*BlockchainBlockchainPlatform, error) {
	var resource BlockchainBlockchainPlatform
	err := ctx.ReadResource("oci:index/blockchainBlockchainPlatform:BlockchainBlockchainPlatform", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BlockchainBlockchainPlatform resources.
type blockchainBlockchainPlatformState struct {
	// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file. The Archive file is a zip file containing third part CA Certificates, the ca key and certificate files used when issuing enrollment certificates (ECerts) and transaction certificates (TCerts). The chainfile (if it exists) contains the certificate chain which should be trusted for this CA, where the 1st in the chain is always the root CA certificate. File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
	CaCertArchiveText *string `pulumi:"caCertArchiveText"`
	// (Updatable) Compartment Identifier
	CompartmentId *string `pulumi:"compartmentId"`
	// Blockchain Platform component details.
	ComponentDetails *BlockchainBlockchainPlatformComponentDetails `pulumi:"componentDetails"`
	// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE
	ComputeShape *string `pulumi:"computeShape"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) Platform Instance Description
	Description *string `pulumi:"description"`
	// Platform Instance Display name, can be renamed
	DisplayName *string `pulumi:"displayName"`
	// Identifier for a federated user
	FederatedUserId *string `pulumi:"federatedUserId"`
	// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// List of OcpuUtilization for all hosts
	HostOcpuUtilizationInfos []BlockchainBlockchainPlatformHostOcpuUtilizationInfo `pulumi:"hostOcpuUtilizationInfos"`
	// IDCS access token with Identity Domain Administrator role
	IdcsAccessToken *string `pulumi:"idcsAccessToken"`
	// Bring your own license
	IsByol *bool `pulumi:"isByol"`
	// True for multi-AD blockchain plaforms, false for single-AD
	IsMultiAd *bool `pulumi:"isMultiAd"`
	// An message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
	LifecycleDetails *string `pulumi:"lifecycleDetails"`
	// (Updatable) Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
	LoadBalancerShape *string `pulumi:"loadBalancerShape"`
	// Role of platform - founder or participant
	PlatformRole *string `pulumi:"platformRole"`
	// Type of Platform shape - DEFAULT or CUSTOM
	PlatformShapeType *string `pulumi:"platformShapeType"`
	// Number of replicas of service components like Rest Proxy, CA and Console
	Replicas *BlockchainBlockchainPlatformReplicas `pulumi:"replicas"`
	// Service endpoint URL, valid post-provisioning
	ServiceEndpoint *string `pulumi:"serviceEndpoint"`
	// The version of the Platform Instance.
	ServiceVersion *string `pulumi:"serviceVersion"`
	// The current state of the Platform Instance.
	State *string `pulumi:"state"`
	// Storage size in TBs
	StorageSizeInTbs *float64 `pulumi:"storageSizeInTbs"`
	// Storage used in TBs
	StorageUsedInTbs *float64 `pulumi:"storageUsedInTbs"`
	// The time the the Platform Instance was created. An RFC3339 formatted datetime string
	TimeCreated *string `pulumi:"timeCreated"`
	// The time the Platform Instance was updated. An RFC3339 formatted datetime string
	TimeUpdated *string `pulumi:"timeUpdated"`
	// Number of total OCPUs allocated to the platform cluster
	TotalOcpuCapacity *int `pulumi:"totalOcpuCapacity"`
}

type BlockchainBlockchainPlatformState struct {
	// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file. The Archive file is a zip file containing third part CA Certificates, the ca key and certificate files used when issuing enrollment certificates (ECerts) and transaction certificates (TCerts). The chainfile (if it exists) contains the certificate chain which should be trusted for this CA, where the 1st in the chain is always the root CA certificate. File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
	CaCertArchiveText pulumi.StringPtrInput
	// (Updatable) Compartment Identifier
	CompartmentId pulumi.StringPtrInput
	// Blockchain Platform component details.
	ComponentDetails BlockchainBlockchainPlatformComponentDetailsPtrInput
	// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE
	ComputeShape pulumi.StringPtrInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags pulumi.MapInput
	// (Updatable) Platform Instance Description
	Description pulumi.StringPtrInput
	// Platform Instance Display name, can be renamed
	DisplayName pulumi.StringPtrInput
	// Identifier for a federated user
	FederatedUserId pulumi.StringPtrInput
	// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags pulumi.MapInput
	// List of OcpuUtilization for all hosts
	HostOcpuUtilizationInfos BlockchainBlockchainPlatformHostOcpuUtilizationInfoArrayInput
	// IDCS access token with Identity Domain Administrator role
	IdcsAccessToken pulumi.StringPtrInput
	// Bring your own license
	IsByol pulumi.BoolPtrInput
	// True for multi-AD blockchain plaforms, false for single-AD
	IsMultiAd pulumi.BoolPtrInput
	// An message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
	LifecycleDetails pulumi.StringPtrInput
	// (Updatable) Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
	LoadBalancerShape pulumi.StringPtrInput
	// Role of platform - founder or participant
	PlatformRole pulumi.StringPtrInput
	// Type of Platform shape - DEFAULT or CUSTOM
	PlatformShapeType pulumi.StringPtrInput
	// Number of replicas of service components like Rest Proxy, CA and Console
	Replicas BlockchainBlockchainPlatformReplicasPtrInput
	// Service endpoint URL, valid post-provisioning
	ServiceEndpoint pulumi.StringPtrInput
	// The version of the Platform Instance.
	ServiceVersion pulumi.StringPtrInput
	// The current state of the Platform Instance.
	State pulumi.StringPtrInput
	// Storage size in TBs
	StorageSizeInTbs pulumi.Float64PtrInput
	// Storage used in TBs
	StorageUsedInTbs pulumi.Float64PtrInput
	// The time the the Platform Instance was created. An RFC3339 formatted datetime string
	TimeCreated pulumi.StringPtrInput
	// The time the Platform Instance was updated. An RFC3339 formatted datetime string
	TimeUpdated pulumi.StringPtrInput
	// Number of total OCPUs allocated to the platform cluster
	TotalOcpuCapacity pulumi.IntPtrInput
}

func (BlockchainBlockchainPlatformState) ElementType() reflect.Type {
	return reflect.TypeOf((*blockchainBlockchainPlatformState)(nil)).Elem()
}

type blockchainBlockchainPlatformArgs struct {
	// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file. The Archive file is a zip file containing third part CA Certificates, the ca key and certificate files used when issuing enrollment certificates (ECerts) and transaction certificates (TCerts). The chainfile (if it exists) contains the certificate chain which should be trusted for this CA, where the 1st in the chain is always the root CA certificate. File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
	CaCertArchiveText *string `pulumi:"caCertArchiveText"`
	// (Updatable) Compartment Identifier
	CompartmentId string `pulumi:"compartmentId"`
	// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE
	ComputeShape string `pulumi:"computeShape"`
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags map[string]interface{} `pulumi:"definedTags"`
	// (Updatable) Platform Instance Description
	Description *string `pulumi:"description"`
	// Platform Instance Display name, can be renamed
	DisplayName string `pulumi:"displayName"`
	// Identifier for a federated user
	FederatedUserId *string `pulumi:"federatedUserId"`
	// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags map[string]interface{} `pulumi:"freeformTags"`
	// IDCS access token with Identity Domain Administrator role
	IdcsAccessToken string `pulumi:"idcsAccessToken"`
	// Bring your own license
	IsByol *bool `pulumi:"isByol"`
	// (Updatable) Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
	LoadBalancerShape *string `pulumi:"loadBalancerShape"`
	// Role of platform - founder or participant
	PlatformRole string `pulumi:"platformRole"`
	// Number of replicas of service components like Rest Proxy, CA and Console
	Replicas *BlockchainBlockchainPlatformReplicas `pulumi:"replicas"`
	// Storage size in TBs
	StorageSizeInTbs *float64 `pulumi:"storageSizeInTbs"`
	// Number of total OCPUs allocated to the platform cluster
	TotalOcpuCapacity *int `pulumi:"totalOcpuCapacity"`
}

// The set of arguments for constructing a BlockchainBlockchainPlatform resource.
type BlockchainBlockchainPlatformArgs struct {
	// Base64 encoded text in ASCII character set of a Thirdparty CA Certificates archive file. The Archive file is a zip file containing third part CA Certificates, the ca key and certificate files used when issuing enrollment certificates (ECerts) and transaction certificates (TCerts). The chainfile (if it exists) contains the certificate chain which should be trusted for this CA, where the 1st in the chain is always the root CA certificate. File list in zip file [ca-cert.pem,ca-key.pem,ca-chain.pem(optional)].
	CaCertArchiveText pulumi.StringPtrInput
	// (Updatable) Compartment Identifier
	CompartmentId pulumi.StringInput
	// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE
	ComputeShape pulumi.StringInput
	// (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. Example: `{"foo-namespace.bar-key": "value"}`
	DefinedTags pulumi.MapInput
	// (Updatable) Platform Instance Description
	Description pulumi.StringPtrInput
	// Platform Instance Display name, can be renamed
	DisplayName pulumi.StringInput
	// Identifier for a federated user
	FederatedUserId pulumi.StringPtrInput
	// (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
	FreeformTags pulumi.MapInput
	// IDCS access token with Identity Domain Administrator role
	IdcsAccessToken pulumi.StringInput
	// Bring your own license
	IsByol pulumi.BoolPtrInput
	// (Updatable) Type of Load Balancer shape - LB_100_MBPS or LB_400_MBPS. Default is LB_100_MBPS.
	LoadBalancerShape pulumi.StringPtrInput
	// Role of platform - founder or participant
	PlatformRole pulumi.StringInput
	// Number of replicas of service components like Rest Proxy, CA and Console
	Replicas BlockchainBlockchainPlatformReplicasPtrInput
	// Storage size in TBs
	StorageSizeInTbs pulumi.Float64PtrInput
	// Number of total OCPUs allocated to the platform cluster
	TotalOcpuCapacity pulumi.IntPtrInput
}

func (BlockchainBlockchainPlatformArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*blockchainBlockchainPlatformArgs)(nil)).Elem()
}

type BlockchainBlockchainPlatformInput interface {
	pulumi.Input

	ToBlockchainBlockchainPlatformOutput() BlockchainBlockchainPlatformOutput
	ToBlockchainBlockchainPlatformOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformOutput
}

func (*BlockchainBlockchainPlatform) ElementType() reflect.Type {
	return reflect.TypeOf((*BlockchainBlockchainPlatform)(nil))
}

func (i *BlockchainBlockchainPlatform) ToBlockchainBlockchainPlatformOutput() BlockchainBlockchainPlatformOutput {
	return i.ToBlockchainBlockchainPlatformOutputWithContext(context.Background())
}

func (i *BlockchainBlockchainPlatform) ToBlockchainBlockchainPlatformOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlockchainBlockchainPlatformOutput)
}

func (i *BlockchainBlockchainPlatform) ToBlockchainBlockchainPlatformPtrOutput() BlockchainBlockchainPlatformPtrOutput {
	return i.ToBlockchainBlockchainPlatformPtrOutputWithContext(context.Background())
}

func (i *BlockchainBlockchainPlatform) ToBlockchainBlockchainPlatformPtrOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlockchainBlockchainPlatformPtrOutput)
}

type BlockchainBlockchainPlatformPtrInput interface {
	pulumi.Input

	ToBlockchainBlockchainPlatformPtrOutput() BlockchainBlockchainPlatformPtrOutput
	ToBlockchainBlockchainPlatformPtrOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformPtrOutput
}

type blockchainBlockchainPlatformPtrType BlockchainBlockchainPlatformArgs

func (*blockchainBlockchainPlatformPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**BlockchainBlockchainPlatform)(nil))
}

func (i *blockchainBlockchainPlatformPtrType) ToBlockchainBlockchainPlatformPtrOutput() BlockchainBlockchainPlatformPtrOutput {
	return i.ToBlockchainBlockchainPlatformPtrOutputWithContext(context.Background())
}

func (i *blockchainBlockchainPlatformPtrType) ToBlockchainBlockchainPlatformPtrOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlockchainBlockchainPlatformPtrOutput)
}

// BlockchainBlockchainPlatformArrayInput is an input type that accepts BlockchainBlockchainPlatformArray and BlockchainBlockchainPlatformArrayOutput values.
// You can construct a concrete instance of `BlockchainBlockchainPlatformArrayInput` via:
//
//          BlockchainBlockchainPlatformArray{ BlockchainBlockchainPlatformArgs{...} }
type BlockchainBlockchainPlatformArrayInput interface {
	pulumi.Input

	ToBlockchainBlockchainPlatformArrayOutput() BlockchainBlockchainPlatformArrayOutput
	ToBlockchainBlockchainPlatformArrayOutputWithContext(context.Context) BlockchainBlockchainPlatformArrayOutput
}

type BlockchainBlockchainPlatformArray []BlockchainBlockchainPlatformInput

func (BlockchainBlockchainPlatformArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BlockchainBlockchainPlatform)(nil)).Elem()
}

func (i BlockchainBlockchainPlatformArray) ToBlockchainBlockchainPlatformArrayOutput() BlockchainBlockchainPlatformArrayOutput {
	return i.ToBlockchainBlockchainPlatformArrayOutputWithContext(context.Background())
}

func (i BlockchainBlockchainPlatformArray) ToBlockchainBlockchainPlatformArrayOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlockchainBlockchainPlatformArrayOutput)
}

// BlockchainBlockchainPlatformMapInput is an input type that accepts BlockchainBlockchainPlatformMap and BlockchainBlockchainPlatformMapOutput values.
// You can construct a concrete instance of `BlockchainBlockchainPlatformMapInput` via:
//
//          BlockchainBlockchainPlatformMap{ "key": BlockchainBlockchainPlatformArgs{...} }
type BlockchainBlockchainPlatformMapInput interface {
	pulumi.Input

	ToBlockchainBlockchainPlatformMapOutput() BlockchainBlockchainPlatformMapOutput
	ToBlockchainBlockchainPlatformMapOutputWithContext(context.Context) BlockchainBlockchainPlatformMapOutput
}

type BlockchainBlockchainPlatformMap map[string]BlockchainBlockchainPlatformInput

func (BlockchainBlockchainPlatformMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BlockchainBlockchainPlatform)(nil)).Elem()
}

func (i BlockchainBlockchainPlatformMap) ToBlockchainBlockchainPlatformMapOutput() BlockchainBlockchainPlatformMapOutput {
	return i.ToBlockchainBlockchainPlatformMapOutputWithContext(context.Background())
}

func (i BlockchainBlockchainPlatformMap) ToBlockchainBlockchainPlatformMapOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BlockchainBlockchainPlatformMapOutput)
}

type BlockchainBlockchainPlatformOutput struct {
	*pulumi.OutputState
}

func (BlockchainBlockchainPlatformOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*BlockchainBlockchainPlatform)(nil))
}

func (o BlockchainBlockchainPlatformOutput) ToBlockchainBlockchainPlatformOutput() BlockchainBlockchainPlatformOutput {
	return o
}

func (o BlockchainBlockchainPlatformOutput) ToBlockchainBlockchainPlatformOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformOutput {
	return o
}

func (o BlockchainBlockchainPlatformOutput) ToBlockchainBlockchainPlatformPtrOutput() BlockchainBlockchainPlatformPtrOutput {
	return o.ToBlockchainBlockchainPlatformPtrOutputWithContext(context.Background())
}

func (o BlockchainBlockchainPlatformOutput) ToBlockchainBlockchainPlatformPtrOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformPtrOutput {
	return o.ApplyT(func(v BlockchainBlockchainPlatform) *BlockchainBlockchainPlatform {
		return &v
	}).(BlockchainBlockchainPlatformPtrOutput)
}

type BlockchainBlockchainPlatformPtrOutput struct {
	*pulumi.OutputState
}

func (BlockchainBlockchainPlatformPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BlockchainBlockchainPlatform)(nil))
}

func (o BlockchainBlockchainPlatformPtrOutput) ToBlockchainBlockchainPlatformPtrOutput() BlockchainBlockchainPlatformPtrOutput {
	return o
}

func (o BlockchainBlockchainPlatformPtrOutput) ToBlockchainBlockchainPlatformPtrOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformPtrOutput {
	return o
}

type BlockchainBlockchainPlatformArrayOutput struct{ *pulumi.OutputState }

func (BlockchainBlockchainPlatformArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]BlockchainBlockchainPlatform)(nil))
}

func (o BlockchainBlockchainPlatformArrayOutput) ToBlockchainBlockchainPlatformArrayOutput() BlockchainBlockchainPlatformArrayOutput {
	return o
}

func (o BlockchainBlockchainPlatformArrayOutput) ToBlockchainBlockchainPlatformArrayOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformArrayOutput {
	return o
}

func (o BlockchainBlockchainPlatformArrayOutput) Index(i pulumi.IntInput) BlockchainBlockchainPlatformOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) BlockchainBlockchainPlatform {
		return vs[0].([]BlockchainBlockchainPlatform)[vs[1].(int)]
	}).(BlockchainBlockchainPlatformOutput)
}

type BlockchainBlockchainPlatformMapOutput struct{ *pulumi.OutputState }

func (BlockchainBlockchainPlatformMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]BlockchainBlockchainPlatform)(nil))
}

func (o BlockchainBlockchainPlatformMapOutput) ToBlockchainBlockchainPlatformMapOutput() BlockchainBlockchainPlatformMapOutput {
	return o
}

func (o BlockchainBlockchainPlatformMapOutput) ToBlockchainBlockchainPlatformMapOutputWithContext(ctx context.Context) BlockchainBlockchainPlatformMapOutput {
	return o
}

func (o BlockchainBlockchainPlatformMapOutput) MapIndex(k pulumi.StringInput) BlockchainBlockchainPlatformOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) BlockchainBlockchainPlatform {
		return vs[0].(map[string]BlockchainBlockchainPlatform)[vs[1].(string)]
	}).(BlockchainBlockchainPlatformOutput)
}

func init() {
	pulumi.RegisterOutputType(BlockchainBlockchainPlatformOutput{})
	pulumi.RegisterOutputType(BlockchainBlockchainPlatformPtrOutput{})
	pulumi.RegisterOutputType(BlockchainBlockchainPlatformArrayOutput{})
	pulumi.RegisterOutputType(BlockchainBlockchainPlatformMapOutput{})
}