# Libreria Online 
# BookEnd

**Integrantes del Grupo.**

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> develop
  - Juan García Martínez (coordinador) 
  - Alfonso Izura Concellón
  - Emilio Prieto Uclés
  - Pablo Navarro Ortiz
  - Carlos Daniel Ojeda Giménez
  - Benjamín Cornelio Sorto

Turno de Prácticas.
  Lunes 17:00-19:00


**Descripción.**

  Nuestro grupo a decidido crear una web orientada a la compra/venta física o digital de libros online. Los usuarios de esta podrán realizar las funciones de: alquilar, intercambiar, publicar comentarios, hacer criticas, valorar...   libros pero únicamente de su versión online, con una interfaz intuitiva y funcional. Además, ante cualquier duda, la web dispondrá de Soporte de Atención al Cliente. También, de otra serie de funcionalidades para la comodidad de los usuarios.

  
<<<<<<< HEAD

**Parte Pública.**

Centrándonos ahora en la parte pública, visible o "interfaz" que tendrá nuestra web al acceder a ella, podemos destacar:
 - Vista principal (Home) donde se visualizaran libros disponibles
 - Se podrá hacer uso de los libros que sean gratuitos y ver sus respectivas criticas
 - Vista al Inicio de Sesión
 - Vista al Registro
 - Vista al panel de Atención al Cliente

Por dentro, el Listado de EN Públicas que hacen que la aplicación funcione correctamente es:
=======
=======
    Juan García Martínez (coordinador)
    Alfonso Izura Concellón
    Emilio Prieto Uclés
    Pablo Navarro Ortiz
    Carlos Daniel Ojeda Giménez
    Benjamín Cornelio Sorto

Turno de Prácticas. Lunes 17:00-19:00

Descripción. Web orientada a la compra/venta fisica o digital de libros online. Como usuarios dispondrá de opciones de alquilar, intercambiar, pubicar comentarios, hacer criticas, valorar... libros pero únicamente de su versión online. Ante cualquier duda, la web dispondra de Soporte de Atención al Cliente.

>>>>>>> 04640593K
Parte Pública.

    Vista principal (Home) donde se visualizaran libros disponibles
    Se podrá hacer uso de los libros que sean gratuitos y ver sus respectivas criticas
    Vista al Inicio de Sesión
    Vista al Registro
    Vista al panel de Atención al Cliente

Listado EN Pública.
<<<<<<< HEAD
>>>>>>> develop
 - ENSoporte: Preguntas y respuestas de Ayuda.
 - ENRegistro: Creacion de Usuario
 - ENLibros: Almacenamos datos de los libros gratuitos
 - ENSugerencia: Almacenar sugerencias
 - ENColeccion: Almacenar datos de una coleccion de libros
<<<<<<< HEAD
 
=======
>>>>>>> develop
 
**Parte privada.**

Por otro lado. centrandonos ahora en la parte privada, un usuario registrado puede acceder a:
   - Ver su listado de sus libros comprados/alquilados
   - Realizar criticas, comentarios, valoraciones
   - Ver un listado con los libros que ha alquilado
   - Publicar sus propios relatos
 
En este caso, el Listado de EN Privadas que hacen que la aplicación funcione correctamente es:
  Separamos las caracteristicas de los libros digitales y fisicos en distintas clases (ENProveedores y ENLicencias)
  - ENUsuario: Almacenamiento de Usuarios
  - ENProveedores: Almacenamiento de libros (fisicos/online)
  - ENCriticas: Realizar comentarios/criticas de los libros
<<<<<<< HEAD
  - ENRelato: Almacenar datos de los relatos
=======
  - ENRelatos: Almacenar datos de los relatos
>>>>>>> develop
  - ENRecomendaciones: Se recomendaran libros con las mejores puntuaciones
  - ENListaUsuario: Almacenar los libros que se ha leido el usuario con su puntuacion. 
  - ENListaDeseo: Almacenar los libros que el usuario desea comprar/alquilar
  
<<<<<<< HEAD
  
**Posibles mejoras.**

Como posibles mejoras que nuestra página web podría llegar a tener, podemos destacar:
  - Sistema de puntos con recompensas para los ususarios
  - Registro mediante correo electronico o similares
 
 
**Problemas y forma de funcionar**
Por suerte en nuestro grupo no nos hemos topado con ningún problema grave con nadie del mismo.
=======
Posibles mejoras.
  - Sistema de puntos con recompensas para los ususarios
=======

    ENSoporte: Preguntas y respuestas de Ayuda.
    ENRegistro: Creacion de Usuario
    ENLibros: Almacenamos datos de los libros gratuitos
    ENSugerencia: Almacenar sugerencias
    ENColeccion: Almacenar datos de una coleccion de libros

Parte privada. Un usuario puede:

    ver su listado de sus libros comprados/alquilados
    realizar criticas, comentarios, valoraciones
    ver un listado con los libros que ha alquilado
    publicar sus propios relatos

Listado EN Privada. Separamos las caracteristicas de los libros digitales y fisicos en distintas clases (ENProveedores y ENLicencias)

    ENUsuario: Almacenamiento de Usuarios
    ENProveedores: Almacenamiento de libros (fisicos/online)
    ENCriticas: Realizar comentarios/criticas de los libros
    ENRelatos: Almacenar datos de los relatos
    ENRecomendaciones: Se recomendaran libros con las mejores puntuaciones
    ENListaUsuario: Almacenar los libros que se ha leido el usuario con su puntuacion.
    ENListaDeseo: Almacenar los libros que el usuario desea comprar/alquilar

Posibles mejoras.

    Sistema de puntos con recompensas para los ususarios

>>>>>>> develop

Al principio repartimos el trabajo de forma aleatoria entre todos, cada uno se encargaría principalmente de 2 EN y 2 CAD. Pero hemos estado utilizando herramientas como whatsapp, discord o la funcionalidad "Live Share" del propio Visual Studio para programar juntos (incluso todos los integrantes a la vez, como fue el caso para la entrega de la interfaz), comentandonos dudas, pasando ejemplos, buscando como solucionar errores, estando en contacto siempre, etc. Así que aunque cada uno se ha centrado principalmente en sus dos clases todos hemos tocado un poco de todo.

Una vez dicho esto, las tareas principales hechas por cada uno del grupo son:

 - Alfonso: Soporte, Registro
 - Carlos: Libros, Provedores
 - Emilio: ListaDeseos, Recomendaciones
 - Benjamin: Coleccion,  ListaUsus
 - Pablo: Sugerencia, Usuario
 - Juan: Critica, Relatos
 
*Cada uno realizo los respectivos EN y CAD de cada clase

<<<<<<< HEAD
En cuanto a la planificación, el único problema con el que nos hemos topado fue al hacer merge con la rama develop. Pensabamos que iba a ser tarea fácil, pero estubimos peleandonos con GIT durante horas para solucionar los multiples errores que a cada uno nos daba al hacer el "git merge", por lo demás todo ha ido bien y cada integrante ha cumplido con los plazos de entrega estipulados.
=======
>>>>>>> 04640593K
>>>>>>> develop
