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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Paginators for the ManagedGrafana service
    ///</summary>
    public class ManagedGrafanaPaginatorFactory : IManagedGrafanaPaginatorFactory
    {
        private readonly IAmazonManagedGrafana client;

        internal ManagedGrafanaPaginatorFactory(IAmazonManagedGrafana client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        public IListPermissionsPaginator ListPermissions(ListPermissionsRequest request) 
        {
            return new ListPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkspaces operation
        ///</summary>
        public IListWorkspacesPaginator ListWorkspaces(ListWorkspacesRequest request) 
        {
            return new ListWorkspacesPaginator(this.client, request);
        }
    }
}