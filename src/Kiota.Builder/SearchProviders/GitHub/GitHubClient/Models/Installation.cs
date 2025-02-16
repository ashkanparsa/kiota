// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models
{
    /// <summary>
    /// Installation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Installation : IAdditionalDataHolder, IParsable
    {
        /// <summary>The access_tokens_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessTokensUrl { get; set; }
#nullable restore
#else
        public string AccessTokensUrl { get; set; }
#endif
        /// <summary>The account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account? Account { get; set; }
#nullable restore
#else
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account Account { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The app_id property</summary>
        public int? AppId { get; set; }
        /// <summary>The app_slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppSlug { get; set; }
#nullable restore
#else
        public string AppSlug { get; set; }
#endif
        /// <summary>The contact_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactEmail { get; set; }
#nullable restore
#else
        public string ContactEmail { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The events property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>The has_multiple_single_files property</summary>
        public bool? HasMultipleSingleFiles { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The ID of the installation.</summary>
        public int? Id { get; set; }
        /// <summary>The permissions granted to the user access token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.AppPermissions? Permissions { get; set; }
#nullable restore
#else
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.AppPermissions Permissions { get; set; }
#endif
        /// <summary>The repositories_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepositoriesUrl { get; set; }
#nullable restore
#else
        public string RepositoriesUrl { get; set; }
#endif
        /// <summary>Describe whether all repositories have been selected or there&apos;s a selection involved</summary>
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation_repository_selection? RepositorySelection { get; set; }
        /// <summary>The single_file_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SingleFileName { get; set; }
#nullable restore
#else
        public string SingleFileName { get; set; }
#endif
        /// <summary>The single_file_paths property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SingleFilePaths { get; set; }
#nullable restore
#else
        public List<string> SingleFilePaths { get; set; }
#endif
        /// <summary>The suspended_at property</summary>
        public DateTimeOffset? SuspendedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.NullableSimpleUser? SuspendedBy { get; set; }
#nullable restore
#else
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.NullableSimpleUser SuspendedBy { get; set; }
#endif
        /// <summary>The ID of the user or organization this token is being scoped to.</summary>
        public int? TargetId { get; set; }
        /// <summary>The target_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetType { get; set; }
#nullable restore
#else
        public string TargetType { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation"/> and sets the default values.
        /// </summary>
        public Installation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "access_tokens_url", n => { AccessTokensUrl = n.GetStringValue(); } },
                { "account", n => { Account = n.GetObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account>(global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account.CreateFromDiscriminatorValue); } },
                { "app_id", n => { AppId = n.GetIntValue(); } },
                { "app_slug", n => { AppSlug = n.GetStringValue(); } },
                { "contact_email", n => { ContactEmail = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "has_multiple_single_files", n => { HasMultipleSingleFiles = n.GetBoolValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "permissions", n => { Permissions = n.GetObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.AppPermissions>(global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.AppPermissions.CreateFromDiscriminatorValue); } },
                { "repositories_url", n => { RepositoriesUrl = n.GetStringValue(); } },
                { "repository_selection", n => { RepositorySelection = n.GetEnumValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation_repository_selection>(); } },
                { "single_file_name", n => { SingleFileName = n.GetStringValue(); } },
                { "single_file_paths", n => { SingleFilePaths = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "suspended_at", n => { SuspendedAt = n.GetDateTimeOffsetValue(); } },
                { "suspended_by", n => { SuspendedBy = n.GetObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.NullableSimpleUser>(global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.NullableSimpleUser.CreateFromDiscriminatorValue); } },
                { "target_id", n => { TargetId = n.GetIntValue(); } },
                { "target_type", n => { TargetType = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("access_tokens_url", AccessTokensUrl);
            writer.WriteObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account>("account", Account);
            writer.WriteIntValue("app_id", AppId);
            writer.WriteStringValue("app_slug", AppSlug);
            writer.WriteStringValue("contact_email", ContactEmail);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteBoolValue("has_multiple_single_files", HasMultipleSingleFiles);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.AppPermissions>("permissions", Permissions);
            writer.WriteStringValue("repositories_url", RepositoriesUrl);
            writer.WriteEnumValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation_repository_selection>("repository_selection", RepositorySelection);
            writer.WriteStringValue("single_file_name", SingleFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("single_file_paths", SingleFilePaths);
            writer.WriteDateTimeOffsetValue("suspended_at", SuspendedAt);
            writer.WriteObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.NullableSimpleUser>("suspended_by", SuspendedBy);
            writer.WriteIntValue("target_id", TargetId);
            writer.WriteStringValue("target_type", TargetType);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise"/>, <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.SimpleUser"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Installation_account : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise? Enterprise { get; set; }
#nullable restore
#else
            public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise Enterprise { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.SimpleUser"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.SimpleUser? SimpleUser { get; set; }
#nullable restore
#else
            public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.SimpleUser SimpleUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Installation.Installation_account();
                result.Enterprise = new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise();
                result.SimpleUser = new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.SimpleUser();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(Enterprise != null || SimpleUser != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(Enterprise, SimpleUser);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Models.Enterprise>(null, Enterprise, SimpleUser);
            }
        }
    }
}
#pragma warning restore CS0618
