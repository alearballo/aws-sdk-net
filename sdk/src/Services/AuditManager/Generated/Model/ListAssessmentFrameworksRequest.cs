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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssessmentFrameworks operation.
    /// Returns a list of the frameworks that are available in the Audit Manager framework
    /// library.
    /// </summary>
    public partial class ListAssessmentFrameworksRequest : AmazonAuditManagerRequest
    {
        private FrameworkType _frameworkType;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FrameworkType. 
        /// <para>
        ///  The type of framework, such as a standard framework or a custom framework. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FrameworkType FrameworkType
        {
            get { return this._frameworkType; }
            set { this._frameworkType = value; }
        }

        // Check to see if FrameworkType property is set
        internal bool IsSetFrameworkType()
        {
            return this._frameworkType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Represents the maximum number of results on a page or for an API request call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that's used to fetch the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

    }
}