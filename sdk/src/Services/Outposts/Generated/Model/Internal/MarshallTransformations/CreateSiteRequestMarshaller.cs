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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSite Request Marshaller
    /// </summary>       
    public class CreateSiteRequestMarshaller : IMarshaller<IRequest, CreateSiteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSiteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSiteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Outposts");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/sites";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotes())
                {
                    context.Writer.WritePropertyName("Notes");
                    context.Writer.Write(publicRequest.Notes);
                }

                if(publicRequest.IsSetOperatingAddress())
                {
                    context.Writer.WritePropertyName("OperatingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OperatingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRackPhysicalProperties())
                {
                    context.Writer.WritePropertyName("RackPhysicalProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = RackPhysicalPropertiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RackPhysicalProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetShippingAddress())
                {
                    context.Writer.WritePropertyName("ShippingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShippingAddress, context);

                    context.Writer.WriteObjectEnd();
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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSiteRequestMarshaller _instance = new CreateSiteRequestMarshaller();        

        internal static CreateSiteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSiteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}