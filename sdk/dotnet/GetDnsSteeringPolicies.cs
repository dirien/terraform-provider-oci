// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci
{
    public static class GetDnsSteeringPolicies
    {
        /// <summary>
        /// This data source provides the list of Steering Policies in Oracle Cloud Infrastructure DNS service.
        /// 
        /// Gets a list of all steering policies in the specified compartment.
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
        ///         var testSteeringPolicies = Output.Create(Oci.GetDnsSteeringPolicies.InvokeAsync(new Oci.GetDnsSteeringPoliciesArgs
        ///         {
        ///             CompartmentId = @var.Compartment_id,
        ///             DisplayName = @var.Steering_policy_display_name,
        ///             DisplayNameContains = @var.Steering_policy_display_name_contains,
        ///             HealthCheckMonitorId = oci_health_checks_http_monitor.Test_http_monitor.Id,
        ///             Id = @var.Steering_policy_id,
        ///             State = @var.Steering_policy_state,
        ///             Template = @var.Steering_policy_template,
        ///             TimeCreatedGreaterThanOrEqualTo = @var.Steering_policy_time_created_greater_than_or_equal_to,
        ///             TimeCreatedLessThan = @var.Steering_policy_time_created_less_than,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDnsSteeringPoliciesResult> InvokeAsync(GetDnsSteeringPoliciesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDnsSteeringPoliciesResult>("oci:index/getDnsSteeringPolicies:GetDnsSteeringPolicies", args ?? new GetDnsSteeringPoliciesArgs(), options.WithVersion());
    }


    public sealed class GetDnsSteeringPoliciesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The OCID of the compartment the resource belongs to.
        /// </summary>
        [Input("compartmentId", required: true)]
        public string CompartmentId { get; set; } = null!;

        /// <summary>
        /// The displayName of a resource.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The partial displayName of a resource. Will match any resource whose name (case-insensitive) contains the provided value.
        /// </summary>
        [Input("displayNameContains")]
        public string? DisplayNameContains { get; set; }

        [Input("filters")]
        private List<Inputs.GetDnsSteeringPoliciesFilterArgs>? _filters;
        public List<Inputs.GetDnsSteeringPoliciesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDnsSteeringPoliciesFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Search by health check monitor OCID. Will match any resource whose health check monitor ID matches the provided value.
        /// </summary>
        [Input("healthCheckMonitorId")]
        public string? HealthCheckMonitorId { get; set; }

        /// <summary>
        /// The OCID of a resource.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The state of a resource.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        /// <summary>
        /// Search by steering template type. Will match any resource whose template type matches the provided value.
        /// </summary>
        [Input("template")]
        public string? Template { get; set; }

        /// <summary>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states all returned resources were created on or after the indicated time.
        /// </summary>
        [Input("timeCreatedGreaterThanOrEqualTo")]
        public string? TimeCreatedGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// An [RFC 3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp that states all returned resources were created before the indicated time.
        /// </summary>
        [Input("timeCreatedLessThan")]
        public string? TimeCreatedLessThan { get; set; }

        public GetDnsSteeringPoliciesArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDnsSteeringPoliciesResult
    {
        /// <summary>
        /// The OCID of the compartment containing the steering policy.
        /// </summary>
        public readonly string CompartmentId;
        /// <summary>
        /// A user-friendly name for the steering policy. Does not have to be unique and can be changed. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        public readonly string? DisplayNameContains;
        public readonly ImmutableArray<Outputs.GetDnsSteeringPoliciesFilterResult> Filters;
        /// <summary>
        /// The OCID of the health check monitor providing health data about the answers of the steering policy. A steering policy answer with `rdata` matching a monitored endpoint will use the health data of that endpoint. A steering policy answer with `rdata` not matching any monitored endpoint will be assumed healthy.
        /// </summary>
        public readonly string? HealthCheckMonitorId;
        /// <summary>
        /// The OCID of the resource.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The current state of the resource.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// The list of steering_policies.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDnsSteeringPoliciesSteeringPolicyResult> SteeringPolicies;
        /// <summary>
        /// A set of predefined rules based on the desired purpose of the steering policy. Each template utilizes Traffic Management's rules in a different order to produce the desired results when answering DNS queries.
        /// </summary>
        public readonly string? Template;
        public readonly string? TimeCreatedGreaterThanOrEqualTo;
        public readonly string? TimeCreatedLessThan;

        [OutputConstructor]
        private GetDnsSteeringPoliciesResult(
            string compartmentId,

            string? displayName,

            string? displayNameContains,

            ImmutableArray<Outputs.GetDnsSteeringPoliciesFilterResult> filters,

            string? healthCheckMonitorId,

            string? id,

            string? state,

            ImmutableArray<Outputs.GetDnsSteeringPoliciesSteeringPolicyResult> steeringPolicies,

            string? template,

            string? timeCreatedGreaterThanOrEqualTo,

            string? timeCreatedLessThan)
        {
            CompartmentId = compartmentId;
            DisplayName = displayName;
            DisplayNameContains = displayNameContains;
            Filters = filters;
            HealthCheckMonitorId = healthCheckMonitorId;
            Id = id;
            State = state;
            SteeringPolicies = steeringPolicies;
            Template = template;
            TimeCreatedGreaterThanOrEqualTo = timeCreatedGreaterThanOrEqualTo;
            TimeCreatedLessThan = timeCreatedLessThan;
        }
    }
}