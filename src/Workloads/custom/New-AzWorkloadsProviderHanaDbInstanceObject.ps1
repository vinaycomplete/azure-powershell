
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
Create an in-memory object for HanaDbProviderInstanceProperties.
.Description
Create an in-memory object for HanaDbProviderInstanceProperties.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.HanaDbProviderInstanceProperties
.Link
https://learn.microsoft.com/powershell/module/az.workloads/new-azworkloadsproviderhanadbinstanceobject
#>
function New-AzWorkloadsProviderHanaDbInstanceObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.HanaDbProviderInstanceProperties')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Gets or sets the hana database name.")]
        [string]
        $Name,
        [Parameter(HelpMessage="Gets or sets the database password.")]
        [string]
        $Password,
        [Parameter(HelpMessage="Gets or sets the key vault URI to secret with the database password.")]
        [string]
        $PasswordUri,
        [Parameter(HelpMessage="Gets or sets the database user name.")]
        [string]
        $Username,
        [Parameter(HelpMessage="Gets or sets the target virtual machine size.")]
        [string]
        $Hostname,
        [Parameter(HelpMessage="Gets or sets the database instance number.")]
        [string]
        $InstanceNumber,
        [Parameter(HelpMessage="Gets or sets the SAP System Identifier.")]
        [string]
        $SapSid,
        [Parameter(HelpMessage="Gets or sets the database sql port.")]
        [string]
        $SqlPort,
        [Parameter(HelpMessage="Gets or sets the blob URI to SSL certificate for the DB.")]
        [string]
        $SslCertificateUri,
        [Parameter(HelpMessage="Gets or sets the hostname(s) in the SSL certificate.")]
        [string]
        $SslHostNameInCertificate,
        [Parameter(HelpMessage="Gets or sets certificate preference if secure communication is enabled.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference])]
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SslPreference]
        $SslPreference
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.HanaDbProviderInstanceProperties]::New()

        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.DbName = $Name
        }
        if ($PSBoundParameters.ContainsKey('Password')) {
            $Object.DbPassword = $Password
        }
        if ($PSBoundParameters.ContainsKey('PasswordUri')) {
            $Object.DbPasswordUri = $PasswordUri
        }
        if ($PSBoundParameters.ContainsKey('Username')) {
            $Object.DbUsername = $Username
        }
        if ($PSBoundParameters.ContainsKey('Hostname')) {
            $Object.Hostname = $Hostname
        }
        if ($PSBoundParameters.ContainsKey('InstanceNumber')) {
            $Object.InstanceNumber = $InstanceNumber
        }
        if ($PSBoundParameters.ContainsKey('SapSid')) {
            $Object.SapSid = $SapSid
        }
        if ($PSBoundParameters.ContainsKey('SqlPort')) {
            $Object.SqlPort = $SqlPort
        }
        if ($PSBoundParameters.ContainsKey('SslCertificateUri')) {
            $Object.SslCertificateUri = $SslCertificateUri
        }
        if ($PSBoundParameters.ContainsKey('SslHostNameInCertificate')) {
            $Object.SslHostNameInCertificate = $SslHostNameInCertificate
        }
        if ($PSBoundParameters.ContainsKey('SslPreference')) {
            $Object.SslPreference = $SslPreference
        }
        $Object.ProviderType = 'SapHana'
        return $Object
    }
}

