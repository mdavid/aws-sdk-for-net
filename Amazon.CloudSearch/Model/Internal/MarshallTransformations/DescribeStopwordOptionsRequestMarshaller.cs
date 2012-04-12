/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Stopword Options Request Marshaller
    /// </summary>       
    public class DescribeStopwordOptionsRequestMarshaller : IMarshaller<IRequest, DescribeStopwordOptionsRequest>
    {
        public IRequest Marshall(DescribeStopwordOptionsRequest describeStopwordOptionsRequest)
        {
            IRequest request = new DefaultRequest(describeStopwordOptionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DescribeStopwordOptions");
            request.Parameters.Add("Version", "2011-02-01");
            if (describeStopwordOptionsRequest != null && describeStopwordOptionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(describeStopwordOptionsRequest.DomainName));
            }

            return request;
        }
    }
}
