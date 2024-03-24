
# API Personas y Domicilios

## Descripción:
Esta API permite gestionar personas y sus domicilios en una base de datos SQL Server. 

## Ofrece funcionalidades para: 
> - Obtener un listado de personas.
> - Crear, editar y eliminar personas.
> - Obtener un listado de domicilios.
> - Crear, editar y eliminar domicilios.

## Tecnologías utilizadas:
> - .NET 7 (última versión)
> - ASP.NET Core
> - Entity Framework Core
> - Automapper
> - Swagger

## Pruebas:

Puedes probar la API utilizando Swagger, que se incluye por defecto en el proyecto.

## Estructura del proyecto:

> - El proyecto se divide en tres partes:
>
>    - Api: Contiene los controladores de la API.
>   - Core: Contiene las entidades y los servicios.
>   - Infrastructure: Contiene los repositorios para la comunicación con la base de datos.  

## Ejemplo de uso:

Para obtener un listado de personas, puedes realizar una petición GET a la siguiente ruta:

> /api/personas  

Respuesta:
```json
[
  {
    "nombre": "Pedro",
    "apellido": "string",
    "telefono": "2604059207",
    "email": "user@example.com",
    "domicilio": {
      "calle": "Las Loicas",
      "altura": 1282,
      "localidad": "Malargue",
      "personaId": 3,
      "persona": null,
      "id": 1
    },
    "id": 3
  },
  {
    "nombre": "Jose",
    "apellido": "Gonzalez",
    "telefono": "5492604059207",
    "email": "user@example.com",
    "domicilio": {
      "calle": "Los Goicos",
      "altura": 456,
      "localidad": "Malargue",
      "personaId": 4,
      "persona": null,
      "id": 4
    },
    "id": 4
  }
]
```

### Endpoints disponibles
- PERSONA:
    - GET: /api/personas
    - POST: /api/personas
    - POST: /api/personaDomicilio
    - GET: /api/persona/{personaId}
    - PUT: /api/persona/{personaId}
    - DELETE: /api/persona/{personaId}
- DOMICILIOS:
    - POST: /api/domicilio
    - PUT: /api/domicilio/{domicilioId}
    - DELETE: /api/domicilio/{domicilioId}
