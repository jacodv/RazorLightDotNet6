**ERROR**
```
  RazorTemplateEngineTests (2 tests) Aborted: Exit code is -2146232797 (Process terminated. Assertion failed.
LanguageVersion 10.0 specified in the deps file could not be parsed.
   at RazorLight.Compilation.RoslynCompilationService.GetParseOptions(CompilationOptions dependencyContextOptions) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 247
   at RazorLight.Compilation.RoslynCompilationService.EnsureOptions() in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 81
   at RazorLight.Compilation.RoslynCompilationService.get_ParseOptions() in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 61
   at RazorLight.Compilation.RoslynCompilationService.CreateSyntaxTree(SourceText sourceText) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 184
   at RazorLight.Compilation.RoslynCompilationService.CreateCompilation(String compilationContent, String assemblyName) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 162
   at RazorLight.Compilation.RoslynCompilationService.CompileAndEmit(IGeneratedRazorTemplate razorTemplate) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RoslynCompilationService.cs:line 100
   at RazorLight.Compilation.RazorTemplateCompiler.CompileAndEmitAsync(RazorLightProjectItem projectItem) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RazorTemplateCompiler.cs:line 223
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at RazorLight.Compilation.RazorTemplateCompiler.CompileAndEmitAsync(RazorLightProjectItem projectItem)
   at RazorLight.Compilation.RazorTemplateCompiler.OnCacheMissAsync(String templateKey) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RazorTemplateCompiler.cs:line 177
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at RazorLight.Compilation.RazorTemplateCompiler.OnCacheMissAsync(String templateKey)
   at RazorLight.Compilation.RazorTemplateCompiler.CompileAsync(String templateKey) in C:\Git\github\RazorLight\src\RazorLight\Compilation\RazorTemplateCompiler.cs:line 93
   at RazorLight.EngineHandler.CompileTemplateAsync(String key) in C:\Git\github\RazorLight\src\RazorLight\EngineHandler.cs:line 64
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at RazorLight.EngineHandler.CompileTemplateAsync(String key)
   at RazorLight.EngineHandler.CompileRenderAsync[T](String key, T model, ExpandoObject viewBag) in C:\Git\github\RazorLight\src\RazorLight\EngineHandler.cs:line 140
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at RazorLight.EngineHandler.CompileRenderAsync[T](String key, T model, ExpandoObject viewBag)
   at RazorLight.EngineHandler.CompileRenderStringAsync[T](String key, String content, T model, ExpandoObject viewBag) in C:\Git\github\RazorLight\src\RazorLight\EngineHandler.cs:line 169
   at RazorLight.RazorLightEngine.CompileRenderStringAsync[T](String key, String content, T model, ExpandoObject viewBag) in C:\Git\github\RazorLight\src\RazorLight\RazorLightEngine.cs:line 63
   at System.Dynamic.UpdateDelegates.UpdateAndExecute5[T0,T1,T2,T3,T4,TRet](CallSite site, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
   at Jdv.Razor.RazorTemplateEngine.Convert(Object data, String templateData, Boolean ifErrorTrySerializeAndDeserialize) in C:\Git\github\RazorLight\RazorLight.Jdv\Jdv.Razor\RazorTemplateEngine.cs:line 59
   at Jdv.Razor.Tests.RazorTemplateEngineTests.Convert_GivenValidInput_ShouldConvert() in C:\Git\github\RazorLight\RazorLight.Jdv\Jdv.Razor.Tests\RazorTemplateEngineTests.cs:line 32
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Span`1& arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.MethodBase.Invoke(Object obj, Object[] parameters)
   at NUnit.Framework.Internal.Reflect.InvokeMethod(MethodInfo method, Object fixture, Object[] args)
   at NUnit.Framework.Internal.MethodWrapper.Invoke(Object fixture, Object[] args)
   at NUnit.Framework.Internal.Commands.TestMethodCommand.InvokeTestMethod(TestExecutionContext context)
   at NUnit.Framework.Internal.Commands.TestMethodCommand.RunTestMethod(TestExecutionContext context)
   at NUnit.Framework.Internal.Commands.TestMethodCommand.Execute(TestExecutionContext context)
   at NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand.<>c__DisplayClass1_0.<Execute>b__0()
   at NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand.RunTestMethodInThreadAbortSafeZone(TestExecutionContext context, Action action)
   at NUnit.Framework.Internal.Commands.BeforeAndAfterTestCommand.Execute(TestExecutionContext context)
   at NUnit.Framework.Internal.Execution.SimpleWorkItem.<>c__DisplayClass4_0.<PerformWork>b__0()
   at NUnit.Framework.Internal.ContextUtils.<>c__DisplayClass1_0`1.<DoIsolated>b__0(Object _)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at NUnit.Framework.Internal.ContextUtils.DoIsolated(ContextCallback callback, Object state)
   at NUnit.Framework.Internal.ContextUtils.DoIsolated[T](Func`1 func)
   at NUnit.Framework.Internal.Execution.SimpleWorkItem.PerformWork()
   at NUnit.Framework.Internal.Execution.WorkItem.RunOnCurrentThread()
   at NUnit.Framework.Internal.Execution.WorkItem.Execute()
   at NUnit.Framework.Internal.Execution.ParallelWorkItemDispatcher.Dispatch(WorkItem work, ParallelExecutionStrategy strategy)
   at NUnit.Framework.Internal.Execution.ParallelWorkItemDispatcher.Dispatch(WorkItem work)
   at NUnit.Framework.Internal.Execution.CompositeWorkItem.RunChildren()
   at NUnit.Framework.Internal.Execution.CompositeWorkItem.PerformWork()
   at NUnit.Framework.Internal.Execution.WorkItem.RunOnCurrentThread()
   at NUnit.Framework.Internal.Execution.WorkItem.Execute()
   at NUnit.Framework.Internal.Execution.TestWorker.TestWorkerThreadProc()
   at System.Threading.Thread.StartCallback())
```
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <IsPackable>false</IsPackable>
    <PreserveCompilationContext>true</PreserveCompilationContext>
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
