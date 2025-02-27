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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for Salesforce Service Cloud.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SalesforceServiceCloud")]
    [Rest.Serialization.JsonTransformation]
    public partial class SalesforceServiceCloudLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SalesforceServiceCloudLinkedService class.
        /// </summary>
        public SalesforceServiceCloudLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SalesforceServiceCloudLinkedService class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="environmentUrl">The URL of Salesforce Service Cloud
        /// instance. Default is 'https://login.salesforce.com'. To copy data
        /// from sandbox, specify 'https://test.salesforce.com'. To copy data
        /// from custom domain, specify, for example,
        /// 'https://[domain].my.salesforce.com'. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="username">The username for Basic authentication of the
        /// Salesforce instance. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="password">The password for Basic authentication of the
        /// Salesforce instance.</param>
        /// <param name="securityToken">The security token is optional to
        /// remotely access Salesforce instance.</param>
        /// <param name="apiVersion">The Salesforce API version used in ADF.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="extendedProperties">Extended properties appended to
        /// the connection string. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string.</param>
        public SalesforceServiceCloudLinkedService(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object environmentUrl = default(object), object username = default(object), SecretBase password = default(SecretBase), SecretBase securityToken = default(SecretBase), object apiVersion = default(object), object extendedProperties = default(object), string encryptedCredential = default(string))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            EnvironmentUrl = environmentUrl;
            Username = username;
            Password = password;
            SecurityToken = securityToken;
            ApiVersion = apiVersion;
            ExtendedProperties = extendedProperties;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of Salesforce Service Cloud instance. Default
        /// is 'https://login.salesforce.com'. To copy data from sandbox,
        /// specify 'https://test.salesforce.com'. To copy data from custom
        /// domain, specify, for example, 'https://[domain].my.salesforce.com'.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentUrl")]
        public object EnvironmentUrl { get; set; }

        /// <summary>
        /// Gets or sets the username for Basic authentication of the
        /// Salesforce instance. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication of the
        /// Salesforce instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the security token is optional to remotely access
        /// Salesforce instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.securityToken")]
        public SecretBase SecurityToken { get; set; }

        /// <summary>
        /// Gets or sets the Salesforce API version used in ADF. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.apiVersion")]
        public object ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets extended properties appended to the connection string.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.extendedProperties")]
        public object ExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
