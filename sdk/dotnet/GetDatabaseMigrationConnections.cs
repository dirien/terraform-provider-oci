// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetDatabaseMigrationConnections
    {
        /// <summary>
        /// This data source provides the list of Connections in Oracle Cloud Infrastructure Database Migration service.
        /// 
        /// List all Database Connections.
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
        ///         var testConnections = Output.Create(Oci.GetDatabaseMigrationConnections.InvokeAsync(new Oci.GetDatabaseMigrationConnectionsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Connection_display_name,
        ///             State = @var.Connection_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDatabaseMigrationConnectionsResult> InvokeAsync(GetDatabaseMigrationConnectionsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseMigrationConnectionsResult>("oci:index/getDatabaseMigrationConnections:GetDatabaseMigrationConnections", args ?? new GetDatabaseMigrationConnectionsArgs(), options.WithVersion());
    }


    public sealed class GetDatabaseMigrationConnectionsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the compartment in which to list resources.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// A filter to return only resources that match the entire display name given.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetDatabaseMigrationConnectionsFilterArgs>? _filters;
        public List<Inputs.GetDatabaseMigrationConnectionsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDatabaseMigrationConnectionsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The current state of the Database Migration Deployment.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetDatabaseMigrationConnectionsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDatabaseMigrationConnectionsResult
    {
        /// <summary>
        /// OCID of the compartment where the secret containing the credentials will be created.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// The list of connection_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDatabaseMigrationConnectionsConnectionCollectionResult> ConnectionCollections;
        /// <summary>
        /// Database Connection display name identifier.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetDatabaseMigrationConnectionsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The current state of the Connection resource.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetDatabaseMigrationConnectionsResult(
            string compartmentId,

            ImmutableArray<Outputs.GetDatabaseMigrationConnectionsConnectionCollectionResult> connectionCollections,

            string? displayName,

            ImmutableArray<Outputs.GetDatabaseMigrationConnectionsFilterResult> filters,

            string id,

            string? state)
        {
            CompartmentId = compartmentId;
            ConnectionCollections = connectionCollections;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            State = state;
        }
    }
}