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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FinSpaceData.Model;
using Amazon.FinSpaceData.Model.Internal.MarshallTransformations;
using Amazon.FinSpaceData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FinSpaceData
{
    /// <summary>
    /// Implementation for accessing FinSpaceData
    ///
    /// The FinSpace APIs let you take actions inside the FinSpace.
    /// </summary>
    public partial class AmazonFinSpaceDataClient : AmazonServiceClient, IAmazonFinSpaceData
    {
        private static IServiceMetadata serviceMetadata = new AmazonFinSpaceDataMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        public AmazonFinSpaceDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinSpaceDataConfig()) { }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        public AmazonFinSpaceDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinSpaceDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(AmazonFinSpaceDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFinSpaceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials and an
        /// AmazonFinSpaceDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials, AmazonFinSpaceDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinSpaceDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinSpaceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFinSpaceDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinSpaceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinSpaceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFinSpaceDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IFinSpaceDataPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFinSpaceDataPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FinSpaceDataPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  CreateChangeset

        internal virtual CreateChangesetResponse CreateChangeset(CreateChangesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangesetResponseUnmarshaller.Instance;

            return Invoke<CreateChangesetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Changeset in a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        public virtual Task<CreateChangesetResponse> CreateChangesetAsync(CreateChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangesetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChangesetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataView

        internal virtual CreateDataViewResponse CreateDataView(CreateDataViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataViewResponseUnmarshaller.Instance;

            return Invoke<CreateDataViewResponse>(request, options);
        }



        /// <summary>
        /// Creates a Dataview for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataView">REST API Reference for CreateDataView Operation</seealso>
        public virtual Task<CreateDataViewResponse> CreateDataViewAsync(CreateDataViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataViewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChangeset

        internal virtual GetChangesetResponse GetChangeset(GetChangesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangesetResponseUnmarshaller.Instance;

            return Invoke<GetChangesetResponse>(request, options);
        }



        /// <summary>
        /// Get information about a Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetChangeset">REST API Reference for GetChangeset Operation</seealso>
        public virtual Task<GetChangesetResponse> GetChangesetAsync(GetChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangesetResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangesetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataset

        internal virtual GetDatasetResponse GetDataset(GetDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetResponseUnmarshaller.Instance;

            return Invoke<GetDatasetResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataset">REST API Reference for GetDataset Operation</seealso>
        public virtual Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataView

        internal virtual GetDataViewResponse GetDataView(GetDataViewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataViewResponseUnmarshaller.Instance;

            return Invoke<GetDataViewResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a Dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataView">REST API Reference for GetDataView Operation</seealso>
        public virtual Task<GetDataViewResponse> GetDataViewAsync(GetDataViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataViewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProgrammaticAccessCredentials

        internal virtual GetProgrammaticAccessCredentialsResponse GetProgrammaticAccessCredentials(GetProgrammaticAccessCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProgrammaticAccessCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProgrammaticAccessCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetProgrammaticAccessCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Request programmatic credentials to use with FinSpace SDK.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProgrammaticAccessCredentials service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        public virtual Task<GetProgrammaticAccessCredentialsResponse> GetProgrammaticAccessCredentialsAsync(GetProgrammaticAccessCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProgrammaticAccessCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProgrammaticAccessCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetProgrammaticAccessCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkingLocation

        internal virtual GetWorkingLocationResponse GetWorkingLocation(GetWorkingLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkingLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkingLocationResponseUnmarshaller.Instance;

            return Invoke<GetWorkingLocationResponse>(request, options);
        }



        /// <summary>
        /// A temporary Amazon S3 location, where you can copy your files from a source location
        /// to stage or use as a scratch space in FinSpace notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkingLocation service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        public virtual Task<GetWorkingLocationResponse> GetWorkingLocationAsync(GetWorkingLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkingLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkingLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkingLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangesets

        internal virtual ListChangesetsResponse ListChangesets(ListChangesetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangesetsResponseUnmarshaller.Instance;

            return Invoke<ListChangesetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the FinSpace Changesets for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangesets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangesets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListChangesets">REST API Reference for ListChangesets Operation</seealso>
        public virtual Task<ListChangesetsResponse> ListChangesetsAsync(ListChangesetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangesetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangesetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangesetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all of the active Datasets that a user has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataViews

        internal virtual ListDataViewsResponse ListDataViews(ListDataViewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataViewsResponseUnmarshaller.Instance;

            return Invoke<ListDataViewsResponse>(request, options);
        }



        /// <summary>
        /// Lists all available Dataviews for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataViews service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDataViews">REST API Reference for ListDataViews Operation</seealso>
        public virtual Task<ListDataViewsResponse> ListDataViewsAsync(ListDataViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataViewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataViewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChangeset

        internal virtual UpdateChangesetResponse UpdateChangeset(UpdateChangesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChangesetResponseUnmarshaller.Instance;

            return Invoke<UpdateChangesetResponse>(request, options);
        }



        /// <summary>
        /// Updates a FinSpace Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateChangeset">REST API Reference for UpdateChangeset Operation</seealso>
        public virtual Task<UpdateChangesetResponse> UpdateChangesetAsync(UpdateChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChangesetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChangesetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataset

        internal virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Updates a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}