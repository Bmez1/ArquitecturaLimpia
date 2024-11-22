# Descripci�n
La siguiente plantilla es una primera versi�n de c�mo estructurar un proyecto de software bajo una
arquitectura limpia compuesta por su capa de Dominio, Aplicaci�n, Infraestrcutura y Presentaci�n.

# Herramientas y Tecnolog�as Utilizadas
- ASP.NET Core 8: Utilizado para construir la API web.
- Entity Framework Core: Utilizado para el acceso a datos y mapeo objeto-relacional (ORM).
- AutoMapper: Utilizado para mapear objetos de dominio a DTOs (Data Transfer Objects).
- MediatR: Implementa el patr�n Mediator para manejar comandos y consultas.
- Microsoft SQL Server: Base de datos utilizada para almacenar la informaci�n de las entidades.

# Configuraci�n del Proyecto
Para configurar y ejecutar el proyecto, sigue los pasos a continuaci�n:

- Clona el repositorio a tu m�quina local.
- Aseg�rate de tener instalado .NET 6.0 o superior.
- Configura la cadena de conexi�n a la base de datos en el archivo appsettings.json.
- Ejecuta las migraciones de Entity Framework para crear la base de datos: dotnet ef database update.
- Inicia la aplicaci�n: dotnet run.
