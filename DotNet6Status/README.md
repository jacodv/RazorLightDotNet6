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
