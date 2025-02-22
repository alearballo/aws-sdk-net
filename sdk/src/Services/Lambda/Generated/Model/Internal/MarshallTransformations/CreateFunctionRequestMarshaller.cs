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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFunction Request Marshaller
    /// </summary>       
    public class CreateFunctionRequestMarshaller : IMarshaller<IRequest, CreateFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFunctionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-03-31/functions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArchitectures())
                {
                    context.Writer.WritePropertyName("Architectures");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestArchitecturesListValue in publicRequest.Architectures)
                    {
                            context.Writer.Write(publicRequestArchitecturesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCode())
                {
                    context.Writer.WritePropertyName("Code");
                    context.Writer.WriteObjectStart();

                    var marshaller = FunctionCodeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Code, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCodeSigningConfigArn())
                {
                    context.Writer.WritePropertyName("CodeSigningConfigArn");
                    context.Writer.Write(publicRequest.CodeSigningConfigArn);
                }

                if(publicRequest.IsSetDeadLetterConfig())
                {
                    context.Writer.WritePropertyName("DeadLetterConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeadLetterConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeadLetterConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.WriteObjectStart();

                    var marshaller = EnvironmentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Environment, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFileSystemConfigs())
                {
                    context.Writer.WritePropertyName("FileSystemConfigs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFileSystemConfigsListValue in publicRequest.FileSystemConfigs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FileSystemConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestFileSystemConfigsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFunctionName())
                {
                    context.Writer.WritePropertyName("FunctionName");
                    context.Writer.Write(publicRequest.FunctionName);
                }

                if(publicRequest.IsSetHandler())
                {
                    context.Writer.WritePropertyName("Handler");
                    context.Writer.Write(publicRequest.Handler);
                }

                if(publicRequest.IsSetImageConfig())
                {
                    context.Writer.WritePropertyName("ImageConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImageConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKMSKeyArn())
                {
                    context.Writer.WritePropertyName("KMSKeyArn");
                    context.Writer.Write(publicRequest.KMSKeyArn);
                }

                if(publicRequest.IsSetLayers())
                {
                    context.Writer.WritePropertyName("Layers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLayersListValue in publicRequest.Layers)
                    {
                            context.Writer.Write(publicRequestLayersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMemorySize())
                {
                    context.Writer.WritePropertyName("MemorySize");
                    context.Writer.Write(publicRequest.MemorySize);
                }

                if(publicRequest.IsSetPackageType())
                {
                    context.Writer.WritePropertyName("PackageType");
                    context.Writer.Write(publicRequest.PackageType);
                }

                if(publicRequest.IsSetPublish())
                {
                    context.Writer.WritePropertyName("Publish");
                    context.Writer.Write(publicRequest.Publish);
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetRuntime())
                {
                    context.Writer.WritePropertyName("Runtime");
                    context.Writer.Write(publicRequest.Runtime);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("Timeout");
                    context.Writer.Write(publicRequest.Timeout);
                }

                if(publicRequest.IsSetTracingConfig())
                {
                    context.Writer.WritePropertyName("TracingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TracingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TracingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateFunctionRequestMarshaller _instance = new CreateFunctionRequestMarshaller();        

        internal static CreateFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}