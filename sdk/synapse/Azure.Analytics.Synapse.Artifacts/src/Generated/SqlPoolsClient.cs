// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The SqlPools service client. </summary>
    public partial class SqlPoolsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SqlPoolsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of SqlPoolsClient for mocking. </summary>
        protected SqlPoolsClient()
        {
        }

        /// <summary> Initializes a new instance of SqlPoolsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public SqlPoolsClient(string endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new SqlPoolsRestClient(_clientDiagnostics, _pipeline, endpoint, options.Version);
        }

        /// <summary> Initializes a new instance of SqlPoolsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal SqlPoolsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            RestClient = new SqlPoolsRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> List Sql Pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlPoolInfoListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlPoolsClient.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Sql Pools. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlPoolInfoListResult> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlPoolsClient.List");
            scope.Start();
            try
            {
                return RestClient.List(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Sql Pool. </summary>
        /// <param name="sqlPoolName"> The Sql Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlPool>> GetAsync(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlPoolsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(sqlPoolName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Sql Pool. </summary>
        /// <param name="sqlPoolName"> The Sql Pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlPool> Get(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlPoolsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(sqlPoolName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
