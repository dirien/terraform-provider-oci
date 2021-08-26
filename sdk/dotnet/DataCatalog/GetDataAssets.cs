// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Oci.DataCatalog
{
    public static class GetDataAssets
    {
        /// <summary>
        /// This data source provides the list of Data Assets in Oracle Cloud Infrastructure Data Catalog service.
        /// 
        /// Returns a list of data assets within a data catalog.
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
        ///         var testDataAssets = Output.Create(Oci.DataCatalog.GetDataAssets.InvokeAsync(new Oci.DataCatalog.GetDataAssetsArgs
        ///         {
        ///             CatalogId = oci_datacatalog_catalog.Test_catalog.Id,
        ///             CreatedById = oci_datacatalog_created_by.Test_created_by.Id,
        ///             DisplayName = @var.Data_asset_display_name,
        ///             DisplayNameContains = @var.Data_asset_display_name_contains,
        ///             ExternalKey = @var.Data_asset_external_key,
        ///             Fields = @var.Data_asset_fields,
        ///             State = @var.Data_asset_state,
        ///             TimeCreated = @var.Data_asset_time_created,
        ///             TimeUpdated = @var.Data_asset_time_updated,
        ///             TypeKey = @var.Data_asset_type_key,
        ///             UpdatedById = oci_datacatalog_updated_by.Test_updated_by.Id,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDataAssetsResult> InvokeAsync(GetDataAssetsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDataAssetsResult>("oci:datacatalog/getDataAssets:getDataAssets", args ?? new GetDataAssetsArgs(), options.WithVersion());
    }


    public sealed class GetDataAssetsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique catalog identifier.
        /// </summary>
        [Input("catalogId", required: true)]
        public string CatalogId { get; set; } = null!;

        /// <summary>
        /// OCID of the user who created the resource.
        /// </summary>
        [Input("createdById")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </summary>
        [Input("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// A filter to return only resources that match display name pattern given. The match is not case sensitive. For Example : /folders?displayNameContains=Cu.* The above would match all folders with display name that starts with "Cu".
        /// </summary>
        [Input("displayNameContains")]
        public string? DisplayNameContains { get; set; }

        /// <summary>
        /// Unique external identifier of this resource in the external source system.
        /// </summary>
        [Input("externalKey")]
        public string? ExternalKey { get; set; }

        [Input("fields")]
        private List<string>? _fields;

        /// <summary>
        /// Specifies the fields to return in a data asset summary response.
        /// </summary>
        public List<string> Fields
        {
            get => _fields ?? (_fields = new List<string>());
            set => _fields = value;
        }

        [Input("filters")]
        private List<Inputs.GetDataAssetsFilterArgs>? _filters;
        public List<Inputs.GetDataAssetsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDataAssetsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// A filter to return only resources that match the specified lifecycle state. The value is case insensitive.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        /// <summary>
        /// The key of the object type.
        /// </summary>
        [Input("typeKey")]
        public string? TypeKey { get; set; }

        public GetDataAssetsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDataAssetsResult
    {
        /// <summary>
        /// The data catalog's OCID.
        /// </summary>
        public readonly string CatalogId;
        /// <summary>
        /// OCID of the user who created the data asset.
        /// </summary>
        public readonly string? CreatedById;
        /// <summary>
        /// The list of data_asset_collection.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDataAssetsDataAssetCollectionResult> DataAssetCollections;
        /// <summary>
        /// A user-friendly display name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </summary>
        public readonly string? DisplayName;
        public readonly string? DisplayNameContains;
        /// <summary>
        /// External URI that can be used to reference the object. Format will differ based on the type of object.
        /// </summary>
        public readonly string? ExternalKey;
        public readonly ImmutableArray<string> Fields;
        public readonly ImmutableArray<Outputs.GetDataAssetsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The current state of the data asset.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// The key of the object type. Type key's can be found via the '/types' endpoint.
        /// </summary>
        public readonly string? TypeKey;

        [OutputConstructor]
        private GetDataAssetsResult(
            string catalogId,

            string? createdById,

            ImmutableArray<Outputs.GetDataAssetsDataAssetCollectionResult> dataAssetCollections,

            string? displayName,

            string? displayNameContains,

            string? externalKey,

            ImmutableArray<string> fields,

            ImmutableArray<Outputs.GetDataAssetsFilterResult> filters,

            string id,

            string? state,

            string? typeKey)
        {
            CatalogId = catalogId;
            CreatedById = createdById;
            DataAssetCollections = dataAssetCollections;
            DisplayName = displayName;
            DisplayNameContains = displayNameContains;
            ExternalKey = externalKey;
            Fields = fields;
            Filters = filters;
            Id = id;
            State = state;
            TypeKey = typeKey;
        }
    }
}