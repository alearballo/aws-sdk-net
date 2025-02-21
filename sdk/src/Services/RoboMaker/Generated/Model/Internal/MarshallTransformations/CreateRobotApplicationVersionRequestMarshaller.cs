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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRobotApplicationVersion Request Marshaller
    /// </summary>       
    public class CreateRobotApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateRobotApplicationVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRobotApplicationVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRobotApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RoboMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-29";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/createRobotApplicationVersion";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplication())
                {
                    context.Writer.WritePropertyName("application");
                    context.Writer.Write(publicRequest.Application);
                }

                if(publicRequest.IsSetCurrentRevisionId())
                {
                    context.Writer.WritePropertyName("currentRevisionId");
                    context.Writer.Write(publicRequest.CurrentRevisionId);
                }

                if(publicRequest.IsSetImageDigest())
                {
                    context.Writer.WritePropertyName("imageDigest");
                    context.Writer.Write(publicRequest.ImageDigest);
                }

                if(publicRequest.IsSetS3Etags())
                {
                    context.Writer.WritePropertyName("s3Etags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestS3EtagsListValue in publicRequest.S3Etags)
                    {
                            context.Writer.Write(publicRequestS3EtagsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRobotApplicationVersionRequestMarshaller _instance = new CreateRobotApplicationVersionRequestMarshaller();        

        internal static CreateRobotApplicationVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRobotApplicationVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}