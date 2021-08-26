# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['PingMonitorArgs', 'PingMonitor']

@pulumi.input_type
class PingMonitorArgs:
    def __init__(__self__, *,
                 compartment_id: pulumi.Input[str],
                 display_name: pulumi.Input[str],
                 interval_in_seconds: pulumi.Input[int],
                 protocol: pulumi.Input[str],
                 targets: pulumi.Input[Sequence[pulumi.Input[str]]],
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[int]] = None,
                 vantage_point_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a PingMonitor resource.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment.
        :param pulumi.Input[str] display_name: (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        :param pulumi.Input[int] interval_in_seconds: (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        :param pulumi.Input[str] protocol: (Updatable) The protocols for ping probes.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] targets: (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        :param pulumi.Input[bool] is_enabled: (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        :param pulumi.Input[int] port: (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        :param pulumi.Input[int] timeout_in_seconds: (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vantage_point_names: (Updatable) A list of names of vantage points from which to execute the probe.
        """
        pulumi.set(__self__, "compartment_id", compartment_id)
        pulumi.set(__self__, "display_name", display_name)
        pulumi.set(__self__, "interval_in_seconds", interval_in_seconds)
        pulumi.set(__self__, "protocol", protocol)
        pulumi.set(__self__, "targets", targets)
        if defined_tags is not None:
            pulumi.set(__self__, "defined_tags", defined_tags)
        if freeform_tags is not None:
            pulumi.set(__self__, "freeform_tags", freeform_tags)
        if is_enabled is not None:
            pulumi.set(__self__, "is_enabled", is_enabled)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if timeout_in_seconds is not None:
            pulumi.set(__self__, "timeout_in_seconds", timeout_in_seconds)
        if vantage_point_names is not None:
            pulumi.set(__self__, "vantage_point_names", vantage_point_names)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> pulumi.Input[str]:
        """
        (Updatable) The OCID of the compartment.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Input[str]:
        """
        (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="intervalInSeconds")
    def interval_in_seconds(self) -> pulumi.Input[int]:
        """
        (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        """
        return pulumi.get(self, "interval_in_seconds")

    @interval_in_seconds.setter
    def interval_in_seconds(self, value: pulumi.Input[int]):
        pulumi.set(self, "interval_in_seconds", value)

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Input[str]:
        """
        (Updatable) The protocols for ping probes.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: pulumi.Input[str]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter
    def targets(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        """
        return pulumi.get(self, "targets")

    @targets.setter
    def targets(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "targets", value)

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        """
        return pulumi.get(self, "defined_tags")

    @defined_tags.setter
    def defined_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "defined_tags", value)

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        """
        return pulumi.get(self, "freeform_tags")

    @freeform_tags.setter
    def freeform_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "freeform_tags", value)

    @property
    @pulumi.getter(name="isEnabled")
    def is_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        """
        return pulumi.get(self, "is_enabled")

    @is_enabled.setter
    def is_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_enabled", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="timeoutInSeconds")
    def timeout_in_seconds(self) -> Optional[pulumi.Input[int]]:
        """
        (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        """
        return pulumi.get(self, "timeout_in_seconds")

    @timeout_in_seconds.setter
    def timeout_in_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "timeout_in_seconds", value)

    @property
    @pulumi.getter(name="vantagePointNames")
    def vantage_point_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        (Updatable) A list of names of vantage points from which to execute the probe.
        """
        return pulumi.get(self, "vantage_point_names")

    @vantage_point_names.setter
    def vantage_point_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "vantage_point_names", value)


@pulumi.input_type
class _PingMonitorState:
    def __init__(__self__, *,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 home_region: Optional[pulumi.Input[str]] = None,
                 interval_in_seconds: Optional[pulumi.Input[int]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 results_url: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 time_created: Optional[pulumi.Input[str]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[int]] = None,
                 vantage_point_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering PingMonitor resources.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        :param pulumi.Input[str] display_name: (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        :param pulumi.Input[str] home_region: The region where updates must be made and where results must be fetched from.
        :param pulumi.Input[int] interval_in_seconds: (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        :param pulumi.Input[bool] is_enabled: (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        :param pulumi.Input[int] port: (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        :param pulumi.Input[str] protocol: (Updatable) The protocols for ping probes.
        :param pulumi.Input[str] results_url: A URL for fetching the probe results.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] targets: (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        :param pulumi.Input[str] time_created: The RFC 3339-formatted creation date and time of the probe.
        :param pulumi.Input[int] timeout_in_seconds: (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vantage_point_names: (Updatable) A list of names of vantage points from which to execute the probe.
        """
        if compartment_id is not None:
            pulumi.set(__self__, "compartment_id", compartment_id)
        if defined_tags is not None:
            pulumi.set(__self__, "defined_tags", defined_tags)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if freeform_tags is not None:
            pulumi.set(__self__, "freeform_tags", freeform_tags)
        if home_region is not None:
            pulumi.set(__self__, "home_region", home_region)
        if interval_in_seconds is not None:
            pulumi.set(__self__, "interval_in_seconds", interval_in_seconds)
        if is_enabled is not None:
            pulumi.set(__self__, "is_enabled", is_enabled)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if results_url is not None:
            pulumi.set(__self__, "results_url", results_url)
        if targets is not None:
            pulumi.set(__self__, "targets", targets)
        if time_created is not None:
            pulumi.set(__self__, "time_created", time_created)
        if timeout_in_seconds is not None:
            pulumi.set(__self__, "timeout_in_seconds", timeout_in_seconds)
        if vantage_point_names is not None:
            pulumi.set(__self__, "vantage_point_names", vantage_point_names)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The OCID of the compartment.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        """
        return pulumi.get(self, "defined_tags")

    @defined_tags.setter
    def defined_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "defined_tags", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        """
        return pulumi.get(self, "freeform_tags")

    @freeform_tags.setter
    def freeform_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "freeform_tags", value)

    @property
    @pulumi.getter(name="homeRegion")
    def home_region(self) -> Optional[pulumi.Input[str]]:
        """
        The region where updates must be made and where results must be fetched from.
        """
        return pulumi.get(self, "home_region")

    @home_region.setter
    def home_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "home_region", value)

    @property
    @pulumi.getter(name="intervalInSeconds")
    def interval_in_seconds(self) -> Optional[pulumi.Input[int]]:
        """
        (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        """
        return pulumi.get(self, "interval_in_seconds")

    @interval_in_seconds.setter
    def interval_in_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "interval_in_seconds", value)

    @property
    @pulumi.getter(name="isEnabled")
    def is_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        """
        return pulumi.get(self, "is_enabled")

    @is_enabled.setter
    def is_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_enabled", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The protocols for ping probes.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="resultsUrl")
    def results_url(self) -> Optional[pulumi.Input[str]]:
        """
        A URL for fetching the probe results.
        """
        return pulumi.get(self, "results_url")

    @results_url.setter
    def results_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "results_url", value)

    @property
    @pulumi.getter
    def targets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        """
        return pulumi.get(self, "targets")

    @targets.setter
    def targets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "targets", value)

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> Optional[pulumi.Input[str]]:
        """
        The RFC 3339-formatted creation date and time of the probe.
        """
        return pulumi.get(self, "time_created")

    @time_created.setter
    def time_created(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_created", value)

    @property
    @pulumi.getter(name="timeoutInSeconds")
    def timeout_in_seconds(self) -> Optional[pulumi.Input[int]]:
        """
        (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        """
        return pulumi.get(self, "timeout_in_seconds")

    @timeout_in_seconds.setter
    def timeout_in_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "timeout_in_seconds", value)

    @property
    @pulumi.getter(name="vantagePointNames")
    def vantage_point_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        (Updatable) A list of names of vantage points from which to execute the probe.
        """
        return pulumi.get(self, "vantage_point_names")

    @vantage_point_names.setter
    def vantage_point_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "vantage_point_names", value)


class PingMonitor(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 interval_in_seconds: Optional[pulumi.Input[int]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[int]] = None,
                 vantage_point_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        This resource provides the Ping Monitor resource in Oracle Cloud Infrastructure Health Checks service.

        Creates a ping monitor. Vantage points will be automatically selected if not specified,
        and probes will be initiated from each vantage point to each of the targets at the frequency
        specified by `intervalInSeconds`.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_ping_monitor = oci.healthchecks.PingMonitor("testPingMonitor",
            compartment_id=var["compartment_id"],
            display_name=var["ping_monitor_display_name"],
            interval_in_seconds=var["ping_monitor_interval_in_seconds"],
            protocol=var["ping_monitor_protocol"],
            targets=var["ping_monitor_targets"],
            defined_tags={
                "Operations.CostCenter": "42",
            },
            freeform_tags={
                "Department": "Finance",
            },
            is_enabled=var["ping_monitor_is_enabled"],
            port=var["ping_monitor_port"],
            timeout_in_seconds=var["ping_monitor_timeout_in_seconds"],
            vantage_point_names=var["ping_monitor_vantage_point_names"])
        ```

        ## Import

        PingMonitors can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:healthchecks/pingMonitor:PingMonitor test_ping_monitor "id"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        :param pulumi.Input[str] display_name: (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        :param pulumi.Input[int] interval_in_seconds: (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        :param pulumi.Input[bool] is_enabled: (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        :param pulumi.Input[int] port: (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        :param pulumi.Input[str] protocol: (Updatable) The protocols for ping probes.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] targets: (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        :param pulumi.Input[int] timeout_in_seconds: (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vantage_point_names: (Updatable) A list of names of vantage points from which to execute the probe.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: PingMonitorArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource provides the Ping Monitor resource in Oracle Cloud Infrastructure Health Checks service.

        Creates a ping monitor. Vantage points will be automatically selected if not specified,
        and probes will be initiated from each vantage point to each of the targets at the frequency
        specified by `intervalInSeconds`.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_ping_monitor = oci.healthchecks.PingMonitor("testPingMonitor",
            compartment_id=var["compartment_id"],
            display_name=var["ping_monitor_display_name"],
            interval_in_seconds=var["ping_monitor_interval_in_seconds"],
            protocol=var["ping_monitor_protocol"],
            targets=var["ping_monitor_targets"],
            defined_tags={
                "Operations.CostCenter": "42",
            },
            freeform_tags={
                "Department": "Finance",
            },
            is_enabled=var["ping_monitor_is_enabled"],
            port=var["ping_monitor_port"],
            timeout_in_seconds=var["ping_monitor_timeout_in_seconds"],
            vantage_point_names=var["ping_monitor_vantage_point_names"])
        ```

        ## Import

        PingMonitors can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:healthchecks/pingMonitor:PingMonitor test_ping_monitor "id"
        ```

        :param str resource_name: The name of the resource.
        :param PingMonitorArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PingMonitorArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 interval_in_seconds: Optional[pulumi.Input[int]] = None,
                 is_enabled: Optional[pulumi.Input[bool]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 targets: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 timeout_in_seconds: Optional[pulumi.Input[int]] = None,
                 vantage_point_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PingMonitorArgs.__new__(PingMonitorArgs)

            if compartment_id is None and not opts.urn:
                raise TypeError("Missing required property 'compartment_id'")
            __props__.__dict__["compartment_id"] = compartment_id
            __props__.__dict__["defined_tags"] = defined_tags
            if display_name is None and not opts.urn:
                raise TypeError("Missing required property 'display_name'")
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["freeform_tags"] = freeform_tags
            if interval_in_seconds is None and not opts.urn:
                raise TypeError("Missing required property 'interval_in_seconds'")
            __props__.__dict__["interval_in_seconds"] = interval_in_seconds
            __props__.__dict__["is_enabled"] = is_enabled
            __props__.__dict__["port"] = port
            if protocol is None and not opts.urn:
                raise TypeError("Missing required property 'protocol'")
            __props__.__dict__["protocol"] = protocol
            if targets is None and not opts.urn:
                raise TypeError("Missing required property 'targets'")
            __props__.__dict__["targets"] = targets
            __props__.__dict__["timeout_in_seconds"] = timeout_in_seconds
            __props__.__dict__["vantage_point_names"] = vantage_point_names
            __props__.__dict__["home_region"] = None
            __props__.__dict__["results_url"] = None
            __props__.__dict__["time_created"] = None
        super(PingMonitor, __self__).__init__(
            'oci:healthchecks/pingMonitor:PingMonitor',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            compartment_id: Optional[pulumi.Input[str]] = None,
            defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            home_region: Optional[pulumi.Input[str]] = None,
            interval_in_seconds: Optional[pulumi.Input[int]] = None,
            is_enabled: Optional[pulumi.Input[bool]] = None,
            port: Optional[pulumi.Input[int]] = None,
            protocol: Optional[pulumi.Input[str]] = None,
            results_url: Optional[pulumi.Input[str]] = None,
            targets: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            time_created: Optional[pulumi.Input[str]] = None,
            timeout_in_seconds: Optional[pulumi.Input[int]] = None,
            vantage_point_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'PingMonitor':
        """
        Get an existing PingMonitor resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        :param pulumi.Input[str] display_name: (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        :param pulumi.Input[str] home_region: The region where updates must be made and where results must be fetched from.
        :param pulumi.Input[int] interval_in_seconds: (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        :param pulumi.Input[bool] is_enabled: (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        :param pulumi.Input[int] port: (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        :param pulumi.Input[str] protocol: (Updatable) The protocols for ping probes.
        :param pulumi.Input[str] results_url: A URL for fetching the probe results.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] targets: (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        :param pulumi.Input[str] time_created: The RFC 3339-formatted creation date and time of the probe.
        :param pulumi.Input[int] timeout_in_seconds: (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vantage_point_names: (Updatable) A list of names of vantage points from which to execute the probe.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PingMonitorState.__new__(_PingMonitorState)

        __props__.__dict__["compartment_id"] = compartment_id
        __props__.__dict__["defined_tags"] = defined_tags
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["freeform_tags"] = freeform_tags
        __props__.__dict__["home_region"] = home_region
        __props__.__dict__["interval_in_seconds"] = interval_in_seconds
        __props__.__dict__["is_enabled"] = is_enabled
        __props__.__dict__["port"] = port
        __props__.__dict__["protocol"] = protocol
        __props__.__dict__["results_url"] = results_url
        __props__.__dict__["targets"] = targets
        __props__.__dict__["time_created"] = time_created
        __props__.__dict__["timeout_in_seconds"] = timeout_in_seconds
        __props__.__dict__["vantage_point_names"] = vantage_point_names
        return PingMonitor(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> pulumi.Output[str]:
        """
        (Updatable) The OCID of the compartment.
        """
        return pulumi.get(self, "compartment_id")

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Operations.CostCenter": "42"}`
        """
        return pulumi.get(self, "defined_tags")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        (Updatable) A user-friendly and mutable name suitable for display in a user interface.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        (Updatable) Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.  For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm). Example: `{"Department": "Finance"}`
        """
        return pulumi.get(self, "freeform_tags")

    @property
    @pulumi.getter(name="homeRegion")
    def home_region(self) -> pulumi.Output[str]:
        """
        The region where updates must be made and where results must be fetched from.
        """
        return pulumi.get(self, "home_region")

    @property
    @pulumi.getter(name="intervalInSeconds")
    def interval_in_seconds(self) -> pulumi.Output[int]:
        """
        (Updatable) The monitor interval in seconds. Valid values: 10, 30, and 60.
        """
        return pulumi.get(self, "interval_in_seconds")

    @property
    @pulumi.getter(name="isEnabled")
    def is_enabled(self) -> pulumi.Output[bool]:
        """
        (Updatable) Enables or disables the monitor. Set to 'true' to launch monitoring.
        """
        return pulumi.get(self, "is_enabled")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[int]:
        """
        (Updatable) The port on which to probe endpoints. If unspecified, probes will use the default port of their protocol.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[str]:
        """
        (Updatable) The protocols for ping probes.
        """
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter(name="resultsUrl")
    def results_url(self) -> pulumi.Output[str]:
        """
        A URL for fetching the probe results.
        """
        return pulumi.get(self, "results_url")

    @property
    @pulumi.getter
    def targets(self) -> pulumi.Output[Sequence[str]]:
        """
        (Updatable) A list of targets (hostnames or IP addresses) of the probe.
        """
        return pulumi.get(self, "targets")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        The RFC 3339-formatted creation date and time of the probe.
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter(name="timeoutInSeconds")
    def timeout_in_seconds(self) -> pulumi.Output[int]:
        """
        (Updatable) The probe timeout in seconds. Valid values: 10, 20, 30, and 60. The probe timeout must be less than or equal to `intervalInSeconds` for monitors.
        """
        return pulumi.get(self, "timeout_in_seconds")

    @property
    @pulumi.getter(name="vantagePointNames")
    def vantage_point_names(self) -> pulumi.Output[Sequence[str]]:
        """
        (Updatable) A list of names of vantage points from which to execute the probe.
        """
        return pulumi.get(self, "vantage_point_names")
