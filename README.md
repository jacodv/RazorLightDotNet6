**Changed Language Version**
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <IsPackable>false</IsPackable>
    <PreserveCompilationContext>true</PreserveCompilationContext>
    <LangVersion>9</LangVersion>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="FluentAssertions" Version="6.2.0" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.0.0" />
    <PackageReference Include="NUnit" Version="3.13.2" />
    <PackageReference Include="NUnit3TestAdapter" Version="4.1.0" />
    <PackageReference Include="coverlet.collector" Version="3.1.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Jdv.Razor\Jdv.Razor.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Update="Microsoft.SourceLink.GitHub" Version="1.1.1" />
  </ItemGroup>

</Project>

```