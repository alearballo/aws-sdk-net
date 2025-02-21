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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Rule Object
    /// </summary>  
    public class RuleUnmarshaller : IUnmarshaller<Rule, XmlUnmarshallerContext>, IUnmarshaller<Rule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Rule IUnmarshaller<Rule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Rule Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Rule unmarshalledObject = new Rule();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = RuleActionUnmarshaller.Instance;
                    unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CaptchaConfig", targetDepth))
                {
                    var unmarshaller = CaptchaConfigUnmarshaller.Instance;
                    unmarshalledObject.CaptchaConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OverrideAction", targetDepth))
                {
                    var unmarshaller = OverrideActionUnmarshaller.Instance;
                    unmarshalledObject.OverrideAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleLabels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Label, LabelUnmarshaller>(LabelUnmarshaller.Instance);
                    unmarshalledObject.RuleLabels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Statement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    unmarshalledObject.Statement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisibilityConfig", targetDepth))
                {
                    var unmarshaller = VisibilityConfigUnmarshaller.Instance;
                    unmarshalledObject.VisibilityConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RuleUnmarshaller _instance = new RuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}