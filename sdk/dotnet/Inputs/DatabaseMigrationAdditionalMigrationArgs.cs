// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Inputs
{

    public sealed class DatabaseMigrationAdditionalMigrationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure.
        /// </summary>
        [Input("cloudExadataInfrastructureId")]
        public Input<string>? CloudExadataInfrastructureId { get; set; }

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cloud VM cluster.
        /// </summary>
        [Input("cloudVmClusterId")]
        public Input<string>? CloudVmClusterId { get; set; }

        /// <summary>
        /// The DB system [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </summary>
        [Input("dbSystemId")]
        public Input<string>? DbSystemId { get; set; }

        public DatabaseMigrationAdditionalMigrationArgs()
        {
        }
    }
}