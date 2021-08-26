// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Database.Outputs
{

    [OutputType]
    public sealed class GetAutonomousDbVersionsAutonomousDbVersionResult
    {
        /// <summary>
        /// A filter to return only autonomous database resources that match the specified workload type.
        /// </summary>
        public readonly string DbWorkload;
        /// <summary>
        /// A URL that points to a detailed description of the Autonomous Database version.
        /// </summary>
        public readonly string Details;
        /// <summary>
        /// True if the database uses [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/adbddoverview.htm).
        /// </summary>
        public readonly bool IsDedicated;
        /// <summary>
        /// True if this version of the Oracle Database software's default is free.
        /// </summary>
        public readonly bool IsDefaultForFree;
        /// <summary>
        /// True if this version of the Oracle Database software's default is paid.
        /// </summary>
        public readonly bool IsDefaultForPaid;
        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        public readonly bool IsFreeTierEnabled;
        /// <summary>
        /// True if this version of the Oracle Database software has payments enabled.
        /// </summary>
        public readonly bool IsPaidEnabled;
        /// <summary>
        /// A valid Oracle Database version for Autonomous Database.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetAutonomousDbVersionsAutonomousDbVersionResult(
            string dbWorkload,

            string details,

            bool isDedicated,

            bool isDefaultForFree,

            bool isDefaultForPaid,

            bool isFreeTierEnabled,

            bool isPaidEnabled,

            string version)
        {
            DbWorkload = dbWorkload;
            Details = details;
            IsDedicated = isDedicated;
            IsDefaultForFree = isDefaultForFree;
            IsDefaultForPaid = isDefaultForPaid;
            IsFreeTierEnabled = isFreeTierEnabled;
            IsPaidEnabled = isPaidEnabled;
            Version = version;
        }
    }
}