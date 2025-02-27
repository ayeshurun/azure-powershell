// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties to configure Encryption</summary>
    public partial class Encryption
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject into a new instance of <see cref="Encryption" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Encryption(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_keyVaultProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonArray>("keyVaultProperties"), out var __jsonKeyVaultProperties) ? If( __jsonKeyVaultProperties as Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IKeyVaultProperties[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IKeyVaultProperties) (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.KeyVaultProperties.FromJson(__u) )) ))() : null : KeyVaultProperty;}
            {_keySource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString>("keySource"), out var __jsonKeySource) ? (string)__jsonKeySource : (string)KeySource;}
            {_requireInfrastructureEncryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonBoolean>("requireInfrastructureEncryption"), out var __jsonRequireInfrastructureEncryption) ? (bool?)__jsonRequireInfrastructureEncryption : RequireInfrastructureEncryption;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IEncryption.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IEncryption.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api202301Preview.IEncryption FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject json ? new Encryption(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Encryption" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Encryption" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._keyVaultProperty)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.XNodeArray();
                foreach( var __x in this._keyVaultProperty )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("keyVaultProperties",__w);
            }
            AddIf( null != (((object)this._keySource)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonString(this._keySource.ToString()) : null, "keySource" ,container.Add );
            AddIf( null != this._requireInfrastructureEncryption ? (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonBoolean((bool)this._requireInfrastructureEncryption) : null, "requireInfrastructureEncryption" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}