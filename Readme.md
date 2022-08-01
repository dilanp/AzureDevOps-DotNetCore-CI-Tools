#ASP.NET Core Code Quality in Azure DevOps Pipelines

##Static Code Analysis
- Create a new ASP.NET Core 6 Web Application.
- To run code analysis in VisualStudio 2022. 
  - Analyze > RunCode Analysis > On Solution
  - Check the "Error List" window for errors, warnings and messages.
- FxCop Nuget packages could be used to get better code analysis results.
  - Add Microsoft.CodeAnalysis.FxCopAnalyzers (v3.3.2) Nuget Package.
  - Add Microsoft.CodeAnalysis.NetAnalyzers (7.0.0-preview1.22310.1) Nuget package if the above is depricated.