# Evaluacion Delosi

## Backend (evaluacion-delosi-api)

En este caso la aplicación está desarrollada con .NET 8, cuentas con las siguientes tecnologías integradas.

- Arquitectura de N capas con inyeccion de dependencias para su posterior escalabilidad.
- Se le agregó el ORM Entity Framework para poder trabajar con la base de datos que se necesite.
- Se realizó configuración JSON para solicitudes y respuestas.
- Se implemento un middleware para el manejo de errores.
- Se configuró la dockerización del proyecto.

### Prerequisitos

Antes de ejecutar la API asegurese de contar con lo siguiente:

- Visual Studio
- Docker Desktop

#### Ejecutar proyecto

Al ejecutar el proyecto seguir los siguientes pasos:

1. Abrir el proyecto `evaluacion-delosi-api` en Visual Studio 2022.
2. El proyecto creará una imagen en Docker Desktop.
3. Iniciar el proyecto API. La API ahora está ejecutándose y lista para aceptar solicitudes.

##### Pruebas Unitarias

Dentro de la coleccion delosi-api.postman_collection.json, encontrará el request que se puede ejecutar para validar la funcionalidad de la API.
