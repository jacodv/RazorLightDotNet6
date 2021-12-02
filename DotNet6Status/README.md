# Environment
- Visual Studio 2022 RTM
- ReSharper 2021.3 EAP (2021-12-1)
- NCrunch 4.11.0.2 VS2022 (30 Day trial)

*Full Framework*
```
PSChildName                      Version
-----------                      -------
v2.0.50727                       2.0.50727.4927
v3.0                             3.0.30729.4926
Windows Communication Foundation 3.0.4506.4926
Windows Presentation Foundation  3.0.6920.4902
v3.5                             3.5.30729.4926
Client                           4.8.04161
Full                             4.8.04161
Client                           4.0.0.0
```

*Net Core*
```
.NET SDK (reflecting any global.json):
 Version:   6.0.100
 Commit:    9e8b04bbff

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.22000
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Program Files\dotnet\sdk\6.0.100\

Host (useful for support):
  Version: 6.0.0
  Commit:  4822e3c3aa

.NET SDKs installed:
  2.2.207 [C:\Program Files\dotnet\sdk]
  3.0.103 [C:\Program Files\dotnet\sdk]
  3.1.415 [C:\Program Files\dotnet\sdk]
  5.0.403 [C:\Program Files\dotnet\sdk]
  6.0.100 [C:\Program Files\dotnet\sdk]
```

# Ensure That Dotnet5 works

[Code Branch](https://github.com/jacodv/RazorLightDotNet6/tree/branch_jdevil-Dotnet5-Success)

## Removed NET472
Visual Studio 2022 does not want to open the solution and load all the projects.  It keeps hanging when opening the tests project.  Tried changing `net472` to `net480`.  No success

Removed net472 from all `.csproj` files.

## New Solution
Created a new solution, `RazorLight.Jdv.sln`, that only has the relevant projects
- RazorLight
- RazorLight.Tests
- RazorLight.Precompile

## Added new projects
In order to simulate my own scenario, I created two new projects, `Jdv.Razor.csproj` and `Jdv.Razor.Tests.csproj`.  These projects contain a subset of our business logic and tests to ensure that the business logic works

The projects are created in a subfolder `RazorLight.Jdv` in order for the code to be separated from the main source.

## Run all tests
Ensure that all code changes compile and run all unit tests to make sure the code works as expected.

- ReSharper
![Dotnet5 ReSharper Tests](.%2FDotnet5%20-%20ReSharper%20-%20All%20Tests%20Pass.png)

- ReSharper
![Dotnet5 VS Tests](.%2FDotnet5%20-%20VSTests%20-%20All%20Tests%20Pass%20-%20Except%202.0.png)

- ReSharper
![Dotnet5 NCrunch Tests](.%2FDotnet5%20-%20NCrunch%20-%20No%20Tests%20Pass.png)

# Start with .Net 6 upgrade

[Code Branch](https://github.com/jacodv/RazorLightDotNet6/tree/branch_jdevil-Dotnet6-Documententing)

First steps is to change the `Jdv.Razor` projects to `Dotnet 6`.  This is what we are doing in our solution.

## Issues
Forced to downgrade the language version in `Jdv.Razor.Tests.csproj`.
- `<LangVersion>9</LangVersion>`

## All tests passed
Excluding `NCrunch`.  The rest passes as before.

# Add .Net6 to RazorLight

[Code Branch](https://github.com/jacodv/RazorLightDotNet6/tree/branch_jdevil-Dotnet6-Upgrade-RazorLight)

## Changes
The following changes was made to the `RazorLight.csproj`

- `<TargetFrameworks>netstandard2.0;netcoreapp3.1;net5.0;net6.0</TargetFrameworks>`
- `<ItemGroup Condition="'$(TargetFramework)' == 'net6.0'">`
```
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
```