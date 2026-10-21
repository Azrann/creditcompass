# creditcompass

Aplicación histórica CreditCompass/uInvest.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2014.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2014-10-05**, [`creditcompass/src/uInvest/uInvest.csproj`](creditcompass/src/uInvest/uInvest.csproj); fecha del commit que modificó el archivo, recuperada del Git local.
- Primer registro del repositorio Git original que contiene este código: **2014-10-05**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [Backbone.Marionette 1.1.0](https://www.nuget.org/packages/Backbone.Marionette/1.1.0), publicada el **2013-08-19** (versión declarada), en [`creditcompass/src/uInvest/packages.config`](creditcompass/src/uInvest/packages.config).
- Referencia adicional: destino `v4.5` en [`creditcompass/src/uInvest/uInvest.csproj`](creditcompass/src/uInvest/uInvest.csproj); su [versión estable se publicó el 2012-08-15](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-framework). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

Se descartaron las marcas de tiempo de la copia de octubre de 2026 y los documentos generados durante esta revisión. Las fechas recuperables no garantizan que no existan cambios posteriores sin datar.

## Por qué merece la pena mirarlo

El recorrido CompanyController → CompanyContext → vistas ofrece un ejemplo concreto de CRUD con ASP.NET MVC y Entity Framework dentro de un panel financiero. El valor está en la estructura del prototipo y sus pantallas; la copia no demuestra un motor propio de análisis financiero.

Puntos de entrada al código:

- [`src/uInvest/Controllers/CompanyController.cs`](creditcompass/src/uInvest/Controllers/CompanyController.cs)
- [`src/uInvest/Models/CompanyModels.cs`](creditcompass/src/uInvest/Models/CompanyModels.cs)
- [`src/uInvest/Controllers/HomeController.cs`](creditcompass/src/uInvest/Controllers/HomeController.cs)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`creditcompass/`](creditcompass/) | Prototipo de aplicación web uInvest/CreditCompass con panel administrativo, gestión de empresas y cuentas de usuario. |



## Requisitos y preparación

.NET Framework, ASP.NET MVC, SQL Server y NuGet.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `creditcompass/src/uInvest.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.
