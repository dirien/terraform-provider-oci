// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Inputs
{

    public sealed class ApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersArgs : Pulumi.ResourceArgs
    {
        [Input("items", required: true)]
        private InputList<Inputs.ApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersItemArgs>? _items;

        /// <summary>
        /// (Updatable) The list of headers.
        /// </summary>
        public InputList<Inputs.ApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersItemArgs> Items
        {
            get => _items ?? (_items = new InputList<Inputs.ApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersItemArgs>());
            set => _items = value;
        }

        /// <summary>
        /// (Updatable) Type of the Response Cache Store Policy.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ApigatewayDeploymentSpecificationRouteRequestPoliciesQueryParameterTransformationsFilterQueryParametersArgs()
        {
        }
    }
}