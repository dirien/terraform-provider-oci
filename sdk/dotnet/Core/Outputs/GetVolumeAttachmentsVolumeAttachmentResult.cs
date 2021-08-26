// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Core.Outputs
{

    [OutputType]
    public sealed class GetVolumeAttachmentsVolumeAttachmentResult
    {
        /// <summary>
        /// The type of volume attachment.
        /// </summary>
        public readonly string AttachmentType;
        /// <summary>
        /// The name of the availability domain.  Example: `Uocm:PHX-AD-1`
        /// </summary>
        public readonly string AvailabilityDomain;
        /// <summary>
        /// The Challenge-Handshake-Authentication-Protocol (CHAP) secret valid for the associated CHAP user name. (Also called the "CHAP password".)
        /// </summary>
        public readonly string ChapSecret;
        /// <summary>
        /// The volume's system-generated Challenge-Handshake-Authentication-Protocol (CHAP) user name. See [RFC 1994](https://tools.ietf.org/html/rfc1994) for more on CHAP.  Example: `ocid1.volume.oc1.phx.&lt;unique_ID&gt;`
        /// </summary>
        public readonly string ChapUsername;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// The device name.
        /// </summary>
        public readonly string Device;
        /// <summary>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.  Example: `My volume attachment`
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Refer the top-level definition of encryptionInTransitType. The default value is NONE.
        /// </summary>
        public readonly string EncryptionInTransitType;
        /// <summary>
        /// The OCID of the volume attachment.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The OCID of the instance.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// The volume's iSCSI IP address.  Example: `169.254.2.2`
        /// </summary>
        public readonly string Ipv4;
        /// <summary>
        /// The target volume's iSCSI Qualified Name in the format defined by [RFC 3720](https://tools.ietf.org/html/rfc3720#page-32).  Example: `iqn.2015-12.com.oracleiaas:40b7ee03-883f-46c6-a951-63d2841d2195`
        /// </summary>
        public readonly string Iqn;
        /// <summary>
        /// Whether the attachment is multipath or not.
        /// </summary>
        public readonly bool IsMultipath;
        /// <summary>
        /// Whether in-transit encryption for the data volume's paravirtualized attachment is enabled or not.
        /// </summary>
        public readonly bool IsPvEncryptionInTransitEnabled;
        /// <summary>
        /// Whether the attachment was created in read-only mode.
        /// </summary>
        public readonly bool IsReadOnly;
        public readonly bool IsShareable;
        /// <summary>
        /// The iscsi login state of the volume attachment. For a multipath volume attachment, all iscsi sessions need to be all logged-in or logged-out to be in logged-in or logged-out state.
        /// </summary>
        public readonly string IscsiLoginState;
        /// <summary>
        /// A list of secondary multipath devices
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVolumeAttachmentsVolumeAttachmentMultipathDeviceResult> MultipathDevices;
        /// <summary>
        /// The volume's iSCSI port, usually port 860 or 3260.  Example: `3260`
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// The current state of the volume attachment.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The date and time the volume was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        public readonly string TimeCreated;
        public readonly bool UseChap;
        /// <summary>
        /// The OCID of the volume.
        /// </summary>
        public readonly string VolumeId;

        [OutputConstructor]
        private GetVolumeAttachmentsVolumeAttachmentResult(
            string attachmentType,

            string availabilityDomain,

            string chapSecret,

            string chapUsername,

            string compartmentId,

            string device,

            string displayName,

            string encryptionInTransitType,

            string id,

            string instanceId,

            string ipv4,

            string iqn,

            bool isMultipath,

            bool isPvEncryptionInTransitEnabled,

            bool isReadOnly,

            bool isShareable,

            string iscsiLoginState,

            ImmutableArray<Outputs.GetVolumeAttachmentsVolumeAttachmentMultipathDeviceResult> multipathDevices,

            int port,

            string state,

            string timeCreated,

            bool useChap,

            string volumeId)
        {
            AttachmentType = attachmentType;
            AvailabilityDomain = availabilityDomain;
            ChapSecret = chapSecret;
            ChapUsername = chapUsername;
            CompartmentId = compartmentId;
            Device = device;
            DisplayName = displayName;
            EncryptionInTransitType = encryptionInTransitType;
            Id = id;
            InstanceId = instanceId;
            Ipv4 = ipv4;
            Iqn = iqn;
            IsMultipath = isMultipath;
            IsPvEncryptionInTransitEnabled = isPvEncryptionInTransitEnabled;
            IsReadOnly = isReadOnly;
            IsShareable = isShareable;
            IscsiLoginState = iscsiLoginState;
            MultipathDevices = multipathDevices;
            Port = port;
            State = state;
            TimeCreated = timeCreated;
            UseChap = useChap;
            VolumeId = volumeId;
        }
    }
}