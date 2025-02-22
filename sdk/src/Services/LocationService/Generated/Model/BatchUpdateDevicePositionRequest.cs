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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateDevicePosition operation.
    /// Uploads position update data for one or more devices to a tracker resource. Amazon
    /// Location uses the data when it reports the last known device position and position
    /// history. Amazon Location retains location data for 30 days.
    /// 
    ///  <note> 
    /// <para>
    /// Position updates are handled based on the <code>PositionFiltering</code> property
    /// of the tracker. When <code>PositionFiltering</code> is set to <code>TimeBased</code>,
    /// updates are evaluated against linked geofence collections, and location data is stored
    /// at a maximum of one position per 30 second interval. If your update frequency is more
    /// often than every 30 seconds, only one update per 30 seconds is stored for each unique
    /// device ID. When <code>PositionFiltering</code> is set to <code>DistanceBased</code>
    /// filtering, location data is stored and evaluated against linked geofence collections
    /// only if the device has moved more than 30 m (98.4 ft).
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchUpdateDevicePositionRequest : AmazonLocationServiceRequest
    {
        private string _trackerName;
        private List<DevicePositionUpdate> _updates = new List<DevicePositionUpdate>();

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// Contains the position update details for each device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<DevicePositionUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}