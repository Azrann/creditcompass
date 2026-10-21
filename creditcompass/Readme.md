# creditcompass

Prototipo de aplicación web uInvest/CreditCompass con panel administrativo, gestión de empresas y cuentas de usuario.

Documentación basada en los archivos locales revisados el 21 de octubre de 2026.

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
