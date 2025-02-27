// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// The Elastic Pool performance level capability.
    /// </summary>
    public partial class ElasticPoolPerformanceLevelCapability
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPoolPerformanceLevelCapability class.
        /// </summary>
        public ElasticPoolPerformanceLevelCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticPoolPerformanceLevelCapability class.
        /// </summary>

        /// <param name="performanceLevel">The performance level for the pool.
        /// </param>

        /// <param name="sku">The sku.
        /// </param>

        /// <param name="supportedLicenseTypes">List of supported license types.
        /// </param>

        /// <param name="maxDatabaseCount">The maximum number of databases supported.
        /// </param>

        /// <param name="includedMaxSize">The included (free) max size for this performance level.
        /// </param>

        /// <param name="supportedMaxSizes">The list of supported max sizes.
        /// </param>

        /// <param name="supportedPerDatabaseMaxSizes">The list of supported per database max sizes.
        /// </param>

        /// <param name="supportedPerDatabaseMaxPerformanceLevels">The list of supported per database max performance levels.
        /// </param>

        /// <param name="zoneRedundant">Whether or not zone redundancy is supported for the performance level.
        /// </param>

        /// <param name="supportedMaintenanceConfigurations">List of supported maintenance configurations
        /// </param>

        /// <param name="status">The status of the capability.
        /// Possible values include: 'Visible', 'Available', 'Default', 'Disabled'</param>

        /// <param name="reason">The reason for the capability not being available.
        /// </param>
        public ElasticPoolPerformanceLevelCapability(PerformanceLevelCapability performanceLevel = default(PerformanceLevelCapability), Sku sku = default(Sku), System.Collections.Generic.IList<LicenseTypeCapability> supportedLicenseTypes = default(System.Collections.Generic.IList<LicenseTypeCapability>), int? maxDatabaseCount = default(int?), MaxSizeCapability includedMaxSize = default(MaxSizeCapability), System.Collections.Generic.IList<MaxSizeRangeCapability> supportedMaxSizes = default(System.Collections.Generic.IList<MaxSizeRangeCapability>), System.Collections.Generic.IList<MaxSizeRangeCapability> supportedPerDatabaseMaxSizes = default(System.Collections.Generic.IList<MaxSizeRangeCapability>), System.Collections.Generic.IList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> supportedPerDatabaseMaxPerformanceLevels = default(System.Collections.Generic.IList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>), bool? zoneRedundant = default(bool?), System.Collections.Generic.IList<MaintenanceConfigurationCapability> supportedMaintenanceConfigurations = default(System.Collections.Generic.IList<MaintenanceConfigurationCapability>), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))

        {
            this.PerformanceLevel = performanceLevel;
            this.Sku = sku;
            this.SupportedLicenseTypes = supportedLicenseTypes;
            this.MaxDatabaseCount = maxDatabaseCount;
            this.IncludedMaxSize = includedMaxSize;
            this.SupportedMaxSizes = supportedMaxSizes;
            this.SupportedPerDatabaseMaxSizes = supportedPerDatabaseMaxSizes;
            this.SupportedPerDatabaseMaxPerformanceLevels = supportedPerDatabaseMaxPerformanceLevels;
            this.ZoneRedundant = zoneRedundant;
            this.SupportedMaintenanceConfigurations = supportedMaintenanceConfigurations;
            this.Status = status;
            this.Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the performance level for the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "performanceLevel")]
        public PerformanceLevelCapability PerformanceLevel {get; private set; }

        /// <summary>
        /// Gets the sku.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku {get; private set; }

        /// <summary>
        /// Gets list of supported license types.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedLicenseTypes")]
        public System.Collections.Generic.IList<LicenseTypeCapability> SupportedLicenseTypes {get; private set; }

        /// <summary>
        /// Gets the maximum number of databases supported.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxDatabaseCount")]
        public int? MaxDatabaseCount {get; private set; }

        /// <summary>
        /// Gets the included (free) max size for this performance level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "includedMaxSize")]
        public MaxSizeCapability IncludedMaxSize {get; private set; }

        /// <summary>
        /// Gets the list of supported max sizes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedMaxSizes")]
        public System.Collections.Generic.IList<MaxSizeRangeCapability> SupportedMaxSizes {get; private set; }

        /// <summary>
        /// Gets the list of supported per database max sizes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedPerDatabaseMaxSizes")]
        public System.Collections.Generic.IList<MaxSizeRangeCapability> SupportedPerDatabaseMaxSizes {get; private set; }

        /// <summary>
        /// Gets the list of supported per database max performance levels.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedPerDatabaseMaxPerformanceLevels")]
        public System.Collections.Generic.IList<ElasticPoolPerDatabaseMaxPerformanceLevelCapability> SupportedPerDatabaseMaxPerformanceLevels {get; private set; }

        /// <summary>
        /// Gets whether or not zone redundancy is supported for the performance level.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "zoneRedundant")]
        public bool? ZoneRedundant {get; private set; }

        /// <summary>
        /// Gets list of supported maintenance configurations
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedMaintenanceConfigurations")]
        public System.Collections.Generic.IList<MaintenanceConfigurationCapability> SupportedMaintenanceConfigurations {get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include: &#39;Visible&#39;, &#39;Available&#39;, &#39;Default&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status {get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reason")]
        public string Reason {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.Sku != null)
            {
                this.Sku.Validate();
            }








        }
    }
}