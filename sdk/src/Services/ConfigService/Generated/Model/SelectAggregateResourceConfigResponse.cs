/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the SelectAggregateResourceConfig operation.
    /// </summary>
    public partial class SelectAggregateResourceConfigResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private QueryInfo _queryInfo;
        private List<string> _results = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The nextToken string returned in a previous request that you use to request the next
        /// page of results in a paginated response. 
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
        /// Gets and sets the property QueryInfo.
        /// </summary>
        public QueryInfo QueryInfo
        {
            get { return this._queryInfo; }
            set { this._queryInfo = value; }
        }

        // Check to see if QueryInfo property is set
        internal bool IsSetQueryInfo()
        {
            return this._queryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Returns the results for the SQL query.
        /// </para>
        /// </summary>
        public List<string> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

    }
}