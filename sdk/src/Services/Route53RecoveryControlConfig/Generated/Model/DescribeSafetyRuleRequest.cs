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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSafetyRule operation.
    /// Describes the safety rules (that is, the assertion rules and gating rules) for the
    /// routing controls in a control panel.
    /// </summary>
    public partial class DescribeSafetyRuleRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _safetyRuleArn;

        /// <summary>
        /// Gets and sets the property SafetyRuleArn. 
        /// <para>
        /// The request body that you include when you update a safety rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SafetyRuleArn
        {
            get { return this._safetyRuleArn; }
            set { this._safetyRuleArn = value; }
        }

        // Check to see if SafetyRuleArn property is set
        internal bool IsSetSafetyRuleArn()
        {
            return this._safetyRuleArn != null;
        }

    }
}