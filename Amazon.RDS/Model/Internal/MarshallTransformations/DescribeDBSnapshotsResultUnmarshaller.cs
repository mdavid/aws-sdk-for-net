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
using System.Collections.Generic;

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeDBSnapshotsResult Unmarshaller
     /// </summary>
    internal class DescribeDBSnapshotsResultUnmarshaller : IUnmarshaller<DescribeDBSnapshotsResult, XmlUnmarshallerContext> 
    {
        public DescribeDBSnapshotsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeDBSnapshotsResult describeDBSnapshotsResult = new DescribeDBSnapshotsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeDBSnapshotsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBSnapshots/DBSnapshot", targetDepth))
                    {
                        describeDBSnapshotsResult.DBSnapshots.Add(DBSnapshotUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeDBSnapshotsResult;
                }
            }
                        


            return describeDBSnapshotsResult;
        }

        private static DescribeDBSnapshotsResultUnmarshaller instance;

        public static DescribeDBSnapshotsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeDBSnapshotsResultUnmarshaller();

            return instance;
        }
    }
}
    
