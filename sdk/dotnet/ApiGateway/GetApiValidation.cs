// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.ApiGateway
{
    public static class GetApiValidation
    {
        /// <summary>
        /// This data source provides details about a specific Api Validation resource in Oracle Cloud Infrastructure API Gateway service.
        /// 
        /// Gets the API validation results.
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
        ///         var testApiValidation = Output.Create(Oci.ApiGateway.GetApiValidation.InvokeAsync(new Oci.ApiGateway.GetApiValidationArgs
        ///         {
        ///             ApiId = oci_apigateway_api.Test_api.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetApiValidationResult> InvokeAsync(GetApiValidationArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiValidationResult>("oci:apigateway/getApiValidation:getApiValidation", args ?? new GetApiValidationArgs(), options.WithVersion());
    }


    public sealed class GetApiValidationArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ocid of the API.
        /// </summary>
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

        public GetApiValidationArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiValidationResult
    {
        public readonly string ApiId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// API validation results.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApiValidationValidationResult> Validations;

        [OutputConstructor]
        private GetApiValidationResult(
            string apiId,

            string id,

            ImmutableArray<Outputs.GetApiValidationValidationResult> validations)
        {
            ApiId = apiId;
            Id = id;
            Validations = validations;
        }
    }
}