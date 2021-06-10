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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MemberConfiguration Marshaller
    /// </summary>       
    public class MemberConfigurationMarshaller : IRequestMarshaller<MemberConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MemberConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFrameworkConfiguration())
            {
                context.Writer.WritePropertyName("FrameworkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MemberFrameworkConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameworkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.Write(requestObject.KmsKeyArn);
            }

            if(requestObject.IsSetLogPublishingConfiguration())
            {
                context.Writer.WritePropertyName("LogPublishingConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MemberLogPublishingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogPublishingConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MemberConfigurationMarshaller Instance = new MemberConfigurationMarshaller();

    }
}