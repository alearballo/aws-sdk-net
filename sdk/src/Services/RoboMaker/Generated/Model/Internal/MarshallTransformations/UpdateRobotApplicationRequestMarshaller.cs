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
    /// UpdateRobotApplication Request Marshaller
    /// </summary>       
    public class UpdateRobotApplicationRequestMarshaller : IMarshaller<IRequest, UpdateRobotApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRobotApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRobotApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RoboMaker");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-29";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateRobotApplication";
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

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("environment");
                    context.Writer.WriteObjectStart();

                    var marshaller = EnvironmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Environment, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRobotSoftwareSuite())
                {
                    context.Writer.WritePropertyName("robotSoftwareSuite");
                    context.Writer.WriteObjectStart();

                    var marshaller = RobotSoftwareSuiteMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RobotSoftwareSuite, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateRobotApplicationRequestMarshaller _instance = new UpdateRobotApplicationRequestMarshaller();        

        internal static UpdateRobotApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRobotApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}