/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetJobOutput operation
    /// </summary>  
    public class GetJobOutputResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetJobOutputResponse response = new GetJobOutputResponse();

            response.Body = context.Stream;
            if (context.ResponseData.IsHeaderPresent("Accept-Ranges"))
                response.AcceptRanges = context.ResponseData.GetHeaderValue("Accept-Ranges");
            if (context.ResponseData.IsHeaderPresent("x-amz-archive-description"))
                response.ArchiveDescription = context.ResponseData.GetHeaderValue("x-amz-archive-description");
            if (context.ResponseData.IsHeaderPresent("x-amz-sha256-tree-hash"))
                response.Checksum = context.ResponseData.GetHeaderValue("x-amz-sha256-tree-hash");
            if (context.ResponseData.IsHeaderPresent("Content-Range"))
                response.ContentRange = context.ResponseData.GetHeaderValue("Content-Range");
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
                response.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            response.Status = (int)context.ResponseData.StatusCode;

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
            {
                return new MissingParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
            {
                return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonGlacierException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        internal override bool HasStreamingProperty
        {
            get
            {
                return true;
            }
        }

        private static GetJobOutputResponseUnmarshaller _instance = new GetJobOutputResponseUnmarshaller();        

        internal static GetJobOutputResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static GetJobOutputResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}