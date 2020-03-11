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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// An object containing the human loop input in JSON format.
    /// </summary>
    public partial class HumanLoopInput
    {
        private string _inputContent;

        /// <summary>
        /// Gets and sets the property InputContent. 
        /// <para>
        /// Serialized input from the human loop. The input must be a string representation of
        /// a file in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4194304)]
        public string InputContent
        {
            get { return this._inputContent; }
            set { this._inputContent = value; }
        }

        // Check to see if InputContent property is set
        internal bool IsSetInputContent()
        {
            return this._inputContent != null;
        }

    }
}