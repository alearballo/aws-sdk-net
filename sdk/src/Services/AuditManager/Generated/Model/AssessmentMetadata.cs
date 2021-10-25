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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The metadata that's associated with the specified assessment.
    /// </summary>
    public partial class AssessmentMetadata
    {
        private AssessmentReportsDestination _assessmentReportsDestination;
        private string _complianceType;
        private DateTime? _creationTime;
        private List<Delegation> _delegations = new List<Delegation>();
        private string _description;
        private string _id;
        private DateTime? _lastUpdated;
        private string _name;
        private List<Role> _roles = new List<Role>();
        private Scope _scope;
        private AssessmentStatus _status;

        /// <summary>
        /// Gets and sets the property AssessmentReportsDestination. 
        /// <para>
        ///  The destination that evidence reports are stored in for the assessment. 
        /// </para>
        /// </summary>
        public AssessmentReportsDestination AssessmentReportsDestination
        {
            get { return this._assessmentReportsDestination; }
            set { this._assessmentReportsDestination = value; }
        }

        // Check to see if AssessmentReportsDestination property is set
        internal bool IsSetAssessmentReportsDestination()
        {
            return this._assessmentReportsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        ///  The name of the compliance standard that's related to the assessment, such as PCI-DSS.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  Specifies when the assessment was created. 
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Delegations. 
        /// <para>
        ///  The delegations that are associated with the assessment. 
        /// </para>
        /// </summary>
        public List<Delegation> Delegations
        {
            get { return this._delegations; }
            set { this._delegations = value; }
        }

        // Check to see if Delegations property is set
        internal bool IsSetDelegations()
        {
            return this._delegations != null && this._delegations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        ///  The time of the most recent update. 
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Name
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
        /// Gets and sets the property Roles. 
        /// <para>
        ///  The roles that are associated with the assessment. 
        /// </para>
        /// </summary>
        public List<Role> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The wrapper of Amazon Web Services accounts and services that are in scope for the
        /// assessment. 
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The overall status of the assessment. 
        /// </para>
        /// </summary>
        public AssessmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}