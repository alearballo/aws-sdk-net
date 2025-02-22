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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AcceptPage Request Marshaller
    /// </summary>       
    public class AcceptPageRequestMarshaller : IMarshaller<IRequest, AcceptPageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AcceptPageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AcceptPageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMContacts");
            string target = "SSMContacts.AcceptPage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAcceptCode())
                {
                    context.Writer.WritePropertyName("AcceptCode");
                    context.Writer.Write(publicRequest.AcceptCode);
                }

                if(publicRequest.IsSetAcceptCodeValidation())
                {
                    context.Writer.WritePropertyName("AcceptCodeValidation");
                    context.Writer.Write(publicRequest.AcceptCodeValidation);
                }

                if(publicRequest.IsSetAcceptType())
                {
                    context.Writer.WritePropertyName("AcceptType");
                    context.Writer.Write(publicRequest.AcceptType);
                }

                if(publicRequest.IsSetContactChannelId())
                {
                    context.Writer.WritePropertyName("ContactChannelId");
                    context.Writer.Write(publicRequest.ContactChannelId);
                }

                if(publicRequest.IsSetNote())
                {
                    context.Writer.WritePropertyName("Note");
                    context.Writer.Write(publicRequest.Note);
                }

                if(publicRequest.IsSetPageId())
                {
                    context.Writer.WritePropertyName("PageId");
                    context.Writer.Write(publicRequest.PageId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AcceptPageRequestMarshaller _instance = new AcceptPageRequestMarshaller();        

        internal static AcceptPageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcceptPageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}