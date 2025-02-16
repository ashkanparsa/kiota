// <auto-generated/>
#pragma warning disable CS0618
using Kiota.Builder.SearchProviders.GitHub.GitHubClient.Repos;
using Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search;
using Kiota.Builder.SearchProviders.GitHub.GitHubClient.User;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Kiota.Builder.SearchProviders.GitHub.GitHubClient
{
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GitHubClient : BaseRequestBuilder
    {
        /// <summary>The repos property</summary>
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Repos.ReposRequestBuilder Repos
        {
            get => new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Repos.ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.SearchRequestBuilder Search
        {
            get => new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.Search.SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.User.UserRequestBuilder User
        {
            get => new global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Kiota.Builder.SearchProviders.GitHub.GitHubClient.GitHubClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitHubClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
        {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
            {
                RequestAdapter.BaseUrl = "https://api.github.com";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}
#pragma warning restore CS0618
