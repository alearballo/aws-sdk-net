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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of tags on a dataset to set row-level security.
    /// </summary>
    public partial class RowLevelPermissionTagConfiguration
    {
        private Status _status;
        private List<RowLevelPermissionTagRule> _tagRules = new List<RowLevelPermissionTagRule>();

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of row-level security tags. If enabled, the status is <code>ENABLED</code>.
        /// If disabled, the status is <code>DISABLED</code>.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TagRules. 
        /// <para>
        /// A set of rules associated with row-level security, such as the tag names and columns
        /// that they are assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<RowLevelPermissionTagRule> TagRules
        {
            get { return this._tagRules; }
            set { this._tagRules = value; }
        }

        // Check to see if TagRules property is set
        internal bool IsSetTagRules()
        {
            return this._tagRules != null && this._tagRules.Count > 0; 
        }

    }
}