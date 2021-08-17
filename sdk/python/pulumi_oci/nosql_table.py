# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['NosqlTableArgs', 'NosqlTable']

@pulumi.input_type
class NosqlTableArgs:
    def __init__(__self__, *,
                 compartment_id: pulumi.Input[str],
                 ddl_statement: pulumi.Input[str],
                 table_limits: pulumi.Input['NosqlTableTableLimitsArgs'],
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 is_auto_reclaimable: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a NosqlTable resource.
        :param pulumi.Input[str] compartment_id: (Updatable) Compartment Identifier.
        :param pulumi.Input[str] ddl_statement: (Updatable) Complete CREATE TABLE DDL statement.
        :param pulumi.Input['NosqlTableTableLimitsArgs'] table_limits: (Updatable) Throughput and storage limits configuration of a table.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        :param pulumi.Input[bool] is_auto_reclaimable: True if table can be reclaimed after an idle period.
        :param pulumi.Input[str] name: Table name.
        """
        pulumi.set(__self__, "compartment_id", compartment_id)
        pulumi.set(__self__, "ddl_statement", ddl_statement)
        pulumi.set(__self__, "table_limits", table_limits)
        if defined_tags is not None:
            pulumi.set(__self__, "defined_tags", defined_tags)
        if freeform_tags is not None:
            pulumi.set(__self__, "freeform_tags", freeform_tags)
        if is_auto_reclaimable is not None:
            pulumi.set(__self__, "is_auto_reclaimable", is_auto_reclaimable)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> pulumi.Input[str]:
        """
        (Updatable) Compartment Identifier.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter(name="ddlStatement")
    def ddl_statement(self) -> pulumi.Input[str]:
        """
        (Updatable) Complete CREATE TABLE DDL statement.
        """
        return pulumi.get(self, "ddl_statement")

    @ddl_statement.setter
    def ddl_statement(self, value: pulumi.Input[str]):
        pulumi.set(self, "ddl_statement", value)

    @property
    @pulumi.getter(name="tableLimits")
    def table_limits(self) -> pulumi.Input['NosqlTableTableLimitsArgs']:
        """
        (Updatable) Throughput and storage limits configuration of a table.
        """
        return pulumi.get(self, "table_limits")

    @table_limits.setter
    def table_limits(self, value: pulumi.Input['NosqlTableTableLimitsArgs']):
        pulumi.set(self, "table_limits", value)

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        """
        return pulumi.get(self, "defined_tags")

    @defined_tags.setter
    def defined_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "defined_tags", value)

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        """
        return pulumi.get(self, "freeform_tags")

    @freeform_tags.setter
    def freeform_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "freeform_tags", value)

    @property
    @pulumi.getter(name="isAutoReclaimable")
    def is_auto_reclaimable(self) -> Optional[pulumi.Input[bool]]:
        """
        True if table can be reclaimed after an idle period.
        """
        return pulumi.get(self, "is_auto_reclaimable")

    @is_auto_reclaimable.setter
    def is_auto_reclaimable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_auto_reclaimable", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Table name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _NosqlTableState:
    def __init__(__self__, *,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 ddl_statement: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 is_auto_reclaimable: Optional[pulumi.Input[bool]] = None,
                 lifecycle_details: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 schema: Optional[pulumi.Input['NosqlTableSchemaArgs']] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 system_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 table_limits: Optional[pulumi.Input['NosqlTableTableLimitsArgs']] = None,
                 time_created: Optional[pulumi.Input[str]] = None,
                 time_of_expiration: Optional[pulumi.Input[str]] = None,
                 time_updated: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering NosqlTable resources.
        :param pulumi.Input[str] compartment_id: (Updatable) Compartment Identifier.
        :param pulumi.Input[str] ddl_statement: (Updatable) Complete CREATE TABLE DDL statement.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        :param pulumi.Input[bool] is_auto_reclaimable: True if table can be reclaimed after an idle period.
        :param pulumi.Input[str] lifecycle_details: A message describing the current state in more detail.
        :param pulumi.Input[str] name: Table name.
        :param pulumi.Input['NosqlTableSchemaArgs'] schema: The table schema information as a JSON object.
        :param pulumi.Input[str] state: The state of a table.
        :param pulumi.Input[Mapping[str, Any]] system_tags: Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        :param pulumi.Input['NosqlTableTableLimitsArgs'] table_limits: (Updatable) Throughput and storage limits configuration of a table.
        :param pulumi.Input[str] time_created: The time the the table was created. An RFC3339 formatted datetime string.
        :param pulumi.Input[str] time_of_expiration: If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        :param pulumi.Input[str] time_updated: The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        """
        if compartment_id is not None:
            pulumi.set(__self__, "compartment_id", compartment_id)
        if ddl_statement is not None:
            pulumi.set(__self__, "ddl_statement", ddl_statement)
        if defined_tags is not None:
            pulumi.set(__self__, "defined_tags", defined_tags)
        if freeform_tags is not None:
            pulumi.set(__self__, "freeform_tags", freeform_tags)
        if is_auto_reclaimable is not None:
            pulumi.set(__self__, "is_auto_reclaimable", is_auto_reclaimable)
        if lifecycle_details is not None:
            pulumi.set(__self__, "lifecycle_details", lifecycle_details)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if schema is not None:
            pulumi.set(__self__, "schema", schema)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if system_tags is not None:
            pulumi.set(__self__, "system_tags", system_tags)
        if table_limits is not None:
            pulumi.set(__self__, "table_limits", table_limits)
        if time_created is not None:
            pulumi.set(__self__, "time_created", time_created)
        if time_of_expiration is not None:
            pulumi.set(__self__, "time_of_expiration", time_of_expiration)
        if time_updated is not None:
            pulumi.set(__self__, "time_updated", time_updated)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) Compartment Identifier.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter(name="ddlStatement")
    def ddl_statement(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) Complete CREATE TABLE DDL statement.
        """
        return pulumi.get(self, "ddl_statement")

    @ddl_statement.setter
    def ddl_statement(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ddl_statement", value)

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        """
        return pulumi.get(self, "defined_tags")

    @defined_tags.setter
    def defined_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "defined_tags", value)

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        """
        return pulumi.get(self, "freeform_tags")

    @freeform_tags.setter
    def freeform_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "freeform_tags", value)

    @property
    @pulumi.getter(name="isAutoReclaimable")
    def is_auto_reclaimable(self) -> Optional[pulumi.Input[bool]]:
        """
        True if table can be reclaimed after an idle period.
        """
        return pulumi.get(self, "is_auto_reclaimable")

    @is_auto_reclaimable.setter
    def is_auto_reclaimable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_auto_reclaimable", value)

    @property
    @pulumi.getter(name="lifecycleDetails")
    def lifecycle_details(self) -> Optional[pulumi.Input[str]]:
        """
        A message describing the current state in more detail.
        """
        return pulumi.get(self, "lifecycle_details")

    @lifecycle_details.setter
    def lifecycle_details(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "lifecycle_details", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Table name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def schema(self) -> Optional[pulumi.Input['NosqlTableSchemaArgs']]:
        """
        The table schema information as a JSON object.
        """
        return pulumi.get(self, "schema")

    @schema.setter
    def schema(self, value: Optional[pulumi.Input['NosqlTableSchemaArgs']]):
        pulumi.set(self, "schema", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        The state of a table.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter(name="systemTags")
    def system_tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        """
        return pulumi.get(self, "system_tags")

    @system_tags.setter
    def system_tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "system_tags", value)

    @property
    @pulumi.getter(name="tableLimits")
    def table_limits(self) -> Optional[pulumi.Input['NosqlTableTableLimitsArgs']]:
        """
        (Updatable) Throughput and storage limits configuration of a table.
        """
        return pulumi.get(self, "table_limits")

    @table_limits.setter
    def table_limits(self, value: Optional[pulumi.Input['NosqlTableTableLimitsArgs']]):
        pulumi.set(self, "table_limits", value)

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> Optional[pulumi.Input[str]]:
        """
        The time the the table was created. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_created")

    @time_created.setter
    def time_created(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_created", value)

    @property
    @pulumi.getter(name="timeOfExpiration")
    def time_of_expiration(self) -> Optional[pulumi.Input[str]]:
        """
        If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_of_expiration")

    @time_of_expiration.setter
    def time_of_expiration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_of_expiration", value)

    @property
    @pulumi.getter(name="timeUpdated")
    def time_updated(self) -> Optional[pulumi.Input[str]]:
        """
        The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_updated")

    @time_updated.setter
    def time_updated(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_updated", value)


class NosqlTable(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 ddl_statement: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 is_auto_reclaimable: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 table_limits: Optional[pulumi.Input[pulumi.InputType['NosqlTableTableLimitsArgs']]] = None,
                 __props__=None):
        """
        This resource provides the Table resource in Oracle Cloud Infrastructure NoSQL Database service.

        Create a new table.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_table = oci.NosqlTable("testTable",
            compartment_id=var["compartment_id"],
            ddl_statement=var["table_ddl_statement"],
            table_limits=oci.NosqlTableTableLimitsArgs(
                max_read_units=var["table_table_limits_max_read_units"],
                max_storage_in_gbs=var["table_table_limits_max_storage_in_gbs"],
                max_write_units=var["table_table_limits_max_write_units"],
            ),
            defined_tags=var["table_defined_tags"],
            freeform_tags={
                "bar-key": "value",
            },
            is_auto_reclaimable=var["table_is_auto_reclaimable"])
        ```

        ## Import

        Tables can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/nosqlTable:NosqlTable test_table "id"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) Compartment Identifier.
        :param pulumi.Input[str] ddl_statement: (Updatable) Complete CREATE TABLE DDL statement.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        :param pulumi.Input[bool] is_auto_reclaimable: True if table can be reclaimed after an idle period.
        :param pulumi.Input[str] name: Table name.
        :param pulumi.Input[pulumi.InputType['NosqlTableTableLimitsArgs']] table_limits: (Updatable) Throughput and storage limits configuration of a table.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NosqlTableArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource provides the Table resource in Oracle Cloud Infrastructure NoSQL Database service.

        Create a new table.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_table = oci.NosqlTable("testTable",
            compartment_id=var["compartment_id"],
            ddl_statement=var["table_ddl_statement"],
            table_limits=oci.NosqlTableTableLimitsArgs(
                max_read_units=var["table_table_limits_max_read_units"],
                max_storage_in_gbs=var["table_table_limits_max_storage_in_gbs"],
                max_write_units=var["table_table_limits_max_write_units"],
            ),
            defined_tags=var["table_defined_tags"],
            freeform_tags={
                "bar-key": "value",
            },
            is_auto_reclaimable=var["table_is_auto_reclaimable"])
        ```

        ## Import

        Tables can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/nosqlTable:NosqlTable test_table "id"
        ```

        :param str resource_name: The name of the resource.
        :param NosqlTableArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NosqlTableArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 ddl_statement: Optional[pulumi.Input[str]] = None,
                 defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 is_auto_reclaimable: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 table_limits: Optional[pulumi.Input[pulumi.InputType['NosqlTableTableLimitsArgs']]] = None,
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
            __props__ = NosqlTableArgs.__new__(NosqlTableArgs)

            if compartment_id is None and not opts.urn:
                raise TypeError("Missing required property 'compartment_id'")
            __props__.__dict__["compartment_id"] = compartment_id
            if ddl_statement is None and not opts.urn:
                raise TypeError("Missing required property 'ddl_statement'")
            __props__.__dict__["ddl_statement"] = ddl_statement
            __props__.__dict__["defined_tags"] = defined_tags
            __props__.__dict__["freeform_tags"] = freeform_tags
            __props__.__dict__["is_auto_reclaimable"] = is_auto_reclaimable
            __props__.__dict__["name"] = name
            if table_limits is None and not opts.urn:
                raise TypeError("Missing required property 'table_limits'")
            __props__.__dict__["table_limits"] = table_limits
            __props__.__dict__["lifecycle_details"] = None
            __props__.__dict__["schema"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["system_tags"] = None
            __props__.__dict__["time_created"] = None
            __props__.__dict__["time_of_expiration"] = None
            __props__.__dict__["time_updated"] = None
        super(NosqlTable, __self__).__init__(
            'oci:index/nosqlTable:NosqlTable',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            compartment_id: Optional[pulumi.Input[str]] = None,
            ddl_statement: Optional[pulumi.Input[str]] = None,
            defined_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            freeform_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            is_auto_reclaimable: Optional[pulumi.Input[bool]] = None,
            lifecycle_details: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            schema: Optional[pulumi.Input[pulumi.InputType['NosqlTableSchemaArgs']]] = None,
            state: Optional[pulumi.Input[str]] = None,
            system_tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            table_limits: Optional[pulumi.Input[pulumi.InputType['NosqlTableTableLimitsArgs']]] = None,
            time_created: Optional[pulumi.Input[str]] = None,
            time_of_expiration: Optional[pulumi.Input[str]] = None,
            time_updated: Optional[pulumi.Input[str]] = None) -> 'NosqlTable':
        """
        Get an existing NosqlTable resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) Compartment Identifier.
        :param pulumi.Input[str] ddl_statement: (Updatable) Complete CREATE TABLE DDL statement.
        :param pulumi.Input[Mapping[str, Any]] defined_tags: (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        :param pulumi.Input[Mapping[str, Any]] freeform_tags: (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        :param pulumi.Input[bool] is_auto_reclaimable: True if table can be reclaimed after an idle period.
        :param pulumi.Input[str] lifecycle_details: A message describing the current state in more detail.
        :param pulumi.Input[str] name: Table name.
        :param pulumi.Input[pulumi.InputType['NosqlTableSchemaArgs']] schema: The table schema information as a JSON object.
        :param pulumi.Input[str] state: The state of a table.
        :param pulumi.Input[Mapping[str, Any]] system_tags: Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        :param pulumi.Input[pulumi.InputType['NosqlTableTableLimitsArgs']] table_limits: (Updatable) Throughput and storage limits configuration of a table.
        :param pulumi.Input[str] time_created: The time the the table was created. An RFC3339 formatted datetime string.
        :param pulumi.Input[str] time_of_expiration: If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        :param pulumi.Input[str] time_updated: The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NosqlTableState.__new__(_NosqlTableState)

        __props__.__dict__["compartment_id"] = compartment_id
        __props__.__dict__["ddl_statement"] = ddl_statement
        __props__.__dict__["defined_tags"] = defined_tags
        __props__.__dict__["freeform_tags"] = freeform_tags
        __props__.__dict__["is_auto_reclaimable"] = is_auto_reclaimable
        __props__.__dict__["lifecycle_details"] = lifecycle_details
        __props__.__dict__["name"] = name
        __props__.__dict__["schema"] = schema
        __props__.__dict__["state"] = state
        __props__.__dict__["system_tags"] = system_tags
        __props__.__dict__["table_limits"] = table_limits
        __props__.__dict__["time_created"] = time_created
        __props__.__dict__["time_of_expiration"] = time_of_expiration
        __props__.__dict__["time_updated"] = time_updated
        return NosqlTable(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> pulumi.Output[str]:
        """
        (Updatable) Compartment Identifier.
        """
        return pulumi.get(self, "compartment_id")

    @property
    @pulumi.getter(name="ddlStatement")
    def ddl_statement(self) -> pulumi.Output[str]:
        """
        (Updatable) Complete CREATE TABLE DDL statement.
        """
        return pulumi.get(self, "ddl_statement")

    @property
    @pulumi.getter(name="definedTags")
    def defined_tags(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        (Updatable) Defined tags for this resource. Each key is predefined and scoped to a namespace.  Example: `{"foo-namespace": {"bar-key": "value"}}`
        """
        return pulumi.get(self, "defined_tags")

    @property
    @pulumi.getter(name="freeformTags")
    def freeform_tags(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        (Updatable) Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only. Example: `{"bar-key": "value"}`
        """
        return pulumi.get(self, "freeform_tags")

    @property
    @pulumi.getter(name="isAutoReclaimable")
    def is_auto_reclaimable(self) -> pulumi.Output[bool]:
        """
        True if table can be reclaimed after an idle period.
        """
        return pulumi.get(self, "is_auto_reclaimable")

    @property
    @pulumi.getter(name="lifecycleDetails")
    def lifecycle_details(self) -> pulumi.Output[str]:
        """
        A message describing the current state in more detail.
        """
        return pulumi.get(self, "lifecycle_details")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Table name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def schema(self) -> pulumi.Output['outputs.NosqlTableSchema']:
        """
        The table schema information as a JSON object.
        """
        return pulumi.get(self, "schema")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The state of a table.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="systemTags")
    def system_tags(self) -> pulumi.Output[Mapping[str, Any]]:
        """
        Read-only system tag. These predefined keys are scoped to namespaces.  At present the only supported namespace is `"orcl-cloud"`; and the only key in that namespace is `"free-tier-retained"`. Example: `{"orcl-cloud"": {"free-tier-retained": "true"}}`
        """
        return pulumi.get(self, "system_tags")

    @property
    @pulumi.getter(name="tableLimits")
    def table_limits(self) -> pulumi.Output['outputs.NosqlTableTableLimits']:
        """
        (Updatable) Throughput and storage limits configuration of a table.
        """
        return pulumi.get(self, "table_limits")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        The time the the table was created. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter(name="timeOfExpiration")
    def time_of_expiration(self) -> pulumi.Output[str]:
        """
        If lifecycleState is INACTIVE, indicates when this table will be automatically removed. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_of_expiration")

    @property
    @pulumi.getter(name="timeUpdated")
    def time_updated(self) -> pulumi.Output[str]:
        """
        The time the the table's metadata was last updated. An RFC3339 formatted datetime string.
        """
        return pulumi.get(self, "time_updated")
