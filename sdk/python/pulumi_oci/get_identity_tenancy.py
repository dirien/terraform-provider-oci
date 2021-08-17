# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetIdentityTenancyResult',
    'AwaitableGetIdentityTenancyResult',
    'get_identity_tenancy',
]

@pulumi.output_type
class GetIdentityTenancyResult:
    """
    A collection of values returned by GetIdentityTenancy.
    """
    def __init__(__self__, defined_tags=None, description=None, freeform_tags=None, home_region_key=None, id=None, name=None, tenancy_id=None, upi_idcs_compatibility_layer_endpoint=None):
        if defined_tags and not isinstance(defined_tags, dict):
            raise TypeError("Expected argument 'defined_tags' to be a dict")
        pulumi.set(__self__, "defined_tags", defined_tags)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if freeform_tags and not isinstance(freeform_tags, dict):
            raise TypeError("Expected argument 'freeform_tags' to be a dict")
        pulumi.set(__self__, "freeform_tags", freeform_tags)
        if home_region_key and not isinstance(home_region_key, str):
            raise TypeError("Expected argument 'home_region_key' to be a str")
        pulumi.set(__self__, "home_region_key", home_region_key)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if tenancy_id and not isinstance(tenancy_id, str):
            raise TypeError("Expected argument 'tenancy_id' to be a str")
        pulumi.set(__self__, "tenancy_id", tenancy_id)
        if upi_idcs_compatibility_layer_endpoint and not isinstance(upi_idcs_compatibility_layer_endpoint, str):
            raise TypeError("Expected argument 'upi_idcs_compatibility_layer_endpoint' to be a str")
        pulumi.set(__self__, "upi_idcs_compatibility_layer_endpoint", upi_idcs_compatibility_layer_endpoint)

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> Mapping[str, Any]:
        """
        Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        """
        return pulumi.get(self, "defined_tags")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The description of the tenancy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> Mapping[str, Any]:
        """
        Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        """
        return pulumi.get(self, "freeform_tags")

    @property
    @pulumi.getter(name="homeRegionKey")
    def home_region_key(self) -> str:
        """
        The region key for the tenancy's home region. For the full list of supported regions, see [Regions and Availability Domains](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/regions.htm).  Example: `PHX`
        """
        return pulumi.get(self, "home_region_key")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The name of the tenancy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="tenancyId")
    def tenancy_id(self) -> str:
        return pulumi.get(self, "tenancy_id")

    @property
    @pulumi.getter(name="upiIdcsCompatibilityLayerEndpoint")
    def upi_idcs_compatibility_layer_endpoint(self) -> str:
        """
        Url which refers to the UPI IDCS compatibility layer endpoint configured for this Tenant's home region.
        """
        return pulumi.get(self, "upi_idcs_compatibility_layer_endpoint")


class AwaitableGetIdentityTenancyResult(GetIdentityTenancyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIdentityTenancyResult(
            defined_tags=self.defined_tags,
            description=self.description,
            freeform_tags=self.freeform_tags,
            home_region_key=self.home_region_key,
            id=self.id,
            name=self.name,
            tenancy_id=self.tenancy_id,
            upi_idcs_compatibility_layer_endpoint=self.upi_idcs_compatibility_layer_endpoint)


def get_identity_tenancy(tenancy_id: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIdentityTenancyResult:
    """
    This data source provides details about a specific Tenancy resource in Oracle Cloud Infrastructure Identity service.

    Get the specified tenancy's information.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_oci as oci

    test_tenancy = oci.get_identity_tenancy(tenancy_id=var["tenancy_ocid"])
    ```


    :param str tenancy_id: The OCID of the tenancy.
    """
    __args__ = dict()
    __args__['tenancyId'] = tenancy_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('oci:index/getIdentityTenancy:GetIdentityTenancy', __args__, opts=opts, typ=GetIdentityTenancyResult).value

    return AwaitableGetIdentityTenancyResult(
        defined_tags=__ret__.defined_tags,
        description=__ret__.description,
        freeform_tags=__ret__.freeform_tags,
        home_region_key=__ret__.home_region_key,
        id=__ret__.id,
        name=__ret__.name,
        tenancy_id=__ret__.tenancy_id,
        upi_idcs_compatibility_layer_endpoint=__ret__.upi_idcs_compatibility_layer_endpoint)