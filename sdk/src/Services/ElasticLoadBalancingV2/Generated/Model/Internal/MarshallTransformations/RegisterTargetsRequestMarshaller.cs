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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterTargets Request Marshaller
    /// </summary>       
    public class RegisterTargetsRequestMarshaller : IMarshaller<IRequest, RegisterTargetsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterTargetsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterTargetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "RegisterTargets");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetTargetGroupArn())
                {
                    request.Parameters.Add("TargetGroupArn", StringUtils.FromString(publicRequest.TargetGroupArn));
                }
                if(publicRequest.IsSetTargets())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Targets)
                    {
                        if(publicRequestlistValue.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("Targets" + "." + "member" + "." + publicRequestlistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValue.AvailabilityZone));
                        }
                        if(publicRequestlistValue.IsSetId())
                        {
                            request.Parameters.Add("Targets" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                        }
                        if(publicRequestlistValue.IsSetPort())
                        {
                            request.Parameters.Add("Targets" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Port", StringUtils.FromInt(publicRequestlistValue.Port));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}