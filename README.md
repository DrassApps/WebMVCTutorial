# WebMVCTutorial

Este repositiorio es un startproject para un panel de administración web, siguiendo el patrón de diseño MVC.
- Está desarrollado con la herramienta Visual Studio.
- Desarrollado en el lenguaje C#
- Uso de Azure Cloud para albergar la BD y el hosting.
- Integrado con la API de google, para el login de los usuarios.

A destacar:

Añadir filtros en la configuración, nos permite gestionar los controladores de una forma más fácil. En otras palabras, simplemente añadiendo el TAG _[AuthorizeAttribute]_ en el controller deseado, esté quedará restringido solo para usuarios autorizados.
```c#
filters.Add(new AuthorizeAttribute());
```

En el archivo Startup.Auth.cs editar el método GoogleCredentials con las claves del proyecto.
```c#
 app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            {
                ClientId = "xxx",
                ClientSecret = "xxx"
            });
```

Puedes ver el resultado en el siguiente enlace: [Proyecto](https://mvctutorialandresm.azurewebsites.net/).
