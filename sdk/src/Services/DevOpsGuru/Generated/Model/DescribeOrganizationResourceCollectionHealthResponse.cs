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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganizationResourceCollectionHealth operation.
    /// </summary>
    public partial class DescribeOrganizationResourceCollectionHealthResponse : AmazonWebServiceResponse
    {
        private List<AccountHealth> _account = new List<AccountHealth>();
        private List<CloudFormationHealth> _cloudFormation = new List<CloudFormationHealth>();
        private string _nextToken;
        private List<ServiceHealth> _service = new List<ServiceHealth>();

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The name of the organization's account.
        /// </para>
        /// </summary>
        public List<AccountHealth> Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null && this._account.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        /// The returned <code>CloudFormationHealthOverview</code> object that contains an <code>InsightHealthOverview</code>
        /// object with the requested system health information.
        /// </para>
        /// </summary>
        public List<CloudFormationHealth> CloudFormation
        {
            get { return this._cloudFormation; }
            set { this._cloudFormation = value; }
        }

        // Check to see if CloudFormation property is set
        internal bool IsSetCloudFormation()
        {
            return this._cloudFormation != null && this._cloudFormation.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// An array of <code>ServiceHealth</code> objects that describes the health of the Amazon
        /// Web Services services associated with the resources in the collection.
        /// </para>
        /// </summary>
        public List<ServiceHealth> Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null && this._service.Count > 0; 
        }

    }
}