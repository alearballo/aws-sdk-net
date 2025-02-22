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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the GetRouteAnalysis operation.
    /// Gets information about the specified route analysis.
    /// </summary>
    public partial class GetRouteAnalysisRequest : AmazonNetworkManagerRequest
    {
        private string _globalNetworkId;
        private string _routeAnalysisId;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteAnalysisId. 
        /// <para>
        /// The ID of the route analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteAnalysisId
        {
            get { return this._routeAnalysisId; }
            set { this._routeAnalysisId = value; }
        }

        // Check to see if RouteAnalysisId property is set
        internal bool IsSetRouteAnalysisId()
        {
            return this._routeAnalysisId != null;
        }

    }
}