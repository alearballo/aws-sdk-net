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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTable operation.
    /// Describes the detailed information about a table from metadata in the cluster. The
    /// information includes its columns. A token is returned to page through the column list.
    /// Depending on the authorization method, use one of the following combinations of request
    /// parameters: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Secrets Manager - specify the Amazon Resource Name (ARN) of the secret, the database
    /// name, and the cluster identifier that matches the cluster in the secret. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Temporary credentials - specify the cluster identifier, the database name, and the
    /// database user name. Permission to call the <code>redshift:GetClusterCredentials</code>
    /// operation is required to use this method. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeTableRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clusterIdentifier;
        private string _connectedDatabase;
        private string _database;
        private string _dbUser;
        private int? _maxResults;
        private string _nextToken;
        private string _schema;
        private string _secretArn;
        private string _table;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This parameter is required when authenticating using either
        /// Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedDatabase. 
        /// <para>
        /// A database name. The connected database is specified when you connect with your authentication
        /// credentials. 
        /// </para>
        /// </summary>
        public string ConnectedDatabase
        {
            get { return this._connectedDatabase; }
            set { this._connectedDatabase = value; }
        }

        // Check to see if ConnectedDatabase property is set
        internal bool IsSetConnectedDatabase()
        {
            return this._connectedDatabase != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database that contains the tables to be described. If <code>ConnectedDatabase</code>
        /// is not specified, this is also the database to connect to with your authentication
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. This parameter is required when authenticating using temporary
        /// credentials. 
        /// </para>
        /// </summary>
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in the response. If more tables exist than
        /// fit in one response, then <code>NextToken</code> is returned to page through the results.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema that contains the table. If no schema is specified, then matching tables
        /// for all schemas are returned. 
        /// </para>
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. This parameter
        /// is required when authenticating using Secrets Manager. 
        /// </para>
        /// </summary>
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The table name. If no table is specified, then all tables for all matching schemas
        /// are returned. If no table and no schema is specified, then all tables for all schemas
        /// in the database are returned
        /// </para>
        /// </summary>
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}