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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a filter that returns a more specific list of Amazon Elastic Block Store
    /// (Amazon EBS) volume recommendations. Use this filter with the <a>GetEBSVolumeRecommendations</a>
    /// action.
    /// 
    ///  
    /// <para>
    /// You can use <code>LambdaFunctionRecommendationFilter</code> with the <a>GetLambdaFunctionRecommendations</a>
    /// action, <code>JobFilter</code> with the <a>DescribeRecommendationExportJobs</a> action,
    /// and <code>Filter</code> with the <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
    /// actions.
    /// </para>
    /// </summary>
    public partial class EBSFilter
    {
        private EBSFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>Finding</code> to return recommendations with a specific finding classification
        /// (for example, <code>NotOptimized</code>).
        /// </para>
        /// </summary>
        public EBSFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value of the filter.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <code>Optimized</code>, or <code>NotOptimized</code>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}