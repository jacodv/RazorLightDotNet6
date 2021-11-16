**IMPLEMENTATION**
```
private class NullRazorProjectFileSystem : RazorProjectFileSystem
		{
			public override IEnumerable<RazorProjectItem> EnumerateItems(string basePath)
			{
				throw new System.NotImplementedException();
			}


#if (NETCOREAPP3_0 || NETCOREAPP3_1 || NET5_0 || NET6_0)
			[System.Obsolete]
#endif
			public override RazorProjectItem GetItem(string path)
			{
				throw new System.NotImplementedException();
			}

#if (NETCOREAPP3_0 || NETCOREAPP3_1 || NET5_0 || NET6_0)
			public override RazorProjectItem GetItem(string path, string fileKind)
			{
				throw new System.NotImplementedException();
			}
#endif
		}
```

**PROJECT**
```
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
      <TargetFrameworks>netstandard2.0;netcoreapp3.1;net5.0;net6.0</TargetFrameworks>
  </PropertyGroup>

  <PropertyGroup>
    <PackageId>RazorLight</PackageId>
    <Title>RazorLight</Title>
    <Version>2.0.0-rc.3</Version>
    <Description>Use Razor to build your templates from strings / files / EmbeddedResources outside of ASP.NET MVC for .NET Core</Description>
    <Authors>toddams</Authors>
    <PackageTags>RazorLight, razor, render, dotnet-core, dotnet, core, template-engine, email, emails</PackageTags>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <PackageLicenseFile>LICENSE</PackageLicenseFile>
  </PropertyGroup>

  <ItemGroup Condition="'$(TargetFramework)' == 'netstandard2.0'">
    <PackageReference Include="Microsoft.CodeAnalysis.Razor" Version="2.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Hosting.Abstractions" Version="2.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Html.Abstractions" Version="2.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Extensions" Version="2.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Razor.Language" Version="2.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.Razor.Runtime" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="2.1.0" />
    <PackageReference Include="Microsoft.Extensions.Primitives" Version="2.1.0" />
    <PackageReference Include="System.Buffers" Version="4.5.0" />
  </ItemGroup>
        
  <ItemGroup Condition="'$(TargetFramework)' == 'netcoreapp3.0'">
    <FrameworkReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Extensions" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.CodeAnalysis.Razor" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="[3.0.3,3.1)" />
    <PackageReference Include="Microsoft.Extensions.Primitives" Version="[3.0.3,3.1)" />
    <PackageReference Include="System.Buffers" Version="4.5.0" />
  </ItemGroup>

  <ItemGroup Condition="'$(TargetFramework)' == 'netcoreapp3.1'">
    <FrameworkReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Extensions" Version="3.1.5" />
    <PackageReference Include="Microsoft.CodeAnalysis.Razor" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="3.1.5" />
    <PackageReference Include="Microsoft.Extensions.Primitives" Version="3.1.5" />
    <PackageReference Include="System.Buffers" Version="4.5.0" />
  </ItemGroup>

  <ItemGroup Condition="'$(TargetFramework)' == 'net5.0'">
    <FrameworkReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Extensions" Version="5.0.0" />
    <PackageReference Include="Microsoft.CodeAnalysis.Razor" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="5.0.0" />
    <PackageReference Include="Microsoft.Extensions.Primitives" Version="5.0.0" />
    <PackageReference Include="System.Buffers" Version="4.5.1" />
  </ItemGroup>

  <ItemGroup Condition="'$(TargetFramework)' == 'net6.0'">
    <FrameworkReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="Microsoft.AspNetCore.Mvc.Razor.Extensions" Version="6.0.0" />
    <PackageReference Include="Microsoft.CodeAnalysis.Razor" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Abstractions" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.DependencyModel" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.FileProviders.Physical" Version="6.0.0" />
    <PackageReference Include="Microsoft.Extensions.Primitives" Version="6.0.0" />
    <PackageReference Include="System.Buffers" Version="4.5.1" />
  </ItemGroup>

  <ItemGroup>
    <None Include="..\..\LICENSE">
      <Pack>True</Pack>
      <PackagePath></PackagePath>
    </None>
  </ItemGroup>
</Project>
```