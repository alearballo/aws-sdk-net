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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBucket Request Marshaller
    /// </summary>       
    public class UpdateBucketRequestMarshaller : IMarshaller<IRequest, UpdateBucketRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBucketRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBucketRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.UpdateBucket";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessLogConfig())
                {
                    context.Writer.WritePropertyName("accessLogConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = BucketAccessLogConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessLogConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAccessRules())
                {
                    context.Writer.WritePropertyName("accessRules");
                    context.Writer.WriteObjectStart();

                    var marshaller = AccessRulesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AccessRules, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBucketName())
                {
                    context.Writer.WritePropertyName("bucketName");
                    context.Writer.Write(publicRequest.BucketName);
                }

                if(publicRequest.IsSetReadonlyAccessAccounts())
                {
                    context.Writer.WritePropertyName("readonlyAccessAccounts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReadonlyAccessAccountsListValue in publicRequest.ReadonlyAccessAccounts)
                    {
                            context.Writer.Write(publicRequestReadonlyAccessAccountsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVersioning())
                {
                    context.Writer.WritePropertyName("versioning");
                    context.Writer.Write(publicRequest.Versioning);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBucketRequestMarshaller _instance = new UpdateBucketRequestMarshaller();        

        internal static UpdateBucketRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBucketRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}