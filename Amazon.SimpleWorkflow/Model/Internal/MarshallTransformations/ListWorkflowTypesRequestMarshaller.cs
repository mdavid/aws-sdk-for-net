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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Workflow Types Request Marshaller
    /// </summary>       
    internal class ListWorkflowTypesRequestMarshaller : IMarshaller<IRequest<ListWorkflowTypesRequest>, ListWorkflowTypesRequest> 
    {
        public IRequest<ListWorkflowTypesRequest> Marshall(ListWorkflowTypesRequest listWorkflowTypesRequest) 
        {

            IRequest<ListWorkflowTypesRequest> request = new DefaultRequest<ListWorkflowTypesRequest>(listWorkflowTypesRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.ListWorkflowTypes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(listWorkflowTypesRequest.Domain);
                }
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetName()) 
                {
                    writer.WritePropertyName("name");
                    writer.Write(listWorkflowTypesRequest.Name);
                }
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetRegistrationStatus()) 
                {
                    writer.WritePropertyName("registrationStatus");
                    writer.Write(listWorkflowTypesRequest.RegistrationStatus);
                }
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetNextPageToken()) 
                {
                    writer.WritePropertyName("nextPageToken");
                    writer.Write(listWorkflowTypesRequest.NextPageToken);
                }
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetMaximumPageSize()) 
                {
                    writer.WritePropertyName("maximumPageSize");
                    writer.Write(listWorkflowTypesRequest.MaximumPageSize);
                }
                if (listWorkflowTypesRequest != null && listWorkflowTypesRequest.IsSetReverseOrder()) 
                {
                    writer.WritePropertyName("reverseOrder");
                    writer.Write(listWorkflowTypesRequest.ReverseOrder);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
