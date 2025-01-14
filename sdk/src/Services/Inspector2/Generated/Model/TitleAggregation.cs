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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The details that define an aggregation based on finding title.
    /// </summary>
    public partial class TitleAggregation
    {
        private AggregationResourceType _resourceType;
        private TitleSortBy _sortBy;
        private SortOrder _sortOrder;
        private List<StringFilter> _titles = new List<StringFilter>();
        private List<StringFilter> _vulnerabilityIds = new List<StringFilter>();

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type to aggregate on.
        /// </para>
        /// </summary>
        public AggregationResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value to sort results by.
        /// </para>
        /// </summary>
        public TitleSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort results by.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Titles. 
        /// <para>
        /// The finding titles to aggregate on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Titles
        {
            get { return this._titles; }
            set { this._titles = value; }
        }

        // Check to see if Titles property is set
        internal bool IsSetTitles()
        {
            return this._titles != null && this._titles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VulnerabilityIds. 
        /// <para>
        /// The vulnerability IDs of the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VulnerabilityIds
        {
            get { return this._vulnerabilityIds; }
            set { this._vulnerabilityIds = value; }
        }

        // Check to see if VulnerabilityIds property is set
        internal bool IsSetVulnerabilityIds()
        {
            return this._vulnerabilityIds != null && this._vulnerabilityIds.Count > 0; 
        }

    }
}