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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CancelEnvironmentDeployment operation.
    /// Attempts to cancel an environment deployment on an <a>UpdateEnvironment</a> action,
    /// if the deployment is <code>IN_PROGRESS</code>. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-env-update.html">Update
    /// an environment</a> in the <i>Proton Administrator guide</i>.
    /// 
    ///  
    /// <para>
    /// The following list includes potential cancellation scenarios.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the cancellation attempt succeeds, the resulting deployment state is <code>CANCELLED</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the cancellation attempt fails, the resulting deployment state is <code>FAILED</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the current <a>UpdateEnvironment</a> action succeeds before the cancellation attempt
    /// starts, the resulting deployment state is <code>SUCCEEDED</code> and the cancellation
    /// attempt has no effect.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelEnvironmentDeploymentRequest : AmazonProtonRequest
    {
        private string _environmentName;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment with the deployment to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

    }
}