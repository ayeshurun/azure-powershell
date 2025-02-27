﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.HDInsight.Commands;
using Microsoft.Azure.Commands.HDInsight.Models.Management;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.HDInsight
{
    [GenericBreakingChangeWithVersionAttribute("The generic type for 'property ComponentVersions' will change from 'System.Collections.Generic.IDictionary`2[System.String,System.String]' to 'System.Collections.Generic.IReadOnlyDictionary`2[System.String,System.String]'. ",Constants.deprecateByAzVersion,Constants.deprecateByVersion)]
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "HDInsightProperty"),OutputType(typeof(AzureHDInsightCapabilities))]
    public class GetAzureHDInsightPropertiesCommand : HDInsightCmdletBase
    {
        #region Input Parameter Definitions

        [Parameter(
            Position = 0,
            Mandatory = true,
            HelpMessage = "Gets or sets the datacenter location for the cluster.")]
        [LocationCompleter("Microsoft.HDInsight/locations/capabilities")]
        public string Location { get; set; }

        #endregion

        public override void ExecuteCmdlet()
        {
            var capabilitiesResult = HDInsightManagementClient.GetProperties(Location);
            var billingSpecResult = HDInsightManagementClient.ListBillingSpecs(Location);
            WriteObject(new AzureHDInsightCapabilities(capabilitiesResult, billingSpecResult), true);
        }
    }
}
