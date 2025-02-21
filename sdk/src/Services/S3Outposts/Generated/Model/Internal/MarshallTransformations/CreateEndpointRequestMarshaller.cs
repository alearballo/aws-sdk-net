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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.S3Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEndpoint Request Marshaller
    /// </summary>       
    public class CreateEndpointRequestMarshaller : IMarshaller<IRequest, CreateEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/S3Outposts/CreateEndpoint";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessType())
                {
                    context.Writer.WritePropertyName("AccessType");
                    context.Writer.Write(publicRequest.AccessType);
                }

                if(publicRequest.IsSetCustomerOwnedIpv4Pool())
                {
                    context.Writer.WritePropertyName("CustomerOwnedIpv4Pool");
                    context.Writer.Write(publicRequest.CustomerOwnedIpv4Pool);
                }

                if(publicRequest.IsSetOutpostId())
                {
                    context.Writer.WritePropertyName("OutpostId");
                    context.Writer.Write(publicRequest.OutpostId);
                }

                if(publicRequest.IsSetSecurityGroupId())
                {
                    context.Writer.WritePropertyName("SecurityGroupId");
                    context.Writer.Write(publicRequest.SecurityGroupId);
                }

                if(publicRequest.IsSetSubnetId())
                {
                    context.Writer.WritePropertyName("SubnetId");
                    context.Writer.Write(publicRequest.SubnetId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEndpointRequestMarshaller _instance = new CreateEndpointRequestMarshaller();        

        internal static CreateEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}