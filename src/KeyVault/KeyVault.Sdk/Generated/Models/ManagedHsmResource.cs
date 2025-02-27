// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System.Linq;

    /// <summary>
    /// Managed HSM resource
    /// </summary>
    public partial class ManagedHsmResource : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHsmResource class.
        /// </summary>
        public ManagedHsmResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedHsmResource class.
        /// </summary>

        /// <param name="id">The Azure Resource Manager resource ID for the managed HSM Pool.
        /// </param>

        /// <param name="name">The name of the managed HSM Pool.
        /// </param>

        /// <param name="type">The resource type of the managed HSM Pool.
        /// </param>

        /// <param name="location">The supported Azure location where the managed HSM Pool should be created.
        /// </param>

        /// <param name="sku">SKU details
        /// </param>

        /// <param name="tags">Resource tags
        /// </param>

        /// <param name="systemData">Metadata pertaining to creation and last modification of the key vault
        /// resource.
        /// </param>
        public ManagedHsmResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), ManagedHsmSku sku = default(ManagedHsmSku), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), SystemData systemData = default(SystemData))

        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Location = location;
            this.Sku = sku;
            this.Tags = tags;
            this.SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the Azure Resource Manager resource ID for the managed HSM Pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets the name of the managed HSM Pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets the resource type of the managed HSM Pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets the supported Azure location where the managed HSM Pool should
        /// be created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets sKU details
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ManagedHsmSku Sku {get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the key vault
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData {get; private set; }
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