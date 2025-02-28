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

using System.Management.Automation;
using Microsoft.Azure.Commands.Management.PowerBIEmbedded.Models;
using Microsoft.Azure.Management.PowerBIEmbedded;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Management.PowerBIEmbedded.WorkspaceCollection
{
    [CmdletDeprecation()]
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "PowerBIWorkspaceCollectionAccessKey"), OutputType(typeof(PSWorkspaceCollectionAccessKey))]
    [Alias("Get-AzPowerBIWorkspaceCollectionAccessKeys")]
    public class GetWorkspaceCollectionAccessKeys : WorkspaceCollectionBaseCmdlet
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Resource Group Name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Workspace Collection Name.")]
        [Alias("Name", "ResourceName")]
        [ValidateNotNullOrEmpty]
        public string WorkspaceCollectionName { get; set; }

        public override void ExecuteCmdlet()
        {
            var accessKeys = this.PowerBIClient.WorkspaceCollections.GetAccessKeys(this.ResourceGroupName, this.WorkspaceCollectionName);
            this.WriteWorkspaceCollectionAccessKeys(accessKeys);
        }
    }
}
