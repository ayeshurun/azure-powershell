// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Configuration settings, as name-value pairs for configuring this extension.</summary>
    public partial class PatchExtensionPropertiesConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IPatchExtensionPropertiesConfigurationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IPatchExtensionPropertiesConfigurationSettingsInternal
    {

        /// <summary>
        /// Creates an new <see cref="PatchExtensionPropertiesConfigurationSettings" /> instance.
        /// </summary>
        public PatchExtensionPropertiesConfigurationSettings()
        {

        }
    }
    /// Configuration settings, as name-value pairs for configuring this extension.
    public partial interface IPatchExtensionPropertiesConfigurationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// Configuration settings, as name-value pairs for configuring this extension.
    internal partial interface IPatchExtensionPropertiesConfigurationSettingsInternal

    {

    }
}