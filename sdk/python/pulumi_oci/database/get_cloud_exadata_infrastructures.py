# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetCloudExadataInfrastructuresResult',
    'AwaitableGetCloudExadataInfrastructuresResult',
    'get_cloud_exadata_infrastructures',
]

@pulumi.output_type
class GetCloudExadataInfrastructuresResult:
    """
    A collection of values returned by getCloudExadataInfrastructures.
    """
    def __init__(__self__, cloud_exadata_infrastructures=None, compartment_id=None, display_name=None, filters=None, id=None, state=None):
        if cloud_exadata_infrastructures and not isinstance(cloud_exadata_infrastructures, list):
            raise TypeError("Expected argument 'cloud_exadata_infrastructures' to be a list")
        pulumi.set(__self__, "cloud_exadata_infrastructures", cloud_exadata_infrastructures)
        if compartment_id and not isinstance(compartment_id, str):
            raise TypeError("Expected argument 'compartment_id' to be a str")
        pulumi.set(__self__, "compartment_id", compartment_id)
        if display_name and not isinstance(display_name, str):
            raise TypeError("Expected argument 'display_name' to be a str")
        pulumi.set(__self__, "display_name", display_name)
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="cloudExadataInfrastructures")
    def cloud_exadata_infrastructures(self) -> Sequence['outputs.GetCloudExadataInfrastructuresCloudExadataInfrastructureResult']:
        """
        The list of cloud_exadata_infrastructures.
        """
        return pulumi.get(self, "cloud_exadata_infrastructures")

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> str:
        """
        The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        """
        return pulumi.get(self, "compartment_id")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[str]:
        """
        The user-friendly name for the cloud Exadata infrastructure resource. The name does not need to be unique.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetCloudExadataInfrastructuresFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        """
        The current lifecycle state of the cloud Exadata infrastructure resource.
        """
        return pulumi.get(self, "state")


class AwaitableGetCloudExadataInfrastructuresResult(GetCloudExadataInfrastructuresResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCloudExadataInfrastructuresResult(
            cloud_exadata_infrastructures=self.cloud_exadata_infrastructures,
            compartment_id=self.compartment_id,
            display_name=self.display_name,
            filters=self.filters,
            id=self.id,
            state=self.state)


def get_cloud_exadata_infrastructures(compartment_id: Optional[str] = None,
                                      display_name: Optional[str] = None,
                                      filters: Optional[Sequence[pulumi.InputType['GetCloudExadataInfrastructuresFilterArgs']]] = None,
                                      state: Optional[str] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCloudExadataInfrastructuresResult:
    """
    This data source provides the list of Cloud Exadata Infrastructures in Oracle Cloud Infrastructure Database service.

    Gets a list of the cloud Exadata infrastructure resources in the specified compartment. Applies to Exadata Cloud Service instances only.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_oci as oci

    test_cloud_exadata_infrastructures = oci.database.get_cloud_exadata_infrastructures(compartment_id=var["compartment_id"],
        display_name=var["cloud_exadata_infrastructure_display_name"],
        state=var["cloud_exadata_infrastructure_state"])
    ```


    :param str compartment_id: The compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
    :param str display_name: A filter to return only resources that match the entire display name given. The match is not case sensitive.
    :param str state: A filter to return only resources that match the given lifecycle state exactly.
    """
    __args__ = dict()
    __args__['compartmentId'] = compartment_id
    __args__['displayName'] = display_name
    __args__['filters'] = filters
    __args__['state'] = state
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('oci:database/getCloudExadataInfrastructures:getCloudExadataInfrastructures', __args__, opts=opts, typ=GetCloudExadataInfrastructuresResult).value

    return AwaitableGetCloudExadataInfrastructuresResult(
        cloud_exadata_infrastructures=__ret__.cloud_exadata_infrastructures,
        compartment_id=__ret__.compartment_id,
        display_name=__ret__.display_name,
        filters=__ret__.filters,
        id=__ret__.id,
        state=__ret__.state)