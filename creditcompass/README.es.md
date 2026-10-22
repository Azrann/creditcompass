**Languages:** [English](Readme.md) · [Español](README.es.md)

# creditcompass

Prototipo de aplicación web uInvest/CreditCompass con panel administrativo, gestión de empresas y cuentas de usuario.

Documentación basada en los archivos locales revisados el 21 de octubre de 2026.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2014.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2014-10-05**, [`creditcompass/src/uInvest/uInvest.csproj`](src/uInvest/uInvest.csproj); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro del repositorio Git original que contiene este código: **2014-10-05**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Backbone.Marionette 1.1.0](https://www.nuget.org/packages/Backbone.Marionette/1.1.0), publicada el **2013-08-19** (versión declarada), en [`creditcompass/src/uInvest/packages.config`](src/uInvest/packages.config).
- Referencia adicional: destino `v4.5` en [`creditcompass/src/uInvest/uInvest.csproj`](src/uInvest/uInvest.csproj); su [versión estable se publicó el 2012-08-15](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

## Por qué merece la pena mirarlo

El recorrido CompanyController → CompanyContext → vistas ofrece un ejemplo concreto de CRUD con ASP.NET MVC y Entity Framework dentro de un panel financiero. El valor está en la estructura del prototipo y sus pantallas; la copia no demuestra un motor propio de análisis financiero.

Puntos de entrada al código:

- [`src/uInvest/Controllers/CompanyController.cs`](src/uInvest/Controllers/CompanyController.cs)
- [`src/uInvest/Models/CompanyModels.cs`](src/uInvest/Models/CompanyModels.cs)
- [`src/uInvest/Controllers/HomeController.cs`](src/uInvest/Controllers/HomeController.cs)

<!-- END project-context -->

## Estructura y responsabilidades

| Ruta | Responsabilidad |
| --- | --- |
| `src/uInvest.sln` | Solución de Visual Studio. |
| `src/uInvest/Controllers/CompanyController.cs` | Operaciones de alta, edición, consulta y eliminación de empresas. |
| `src/uInvest/Controllers/HomeController.cs` | Vistas de inicio, Dashboard y Prototype. |
| `src/uInvest/Models/CompanyModels.cs` | CompanyContext y CompanyDto con nombre, publicación, ruta y versión. |
| `src/uInvest/App_Data/` | Archivos locales de base de datos SQL Server. |

## Tecnologías y requisitos

Windows, Visual Studio/MSBuild con .NET Framework 4.5, ASP.NET MVC 4, Entity Framework 5 y SQL Server/LocalDB.

Destinos leídos de los proyectos: `v4.5`.

## Preparación y arranque

Abrir src/uInvest.sln, restaurar paquetes NuGet y seleccionar uInvest en IIS Express. Crear una base de pruebas y ajustar DefaultConnection antes de usar operaciones de empresas o cuentas.

Soluciones presentes: `src/uInvest.sln`.

## Configuración e integraciones

Revisar Web.config y sus transformaciones de publicación. Los .mdf y .ldf existentes pueden incluir usuarios u otros datos privados y quedan excluidos.

## Estado de esta copia

El código visible implementa un prototipo de gestión; no acredita un motor de evaluación crediticia operativo.

La revisión fue estática: no se restauraron dependencias, no se compiló ni se ejecutaron aplicaciones o pruebas. Los comandos anteriores son instrucciones de preparación, no resultados de validación. Las versiones indicadas son las del código conservado.


## Copia pública

Las credenciales originales se han retirado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Los datos locales, sesiones, certificados privados y perfiles de despliegue se omiten. Configurar servicios y credenciales propios antes de ejecutar. La compilación y el funcionamiento con servicios externos no se han validado.
