<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="FormulaOnePickr.Web.Azure" generation="1" functional="0" release="0" Id="9b63dde0-e18e-485f-bace-64cb36d7eee9" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="FormulaOnePickr.Web.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="FormulaOnePickr.Web:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/LB:FormulaOnePickr.Web:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="FormulaOnePickr.Web:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/MapFormulaOnePickr.Web:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="FormulaOnePickr.WebInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/MapFormulaOnePickr.WebInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:FormulaOnePickr.Web:Endpoint1">
          <toPorts>
            <inPortMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.Web/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapFormulaOnePickr.Web:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.Web/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapFormulaOnePickr.WebInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.WebInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="FormulaOnePickr.Web" generation="1" functional="0" release="0" software="C:\Projects\FormulaOnePickr\src\FormulaOnePickr.Web.Azure\csx\Debug\roles\FormulaOnePickr.Web" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;FormulaOnePickr.Web&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;FormulaOnePickr.Web&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.WebInstances" />
            <sCSPolicyFaultDomainMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.WebFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyFaultDomain name="FormulaOnePickr.WebFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="FormulaOnePickr.WebInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="a2238b88-324d-4ef7-aeef-751c4502871f" ref="Microsoft.RedDog.Contract\ServiceContract\FormulaOnePickr.Web.AzureContract@ServiceDefinition.build">
      <interfacereferences>
        <interfaceReference Id="97fec8c0-9d37-4b63-add9-dd4a89d6748a" ref="Microsoft.RedDog.Contract\Interface\FormulaOnePickr.Web:Endpoint1@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/FormulaOnePickr.Web.Azure/FormulaOnePickr.Web.AzureGroup/FormulaOnePickr.Web:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>