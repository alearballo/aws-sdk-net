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
    /// Container for the parameters to the UpdateNetworkAnalyzerConfiguration operation.
    /// Update NetworkAnalyzer configuration.
    /// </summary>
    public partial class UpdateNetworkAnalyzerConfigurationRequest : AmazonIoTWirelessRequest
    {
        private string _configurationName;
        private TraceContent _traceContent;
        private List<string> _wirelessDevicesToAdd = new List<string>();
        private List<string> _wirelessDevicesToRemove = new List<string>();
        private List<string> _wirelessGatewaysToAdd = new List<string>();
        private List<string> _wirelessGatewaysToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigurationName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property TraceContent.
        /// </summary>
        public TraceContent TraceContent
        {
            get { return this._traceContent; }
            set { this._traceContent = value; }
        }

        // Check to see if TraceContent property is set
        internal bool IsSetTraceContent()
        {
            return this._traceContent != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDevicesToAdd. 
        /// <para>
        /// WirelessDevices to add into NetworkAnalyzerConfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> WirelessDevicesToAdd
        {
            get { return this._wirelessDevicesToAdd; }
            set { this._wirelessDevicesToAdd = value; }
        }

        // Check to see if WirelessDevicesToAdd property is set
        internal bool IsSetWirelessDevicesToAdd()
        {
            return this._wirelessDevicesToAdd != null && this._wirelessDevicesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WirelessDevicesToRemove. 
        /// <para>
        /// WirelessDevices to remove from NetworkAnalyzerConfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> WirelessDevicesToRemove
        {
            get { return this._wirelessDevicesToRemove; }
            set { this._wirelessDevicesToRemove = value; }
        }

        // Check to see if WirelessDevicesToRemove property is set
        internal bool IsSetWirelessDevicesToRemove()
        {
            return this._wirelessDevicesToRemove != null && this._wirelessDevicesToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToAdd. 
        /// <para>
        /// WirelessGateways to add into NetworkAnalyzerConfiguration.
        /// </para>
        /// </summary>
        public List<string> WirelessGatewaysToAdd
        {
            get { return this._wirelessGatewaysToAdd; }
            set { this._wirelessGatewaysToAdd = value; }
        }

        // Check to see if WirelessGatewaysToAdd property is set
        internal bool IsSetWirelessGatewaysToAdd()
        {
            return this._wirelessGatewaysToAdd != null && this._wirelessGatewaysToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToRemove. 
        /// <para>
        /// WirelessGateways to remove from NetworkAnalyzerConfiguration.
        /// </para>
        /// </summary>
        public List<string> WirelessGatewaysToRemove
        {
            get { return this._wirelessGatewaysToRemove; }
            set { this._wirelessGatewaysToRemove = value; }
        }

        // Check to see if WirelessGatewaysToRemove property is set
        internal bool IsSetWirelessGatewaysToRemove()
        {
            return this._wirelessGatewaysToRemove != null && this._wirelessGatewaysToRemove.Count > 0; 
        }

    }
}