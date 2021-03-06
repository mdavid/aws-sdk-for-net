/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetBucketVersioningResponse contains the GetBucketVersioningResult and 
    /// any headers returned by S3.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class GetBucketVersioningResponse : S3Response
    {
        #region Private Members

        private S3BucketVersioningConfig config;

        #endregion

        #region VersioningConfig

        /// <summary>
        /// Gets and sets the Versioning property.
        /// Unless Versioning has been explicitly "Enabled" on a bucket,
        /// Versioning Status is "Off". Once Versioning has been 
        /// "Enabled", it can be "Suspended" but cannot be switched "Off".
        /// </summary>
        [XmlElementAttribute(ElementName = "VersioningConfig")]
        public S3BucketVersioningConfig VersioningConfig
        {
            get { return this.config; }
            set { this.config = value; }
        }

        #endregion
    }
}