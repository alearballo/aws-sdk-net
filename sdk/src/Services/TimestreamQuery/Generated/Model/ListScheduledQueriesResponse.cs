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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// This is the response object from the ListScheduledQueries operation.
    /// </summary>
    public partial class ListScheduledQueriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScheduledQuery> _scheduledQueries = new List<ScheduledQuery>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ScheduledQueries. 
        /// <para>
        /// A list of scheduled queries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ScheduledQuery> ScheduledQueries
        {
            get { return this._scheduledQueries; }
            set { this._scheduledQueries = value; }
        }

        // Check to see if ScheduledQueries property is set
        internal bool IsSetScheduledQueries()
        {
            return this._scheduledQueries != null && this._scheduledQueries.Count > 0; 
        }

    }
}