
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for Diagnostics Extension
.Description
Create a in-memory object for Diagnostics Extension
.Example
$storageAccountKey = Get-AzStorageAccountKey -ResourceGroupName "ContosOrg" -Name "ContosSA"
$configFile = "<WAD configuration file path>"
$extension = New-AzCloudServiceDiagnosticsExtension -Name "WADExtension" -ResourceGroupName "ContosOrg" -CloudServiceName "ContosCS" -StorageAccountName "ContosSA" -StorageAccountKey $storageAccountKey[0].Value -DiagnosticsConfigurationPath $configFile -TypeHandlerVersion "1.5" -AutoUpgradeMinorVersion $true

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.Extension
.Link
https://learn.microsoft.com/powershell/module/az.cloudservice/new-azcloudservicediagnosticsextension
#>
function New-AzCloudServiceDiagnosticsExtension {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.Extension])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Position=1)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription.
    ${Subscription},

    [Parameter(Position=0, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Name of Diagnostics Extension.
    ${Name},

    [Parameter(Position=2, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Resource Group name of Cloud Service.
    ${ResourceGroupName},

    [Parameter(Position=3, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Name of Cloud Service.
    ${CloudServiceName},

    [Parameter(Position=4, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Specifies the configuration for Azure Diagnostics.
    # You can download the schema by using the following command: (Get-AzureServiceAvailableExtension -ExtensionName 'PaaSDiagnostics' -ProviderNamespace 'Microsoft.Azure.Diagnostics').PublicConfigurationSchema | Out-File -Encoding utf8 -FilePath 'WadConfig.xsd'
    ${DiagnosticsConfigurationPath},

    [Parameter(Position=5, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Name of the Storage Account.
    ${StorageAccountName},

    [Parameter(Position=6, Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Storage Account Key.
    ${StorageAccountKey},

    [Parameter(Position=7)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String]
    # Specifies the version of the extension.
    ${TypeHandlerVersion},

    [Parameter(Position=8)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.String[]]
    # Roles applied to.
    ${RolesAppliedTo},

    [Parameter(Position=9)]
    [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Category('Body')]
    [System.Boolean]
    # Auto upgrade minor version.
    ${AutoUpgradeMinorVersion}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.CloudService.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            __AllParameterSets = 'Az.CloudService.custom\New-AzCloudServiceDiagnosticsExtension';
        }
        if (('__AllParameterSets') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Subscription')) {
            $PSBoundParameters['Subscription'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.CloudService.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
