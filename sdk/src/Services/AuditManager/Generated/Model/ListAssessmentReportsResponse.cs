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
    /// This is the response object from the ListAssessmentReports operation.
    /// </summary>
    public partial class ListAssessmentReportsResponse : AmazonWebServiceResponse
    {
        private List<AssessmentReportMetadata> _assessmentReports = new List<AssessmentReportMetadata>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssessmentReports. 
        /// <para>
        ///  The list of assessment reports that the <code>ListAssessmentReports</code> API returned.
        /// 
        /// </para>
        /// </summary>
        public List<AssessmentReportMetadata> AssessmentReports
        {
            get { return this._assessmentReports; }
            set { this._assessmentReports = value; }
        }

        // Check to see if AssessmentReports property is set
        internal bool IsSetAssessmentReports()
        {
            return this._assessmentReports != null && this._assessmentReports.Count > 0; 
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