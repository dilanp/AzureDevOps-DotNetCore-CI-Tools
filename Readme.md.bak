# ASP.NET Core Code Quality in Azure DevOps Pipelines

## Static Code Analysis
- Create a new ASP.NET Core 6 Web Application.
- Add new code into a GitHub repository.
- To run code analysis in VisualStudio 2022. 
  - Analyze > RunCode Analysis > On Solution
  - Check the "Error List" window for errors, warnings and messages.
- FxCop Nuget packages could be used to get better code analysis results.
  - Add Microsoft.CodeAnalysis.FxCopAnalyzers (v3.3.2) Nuget Package.
  - Add Microsoft.CodeAnalysis.NetAnalyzers (7.0.0-preview1.22310.1) Nuget package if the above is depricated.
  - In Solution Explorer, expand Dependencies > Analyzers > ... to see all rules that has been added.
  - Now when you build the solution, the "Output" window should give all the code analysis results.
- Setup Azure DevOps for CI.
  - Create a new project called "CodeQuality-DotNetCore".
  - Add a new Azure DevOps pipeline based on the above code in the GitHub repository.
  - Make sure to remove the unit test task in the pipeline definition yaml.
  - Save and run the pipeline.
  - Once the build job has been successfully completed, code analysis results should be available under "Summary" area.
  
## Detect & fix open source package vulnerabilities
- There are tools available on VisualStudio marketplace for this purpose such as, Mend Bolt (formerly, WhiteSource Bolt).
- First, visit Organization Settings > Extensions > Browse Marketplace.
- Search and find the tool. Then, install it for the organization.
- Activate the plugin by visiting Settings > Mend.
- Now, select a particular pipeline run and notice the "Mend Bolt" tab placed next to the "Summary" tab.
- In some plugins we'll have to go and add a task to the pipeline yaml file to get it enabled.

## Unit tests
- Add a new C# XUnit project to the solution.
- Add XUnit (v2.4.2) Nuget package for the test project.
- Add a reference to the CodeQuality project.
- Add a test classes and add test methods as required.
- Update the pipeline yaml file and add a new step to run unit tests and save it.
- Push the newly added unit test changes to GitHub and monitor pipeline job to see how unit tests are run.
- Also, notice the "Test" tab placed next to the "Summary" tab. This should give unit test run results.
