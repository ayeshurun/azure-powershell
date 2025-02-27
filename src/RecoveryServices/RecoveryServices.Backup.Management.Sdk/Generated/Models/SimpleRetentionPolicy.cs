// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Simple policy retention.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SimpleRetentionPolicy")]
    public partial class SimpleRetentionPolicy : RetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the SimpleRetentionPolicy class.
        /// </summary>
        public SimpleRetentionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleRetentionPolicy class.
        /// </summary>
        /// <param name="retentionDuration">Retention duration of the
        /// protection policy.</param>
        public SimpleRetentionPolicy(RetentionDuration retentionDuration = default(RetentionDuration))
        {
            RetentionDuration = retentionDuration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets retention duration of the protection policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionDuration")]
        public RetentionDuration RetentionDuration { get; set; }

    }
}
