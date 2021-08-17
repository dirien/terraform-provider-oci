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

__all__ = ['DnsRrsetArgs', 'DnsRrset']

@pulumi.input_type
class DnsRrsetArgs:
    def __init__(__self__, *,
                 domain: pulumi.Input[str],
                 rtype: pulumi.Input[str],
                 zone_name_or_id: pulumi.Input[str],
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 view_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a DnsRrset resource.
        :param pulumi.Input[str] domain: The fully qualified domain name where the record can be located.
        :param pulumi.Input[str] rtype: The type of the target RRSet within the target zone.
        :param pulumi.Input[str] zone_name_or_id: The name or OCID of the target zone.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment the resource belongs to.
        :param pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]] items: (Updatable) 
               **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        :param pulumi.Input[str] scope: Specifies to operate only on resources that have a matching DNS scope. 
               This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        :param pulumi.Input[str] view_id: The OCID of the view the resource is associated with.
        """
        pulumi.set(__self__, "domain", domain)
        pulumi.set(__self__, "rtype", rtype)
        pulumi.set(__self__, "zone_name_or_id", zone_name_or_id)
        if compartment_id is not None:
            pulumi.set(__self__, "compartment_id", compartment_id)
        if items is not None:
            pulumi.set(__self__, "items", items)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if view_id is not None:
            pulumi.set(__self__, "view_id", view_id)

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Input[str]:
        """
        The fully qualified domain name where the record can be located.
        """
        return pulumi.get(self, "domain")

    @domain.setter
    def domain(self, value: pulumi.Input[str]):
        pulumi.set(self, "domain", value)

    @property
    @pulumi.getter
    def rtype(self) -> pulumi.Input[str]:
        """
        The type of the target RRSet within the target zone.
        """
        return pulumi.get(self, "rtype")

    @rtype.setter
    def rtype(self, value: pulumi.Input[str]):
        pulumi.set(self, "rtype", value)

    @property
    @pulumi.getter(name="zoneNameOrId")
    def zone_name_or_id(self) -> pulumi.Input[str]:
        """
        The name or OCID of the target zone.
        """
        return pulumi.get(self, "zone_name_or_id")

    @zone_name_or_id.setter
    def zone_name_or_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "zone_name_or_id", value)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The OCID of the compartment the resource belongs to.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter
    def items(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]]:
        """
        (Updatable) 
        **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        """
        return pulumi.get(self, "items")

    @items.setter
    def items(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]]):
        pulumi.set(self, "items", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies to operate only on resources that have a matching DNS scope. 
        This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter(name="viewId")
    def view_id(self) -> Optional[pulumi.Input[str]]:
        """
        The OCID of the view the resource is associated with.
        """
        return pulumi.get(self, "view_id")

    @view_id.setter
    def view_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "view_id", value)


@pulumi.input_type
class _DnsRrsetState:
    def __init__(__self__, *,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]] = None,
                 rtype: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 view_id: Optional[pulumi.Input[str]] = None,
                 zone_name_or_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DnsRrset resources.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment the resource belongs to.
        :param pulumi.Input[str] domain: The fully qualified domain name where the record can be located.
        :param pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]] items: (Updatable) 
               **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        :param pulumi.Input[str] rtype: The type of the target RRSet within the target zone.
        :param pulumi.Input[str] scope: Specifies to operate only on resources that have a matching DNS scope. 
               This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        :param pulumi.Input[str] view_id: The OCID of the view the resource is associated with.
        :param pulumi.Input[str] zone_name_or_id: The name or OCID of the target zone.
        """
        if compartment_id is not None:
            pulumi.set(__self__, "compartment_id", compartment_id)
        if domain is not None:
            pulumi.set(__self__, "domain", domain)
        if items is not None:
            pulumi.set(__self__, "items", items)
        if rtype is not None:
            pulumi.set(__self__, "rtype", rtype)
        if scope is not None:
            pulumi.set(__self__, "scope", scope)
        if view_id is not None:
            pulumi.set(__self__, "view_id", view_id)
        if zone_name_or_id is not None:
            pulumi.set(__self__, "zone_name_or_id", zone_name_or_id)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The OCID of the compartment the resource belongs to.
        """
        return pulumi.get(self, "compartment_id")

    @compartment_id.setter
    def compartment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compartment_id", value)

    @property
    @pulumi.getter
    def domain(self) -> Optional[pulumi.Input[str]]:
        """
        The fully qualified domain name where the record can be located.
        """
        return pulumi.get(self, "domain")

    @domain.setter
    def domain(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "domain", value)

    @property
    @pulumi.getter
    def items(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]]:
        """
        (Updatable) 
        **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        """
        return pulumi.get(self, "items")

    @items.setter
    def items(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DnsRrsetItemArgs']]]]):
        pulumi.set(self, "items", value)

    @property
    @pulumi.getter
    def rtype(self) -> Optional[pulumi.Input[str]]:
        """
        The type of the target RRSet within the target zone.
        """
        return pulumi.get(self, "rtype")

    @rtype.setter
    def rtype(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rtype", value)

    @property
    @pulumi.getter
    def scope(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies to operate only on resources that have a matching DNS scope. 
        This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        """
        return pulumi.get(self, "scope")

    @scope.setter
    def scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scope", value)

    @property
    @pulumi.getter(name="viewId")
    def view_id(self) -> Optional[pulumi.Input[str]]:
        """
        The OCID of the view the resource is associated with.
        """
        return pulumi.get(self, "view_id")

    @view_id.setter
    def view_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "view_id", value)

    @property
    @pulumi.getter(name="zoneNameOrId")
    def zone_name_or_id(self) -> Optional[pulumi.Input[str]]:
        """
        The name or OCID of the target zone.
        """
        return pulumi.get(self, "zone_name_or_id")

    @zone_name_or_id.setter
    def zone_name_or_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone_name_or_id", value)


