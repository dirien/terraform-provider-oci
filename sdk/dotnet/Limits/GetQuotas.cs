// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Limits
{
    public static class GetQuotas
    {
        /// <summary>
        /// This data source provides the list of Quotas in Oracle Cloud Infrastructure Limits service.
        /// 
        /// Lists all quotas on resources from the given compartment.
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
        ///         var testQuotas = Output.Create(Oci.Limits.GetQuotas.InvokeAsync(new Oci.Limits.GetQuotasArgs
        ///         {
        ///             CompartmentId = @var.Tenancy_ocid,
        ///             Name = @var.Quota_name,
        ///             State = @var.Quota_state,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetQuotasResult> InvokeAsync(GetQuotasArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetQuotasResult>("oci:limits/getQuotas:getQuotas", args ?? new GetQuotasArgs(), options.WithVersion());
    }


    public sealed class GetQuotasArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The OCID of the parent compartment (remember that the tenancy is simply the root compartment).
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        [Input("filters")]
        private List<Inputs.GetQuotasFilterArgs>? _filters;
        public List<Inputs.GetQuotasFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetQuotasFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// name
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Filters returned quotas based on the given state.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        public GetQuotasArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetQuotasResult
    {
        /// <summary>
        /// The OCID of the compartment containing the resource this quota applies to.
        /// </summary>
        public readonly string CompartmentId;
        public readonly ImmutableArray<Outputs.GetQuotasFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name you assign to the quota during creation. The name must be unique across all quotas in the tenancy and cannot be changed.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The list of quotas.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetQuotasQuotaResult> Quotas;
        /// <summary>
        /// The quota's current state.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private GetQuotasResult(
            string compartmentId,

            ImmutableArray<Outputs.GetQuotasFilterResult> filters,

            string id,

            string? name,

            ImmutableArray<Outputs.GetQuotasQuotaResult> quotas,

            string? state)
        {
            CompartmentId = compartmentId;
            Filters = filters;
            Id = id;
            Name = name;
            Quotas = quotas;
            State = state;
        }
    }
}