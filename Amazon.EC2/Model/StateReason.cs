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
 *  API Version: 2011-12-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Reason for the state change.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-12-15/", IsNullable = false)]
    public class StateReason
    {    
        private string codeField;
        private string messageField;

        /// <summary>
        /// Gets and sets the Code property.
        /// Reason code for the state change.
        /// </summary>
        [XmlElementAttribute(ElementName = "Code")]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Sets the Code property
        /// </summary>
        /// <param name="code">Reason code for the state change.</param>
        /// <returns>this instance</returns>
        public StateReason WithCode(string code)
        {
            this.codeField = code;
            return this;
        }

        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }

        /// <summary>
        /// Gets and sets the Message property.
        /// Message for the state change.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">Message for the state change.</param>
        /// <returns>this instance</returns>
        public StateReason WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }

    }
}
