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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateResiliencyPolicy Request Marshaller
    /// </summary>       
    public class UpdateResiliencyPolicyRequestMarshaller : IMarshaller<IRequest, UpdateResiliencyPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateResiliencyPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateResiliencyPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-resiliency-policy";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataLocationConstraint())
                {
                    context.Writer.WritePropertyName("dataLocationConstraint");
                    context.Writer.Write(publicRequest.DataLocationConstraint);
                }

                if(publicRequest.IsSetPolicy())
                {
                    context.Writer.WritePropertyName("policy");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPolicyKvp in publicRequest.Policy)
                    {
                        context.Writer.WritePropertyName(publicRequestPolicyKvp.Key);
                        var publicRequestPolicyValue = publicRequestPolicyKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = FailurePolicyMarshaller.Instance;
                        marshaller.Marshall(publicRequestPolicyValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPolicyArn())
                {
                    context.Writer.WritePropertyName("policyArn");
                    context.Writer.Write(publicRequest.PolicyArn);
                }

                if(publicRequest.IsSetPolicyDescription())
                {
                    context.Writer.WritePropertyName("policyDescription");
                    context.Writer.Write(publicRequest.PolicyDescription);
                }

                if(publicRequest.IsSetPolicyName())
                {
                    context.Writer.WritePropertyName("policyName");
                    context.Writer.Write(publicRequest.PolicyName);
                }

                if(publicRequest.IsSetTier())
                {
                    context.Writer.WritePropertyName("tier");
                    context.Writer.Write(publicRequest.Tier);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateResiliencyPolicyRequestMarshaller _instance = new UpdateResiliencyPolicyRequestMarshaller();        

        internal static UpdateResiliencyPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateResiliencyPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}