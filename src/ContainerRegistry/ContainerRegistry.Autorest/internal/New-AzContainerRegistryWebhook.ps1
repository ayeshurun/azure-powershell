
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
Creates a webhook for a container registry with the specified parameters.
.Description
Creates a webhook for a container registry with the specified parameters.
.Example
New-AzContainerRegistryWebhook -ResourceGroupName "MyResourceGroup" -RegistryName "RegistryExample" -Name "webhook001" -Uri http://www.bing.com -Action Delete,Push -Header @{SpecialHeader='headerVal'} -Tag @{Key="val"} -Location "east us" -Status Enabled -Scope "foo:*"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhook
.Link
https://learn.microsoft.com/powershell/module/az.containerregistry/new-azcontainerregistrywebhook
#>
function New-AzContainerRegistryWebhook {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhook])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('WebhookName', 'ResourceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the webhook.
    ${Name},

    [Parameter(Mandatory)]
    [Alias('ContainerRegistryName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the container registry.
    ${RegistryName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The location of the webhook.
    # This cannot be changed after the resource is created.
    ${Location},

    [Parameter()]
    [AllowEmptyCollection()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookAction])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookAction[]]
    # The list of actions that trigger the webhook to post notifications.
    ${Action},

    [Parameter()]
    [Alias('Header')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhookPropertiesCreateParametersCustomHeaders]))]
    [System.Collections.Hashtable]
    # Custom headers that will be added to the webhook notifications.
    ${CustomHeader},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The scope of repositories where the event can be triggered.
    # For example, 'foo:*' means events for all tags under repository 'foo'.
    # 'foo:bar' means events for 'foo:bar' only.
    # 'foo' is equivalent to 'foo:latest'.
    # Empty means all events.
    ${Scope},

    [Parameter()]
    [Alias('Uri')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The service URI for the webhook to post notifications.
    ${ServiceUri},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus]
    # The status of the webhook at the time the operation was called.
    ${Status},

    [Parameter()]
    [Alias('Tags')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IWebhookCreateParametersTags]))]
    [System.Collections.Hashtable]
    # The tags for the webhook.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.ContainerRegistry.private\New-AzContainerRegistryWebhook_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
