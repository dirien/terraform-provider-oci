# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SwiftPasswordArgs', 'SwiftPassword']

@pulumi.input_type
class SwiftPasswordArgs:
    def __init__(__self__, *,
                 description: pulumi.Input[str],
                 user_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a SwiftPassword resource.
        :param pulumi.Input[str] description: (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        pulumi.set(__self__, "description", description)
        pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Input[str]:
        """
        (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: pulumi.Input[str]):
        pulumi.set(self, "description", value)

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
class _SwiftPasswordState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 expires_on: Optional[pulumi.Input[str]] = None,
                 inactive_state: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None,
                 time_created: Optional[pulumi.Input[str]] = None,
                 user_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering SwiftPassword resources.
        :param pulumi.Input[str] description: (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] expires_on: Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] inactive_state: The detailed status of INACTIVE lifecycleState.
        :param pulumi.Input[str] password: The Swift password. The value is available only in the response for `CreateSwiftPassword`, and not for `ListSwiftPasswords` or `UpdateSwiftPassword`.
        :param pulumi.Input[str] state: The password's current state.
        :param pulumi.Input[str] time_created: Date and time the `SwiftPassword` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if expires_on is not None:
            pulumi.set(__self__, "expires_on", expires_on)
        if inactive_state is not None:
            pulumi.set(__self__, "inactive_state", inactive_state)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if time_created is not None:
            pulumi.set(__self__, "time_created", time_created)
        if user_id is not None:
            pulumi.set(__self__, "user_id", user_id)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="expiresOn")
    def expires_on(self) -> Optional[pulumi.Input[str]]:
        """
        Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "expires_on")

    @expires_on.setter
    def expires_on(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "expires_on", value)

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
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        The Swift password. The value is available only in the response for `CreateSwiftPassword`, and not for `ListSwiftPasswords` or `UpdateSwiftPassword`.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        """
        The password's current state.
        """
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> Optional[pulumi.Input[str]]:
        """
        Date and time the `SwiftPassword` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_created")

    @time_created.setter
    def time_created(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "time_created", value)

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


class SwiftPassword(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 user_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        This resource provides the Swift Password resource in Oracle Cloud Infrastructure Identity service.

        **Deprecated. Use [CreateAuthToken](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/AuthToken/CreateAuthToken) instead.**

        Creates a new Swift password for the specified user. For information about what Swift passwords are for, see
        [Managing User Credentials](https://docs.cloud.oracle.com/iaas/Content/Identity/Tasks/managingcredentials.htm).

        You must specify a *description* for the Swift password (although it can be an empty string). It does not
        have to be unique, and you can change it anytime with
        [UpdateSwiftPassword](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/SwiftPassword/UpdateSwiftPassword).

        Every user has permission to create a Swift password for *their own user ID*. An administrator in your organization
        does not need to write a policy to give users this ability. To compare, administrators who have permission to the
        tenancy can use this operation to create a Swift password for any user, including themselves.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_swift_password = oci.identity.SwiftPassword("testSwiftPassword",
            description=var["swift_password_description"],
            user_id=oci_identity_user["test_user"]["id"])
        ```

        ## Import

        SwiftPasswords can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:identity/swiftPassword:SwiftPassword test_swift_password "users/{userId}/swiftPasswords/{swiftPasswordId}"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SwiftPasswordArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource provides the Swift Password resource in Oracle Cloud Infrastructure Identity service.

        **Deprecated. Use [CreateAuthToken](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/AuthToken/CreateAuthToken) instead.**

        Creates a new Swift password for the specified user. For information about what Swift passwords are for, see
        [Managing User Credentials](https://docs.cloud.oracle.com/iaas/Content/Identity/Tasks/managingcredentials.htm).

        You must specify a *description* for the Swift password (although it can be an empty string). It does not
        have to be unique, and you can change it anytime with
        [UpdateSwiftPassword](https://docs.cloud.oracle.com/iaas/api/#/en/identity/20160918/SwiftPassword/UpdateSwiftPassword).

        Every user has permission to create a Swift password for *their own user ID*. An administrator in your organization
        does not need to write a policy to give users this ability. To compare, administrators who have permission to the
        tenancy can use this operation to create a Swift password for any user, including themselves.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_oci as oci

        test_swift_password = oci.identity.SwiftPassword("testSwiftPassword",
            description=var["swift_password_description"],
            user_id=oci_identity_user["test_user"]["id"])
        ```

        ## Import

        SwiftPasswords can be imported using the `id`, e.g.

        ```sh
         $ pulumi import oci:identity/swiftPassword:SwiftPassword test_swift_password "users/{userId}/swiftPasswords/{swiftPasswordId}"
        ```

        :param str resource_name: The name of the resource.
        :param SwiftPasswordArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SwiftPasswordArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
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
            __props__ = SwiftPasswordArgs.__new__(SwiftPasswordArgs)

            if description is None and not opts.urn:
                raise TypeError("Missing required property 'description'")
            __props__.__dict__["description"] = description
            if user_id is None and not opts.urn:
                raise TypeError("Missing required property 'user_id'")
            __props__.__dict__["user_id"] = user_id
            __props__.__dict__["expires_on"] = None
            __props__.__dict__["inactive_state"] = None
            __props__.__dict__["password"] = None
            __props__.__dict__["state"] = None
            __props__.__dict__["time_created"] = None
        super(SwiftPassword, __self__).__init__(
            'oci:identity/swiftPassword:SwiftPassword',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            expires_on: Optional[pulumi.Input[str]] = None,
            inactive_state: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            state: Optional[pulumi.Input[str]] = None,
            time_created: Optional[pulumi.Input[str]] = None,
            user_id: Optional[pulumi.Input[str]] = None) -> 'SwiftPassword':
        """
        Get an existing SwiftPassword resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        :param pulumi.Input[str] expires_on: Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] inactive_state: The detailed status of INACTIVE lifecycleState.
        :param pulumi.Input[str] password: The Swift password. The value is available only in the response for `CreateSwiftPassword`, and not for `ListSwiftPasswords` or `UpdateSwiftPassword`.
        :param pulumi.Input[str] state: The password's current state.
        :param pulumi.Input[str] time_created: Date and time the `SwiftPassword` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        :param pulumi.Input[str] user_id: The OCID of the user.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SwiftPasswordState.__new__(_SwiftPasswordState)

        __props__.__dict__["description"] = description
        __props__.__dict__["expires_on"] = expires_on
        __props__.__dict__["inactive_state"] = inactive_state
        __props__.__dict__["password"] = password
        __props__.__dict__["state"] = state
        __props__.__dict__["time_created"] = time_created
        __props__.__dict__["user_id"] = user_id
        return SwiftPassword(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[str]:
        """
        (Updatable) The description you assign to the Swift password during creation. Does not have to be unique, and it's changeable.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="expiresOn")
    def expires_on(self) -> pulumi.Output[str]:
        """
        Date and time when this password will expire, in the format defined by RFC3339. Null if it never expires.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "expires_on")

    @property
    @pulumi.getter(name="inactiveState")
    def inactive_state(self) -> pulumi.Output[str]:
        """
        The detailed status of INACTIVE lifecycleState.
        """
        return pulumi.get(self, "inactive_state")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        The Swift password. The value is available only in the response for `CreateSwiftPassword`, and not for `ListSwiftPasswords` or `UpdateSwiftPassword`.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The password's current state.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="timeCreated")
    def time_created(self) -> pulumi.Output[str]:
        """
        Date and time the `SwiftPassword` object was created, in the format defined by RFC3339.  Example: `2016-08-25T21:10:29.600Z`
        """
        return pulumi.get(self, "time_created")

    @property
    @pulumi.getter(name="userId")
    def user_id(self) -> pulumi.Output[str]:
        """
        The OCID of the user.
        """
        return pulumi.get(self, "user_id")
