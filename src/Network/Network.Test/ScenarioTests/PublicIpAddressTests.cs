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

using Microsoft.Azure.Commands.Network.Test.ScenarioTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Commands.Network.Test.ScenarioTests
{
    public class PublicIpAddressTests : NetworkTestRunner
    {
        public PublicIpAddressTests(Xunit.Abstractions.ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUD()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDPublicIPPrefix()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-PublicIPPrefix");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDNoDomainNameLabel()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-NoDomainNameLabel");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDStaticAllocation()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-StaticAllocation");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDEditDomainNameLavel()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-EditDomainNameLavel");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDReverseFqdn()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-ReverseFqdn");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDIpTag()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-IpTag");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressIpVersion()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressIpVersion");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressVmss()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressVmss");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpBasicSku()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-BasicSku");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpStandardSku()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-StandardSku");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpStandardSkuAsDefault()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-StandardSkuDefault");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.ddos)]
        public void TestPublicIpDdosProtection()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-DdosProtection");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpStandardSkuGlobalTier()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-StandardSkuGlobalTier");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressZones()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressZones");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.wanrpdev)]
        public void TestPublicIpAddressCRUDIdleTimeout()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressCRUD-IdleTimeout");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestPublicIpAddressInEdgeZone()
        {
            TestRunner.RunTestScript("Test-PublicIpAddressInEdgeZone");
        }
    }
}
