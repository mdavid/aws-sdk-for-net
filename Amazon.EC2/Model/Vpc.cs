/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-11-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///VPC
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-11-01/", IsNullable = false)]
    public class Vpc
    {    
        private string vpcIdField;
        private string vpcStateField;
        private string cidrBlockField;
        private string dhcpOptionsIdField;
        private List<Tag> tagField;
        private string instanceTenancyField;

        /// <summary>
        /// Gets and sets the VpcId property.
        /// The VPC's ID
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The VPC's ID</param>
        /// <returns>this instance</returns>
        public Vpc WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

        /// <summary>
        /// Gets and sets the VpcState property.
        /// The current state of the VPC (pending or available).
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcState")]
        public string VpcState
        {
            get { return this.vpcStateField; }
            set { this.vpcStateField = value; }
        }

        /// <summary>
        /// Sets the VpcState property
        /// </summary>
        /// <param name="vpcState">The current state of the VPC (pending or available).</param>
        /// <returns>this instance</returns>
        public Vpc WithVpcState(string vpcState)
        {
            this.vpcStateField = vpcState;
            return this;
        }

        /// <summary>
        /// Checks if VpcState property is set
        /// </summary>
        /// <returns>true if VpcState property is set</returns>
        public bool IsSetVpcState()
        {
            return this.vpcStateField != null;
        }

        /// <summary>
        /// Gets and sets the CidrBlock property.
        /// The CIDR block the VPC covers
        /// </summary>
        [XmlElementAttribute(ElementName = "CidrBlock")]
        public string CidrBlock
        {
            get { return this.cidrBlockField; }
            set { this.cidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CidrBlock property
        /// </summary>
        /// <param name="cidrBlock">The CIDR block the VPC covers</param>
        /// <returns>this instance</returns>
        public Vpc WithCidrBlock(string cidrBlock)
        {
            this.cidrBlockField = cidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if CidrBlock property is set
        /// </summary>
        /// <returns>true if CidrBlock property is set</returns>
        public bool IsSetCidrBlock()
        {
            return this.cidrBlockField != null;
        }

        /// <summary>
        /// Gets and sets the DhcpOptionsId property.
        /// The ID of the set of DHCP options you've
        /// associated with the VPC
        /// (or "default" if
        /// the default options are
        /// associated with the VPC).
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpOptionsId")]
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsIdField; }
            set { this.dhcpOptionsIdField = value; }
        }

        /// <summary>
        /// Sets the DhcpOptionsId property
        /// </summary>
        /// <param name="dhcpOptionsId">The ID of the set of DHCP options you've
        /// associated with the VPC
        /// (or "default" if
        /// the default options are
        /// associated with the VPC).</param>
        /// <returns>this instance</returns>
        public Vpc WithDhcpOptionsId(string dhcpOptionsId)
        {
            this.dhcpOptionsIdField = dhcpOptionsId;
            return this;
        }

        /// <summary>
        /// Checks if DhcpOptionsId property is set
        /// </summary>
        /// <returns>true if DhcpOptionsId property is set</returns>
        public bool IsSetDhcpOptionsId()
        {
            return this.dhcpOptionsIdField != null;
        }

        /// <summary>
        /// Gets and sets the Tag property.
        /// A list of tags for the Vpc.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">A list of tags for the Vpc.</param>
        /// <returns>this instance</returns>
        public Vpc WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }


        /// <summary>
        /// Gets and sets the InstanceTenancy property.
        /// The allowed tenancy of instances launched into the VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceTenancy")]
        public string InstanceTenancy
        {
            get { return this.instanceTenancyField; }
            set { this.instanceTenancyField = value; }
        }


        /// <summary>
        /// Checks if InstanceTenancy property is set
        /// </summary>
        /// <returns>true if InstanceTenancy property is set</returns>
        public bool IsSetInstanceTenancy()
        {
            return this.instanceTenancyField != null;
        }

        /// <summary>
        /// Sets the InstanceTenancy property
        /// </summary>
        /// <param name="instanceTenancy">The allowed tenancy of instances launched into the VPC.</param>
        /// <returns>this instance</returns>
        public Vpc WithInstanceTenancy(string instanceTenancy)
        {
            this.instanceTenancyField = instanceTenancy;
            return this;
        }
    }
}
