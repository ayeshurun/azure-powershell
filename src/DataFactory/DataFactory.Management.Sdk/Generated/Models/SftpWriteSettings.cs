// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Sftp write settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SftpWriteSettings")]
    public partial class SftpWriteSettings : StoreWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the SftpWriteSettings class.
        /// </summary>
        public SftpWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SftpWriteSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="disableMetricsCollection">If true, disable data store
        /// metrics collection. Default is false. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="copyBehavior">The type of copy behavior for copy
        /// sink.</param>
        /// <param name="operationTimeout">Specifies the timeout for writing
        /// each chunk to SFTP server. Default value: 01:00:00 (one hour).
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="useTempFileRename">Upload to temporary file(s) and
        /// rename. Disable this option if your SFTP server doesn't support
        /// rename operation. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public SftpWriteSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object copyBehavior = default(object), object operationTimeout = default(object), object useTempFileRename = default(object))
            : base(additionalProperties, maxConcurrentConnections, disableMetricsCollection, copyBehavior)
        {
            OperationTimeout = operationTimeout;
            UseTempFileRename = useTempFileRename;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the timeout for writing each chunk to SFTP
        /// server. Default value: 01:00:00 (one hour). Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "operationTimeout")]
        public object OperationTimeout { get; set; }

        /// <summary>
        /// Gets or sets upload to temporary file(s) and rename. Disable this
        /// option if your SFTP server doesn't support rename operation. Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "useTempFileRename")]
        public object UseTempFileRename { get; set; }

    }
}
