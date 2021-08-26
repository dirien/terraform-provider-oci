// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.NetworkLoadBalancer
{
    public static class GetBackendHealth
    {
        /// <summary>
        /// This data source provides details about a specific Backend Health resource in Oracle Cloud Infrastructure Network Load Balancer service.
        /// 
        /// Retrieves the current health status of the specified backend server.
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
        ///         var testBackendHealth = Output.Create(Oci.NetworkLoadBalancer.GetBackendHealth.InvokeAsync(new Oci.NetworkLoadBalancer.GetBackendHealthArgs
        ///         {
        ///             BackendName = oci_network_load_balancer_backend.Test_backend.Name,
        ///             BackendSetName = oci_network_load_balancer_backend_set.Test_backend_set.Name,
        ///             NetworkLoadBalancerId = oci_network_load_balancer_network_load_balancer.Test_network_load_balancer.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBackendHealthResult> InvokeAsync(GetBackendHealthArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBackendHealthResult>("oci:networkloadbalancer/getBackendHealth:getBackendHealth", args ?? new GetBackendHealthArgs(), options.WithVersion());
    }


    public sealed class GetBackendHealthArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the backend server for which to retrieve the health status, specified as &lt;ip&gt;:&lt;port&gt; or as &lt;ip&gt; &lt;OCID&gt;:&lt;port&gt;.  Example: `10.0.0.3:8080` or `ocid1.privateip..oc1.&lt;var&gt;&amp;lt;unique_ID&amp;gt;&lt;/var&gt;:8080`
        /// </summary>
        [Input("backendName", required: true)]
        public string BackendName { get; set; } = null!;

        /// <summary>
        /// The name of the backend set associated with the backend server for which to retrieve the health status.  Example: `example_backend_set`
        /// </summary>
        [Input("backendSetName", required: true)]
        public string BackendSetName { get; set; } = null!;

        /// <summary>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the network load balancer to update.
        /// </summary>
        [Input("networkLoadBalancerId", required: true)]
        public string NetworkLoadBalancerId { get; set; } = null!;

        public GetBackendHealthArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBackendHealthResult
    {
        public readonly string BackendName;
        public readonly string BackendSetName;
        /// <summary>
        /// A list of the most recent health check results returned for the specified backend server.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBackendHealthHealthCheckResultResult> HealthCheckResults;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string NetworkLoadBalancerId;
        /// <summary>
        /// The general health status of the specified backend server.
        /// *   **OK:**  All health check probes return `OK`
        /// *   **WARNING:** At least one of the health check probes does not return `OK`
        /// *   **CRITICAL:** None of the health check probes return `OK`. *
        /// *   **UNKNOWN:** One of the health checks probes return `UNKNOWN`,
        /// *   or the system is unable to retrieve metrics at this time.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetBackendHealthResult(
            string backendName,

            string backendSetName,

            ImmutableArray<Outputs.GetBackendHealthHealthCheckResultResult> healthCheckResults,

            string id,

            string networkLoadBalancerId,

            string status)
        {
            BackendName = backendName;
            BackendSetName = backendSetName;
            HealthCheckResults = healthCheckResults;
            Id = id;
            NetworkLoadBalancerId = networkLoadBalancerId;
            Status = status;
        }
    }
}