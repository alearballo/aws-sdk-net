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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUseCase operation.
    /// Deletes a use case from an integration association.
    /// </summary>
    public partial class DeleteUseCaseRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _integrationAssociationId;
        private string _useCaseId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string IntegrationAssociationId
        {
            get { return this._integrationAssociationId; }
            set { this._integrationAssociationId = value; }
        }

        // Check to see if IntegrationAssociationId property is set
        internal bool IsSetIntegrationAssociationId()
        {
            return this._integrationAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property UseCaseId. 
        /// <para>
        /// The identifier for the use case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string UseCaseId
        {
            get { return this._useCaseId; }
            set { this._useCaseId = value; }
        }

        // Check to see if UseCaseId property is set
        internal bool IsSetUseCaseId()
        {
            return this._useCaseId != null;
        }

    }
}