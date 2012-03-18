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
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// WorkflowExecutionInfosUnmarshaller 
      /// </summary> 
      internal class WorkflowExecutionInfosUnmarshaller : IUnmarshaller<WorkflowExecutionInfos, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionInfos, JsonUnmarshallerContext> 
      { 
        WorkflowExecutionInfos IUnmarshaller<WorkflowExecutionInfos, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public WorkflowExecutionInfos Unmarshall(JsonUnmarshallerContext context) 
        { 
          WorkflowExecutionInfos workflowExecutionInfos = new WorkflowExecutionInfos();
          workflowExecutionInfos.ExecutionInfos = null; 
                        
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("ExecutionInfos", targetDepth)) 
              {
                workflowExecutionInfos.ExecutionInfos = new List<WorkflowExecutionInfo>();
                        WorkflowExecutionInfoUnmarshaller unmarshaller = WorkflowExecutionInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     workflowExecutionInfos.ExecutionInfos.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("NextPageToken", targetDepth)) 
              {
                workflowExecutionInfos.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return workflowExecutionInfos; 
            } 
          } 
          return workflowExecutionInfos; 
        } 
        
        private static WorkflowExecutionInfosUnmarshaller instance; 
        public static WorkflowExecutionInfosUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new WorkflowExecutionInfosUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
