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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the UpdateVolume operation.
    /// </summary>
    public partial class UpdateVolumeResponse : AmazonWebServiceResponse
    {
        private Volume _volume;

        /// <summary>
        /// Gets and sets the property Volume. 
        /// <para>
        /// Returned after a successful <code>UpdateVolume</code> API operation, describing the
        /// volume just updated.
        /// </para>
        /// </summary>
        public Volume Volume
        {
            get { return this._volume; }
            set { this._volume = value; }
        }

        // Check to see if Volume property is set
        internal bool IsSetVolume()
        {
            return this._volume != null;
        }

    }
}