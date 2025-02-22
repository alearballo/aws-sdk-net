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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Sidewalk device object.
    /// </summary>
    public partial class SidewalkDevice
    {
        private string _amazonId;
        private List<CertificateList> _deviceCertificates = new List<CertificateList>();
        private string _sidewalkId;
        private string _sidewalkManufacturingSn;

        /// <summary>
        /// Gets and sets the property AmazonId.
        /// </summary>
        [AWSProperty(Max=2048)]
        public string AmazonId
        {
            get { return this._amazonId; }
            set { this._amazonId = value; }
        }

        // Check to see if AmazonId property is set
        internal bool IsSetAmazonId()
        {
            return this._amazonId != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceCertificates. 
        /// <para>
        /// The sidewalk device certificates for Ed25519 and P256r1.
        /// </para>
        /// </summary>
        public List<CertificateList> DeviceCertificates
        {
            get { return this._deviceCertificates; }
            set { this._deviceCertificates = value; }
        }

        // Check to see if DeviceCertificates property is set
        internal bool IsSetDeviceCertificates()
        {
            return this._deviceCertificates != null && this._deviceCertificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SidewalkId. 
        /// <para>
        /// The sidewalk device identification.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SidewalkId
        {
            get { return this._sidewalkId; }
            set { this._sidewalkId = value; }
        }

        // Check to see if SidewalkId property is set
        internal bool IsSetSidewalkId()
        {
            return this._sidewalkId != null;
        }

        /// <summary>
        /// Gets and sets the property SidewalkManufacturingSn. 
        /// <para>
        /// The Sidewalk manufacturing series number.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string SidewalkManufacturingSn
        {
            get { return this._sidewalkManufacturingSn; }
            set { this._sidewalkManufacturingSn = value; }
        }

        // Check to see if SidewalkManufacturingSn property is set
        internal bool IsSetSidewalkManufacturingSn()
        {
            return this._sidewalkManufacturingSn != null;
        }

    }
}