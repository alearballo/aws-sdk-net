/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.TimestreamQuery.Model;
using Amazon.TimestreamQuery.Model.Internal.MarshallTransformations;
using Amazon.TimestreamQuery.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.TimestreamQuery
{
    /// <summary>
    /// Implementation for accessing TimestreamQuery
    ///
    /// Amazon Timestream Query
    /// </summary>
    public partial class AmazonTimestreamQueryClient : AmazonServiceClient, IAmazonTimestreamQuery
    {
        private static IServiceMetadata serviceMetadata = new AmazonTimestreamQueryMetadata();
        private ITimestreamQueryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITimestreamQueryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TimestreamQueryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonTimestreamQueryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamQueryConfig()) { }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamQueryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTimestreamQueryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonTimestreamQueryClient Configuration Object</param>
        public AmazonTimestreamQueryClient(AmazonTimestreamQueryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTimestreamQueryClient(AWSCredentials credentials)
            : this(credentials, new AmazonTimestreamQueryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamQueryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTimestreamQueryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Credentials and an
        /// AmazonTimestreamQueryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTimestreamQueryClient Configuration Object</param>
        public AmazonTimestreamQueryClient(AWSCredentials credentials, AmazonTimestreamQueryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamQueryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTimestreamQueryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamQueryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTimestreamQueryClient Configuration Object</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTimestreamQueryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamQueryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTimestreamQueryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTimestreamQueryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTimestreamQueryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTimestreamQueryClient Configuration Object</param>
        public AmazonTimestreamQueryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTimestreamQueryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region  EndpointOperation Override

        protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
        {
            return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>
            {
                var request = new DescribeEndpointsRequest
                {
                };
                
                var response = DescribeEndpoints(request);
                if(response.HttpStatusCode != HttpStatusCode.OK || response.Endpoints == null)
                {
                    return null;
                }

                var endpoints = new List<DiscoveryEndpointBase>();
                foreach(var endpoint in response.Endpoints)
                {
                    endpoints.Add(new DiscoveryEndpoint(endpoint.Address, endpoint.CachePeriodInMinutes));
                }
            
                return endpoints;
            });
        }

        #endregion

        #region  CancelQuery


        /// <summary>
        /// Cancels a query that has been issued. Cancellation is provided only if the query
        /// has not completed running before the cancellation request was issued. Because cancellation
        /// is an idempotent operation, subsequent cancellation requests will return a <code>CancellationMessage</code>,
        /// indicating that the query has already been canceled. See <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/code-samples.cancel-query.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CancelQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CancelQueryResponse>(request, options);
        }


        /// <summary>
        /// Cancels a query that has been issued. Cancellation is provided only if the query
        /// has not completed running before the cancellation request was issued. Because cancellation
        /// is an idempotent operation, subsequent cancellation requests will return a <code>CancellationMessage</code>,
        /// indicating that the query has already been canceled. See <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/code-samples.cancel-query.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CancelQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<CancelQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScheduledQuery


        /// <summary>
        /// Create a scheduled query that will be run on your behalf at the configured schedule.
        /// Timestream assumes the execution role provided as part of the <code>ScheduledQueryExecutionRoleArn</code>
        /// parameter to run the query. You can use the <code>NotificationConfiguration</code>
        /// parameter to configure notification for your scheduled query operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledQuery service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CreateScheduledQuery">REST API Reference for CreateScheduledQuery Operation</seealso>
        public virtual CreateScheduledQueryResponse CreateScheduledQuery(CreateScheduledQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateScheduledQueryResponse>(request, options);
        }


        /// <summary>
        /// Create a scheduled query that will be run on your behalf at the configured schedule.
        /// Timestream assumes the execution role provided as part of the <code>ScheduledQueryExecutionRoleArn</code>
        /// parameter to run the query. You can use the <code>NotificationConfiguration</code>
        /// parameter to configure notification for your scheduled query operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CreateScheduledQuery">REST API Reference for CreateScheduledQuery Operation</seealso>
        public virtual Task<CreateScheduledQueryResponse> CreateScheduledQueryAsync(CreateScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<CreateScheduledQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledQuery


        /// <summary>
        /// Deletes a given scheduled query. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledQuery service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DeleteScheduledQuery">REST API Reference for DeleteScheduledQuery Operation</seealso>
        public virtual DeleteScheduledQueryResponse DeleteScheduledQuery(DeleteScheduledQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteScheduledQueryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a given scheduled query. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DeleteScheduledQuery">REST API Reference for DeleteScheduledQuery Operation</seealso>
        public virtual Task<DeleteScheduledQueryResponse> DeleteScheduledQueryAsync(DeleteScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DeleteScheduledQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because the Timestream SDKs are designed to transparently work with the service’s
        /// architecture, including the management and mapping of the service endpoints, <i>it
        /// is not recommended that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are using <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/VPCEndpoints">VPC
        /// endpoints (Amazon Web Services PrivateLink) with Timestream </a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how and when to use and implement DescribeEndpoints, see
        /// <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
        /// Endpoint Discovery Pattern</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }


        /// <summary>
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because the Timestream SDKs are designed to transparently work with the service’s
        /// architecture, including the management and mapping of the service endpoints, <i>it
        /// is not recommended that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are using <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/VPCEndpoints">VPC
        /// endpoints (Amazon Web Services PrivateLink) with Timestream </a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how and when to use and implement DescribeEndpoints, see
        /// <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
        /// Endpoint Discovery Pattern</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledQuery


        /// <summary>
        /// Provides detailed information about a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledQuery service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeScheduledQuery">REST API Reference for DescribeScheduledQuery Operation</seealso>
        public virtual DescribeScheduledQueryResponse DescribeScheduledQuery(DescribeScheduledQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeScheduledQueryResponse>(request, options);
        }


        /// <summary>
        /// Provides detailed information about a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeScheduledQuery">REST API Reference for DescribeScheduledQuery Operation</seealso>
        public virtual Task<DescribeScheduledQueryResponse> DescribeScheduledQueryAsync(DescribeScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeScheduledQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteScheduledQuery


        /// <summary>
        /// You can use this API to run a scheduled query manually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ExecuteScheduledQuery">REST API Reference for ExecuteScheduledQuery Operation</seealso>
        public virtual ExecuteScheduledQueryResponse ExecuteScheduledQuery(ExecuteScheduledQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ExecuteScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ExecuteScheduledQueryResponse>(request, options);
        }


        /// <summary>
        /// You can use this API to run a scheduled query manually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ExecuteScheduledQuery">REST API Reference for ExecuteScheduledQuery Operation</seealso>
        public virtual Task<ExecuteScheduledQueryResponse> ExecuteScheduledQueryAsync(ExecuteScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ExecuteScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ExecuteScheduledQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScheduledQueries


        /// <summary>
        /// Gets a list of all scheduled queries in the caller's Amazon account and Region. <code>ListScheduledQueries</code>
        /// is eventually consistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledQueries service method.</param>
        /// 
        /// <returns>The response from the ListScheduledQueries service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListScheduledQueries">REST API Reference for ListScheduledQueries Operation</seealso>
        public virtual ListScheduledQueriesResponse ListScheduledQueries(ListScheduledQueriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledQueriesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListScheduledQueriesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListScheduledQueriesResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of all scheduled queries in the caller's Amazon account and Region. <code>ListScheduledQueries</code>
        /// is eventually consistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledQueries service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListScheduledQueries">REST API Reference for ListScheduledQueries Operation</seealso>
        public virtual Task<ListScheduledQueriesResponse> ListScheduledQueriesAsync(ListScheduledQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScheduledQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduledQueriesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListScheduledQueriesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListScheduledQueriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags on a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsForResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List all tags on a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsForResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PrepareQuery


        /// <summary>
        /// A synchronous operation that allows you to submit a query with parameters to be stored
        /// by Timestream for later running. Timestream only supports using this operation with
        /// the <code>PrepareQueryRequest$ValidateOnly</code> set to <code>true</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareQuery service method.</param>
        /// 
        /// <returns>The response from the PrepareQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/PrepareQuery">REST API Reference for PrepareQuery Operation</seealso>
        public virtual PrepareQueryResponse PrepareQuery(PrepareQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PrepareQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PrepareQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<PrepareQueryResponse>(request, options);
        }


        /// <summary>
        /// A synchronous operation that allows you to submit a query with parameters to be stored
        /// by Timestream for later running. Timestream only supports using this operation with
        /// the <code>PrepareQueryRequest$ValidateOnly</code> set to <code>true</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PrepareQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/PrepareQuery">REST API Reference for PrepareQuery Operation</seealso>
        public virtual Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PrepareQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PrepareQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PrepareQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<PrepareQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Query


        /// <summary>
        /// <code>Query</code> is a synchronous operation that enables you to run a query against
        /// your Amazon Timestream data. <code>Query</code> will time out after 60 seconds. You
        /// must update the default timeout in the SDK to support a timeout of 60 seconds. See
        /// the <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/code-samples.run-query.html">code
        /// sample</a> for details. 
        /// 
        ///  
        /// <para>
        /// Your query request will fail in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you submit a <code>Query</code> request with the same client token outside of
        /// the 5-minute idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you submit a <code>Query</code> request with the same client token, but change
        /// other parameters, within the 5-minute idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the size of the row (including the query metadata) exceeds 1 MB, then the query
        /// will fail with the following error message: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Query aborted as max page response size has been exceeded by the output result
        /// row</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the IAM principal of the query initiator and the result reader are not the same
        /// and/or the query initiator and the result reader do not have the same query string
        /// in the query requests, the query will fail with an <code>Invalid pagination token</code>
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.QueryExecutionException">
        /// Timestream was unable to run the query successfully.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/Query">REST API Reference for Query Operation</seealso>
        public virtual QueryResponse Query(QueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = QueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<QueryResponse>(request, options);
        }


        /// <summary>
        /// <code>Query</code> is a synchronous operation that enables you to run a query against
        /// your Amazon Timestream data. <code>Query</code> will time out after 60 seconds. You
        /// must update the default timeout in the SDK to support a timeout of 60 seconds. See
        /// the <a href="https://docs.aws.amazon.com/Timestream/latest/developerguide/code-samples.run-query.html">code
        /// sample</a> for details. 
        /// 
        ///  
        /// <para>
        /// Your query request will fail in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you submit a <code>Query</code> request with the same client token outside of
        /// the 5-minute idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you submit a <code>Query</code> request with the same client token, but change
        /// other parameters, within the 5-minute idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the size of the row (including the query metadata) exceeds 1 MB, then the query
        /// will fail with the following error message: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Query aborted as max page response size has been exceeded by the output result
        /// row</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the IAM principal of the query initiator and the result reader are not the same
        /// and/or the query initiator and the result reader do not have the same query string
        /// in the query requests, the query will fail with an <code>Invalid pagination token</code>
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Query service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.QueryExecutionException">
        /// Timestream was unable to run the query successfully.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/Query">REST API Reference for Query Operation</seealso>
        public virtual Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = QueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<QueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the association of tags from a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScheduledQuery


        /// <summary>
        /// Update a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UpdateScheduledQuery">REST API Reference for UpdateScheduledQuery Operation</seealso>
        public virtual UpdateScheduledQueryResponse UpdateScheduledQuery(UpdateScheduledQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateScheduledQueryResponse>(request, options);
        }


        /// <summary>
        /// Update a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UpdateScheduledQuery">REST API Reference for UpdateScheduledQuery Operation</seealso>
        public virtual Task<UpdateScheduledQueryResponse> UpdateScheduledQueryAsync(UpdateScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScheduledQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduledQueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateScheduledQueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateScheduledQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}