class DnsRrset(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DnsRrsetItemArgs']]]]] = None,
                 rtype: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 view_id: Optional[pulumi.Input[str]] = None,
                 zone_name_or_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        This resource provides the Rrset resource in Oracle Cloud Infrastructure DNS service.

        Replaces records in the specified RRSet. For private zones, the scope query parameter is required with a
        value of `PRIVATE`. When the zone name is provided as a path parameter and `PRIVATE` is used for the scope
        query parameter then the viewId query parameter is required.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_rrset = oci.DnsRrset("testRrset",
            domain=var["rrset_domain"],
            rtype=var["rrset_rtype"],
            zone_name_or_id=oci_dns_zone["test_zone"]["id"],
            compartment_id=var["compartment_id"],
            items=[oci.DnsRrsetItemArgs(
                domain=var["rrset_items_domain"],
                rdata=var["rrset_items_rdata"],
                rtype=var["rrset_items_rtype"],
                ttl=var["rrset_items_ttl"],
            )],
            scope=var["rrset_scope"],
            view_id=oci_dns_view["test_view"]["id"])
        ```

        ## Import

        For legacy Rrsets that were created without using `scope`, these Rrsets can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/dnsRrset:DnsRrset test_rrset "zoneNameOrId/{zoneNameOrId}/domain/{domain}/rtype/{rtype}"
        ```

         For Rrsets created using `scope` and `view_id`, these Rrsets can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/dnsRrset:DnsRrset test_rrset "zoneNameOrId/{zoneNameOrId}/domain/{domain}/rtype/{rtype}/scope/{scope}/viewId/{viewId}"
        ```

         skip adding `{view_id}` at the end if Rrset was created without `view_id`.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment the resource belongs to.
        :param pulumi.Input[str] domain: The fully qualified domain name where the record can be located.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DnsRrsetItemArgs']]]] items: (Updatable) 
               **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        :param pulumi.Input[str] rtype: The type of the target RRSet within the target zone.
        :param pulumi.Input[str] scope: Specifies to operate only on resources that have a matching DNS scope. 
               This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        :param pulumi.Input[str] view_id: The OCID of the view the resource is associated with.
        :param pulumi.Input[str] zone_name_or_id: The name or OCID of the target zone.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DnsRrsetArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource provides the Rrset resource in Oracle Cloud Infrastructure DNS service.

        Replaces records in the specified RRSet. For private zones, the scope query parameter is required with a
        value of `PRIVATE`. When the zone name is provided as a path parameter and `PRIVATE` is used for the scope
        query parameter then the viewId query parameter is required.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_rrset = oci.DnsRrset("testRrset",
            domain=var["rrset_domain"],
            rtype=var["rrset_rtype"],
            zone_name_or_id=oci_dns_zone["test_zone"]["id"],
            compartment_id=var["compartment_id"],
            items=[oci.DnsRrsetItemArgs(
                domain=var["rrset_items_domain"],
                rdata=var["rrset_items_rdata"],
                rtype=var["rrset_items_rtype"],
                ttl=var["rrset_items_ttl"],
            )],
            scope=var["rrset_scope"],
            view_id=oci_dns_view["test_view"]["id"])
        ```

        ## Import

        For legacy Rrsets that were created without using `scope`, these Rrsets can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/dnsRrset:DnsRrset test_rrset "zoneNameOrId/{zoneNameOrId}/domain/{domain}/rtype/{rtype}"
        ```

         For Rrsets created using `scope` and `view_id`, these Rrsets can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/dnsRrset:DnsRrset test_rrset "zoneNameOrId/{zoneNameOrId}/domain/{domain}/rtype/{rtype}/scope/{scope}/viewId/{viewId}"
        ```

         skip adding `{view_id}` at the end if Rrset was created without `view_id`.

        :param str resource_name: The name of the resource.
        :param DnsRrsetArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DnsRrsetArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 compartment_id: Optional[pulumi.Input[str]] = None,
                 domain: Optional[pulumi.Input[str]] = None,
                 items: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DnsRrsetItemArgs']]]]] = None,
                 rtype: Optional[pulumi.Input[str]] = None,
                 scope: Optional[pulumi.Input[str]] = None,
                 view_id: Optional[pulumi.Input[str]] = None,
                 zone_name_or_id: Optional[pulumi.Input[str]] = None,
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
            __props__ = DnsRrsetArgs.__new__(DnsRrsetArgs)

            __props__.__dict__["compartment_id"] = compartment_id
            if domain is None and not opts.urn:
                raise TypeError("Missing required property 'domain'")
            __props__.__dict__["domain"] = domain
            __props__.__dict__["items"] = items
            if rtype is None and not opts.urn:
                raise TypeError("Missing required property 'rtype'")
            __props__.__dict__["rtype"] = rtype
            __props__.__dict__["scope"] = scope
            __props__.__dict__["view_id"] = view_id
            if zone_name_or_id is None and not opts.urn:
                raise TypeError("Missing required property 'zone_name_or_id'")
            __props__.__dict__["zone_name_or_id"] = zone_name_or_id
        super(DnsRrset, __self__).__init__(
            'oci:index/dnsRrset:DnsRrset',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            compartment_id: Optional[pulumi.Input[str]] = None,
            domain: Optional[pulumi.Input[str]] = None,
            items: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DnsRrsetItemArgs']]]]] = None,
            rtype: Optional[pulumi.Input[str]] = None,
            scope: Optional[pulumi.Input[str]] = None,
            view_id: Optional[pulumi.Input[str]] = None,
            zone_name_or_id: Optional[pulumi.Input[str]] = None) -> 'DnsRrset':
        """
        Get an existing DnsRrset resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] compartment_id: (Updatable) The OCID of the compartment the resource belongs to.
        :param pulumi.Input[str] domain: The fully qualified domain name where the record can be located.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DnsRrsetItemArgs']]]] items: (Updatable) 
               **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        :param pulumi.Input[str] rtype: The type of the target RRSet within the target zone.
        :param pulumi.Input[str] scope: Specifies to operate only on resources that have a matching DNS scope. 
               This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        :param pulumi.Input[str] view_id: The OCID of the view the resource is associated with.
        :param pulumi.Input[str] zone_name_or_id: The name or OCID of the target zone.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DnsRrsetState.__new__(_DnsRrsetState)

        __props__.__dict__["compartment_id"] = compartment_id
        __props__.__dict__["domain"] = domain
        __props__.__dict__["items"] = items
        __props__.__dict__["rtype"] = rtype
        __props__.__dict__["scope"] = scope
        __props__.__dict__["view_id"] = view_id
        __props__.__dict__["zone_name_or_id"] = zone_name_or_id
        return DnsRrset(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="compartmentId")
    def compartment_id(self) -> pulumi.Output[str]:
        """
        (Updatable) The OCID of the compartment the resource belongs to.
        """
        return pulumi.get(self, "compartment_id")

    @property
    @pulumi.getter
    def domain(self) -> pulumi.Output[str]:
        """
        The fully qualified domain name where the record can be located.
        """
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter
    def items(self) -> pulumi.Output[Sequence['outputs.DnsRrsetItem']]:
        """
        (Updatable) 
        **NOTE** Omitting `items` at time of create, will delete any existing records in the RRSet
        """
        return pulumi.get(self, "items")

    @property
    @pulumi.getter
    def rtype(self) -> pulumi.Output[str]:
        """
        The type of the target RRSet within the target zone.
        """
        return pulumi.get(self, "rtype")

    @property
    @pulumi.getter
    def scope(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies to operate only on resources that have a matching DNS scope. 
        This value will be null for zones in the global DNS and `PRIVATE` when creating private Rrsets.
        """
        return pulumi.get(self, "scope")

    @property
    @pulumi.getter(name="viewId")
    def view_id(self) -> pulumi.Output[Optional[str]]:
        """
        The OCID of the view the resource is associated with.
        """
        return pulumi.get(self, "view_id")

    @property
    @pulumi.getter(name="zoneNameOrId")
    def zone_name_or_id(self) -> pulumi.Output[str]:
        """
        The name or OCID of the target zone.
        """
        return pulumi.get(self, "zone_name_or_id")
