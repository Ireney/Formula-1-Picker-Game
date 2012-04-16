<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="CleverDogStudios.FormulaOnePickr.WebService.Azure" generation="1" functional="0" release="0" Id="6ce06a22-64fd-4267-a39f-0a8e941dcd10" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="CleverDogStudios.FormulaOnePickr.WebService.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="FormulaOnePickr.WebService:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/LB:FormulaOnePickr.WebService:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="FormulaOnePickr.WebService:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/MapFormulaOnePickr.WebService:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="FormulaOnePickr.WebServiceInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/MapFormulaOnePickr.WebServiceInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:FormulaOnePickr.WebService:Endpoint1">
          <toPorts>
            <inPortMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebService/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapFormulaOnePickr.WebService:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebService/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapFormulaOnePickr.WebServiceInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebServiceInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="FormulaOnePickr.WebService" generation="1" functional="0" release="0" software="C:\Projects\FormulaOnePickr\src\CleverDogStudios.FormulaOnePickr.WebService.Azure\csx\Debug\roles\FormulaOnePickr.WebService" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;FormulaOnePickr.WebService&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;FormulaOnePickr.WebService&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="CleverDogStudios.FormulaOnePickr.WebService.svclog" defaultAmount="[1000,1000,1000]" defaultSticky="true" kind="Directory" />
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebServiceInstances" />
            <sCSPolicyFaultDomainMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebServiceFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyFaultDomain name="FormulaOnePickr.WebServiceFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="FormulaOnePickr.WebServiceInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="3d31fe73-95dc-444e-8dd4-5401169b0d67" ref="Microsoft.RedDog.Contract\ServiceContract\CleverDogStudios.FormulaOnePickr.WebService.AzureContract@ServiceDefinition.build">
      <interfacereferences>
        <interfaceReference Id="b3bf3cd9-a9bf-4fe0-9e8c-f34cf39251c3" ref="Microsoft.RedDog.Contract\Interface\FormulaOnePickr.WebService:Endpoint1@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/CleverDogStudios.FormulaOnePickr.WebService.Azure/CleverDogStudios.FormulaOnePickr.WebService.AzureGroup/FormulaOnePickr.WebService:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>