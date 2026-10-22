**Languages:** [English](Readme.md) · [Español](README.es.md)

# creditcompass

uInvest/CreditCompass web application prototype with an administration dashboard, company management, and user accounts.

Documentation based on local files reviewed on 21 October 2026.

<!-- BEGIN project-context -->

## Historical dates and evidence

**Reference year for this version: 2014.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2014-10-05**, [`creditcompass/src/uInvest/uInvest.csproj`](src/uInvest/uInvest.csproj); date of the commit modifying the file, recovered from local Git history.
- First record in the original Git repository containing this code: **2014-10-05**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [Backbone.Marionette 1.1.0](https://www.nuget.org/packages/Backbone.Marionette/1.1.0), published on **2013-08-19** (declared version), in [`creditcompass/src/uInvest/packages.config`](src/uInvest/packages.config).
- Additional reference: target `v4.5` in [`creditcompass/src/uInvest/uInvest.csproj`](src/uInvest/uInvest.csproj); its [stable release was published on 2012-08-15](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

October 2026 copy timestamps and documents generated during this review were excluded. Recoverable dates do not guarantee that there are no later, undated changes.

## Why this is worth exploring

The CompanyController → CompanyContext → views flow provides a concrete example of CRUD with ASP.NET MVC and Entity Framework in a financial dashboard. Its value is the prototype's structure and screens; this copy does not demonstrate a proprietary financial analysis engine.

Code entry points:

- [`src/uInvest/Controllers/CompanyController.cs`](src/uInvest/Controllers/CompanyController.cs)
- [`src/uInvest/Models/CompanyModels.cs`](src/uInvest/Models/CompanyModels.cs)
- [`src/uInvest/Controllers/HomeController.cs`](src/uInvest/Controllers/HomeController.cs)

<!-- END project-context -->

## Structure and responsibilities

| Path | Responsibility |
| --- | --- |
| `src/uInvest.sln` | Visual Studio solution. |
| `src/uInvest/Controllers/CompanyController.cs` | Company creation, editing, retrieval, and deletion. |
| `src/uInvest/Controllers/HomeController.cs` | Home, Dashboard, and Prototype views. |
| `src/uInvest/Models/CompanyModels.cs` | CompanyContext and CompanyDto with name, publication, path, and version. |
| `src/uInvest/App_Data/` | Local SQL Server database files. |

## Technologies and requirements

Windows, Visual Studio/MSBuild with .NET Framework 4.5, ASP.NET MVC 4, Entity Framework 5, and SQL Server/LocalDB.

Targets read from project files: `v4.5`.

## Setup and startup

Open src/uInvest.sln, restore NuGet packages, and select uInvest in IIS Express. Create a test database and adjust DefaultConnection before using company or account operations.

Solutions present: `src/uInvest.sln`.

## Configuration and integrations

Review Web.config and its publish transformations. Existing .mdf and .ldf files may contain users or other private data and are excluded.

## Status of this copy

The visible code implements a management prototype; it does not establish the existence of an operational credit assessment engine.

The review was static: dependencies were not restored, and applications and tests were neither built nor run. The commands above are setup instructions, not validation results. Listed versions describe the preserved code.


## Public copy

Original credentials have been removed or replaced with `REPLACE_WITH_YOUR_VALUE`. Local data, sessions, private certificates, and deployment profiles are omitted. Configure your own services and credentials before running. Building and operation with external services have not been validated.
