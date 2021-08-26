// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core
{
    /// <summary>
    /// This resource provides the Volume Attachment resource in Oracle Cloud Infrastructure Core service.
    /// 
    /// Attaches the specified storage volume to the specified instance.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Oci = Pulumi.Oci;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var testVolumeAttachment = new Oci.Core.VolumeAttachment("testVolumeAttachment", new Oci.Core.VolumeAttachmentArgs
    ///         {
    ///             AttachmentType = @var.Volume_attachment_attachment_type,
    ///             InstanceId = oci_core_instance.Test_instance.Id,
    ///             VolumeId = oci_core_volume.Test_volume.Id,
    ///             Device = @var.Volume_attachment_device,
    ///             DisplayName = @var.Volume_attachment_display_name,
    ///             EncryptionInTransitType = @var.Volume_attachment_encryption_in_transit_type,
    ///             IsPvEncryptionInTransitEnabled = @var.Volume_attachment_is_pv_encryption_in_transit_enabled,
    ///             IsReadOnly = @var.Volume_attachment_is_read_only,
    ///             IsShareable = @var.Volume_attachment_is_shareable,
    ///             UseChap = @var.Volume_attachment_use_chap,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// VolumeAttachments can be imported using the `id`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import oci:core/volumeAttachment:VolumeAttachment test_volume_attachment "id"
    /// ```
    /// </summary>
    [OciResourceType("oci:core/volumeAttachment:VolumeAttachment")]
    public partial class VolumeAttachment : Pulumi.CustomResource
    {
        /// <summary>
        /// The type of volume. The only supported values are "iscsi" and "paravirtualized".
        /// </summary>
        [Output("attachmentType")]
        public Output<string> AttachmentType { get; private set; } = null!;

        /// <summary>
        /// The availability domain of an instance.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        [Output("availabilityDomain")]
        public Output<string> AvailabilityDomain { get; private set; } = null!;

        /// <summary>
        /// The Challenge-Handshake-Authentication-Protocol (CHAP) secret valid for the associated CHAP user name. (Also called the "CHAP password".)
        /// </summary>
        [Output("chapSecret")]
        public Output<string> ChapSecret { get; private set; } = null!;

        /// <summary>
        /// The volume's system-generated Challenge-Handshake-Authentication-Protocol (CHAP) user name. See [RFC 1994](https://tools.ietf.org/html/rfc1994) for more on CHAP.  Example: `ocid1.volume.oc1.phx.&lt;unique_ID&gt;`
        /// </summary>
        [Output("chapUsername")]
        public Output<string> ChapUsername { get; private set; } = null!;

        /// <summary>
        /// The OCID of the compartment.
        /// </summary>
        [Output("compartmentId")]
        public Output<string> CompartmentId { get; private set; } = null!;

        /// <summary>
        /// The device name.
        /// </summary>
        [Output("device")]
        public Output<string> Device { get; private set; } = null!;

        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Refer the top-level definition of encryptionInTransitType. The default value is NONE.
        /// </summary>
        [Output("encryptionInTransitType")]
        public Output<string> EncryptionInTransitType { get; private set; } = null!;

        /// <summary>
        /// The OCID of the instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// The volume's iSCSI IP address.  Example: `169.254.2.2`
        /// </summary>
        [Output("ipv4")]
        public Output<string> Ipv4 { get; private set; } = null!;

        /// <summary>
        /// The target volume's iSCSI Qualified Name in the format defined by [RFC 3720](https://tools.ietf.org/html/rfc3720#page-32).  Example: `iqn.2015-12.com.oracleiaas:40b7ee03-883f-46c6-a951-63d2841d2195`
        /// </summary>
        [Output("iqn")]
        public Output<string> Iqn { get; private set; } = null!;

        /// <summary>
        /// Whether the attachment is multipath or not.
        /// </summary>
        [Output("isMultipath")]
        public Output<bool> IsMultipath { get; private set; } = null!;

        /// <summary>
        /// Whether to enable in-transit encryption for the data volume's paravirtualized attachment. The default value is false.
        /// </summary>
        [Output("isPvEncryptionInTransitEnabled")]
        public Output<bool> IsPvEncryptionInTransitEnabled { get; private set; } = null!;

        /// <summary>
        /// Whether the attachment was created in read-only mode.
        /// </summary>
        [Output("isReadOnly")]
        public Output<bool> IsReadOnly { get; private set; } = null!;

        /// <summary>
        /// Whether the attachment should be created in shareable mode. If an attachment is created in shareable mode, then other instances can attach the same volume, provided that they also create their attachments in shareable mode. Only certain volume types can be attached in shareable mode. Defaults to false if not specified.
        /// </summary>
        [Output("isShareable")]
        public Output<bool> IsShareable { get; private set; } = null!;

        /// <summary>
        /// The iscsi login state of the volume attachment. For a multipath volume attachment, all iscsi sessions need to be all logged-in or logged-out to be in logged-in or logged-out state.
        /// </summary>
        [Output("iscsiLoginState")]
        public Output<string> IscsiLoginState { get; private set; } = null!;

        /// <summary>
        /// A list of secondary multipath devices
        /// </summary>
        [Output("multipathDevices")]
        public Output<ImmutableArray<Outputs.VolumeAttachmentMultipathDevice>> MultipathDevices { get; private set; } = null!;

        /// <summary>
        /// The volume's iSCSI port, usually port 860 or 3260.  Example: `3260`
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// The current state of the volume attachment.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The date and time the volume was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// Whether to use CHAP authentication for the volume attachment. Defaults to false.
        /// </summary>
        [Output("useChap")]
        public Output<bool> UseChap { get; private set; } = null!;

        /// <summary>
        /// The OCID of the volume.
        /// </summary>
        [Output("volumeId")]
        public Output<string> VolumeId { get; private set; } = null!;


        /// <summary>
        /// Create a VolumeAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VolumeAttachment(string name, VolumeAttachmentArgs args, CustomResourceOptions? options = null)
            : base("oci:core/volumeAttachment:VolumeAttachment", name, args ?? new VolumeAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VolumeAttachment(string name, Input<string> id, VolumeAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("oci:core/volumeAttachment:VolumeAttachment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VolumeAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VolumeAttachment Get(string name, Input<string> id, VolumeAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new VolumeAttachment(name, id, state, options);
        }
    }

    public sealed class VolumeAttachmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of volume. The only supported values are "iscsi" and "paravirtualized".
        /// </summary>
        [Input("attachmentType", required: true)]
        public Input<string> AttachmentType { get; set; } = null!;

        /// <summary>
        /// The OCID of the compartment.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        /// <summary>
        /// The device name.
        /// </summary>
        [Input("device")]
        public Input<string>? Device { get; set; }

        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Refer the top-level definition of encryptionInTransitType. The default value is NONE.
        /// </summary>
        [Input("encryptionInTransitType")]
        public Input<string>? EncryptionInTransitType { get; set; }

        /// <summary>
        /// The OCID of the instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Whether to enable in-transit encryption for the data volume's paravirtualized attachment. The default value is false.
        /// </summary>
        [Input("isPvEncryptionInTransitEnabled")]
        public Input<bool>? IsPvEncryptionInTransitEnabled { get; set; }

        /// <summary>
        /// Whether the attachment was created in read-only mode.
        /// </summary>
        [Input("isReadOnly")]
        public Input<bool>? IsReadOnly { get; set; }

        /// <summary>
        /// Whether the attachment should be created in shareable mode. If an attachment is created in shareable mode, then other instances can attach the same volume, provided that they also create their attachments in shareable mode. Only certain volume types can be attached in shareable mode. Defaults to false if not specified.
        /// </summary>
        [Input("isShareable")]
        public Input<bool>? IsShareable { get; set; }

        /// <summary>
        /// Whether to use CHAP authentication for the volume attachment. Defaults to false.
        /// </summary>
        [Input("useChap")]
        public Input<bool>? UseChap { get; set; }

        /// <summary>
        /// The OCID of the volume.
        /// </summary>
        [Input("volumeId", required: true)]
        public Input<string> VolumeId { get; set; } = null!;

        public VolumeAttachmentArgs()
        {
        }
    }

    public sealed class VolumeAttachmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of volume. The only supported values are "iscsi" and "paravirtualized".
        /// </summary>
        [Input("attachmentType")]
        public Input<string>? AttachmentType { get; set; }

        /// <summary>
        /// The availability domain of an instance.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        [Input("availabilityDomain")]
        public Input<string>? AvailabilityDomain { get; set; }

        /// <summary>
        /// The Challenge-Handshake-Authentication-Protocol (CHAP) secret valid for the associated CHAP user name. (Also called the "CHAP password".)
        /// </summary>
        [Input("chapSecret")]
        public Input<string>? ChapSecret { get; set; }

        /// <summary>
        /// The volume's system-generated Challenge-Handshake-Authentication-Protocol (CHAP) user name. See [RFC 1994](https://tools.ietf.org/html/rfc1994) for more on CHAP.  Example: `ocid1.volume.oc1.phx.&lt;unique_ID&gt;`
        /// </summary>
        [Input("chapUsername")]
        public Input<string>? ChapUsername { get; set; }

        /// <summary>
        /// The OCID of the compartment.
        /// </summary>
        [Input("compartmentId")]
        public Input<string>? CompartmentId { get; set; }

        /// <summary>
        /// The device name.
        /// </summary>
        [Input("device")]
        public Input<string>? Device { get; set; }

        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Refer the top-level definition of encryptionInTransitType. The default value is NONE.
        /// </summary>
        [Input("encryptionInTransitType")]
        public Input<string>? EncryptionInTransitType { get; set; }

        /// <summary>
        /// The OCID of the instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// The volume's iSCSI IP address.  Example: `169.254.2.2`
        /// </summary>
        [Input("ipv4")]
        public Input<string>? Ipv4 { get; set; }

        /// <summary>
        /// The target volume's iSCSI Qualified Name in the format defined by [RFC 3720](https://tools.ietf.org/html/rfc3720#page-32).  Example: `iqn.2015-12.com.oracleiaas:40b7ee03-883f-46c6-a951-63d2841d2195`
        /// </summary>
        [Input("iqn")]
        public Input<string>? Iqn { get; set; }

        /// <summary>
        /// Whether the attachment is multipath or not.
        /// </summary>
        [Input("isMultipath")]
        public Input<bool>? IsMultipath { get; set; }

        /// <summary>
        /// Whether to enable in-transit encryption for the data volume's paravirtualized attachment. The default value is false.
        /// </summary>
        [Input("isPvEncryptionInTransitEnabled")]
        public Input<bool>? IsPvEncryptionInTransitEnabled { get; set; }

        /// <summary>
        /// Whether the attachment was created in read-only mode.
        /// </summary>
        [Input("isReadOnly")]
        public Input<bool>? IsReadOnly { get; set; }

        /// <summary>
        /// Whether the attachment should be created in shareable mode. If an attachment is created in shareable mode, then other instances can attach the same volume, provided that they also create their attachments in shareable mode. Only certain volume types can be attached in shareable mode. Defaults to false if not specified.
        /// </summary>
        [Input("isShareable")]
        public Input<bool>? IsShareable { get; set; }

        /// <summary>
        /// The iscsi login state of the volume attachment. For a multipath volume attachment, all iscsi sessions need to be all logged-in or logged-out to be in logged-in or logged-out state.
        /// </summary>
        [Input("iscsiLoginState")]
        public Input<string>? IscsiLoginState { get; set; }

        [Input("multipathDevices")]
        private InputList<Inputs.VolumeAttachmentMultipathDeviceGetArgs>? _multipathDevices;

        /// <summary>
        /// A list of secondary multipath devices
        /// </summary>
        public InputList<Inputs.VolumeAttachmentMultipathDeviceGetArgs> MultipathDevices
        {
            get => _multipathDevices ?? (_multipathDevices = new InputList<Inputs.VolumeAttachmentMultipathDeviceGetArgs>());
            set => _multipathDevices = value;
        }

        /// <summary>
        /// The volume's iSCSI port, usually port 860 or 3260.  Example: `3260`
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// The current state of the volume attachment.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The date and time the volume was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// Whether to use CHAP authentication for the volume attachment. Defaults to false.
        /// </summary>
        [Input("useChap")]
        public Input<bool>? UseChap { get; set; }

        /// <summary>
        /// The OCID of the volume.
        /// </summary>
        [Input("volumeId")]
        public Input<string>? VolumeId { get; set; }

        public VolumeAttachmentState()
        {
        }
    }
}