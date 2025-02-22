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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// Contains details about an invalid parameter.
    /// </summary>
    public partial class InvalidParameterDetail
    {
        private InvalidParameterProblem _problem;

        /// <summary>
        /// Gets and sets the property Problem. 
        /// <para>
        /// Detail describing why an individual parameter did not satisfy the constraints specified
        /// by the service
        /// </para>
        /// </summary>
        public InvalidParameterProblem Problem
        {
            get { return this._problem; }
            set { this._problem = value; }
        }

        // Check to see if Problem property is set
        internal bool IsSetProblem()
        {
            return this._problem != null;
        }

    }
}