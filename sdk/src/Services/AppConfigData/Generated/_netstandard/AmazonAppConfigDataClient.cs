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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppConfigData.Model;
using Amazon.AppConfigData.Model.Internal.MarshallTransformations;
using Amazon.AppConfigData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppConfigData
{
    /// <summary>
    /// Implementation for accessing AppConfigData
    ///
    /// Use the AppConfigData API, a capability of AWS AppConfig, to retrieve deployed configuration.
    /// </summary>
    public partial class AmazonAppConfigDataClient : AmazonServiceClient, IAmazonAppConfigData
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppConfigDataMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        public AmazonAppConfigDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppConfigDataConfig()) { }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        public AmazonAppConfigDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppConfigDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(AmazonAppConfigDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppConfigDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials and an
        /// AmazonAppConfigDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials, AmazonAppConfigDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppConfigDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppConfigDataConfig clientConfig)
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


        #region  GetLatestConfiguration

        internal virtual GetLatestConfigurationResponse GetLatestConfiguration(GetLatestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLatestConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the latest deployed configuration. This API may return empty Configuration
        /// data if the client already has the latest version. See StartConfigurationSession to
        /// obtain an InitialConfigurationToken to call this API.
        /// 
        ///  <important> 
        /// <para>
        /// Each call to GetLatestConfiguration returns a new ConfigurationToken (NextPollConfigurationToken
        /// in the response). This new token MUST be provided to the next call to GetLatestConfiguration
        /// when polling for configuration updates.
        /// </para>
        ///  
        /// <para>
        /// To avoid excess charges, we recommend that you include the <code>ClientConfigurationVersion</code>
        /// value with every call to <code>GetConfiguration</code>. This value must be saved on
        /// your client. Subsequent calls to <code>GetConfiguration</code> must pass this value
        /// by using the <code>ClientConfigurationVersion</code> parameter. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLatestConfiguration service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        public virtual Task<GetLatestConfigurationResponse> GetLatestConfigurationAsync(GetLatestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLatestConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartConfigurationSession

        internal virtual StartConfigurationSessionResponse StartConfigurationSession(StartConfigurationSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationSessionResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationSessionResponse>(request, options);
        }



        /// <summary>
        /// Starts a configuration session used to retrieve a deployed configuration. See the
        /// GetLatestConfiguration API for more details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationSession service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        public virtual Task<StartConfigurationSessionResponse> StartConfigurationSessionAsync(StartConfigurationSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationSessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartConfigurationSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}