# Descripción
La siguiente plantilla es una primera versión de cómo estructurar un proyecto de software bajo una
arquitectura limpia compuesta por su capa de Dominio, Aplicación, Infraestrcutura y Presentación.

# Herramientas y Tecnologías Utilizadas
- ASP.NET Core 8: Utilizado para construir la API web.
- Entity Framework Core: Utilizado para el acceso a datos y mapeo objeto-relacional (ORM).
- AutoMapper: Utilizado para mapear objetos de dominio a DTOs (Data Transfer Objects).
- MediatR: Implementa el patrón Mediator para manejar comandos y consultas.
- Microsoft SQL Server: Base de datos utilizada para almacenar la información de las entidades.

# Configuración del Proyecto
Para configurar y ejecutar el proyecto, sigue los pasos a continuación:

- Clona el repositorio a tu máquina local.
- Asegúrate de tener instalado .NET 6.0 o superior.
- Configura la cadena de conexión a la base de datos en el archivo appsettings.json.
- Ejecuta las migraciones de Entity Framework para crear la base de datos: dotnet ef database update.
- Inicia la aplicación: dotnet run.
