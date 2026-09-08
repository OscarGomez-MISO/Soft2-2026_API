# Soft2-2026_API

Proyecto backend de ejemplo para la asignatura Soft2 (2026). Aplicación Web API mínima construida con ASP.NET Core y .NET 9.

Características principales
- API REST básica con controladores de ejemplo (WeatherForecast y User).
- Estructura simple con carpetas: Controllers, Dtos, Services, Repositories.
- Soporte OpenAPI (documentación Swagger) en entorno de desarrollo.

Requisitos
- .NET 9 SDK (https://dotnet.microsoft.com/)
- Visual Studio 2022/2026, Visual Studio Code u otra IDE compatible

Cómo ejecutar
1. Abrir una terminal en la carpeta del proyecto (contiene WebApplication1.csproj).
2. Restaurar dependencias y compilar:
   dotnet restore
   dotnet build
3. Ejecutar la aplicación:
   dotnet run
4. En entorno de desarrollo, la documentación OpenAPI/Swagger estará disponible normalmente en https://localhost:{port}/swagger o la ruta mostrada en la consola.

Estructura del proyecto
- Controllers/: controladores Web API (WeatherForecastController.cs, UserController.cs)
- Dtos/: objetos de transferencia de datos (WeatherForecastDto, UserDto)
- Services/: servicios de negocio (esqueleto UserService)
- Repositories/: acceso a datos (esqueleto UserRepository)
- Program.cs: configuración y arranque de la aplicación

Endpoints principales (ejemplos)
- GET /WeatherForecast — Devuelve una lista de WeatherForecastDto de ejemplo.
- POST /WeatherForecast — Devuelve una lista corta con responseCode y MessageResponse rellenados.
- GET /api/User — Ejemplo que devuelve un arreglo de strings (placeholder).

Notas para contribuir
- Este repositorio contiene código de inicio y controladores/esqueletos vacíos. Antes de añadir lógica de negocio o acceso a datos, crear y documentar los contratos DTO y agregar pruebas.

Publicación
- Para publicar la API como paquete o contenedor, usar los comandos dotnet publish o Docker según la estrategia elegida.

Contacto
- Repo: https://github.com/OscarGomez-MISO/Soft2-2026_API

Licencia
- Añadir fichero LICENSE si desea especificar una licencia para este proyecto.

