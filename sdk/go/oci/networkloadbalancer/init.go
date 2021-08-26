// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package networkloadbalancer

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-oci/sdk/go/oci"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "oci:networkloadbalancer/backend:Backend":
		r = &Backend{}
	case "oci:networkloadbalancer/backendSet:BackendSet":
		r = &BackendSet{}
	case "oci:networkloadbalancer/listener:Listener":
		r = &Listener{}
	case "oci:networkloadbalancer/networkLoadBalancer:NetworkLoadBalancer":
		r = &NetworkLoadBalancer{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := oci.PkgVersion()
	if err != nil {
		fmt.Printf("failed to determine package version. defaulting to v1: %v\n", err)
	}
	pulumi.RegisterResourceModule(
		"oci",
		"networkloadbalancer/backend",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"oci",
		"networkloadbalancer/backendSet",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"oci",
		"networkloadbalancer/listener",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"oci",
		"networkloadbalancer/networkLoadBalancer",
		&module{version},
	)
}