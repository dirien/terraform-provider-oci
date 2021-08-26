// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.GoldenGate
{
    public static class GetDatabaseRegistrations
    {
        /// <summary>
        /// This data source provides the list of Database Registrations in Oracle Cloud Infrastructure Golden Gate service.
        /// 
        /// Lists the DatabaseRegistrations in the compartment.
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
        ///         var testDatabaseRegistrations = Output.Create(Oci.GoldenGate.GetDatabaseRegistrations.InvokeAsync(new Oci.GoldenGate.GetDatabaseRegistrationsArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Database_registration_display_name,
        ///             State = @var.Database_registration_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDatabaseRegistrationsResult> InvokeAsync(GetDatabaseRegistrationsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseRegistrationsResult>("oci:goldengate/getDatabaseRegistrations:getDatabaseRegistrations", args ?? new GetDatabaseRegistrationsArgs(), options.WithVersion());
    }


    public sealed class GetDatabaseRegistrationsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the compartment in which to list resources.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// A filter to return only the resources that match the entire 'displayName' given.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        [Input("filters")]
        private List<Inputs.GetDatabaseRegistrationsFilterArgs>? _filters;
        public List<Inputs.GetDatabaseRegistrationsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDatabaseRegistrationsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A filter to return only the resources that match the 'lifecycleState' given.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetDatabaseRegistrationsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDatabaseRegistrationsResult
    {
        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment being referenced.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// The list of database_registration_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDatabaseRegistrationsDatabaseRegistrationCollectionResult> DatabaseRegistrationCollections;
        /// <summary>
        /// An object's Display Name.
        /// </summary>
        public readonly string? DisplayName;
        public readonly ImmutableArray<Outputs.GetDatabaseRegistrationsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Possible lifecycle states.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetDatabaseRegistrationsResult(
            string compartmentId,

            ImmutableArray<Outputs.GetDatabaseRegistrationsDatabaseRegistrationCollectionResult> databaseRegistrationCollections,

            string? displayName,

            ImmutableArray<Outputs.GetDatabaseRegistrationsFilterResult> filters,

            string id,

            string? state)
        {
            CompartmentId = compartmentId;
            DatabaseRegistrationCollections = databaseRegistrationCollections;
            DisplayName = displayName;
            Filters = filters;
            Id = id;
            State = state;
        }
    }
}