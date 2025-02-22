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
    /// This is the response object from the DeleteServiceTemplateVersion operation.
    /// </summary>
    public partial class DeleteServiceTemplateVersionResponse : AmazonWebServiceResponse
    {
        private ServiceTemplateVersion _serviceTemplateVersion;

        /// <summary>
        /// Gets and sets the property ServiceTemplateVersion. 
        /// <para>
        /// The service template version detail data that's returned by Proton.
        /// </para>
        /// </summary>
        public ServiceTemplateVersion ServiceTemplateVersion
        {
            get { return this._serviceTemplateVersion; }
            set { this._serviceTemplateVersion = value; }
        }

        // Check to see if ServiceTemplateVersion property is set
        internal bool IsSetServiceTemplateVersion()
        {
            return this._serviceTemplateVersion != null;
        }

    }
}