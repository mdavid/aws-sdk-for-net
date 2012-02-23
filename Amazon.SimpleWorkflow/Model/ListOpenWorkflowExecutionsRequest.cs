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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the ListOpenWorkflowExecutions operation.
    /// <para> Returns a list of open workflow executions in the specified domain that meet the filtering criteria. The results may be split into
    /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken returned by the initial call. </para>
    /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
    /// changes. </para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleWorkflow.AmazonSimpleWorkflow.ListOpenWorkflowExecutions"/>
    public class ListOpenWorkflowExecutionsRequest : AmazonWebServiceRequest
    {
        private string domain;
        private ExecutionTimeFilter startTimeFilter;
        private WorkflowTypeFilter typeFilter;
        private TagFilter tagFilter;
        private string nextPageToken;
        private int? maximumPageSize;
        private bool? reverseOrder;
        private WorkflowExecutionFilter executionFilter;

        /// <summary>
        /// The name of the domain that contains the workflow executions to list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        /// <summary>
        /// Sets the Domain property
        /// </summary>
        /// <param name="domain">The value to set for the Domain property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithDomain(string domain)
        {
            this.domain = domain;
            return this;
        }
            

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;       
        }

        /// <summary>
        /// Workflow executions are included in the returned results based on whether their start times are within the range specified by this filter.
        ///  
        /// </summary>
        public ExecutionTimeFilter StartTimeFilter
        {
            get { return this.startTimeFilter; }
            set { this.startTimeFilter = value; }
        }

        /// <summary>
        /// Sets the StartTimeFilter property
        /// </summary>
        /// <param name="startTimeFilter">The value to set for the StartTimeFilter property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithStartTimeFilter(ExecutionTimeFilter startTimeFilter)
        {
            this.startTimeFilter = startTimeFilter;
            return this;
        }
            

        // Check to see if StartTimeFilter property is set
        internal bool IsSetStartTimeFilter()
        {
            return this.startTimeFilter != null;       
        }

        /// <summary>
        /// If specified, only executions of the type specified in the filter are returned. <note><c>executionFilter</c>, <c>typeFilter</c> and
        /// <c>tagFilter</c> are mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public WorkflowTypeFilter TypeFilter
        {
            get { return this.typeFilter; }
            set { this.typeFilter = value; }
        }

        /// <summary>
        /// Sets the TypeFilter property
        /// </summary>
        /// <param name="typeFilter">The value to set for the TypeFilter property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithTypeFilter(WorkflowTypeFilter typeFilter)
        {
            this.typeFilter = typeFilter;
            return this;
        }
            

        // Check to see if TypeFilter property is set
        internal bool IsSetTypeFilter()
        {
            return this.typeFilter != null;       
        }

        /// <summary>
        /// If specified, only executions that have the matching tag are listed. <note><c>executionFilter</c>, <c>typeFilter</c> and <c>tagFilter</c>
        /// are mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public TagFilter TagFilter
        {
            get { return this.tagFilter; }
            set { this.tagFilter = value; }
        }

        /// <summary>
        /// Sets the TagFilter property
        /// </summary>
        /// <param name="tagFilter">The value to set for the TagFilter property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithTagFilter(TagFilter tagFilter)
        {
            this.tagFilter = tagFilter;
            return this;
        }
            

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this.tagFilter != null;       
        }

        /// <summary>
        /// If on a previous call to this method a <c>NextPageToken</c> was returned, the results are being paginated. To get the next page of results,
        /// repeat the call with the returned token and all other arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;       
        }

        /// <summary>
        /// The maximum number of results returned in each page. The default is 100, but the caller can override this value to a page size
        /// <i>smaller</i> than the default. You cannot specify a page size greater than 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this.maximumPageSize ?? default(int); }
            set { this.maximumPageSize = value; }
        }

        /// <summary>
        /// Sets the MaximumPageSize property
        /// </summary>
        /// <param name="maximumPageSize">The value to set for the MaximumPageSize property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithMaximumPageSize(int maximumPageSize)
        {
            this.maximumPageSize = maximumPageSize;
            return this;
        }
            

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this.maximumPageSize.HasValue;       
        }

        /// <summary>
        /// When set to <c>true</c>, returns the results in reverse order. By default the results are returned in descending order of the start time of
        /// the executions.
        ///  
        /// </summary>
        public bool ReverseOrder
        {
            get { return this.reverseOrder ?? default(bool); }
            set { this.reverseOrder = value; }
        }

        /// <summary>
        /// Sets the ReverseOrder property
        /// </summary>
        /// <param name="reverseOrder">The value to set for the ReverseOrder property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithReverseOrder(bool reverseOrder)
        {
            this.reverseOrder = reverseOrder;
            return this;
        }
            

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this.reverseOrder.HasValue;       
        }

        /// <summary>
        /// If specified, only workflow executions matching the workflow id specified in the filter are returned. <note><c>executionFilter</c>,
        /// <c>typeFilter</c> and <c>tagFilter</c> are mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public WorkflowExecutionFilter ExecutionFilter
        {
            get { return this.executionFilter; }
            set { this.executionFilter = value; }
        }

        /// <summary>
        /// Sets the ExecutionFilter property
        /// </summary>
        /// <param name="executionFilter">The value to set for the ExecutionFilter property </param>
        /// <returns>this instance</returns>
        public ListOpenWorkflowExecutionsRequest WithExecutionFilter(WorkflowExecutionFilter executionFilter)
        {
            this.executionFilter = executionFilter;
            return this;
        }
            

        // Check to see if ExecutionFilter property is set
        internal bool IsSetExecutionFilter()
        {
            return this.executionFilter != null;       
        }
    }
}
    
