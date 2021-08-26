// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.DatabaseManagement.Outputs
{

    [OutputType]
    public sealed class ManagedDatabaseGroupManagedDatabase
    {
        /// <summary>
        /// (Updatable) The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which the Managed Database Group resides.
        /// </summary>
        public readonly string? CompartmentId;
        /// <summary>
        /// The subtype of the Oracle Database. Indicates whether the database is a Container Database, Pluggable Database, or a Non-container Database.
        /// </summary>
        public readonly string? DatabaseSubType;
        /// <summary>
        /// The type of Oracle Database installation.
        /// </summary>
        public readonly string? DatabaseType;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the managed database that needs to be added to the Managed Database Group.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the Managed Database Group. Valid characters are uppercase or lowercase letters, numbers, and "_". The name of the Managed Database Group cannot be modified. It must be unique in the compartment and must begin with an alphabetic character.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The date and time the Managed Database was added to the group.
        /// </summary>
        public readonly string? TimeAdded;

        [OutputConstructor]
        private ManagedDatabaseGroupManagedDatabase(
            string? compartmentId,

            string? databaseSubType,

            string? databaseType,

            string? id,

            string? name,

            string? timeAdded)
        {
            CompartmentId = compartmentId;
            DatabaseSubType = databaseSubType;
            DatabaseType = databaseType;
            Id = id;
            Name = name;
            TimeAdded = timeAdded;
        }
    }
}