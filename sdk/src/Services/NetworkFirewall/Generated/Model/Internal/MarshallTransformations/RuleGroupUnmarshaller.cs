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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleGroup Object
    /// </summary>  
    public class RuleGroupUnmarshaller : IUnmarshaller<RuleGroup, XmlUnmarshallerContext>, IUnmarshaller<RuleGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RuleGroup IUnmarshaller<RuleGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RuleGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RuleGroup unmarshalledObject = new RuleGroup();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RulesSource", targetDepth))
                {
                    var unmarshaller = RulesSourceUnmarshaller.Instance;
                    unmarshalledObject.RulesSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleVariables", targetDepth))
                {
                    var unmarshaller = RuleVariablesUnmarshaller.Instance;
                    unmarshalledObject.RuleVariables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatefulRuleOptions", targetDepth))
                {
                    var unmarshaller = StatefulRuleOptionsUnmarshaller.Instance;
                    unmarshalledObject.StatefulRuleOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RuleGroupUnmarshaller _instance = new RuleGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}