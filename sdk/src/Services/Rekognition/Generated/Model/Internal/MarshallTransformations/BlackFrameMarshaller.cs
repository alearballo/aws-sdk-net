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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BlackFrame Marshaller
    /// </summary>       
    public class BlackFrameMarshaller : IRequestMarshaller<BlackFrame, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BlackFrame requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMaxPixelThreshold())
            {
                context.Writer.WritePropertyName("MaxPixelThreshold");
                context.Writer.Write(requestObject.MaxPixelThreshold);
            }

            if(requestObject.IsSetMinCoveragePercentage())
            {
                context.Writer.WritePropertyName("MinCoveragePercentage");
                context.Writer.Write(requestObject.MinCoveragePercentage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BlackFrameMarshaller Instance = new BlackFrameMarshaller();

    }
}