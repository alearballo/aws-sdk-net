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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Processor Marshaller
    /// </summary>       
    public class ProcessorMarshaller : IRequestMarshaller<Processor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Processor requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("Configuration");
                context.Writer.WriteObjectStart();

                var marshaller = ProcessorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Configuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionOrder())
            {
                context.Writer.WritePropertyName("ExecutionOrder");
                context.Writer.Write(requestObject.ExecutionOrder);
            }

            if(requestObject.IsSetFallbackAction())
            {
                context.Writer.WritePropertyName("FallbackAction");
                context.Writer.Write(requestObject.FallbackAction);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProcessorMarshaller Instance = new ProcessorMarshaller();

    }
}