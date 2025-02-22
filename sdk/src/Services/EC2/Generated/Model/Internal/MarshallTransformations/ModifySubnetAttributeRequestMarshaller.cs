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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifySubnetAttribute Request Marshaller
    /// </summary>       
    public class ModifySubnetAttributeRequestMarshaller : IMarshaller<IRequest, ModifySubnetAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySubnetAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifySubnetAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifySubnetAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAssignIpv6AddressOnCreation())
                {
                    request.Parameters.Add("AssignIpv6AddressOnCreation.Value", StringUtils.FromBool(publicRequest.AssignIpv6AddressOnCreation));
                }
                if(publicRequest.IsSetCustomerOwnedIpv4Pool())
                {
                    request.Parameters.Add("CustomerOwnedIpv4Pool", StringUtils.FromString(publicRequest.CustomerOwnedIpv4Pool));
                }
                if(publicRequest.IsSetEnableDns64())
                {
                    request.Parameters.Add("EnableDns64.Value", StringUtils.FromBool(publicRequest.EnableDns64));
                }
                if(publicRequest.IsSetEnableResourceNameDnsAAAARecordOnLaunch())
                {
                    request.Parameters.Add("EnableResourceNameDnsAAAARecordOnLaunch.Value", StringUtils.FromBool(publicRequest.EnableResourceNameDnsAAAARecordOnLaunch));
                }
                if(publicRequest.IsSetEnableResourceNameDnsARecordOnLaunch())
                {
                    request.Parameters.Add("EnableResourceNameDnsARecordOnLaunch.Value", StringUtils.FromBool(publicRequest.EnableResourceNameDnsARecordOnLaunch));
                }
                if(publicRequest.IsSetMapCustomerOwnedIpOnLaunch())
                {
                    request.Parameters.Add("MapCustomerOwnedIpOnLaunch.Value", StringUtils.FromBool(publicRequest.MapCustomerOwnedIpOnLaunch));
                }
                if(publicRequest.IsSetMapPublicIpOnLaunch())
                {
                    request.Parameters.Add("MapPublicIpOnLaunch.Value", StringUtils.FromBool(publicRequest.MapPublicIpOnLaunch));
                }
                if(publicRequest.IsSetPrivateDnsHostnameTypeOnLaunch())
                {
                    request.Parameters.Add("PrivateDnsHostnameTypeOnLaunch", StringUtils.FromString(publicRequest.PrivateDnsHostnameTypeOnLaunch));
                }
                if(publicRequest.IsSetSubnetId())
                {
                    request.Parameters.Add("SubnetId", StringUtils.FromString(publicRequest.SubnetId));
                }
            }
            return request;
        }
                    private static ModifySubnetAttributeRequestMarshaller _instance = new ModifySubnetAttributeRequestMarshaller();        

        internal static ModifySubnetAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySubnetAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}