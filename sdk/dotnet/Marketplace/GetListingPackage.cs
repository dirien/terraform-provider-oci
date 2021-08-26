// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.Marketplace
{
    public static class GetListingPackage
    {
        /// <summary>
        /// This data source provides details about a specific Listing Package resource in Oracle Cloud Infrastructure Marketplace service.
        /// 
        /// Get the details of the specified version of a package, including information needed to launch the package.
        /// 
        /// If you plan to launch an instance from an image listing, you must first subscribe to the listing. When
        /// you launch the instance, you also need to provide the image ID of the listing resource version that you want.
        /// 
        /// Subscribing to the listing requires you to first get a signature from the terms of use agreement for the
        /// listing resource version. To get the signature, issue a [GetAppCatalogListingAgreements](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogListingResourceVersionAgreements/GetAppCatalogListingAgreements) API call.
        /// The [AppCatalogListingResourceVersionAgreements](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogListingResourceVersionAgreements) object, including
        /// its signature, is returned in the response. With the signature for the terms of use agreement for the desired
        /// listing resource version, create a subscription by issuing a
        /// [CreateAppCatalogSubscription](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogSubscription/CreateAppCatalogSubscription) API call.
        /// 
        /// To get the image ID to launch an instance, issue a [GetAppCatalogListingResourceVersion](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogListingResourceVersion/GetAppCatalogListingResourceVersion) API call.
        /// Lastly, to launch the instance, use the image ID of the listing resource version to issue a [LaunchInstance](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/Instance/LaunchInstance) API call.
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
        ///         var testListingPackage = Output.Create(Oci.Marketplace.GetListingPackage.InvokeAsync(new Oci.Marketplace.GetListingPackageArgs
        ///         {
        ///             ListingId = oci_marketplace_listing.Test_listing.Id,
        ///             PackageVersion = @var.Listing_package_package_version,
        ///             CompartmentId = @var.Compartment_id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetListingPackageResult> InvokeAsync(GetListingPackageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetListingPackageResult>("oci:marketplace/getListingPackage:getListingPackage", args ?? new GetListingPackageArgs(), options.WithVersion());
    }


    public sealed class GetListingPackageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique identifier for the compartment.
        /// </summary>
        [Input("compartmentId")]
        public string? CompartmentId { get; set; }

        /// <summary>
        /// The unique identifier for the listing.
        /// </summary>
        [Input("listingId", required: true)]
        public string ListingId { get; set; } = null!;

        /// <summary>
        /// The version of the package. Package versions are unique within a listing.
        /// </summary>
        [Input("packageVersion", required: true)]
        public string PackageVersion { get; set; } = null!;

        public GetListingPackageArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetListingPackageResult
    {
        /// <summary>
        /// The ID of the listing resource associated with this listing package. For more information, see [AppCatalogListing](https://docs.cloud.oracle.com/en-us/iaas/api/#/en/iaas/latest/AppCatalogListing/) in the Core Services API.
        /// </summary>
        public readonly string AppCatalogListingId;
        /// <summary>
        /// The resource version of the listing resource associated with this listing package.
        /// </summary>
        public readonly string AppCatalogListingResourceVersion;
        public readonly string? CompartmentId;
        /// <summary>
        /// A description of the variable.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The id of the image corresponding to the package.
        /// </summary>
        public readonly string ImageId;
        /// <summary>
        /// The ID of the listing that the specified package belongs to.
        /// </summary>
        public readonly string ListingId;
        /// <summary>
        /// OS used by the listing.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListingPackageOperatingSystemResult> OperatingSystems;
        /// <summary>
        /// The specified package's type.
        /// </summary>
        public readonly string PackageType;
        public readonly string PackageVersion;
        /// <summary>
        /// The model for pricing.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListingPackagePricingResult> Pricings;
        /// <summary>
        /// The regions where the listing is available.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListingPackageRegionResult> Regions;
        /// <summary>
        /// The unique identifier for the package resource.
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// Link to the orchestration resource.
        /// </summary>
        public readonly string ResourceLink;
        /// <summary>
        /// The date and time this listing package was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.  Example: `2016-08-25T21:10:29.600Z`
        /// </summary>
        public readonly string TimeCreated;
        /// <summary>
        /// List of variables for the orchestration resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListingPackageVariableResult> Variables;
        /// <summary>
        /// The package version.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private GetListingPackageResult(
            string appCatalogListingId,

            string appCatalogListingResourceVersion,

            string? compartmentId,

            string description,

            string id,

            string imageId,

            string listingId,

            ImmutableArray<Outputs.GetListingPackageOperatingSystemResult> operatingSystems,

            string packageType,

            string packageVersion,

            ImmutableArray<Outputs.GetListingPackagePricingResult> pricings,

            ImmutableArray<Outputs.GetListingPackageRegionResult> regions,

            string resourceId,

            string resourceLink,

            string timeCreated,

            ImmutableArray<Outputs.GetListingPackageVariableResult> variables,

            string version)
        {
            AppCatalogListingId = appCatalogListingId;
            AppCatalogListingResourceVersion = appCatalogListingResourceVersion;
            CompartmentId = compartmentId;
            Description = description;
            Id = id;
            ImageId = imageId;
            ListingId = listingId;
            OperatingSystems = operatingSystems;
            PackageType = packageType;
            PackageVersion = packageVersion;
            Pricings = pricings;
            Regions = regions;
            ResourceId = resourceId;
            ResourceLink = resourceLink;
            TimeCreated = timeCreated;
            Variables = variables;
            Version = version;
        }
    }
}