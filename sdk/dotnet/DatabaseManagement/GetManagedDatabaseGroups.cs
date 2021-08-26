// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.DatabaseManagement
{
    public static class GetManagedDatabaseGroups
    {
        /// <summary>
        /// This data source provides the list of Managed Database Groups in Oracle Cloud Infrastructure Database Management service.
        /// 
        /// Gets the Managed Database Group for a specific ID or the list of Managed Database Groups in
        /// a specific compartment. Managed Database Groups can also be filtered based on the name parameter.
        /// Only one of the parameters, ID or name should be provided. If none of these parameters is provided,
        /// all the Managed Database Groups in the compartment are listed.
        /// 
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Oci = Pulumi.Oci;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var testManagedDatabaseGroups = Output.Create(Oci.DatabaseManagement.GetManagedDatabaseGroups.InvokeAsync(new Oci.DatabaseManagement.GetManagedDatabaseGroupsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             Id = @var.Managed_database_group_id,
        ///             Name = @var.Managed_database_group_name,
        ///             State = @var.Managed_database_group_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetManagedDatabaseGroupsResult> InvokeAsync(GetManagedDatabaseGroupsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagedDatabaseGroupsResult>("oci:databasemanagement/getManagedDatabaseGroups:getManagedDatabaseGroups", args ?? new GetManagedDatabaseGroupsArgs(), options.WithVersion());
    }


    public sealed class GetManagedDatabaseGroupsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetManagedDatabaseGroupsFilterArgs>? _filters;
        public List<Inputs.GetManagedDatabaseGroupsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetManagedDatabaseGroupsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The identifier of the resource. Only one of the parameters, id or name should be provided.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A filter to return only resources that match the entire name. Only one of the parameters, id or name should be provided
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The lifecycle state of a resource.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetManagedDatabaseGroupsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetManagedDatabaseGroupsResult
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which the Managed Database resides.
        /// </summary>
        public readonly string CompartmentId;
        public readonly ImmutableArray<Outputs.GetManagedDatabaseGroupsFilterResult> Filters;
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The list of managed_database_group_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetManagedDatabaseGroupsManagedDatabaseGroupCollectionResult> ManagedDatabaseGroupCollections;
        /// <summary>
        /// The name of the Managed Database Group.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The current lifecycle state of the Managed Database Group.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetManagedDatabaseGroupsResult(
            string compartmentId,

            ImmutableArray<Outputs.GetManagedDatabaseGroupsFilterResult> filters,

            string? id,

            ImmutableArray<Outputs.GetManagedDatabaseGroupsManagedDatabaseGroupCollectionResult> managedDatabaseGroupCollections,

            string? name,

            string? state)
        {
            CompartmentId = compartmentId;
            Filters = filters;
            Id = id;
            ManagedDatabaseGroupCollections = managedDatabaseGroupCollections;
            Name = name;
            State = state;
        }
    }
}