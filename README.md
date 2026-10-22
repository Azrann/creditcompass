**Languages:** [English](README.md) · [Español](README.es.md)

# creditcompass

Historical CreditCompass/uInvest application.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2014.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2014-10-05**, [`creditcompass/src/uInvest/uInvest.csproj`](creditcompass/src/uInvest/uInvest.csproj); date of the commit modifying the file, recovered from local Git history.
- First record in the original Git repository containing this code: **2014-10-05**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Backbone.Marionette 1.1.0](https://www.nuget.org/packages/Backbone.Marionette/1.1.0), published on **2013-08-19** (declared version), in [`creditcompass/src/uInvest/packages.config`](creditcompass/src/uInvest/packages.config).
- Additional reference: target `v4.5` in [`creditcompass/src/uInvest/uInvest.csproj`](creditcompass/src/uInvest/uInvest.csproj); its [stable release was published on 2012-08-15](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

## Why this is worth exploring

The CompanyController → CompanyContext → views flow provides a concrete example of CRUD with ASP.NET MVC and Entity Framework in a financial dashboard. Its value is the prototype's structure and screens; this copy does not demonstrate a proprietary financial analysis engine.

Code entry points:

- [`src/uInvest/Controllers/CompanyController.cs`](creditcompass/src/uInvest/Controllers/CompanyController.cs)
- [`src/uInvest/Models/CompanyModels.cs`](creditcompass/src/uInvest/Models/CompanyModels.cs)
- [`src/uInvest/Controllers/HomeController.cs`](creditcompass/src/uInvest/Controllers/HomeController.cs)

<!-- END project-context -->

## Contents

| Directory | Function |
| --- | --- |
| [`creditcompass/`](creditcompass/) | uInvest/CreditCompass web application prototype with an administration dashboard, company management, and user accounts. |



## Requirements and setup

.NET Framework, ASP.NET MVC, SQL Server, and NuGet.

This is a historical copy. Consult each component's project files and README for versions and dependencies. Restore NuGet/npm from the appropriate folder; internal libraries may need rebuilding. Prepare databases and external services using your own accounts.

Preserved solutions:

- `creditcompass/src/uInvest.sln`

## Configuration and security

Original secrets have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Search for this marker before running and provide values through local configuration or environment variables. Sessions, private keys, signing certificates, databases, logs, deployment profiles, and binary packages are not published. The `.gitignore` protects these local files.

A fresh history is published: old commits remain only in the original local copy. Example values cannot connect to the original services.

## Validation status

A static review and secret scan were performed before publication. Applications, trading operations, deployments, and tests contacting external services were not run. Building with current tools is not guaranteed. Some projects need historical dependencies and assets that are not included.

## Licenses and provenance

Third-party licenses and attributions present in the code are retained. No blanket license is added to components that lacked one. This import preserves local sources and does not claim to be a current version of the original project.
