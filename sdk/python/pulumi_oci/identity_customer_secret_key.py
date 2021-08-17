# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['IdentityCustomerSecretKeyArgs', 'IdentityCustomerSecretKey']

@pulumi.input_type
class IdentityCustomerSecretKeyArgs:
    def __init__(__self__, *,
                 display_name: pulumi.Input[str],
                 user_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a IdentityCustomerSecretKey resource.
        :param pulumi.Input[str] display_name: (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        pulumi.set(__self__, "display_name", display_name)
        pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Input[str]:
        """
        (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> pulumi.Input[str]:
        """
        The OCID of the user.
        """
        return pulumi.get(self, "user_id")

    @user_id.setter
    def user_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "user_id", value)


@pulumi.input_type
class _IdentityCustomerSecretKeyState:
    def __init__(__self__, *,
                 display_name: Optional[pulumi.Input[str]] = None,
                 inactive_state: Optional[pulumi.Input[str]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 time_created: Optional[pulumi.Input[str]] = None,
                 time_expires: Optional[pulumi.Input[str]] = None,
                 user_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering IdentityCustomerSecretKey resources.
        :param pulumi.Input[str] display_name: (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] inactive_state: The detailed status of INACTIVE lifecycleState.
        :param pulumi.Input[str] key: The secret key.
        :param pulumi.Input[str] state: The secret key's current state.
        :param pulumi.Input[str] time_created: Date and time the `CustomerSecretKey` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] time_expires: Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if inactive_state is not None:
            pulumi.set(__self__, "inactive_state", inactive_state)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if time_created is not None:
            pulumi.set(__self__, "time_created", time_created)
        if time_expires is not None:
            pulumi.set(__self__, "time_expires", time_expires)
        if user_id is not None:
            pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter(name="inactiveState")
    def inactive_state(self) -> Optional[pulumi.Input[str]]:
        """
        The detailed status of INACTIVE lifecycleState.
        """
        return pulumi.get(self, "inactive_state")

    @inactive_state.setter
    def inactive_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "inactive_state", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        The secret key.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        The secret key's current state.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> Optional[pulumi.Input[str]]:
        """
        Date and time the `CustomerSecretKey` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_created")

    @time_created.setter
    def time_created(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_created", value)

    @property
    @pulumi.getter(name="timeExpires")
    def time_expires(self) -> Optional[pulumi.Input[str]]:
        """
        Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_expires")

    @time_expires.setter
    def time_expires(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_expires", value)

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> Optional[pulumi.Input[str]]:
        """
        The OCID of the user.
        """
        return pulumi.get(self, "user_id")

    @user_id.setter
    def user_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_id", value)


class IdentityCustomerSecretKey(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 user_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        This resource provides the Customer Secret Key resource in Oracle Cloud Infrastructure Identity service.

        Creates a new secret key for the specified user. Secret keys are used for authentication with the Object Storage Service's Amazon S3
        compatible API. The secret key consists of an Access Key/Secret Key pair. For information, see
        [Managing User Credentials](https://docs.cloud.oracle.com/iaas/Content/Identity/Tasks/managingcredentials.htm).

        You must specify a *description* for the secret key (although it can be an empty string). It does not
        have to be unique, and you can change it anytime with
        [UpdateCustomerSecretKey](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/CustomerSecretKeySummary/UpdateCustomerSecretKey).

        Every user has permission to create a secret key for *their own user ID*. An administrator in your organization
        does not need to write a policy to give users this ability. To compare, administrators who have permission to the
        tenancy can use this operation to create a secret key for any user, including themselves.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_customer_secret_key = oci.IdentityCustomerSecretKey("testCustomerSecretKey",
            display_name=var["customer_secret_key_display_name"],
            user_id=oci_identity_user["test_user"]["id"])
        ```

        ## Import

        CustomerSecretKeys can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/identityCustomerSecretKey:IdentityCustomerSecretKey test_customer_secret_key "users/{userId}/customerSecretKeys/{customerSecretKeyId}"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] display_name: (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IdentityCustomerSecretKeyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource provides the Customer Secret Key resource in Oracle Cloud Infrastructure Identity service.

        Creates a new secret key for the specified user. Secret keys are used for authentication with the Object Storage Service's Amazon S3
        compatible API. The secret key consists of an Access Key/Secret Key pair. For information, see
        [Managing User Credentials](https://docs.cloud.oracle.com/iaas/Content/Identity/Tasks/managingcredentials.htm).

        You must specify a *description* for the secret key (although it can be an empty string). It does not
        have to be unique, and you can change it anytime with
        [UpdateCustomerSecretKey](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/CustomerSecretKeySummary/UpdateCustomerSecretKey).

        Every user has permission to create a secret key for *their own user ID*. An administrator in your organization
        does not need to write a policy to give users this ability. To compare, administrators who have permission to the
        tenancy can use this operation to create a secret key for any user, including themselves.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_customer_secret_key = oci.IdentityCustomerSecretKey("testCustomerSecretKey",
            display_name=var["customer_secret_key_display_name"],
            user_id=oci_identity_user["test_user"]["id"])
        ```

        ## Import

        CustomerSecretKeys can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:index/identityCustomerSecretKey:IdentityCustomerSecretKey test_customer_secret_key "users/{userId}/customerSecretKeys/{customerSecretKeyId}"
        ```

        :param str resource_name: The name of the resource.
        :param IdentityCustomerSecretKeyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IdentityCustomerSecretKeyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 user_id: Optional[pulumi.Input[str]] = None,
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
            __props__ = IdentityCustomerSecretKeyArgs.__new__(IdentityCustomerSecretKeyArgs)

            if display_name is None and not opts.urn:
                raise TypeError("Missing required property 'display_name'")
            __props__.__dict__["display_name"] = display_name
            if user_id is None and not opts.urn:
                raise TypeError("Missing required property 'user_id'")
            __props__.__dict__["user_id"] = user_id
            __props__.__dict__["inactive_state"] = None
            __props__.__dict__["key"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["time_created"] = None
            __props__.__dict__["time_expires"] = None
        super(IdentityCustomerSecretKey, __self__).__init__(
            'oci:index/identityCustomerSecretKey:IdentityCustomerSecretKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            inactive_state: Optional[pulumi.Input[str]] = None,
            key: Optional[pulumi.Input[str]] = None,
            state: Optional[pulumi.Input[str]] = None,
            time_created: Optional[pulumi.Input[str]] = None,
            time_expires: Optional[pulumi.Input[str]] = None,
            user_id: Optional[pulumi.Input[str]] = None) -> 'IdentityCustomerSecretKey':
        """
        Get an existing IdentityCustomerSecretKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] display_name: (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] inactive_state: The detailed status of INACTIVE lifecycleState.
        :param pulumi.Input[str] key: The secret key.
        :param pulumi.Input[str] state: The secret key's current state.
        :param pulumi.Input[str] time_created: Date and time the `CustomerSecretKey` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] time_expires: Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IdentityCustomerSecretKeyState.__new__(_IdentityCustomerSecretKeyState)

        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["inactive_state"] = inactive_state
        __props__.__dict__["key"] = key
        __props__.__dict__["state"] = state
        __props__.__dict__["time_created"] = time_created
        __props__.__dict__["time_expires"] = time_expires
        __props__.__dict__["user_id"] = user_id
        return IdentityCustomerSecretKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[str]:
        """
        (Updatable) The name you assign to the secret key during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter(name="inactiveState")
    def inactive_state(self) -> pulumi.Output[str]:
        """
        The detailed status of INACTIVE lifecycleState.
        """
        return pulumi.get(self, "inactive_state")

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[str]:
        """
        The secret key.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The secret key's current state.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        Date and time the `CustomerSecretKey` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter(name="timeExpires")
    def time_expires(self) -> pulumi.Output[str]:
        """
        Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_expires")

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> pulumi.Output[str]:
        """
        The OCID of the user.
        """
        return pulumi.get(self, "user_id")
