// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Kms.Outputs
{

    [OutputType]
    public sealed class GetKeyVersionsKeyVersionReplicaDetailsResult
    {
        /// <summary>
        /// ReplicationId associated with a key version operation
        /// </summary>
        public readonly string ReplicationId;

        [OutputConstructor]
        private GetKeyVersionsKeyVersionReplicaDetailsResult(string replicationId)
        {
            ReplicationId = replicationId;
        }
    }
}