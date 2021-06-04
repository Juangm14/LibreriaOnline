# LibreriaOnline

Integrantes del Grupo.

  - Juan García Martínez (coordinador) 
  - Alfonso Izura Concellón
  - Emilio Prieto Uclés
  - Pablo Navarro Ortiz
  - Carlos Daniel Ojeda Giménez
  - Benjamín Cornelio Sorto

Turno de Prácticas.
  Lunes 17:00-19:00

Descripción.
  Web orientada a la compra/venta fisica o digital de libros online. Como usuarios dispondrá de opciones de alquilar, intercambiar, pubicar comentarios, hacer criticas, valorar...   libros pero únicamente de su versión online. Ante cualquier duda, la web dispondra de Soporte de Atención al Cliente.
  
    Juan García Martínez (coordinador)
    Alfonso Izura Concellón
    Emilio Prieto Uclés
    Pablo Navarro Ortiz
    Carlos Daniel Ojeda Giménez
    Benjamín Cornelio Sorto

Turno de Prácticas. Lunes 17:00-19:00

Parte Pública.

    Vista principal (Home) donde se visualizaran libros disponibles
    Se podrá hacer uso de los libros que sean gratuitos y ver sus respectivas criticas
    Vista al Inicio de Sesión
    Vista al Registro
    Vista al panel de Atención al Cliente

Listado EN Pública.
 - ENSoporte: Preguntas y respuestas de Ayuda.
 - ENRegistro: Creacion de Usuario
 - ENLibros: Almacenamos datos de los libros gratuitos
 - ENSugerencia: Almacenar sugerencias
 - ENColeccion: Almacenar datos de una coleccion de libros

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
    ENListaLeidos: Almacenar los libros que se ha leido el usuario con su puntuacion.
    ENListaDeseo: Almacenar los libros que el usuario desea comprar/alquilar

Posibles mejoras.

    Sistema de puntos con recompensas para los ususarios
    
------------------ Ultima entrega ------------------
- Usuarios

      Usuario1: johnsmithgacacoc24@gmail.com 
      Contraseña: 123
      Usuario2: admin@admin.com
      Contraseña: admin
      (No puede hacer nada especial, es un usuario como otro cualquiera)

- Proveedores

      Proveedor1: carlos@carlos.com
      Contraseña: 123
      Proveedor2: juan@juan.com
      Contraseña: 123
    
---------- Explicacion de las tareas realizadas ----------

Alfonso Izura Concellón 73439051M:

    CADRegistro.cs y ENRegistro.cs: Clases orientadas para el registro e inicio de sesion de usuarios.

    Registro.aspx: Pagina donde el usuario se registra. Necesitara introducir obligatoriamente un nick, un email y contraseña. Los demas campos no son obligatorios. Una vez el usuario se registre correctamente, sera redireccionado a la pagina principal con la sesion ya iniciada. Se mostrara en el menu esta opcion si el usuario no tiene la sesion iniciada. 

    Registro.aspx.cs: Code-behind de Registro.aspx.

    SignIn.aspx: Pagina donde el usuario puede iniciar sesión. El usuario puede iniciar sesion introduciendo tanto su nick como su email (y contraseña). Una vez validados los datos introducidos se redirigira a la pagina principal. Se mostrara en el menu esta opcion si el usuario no tiene la sesion iniciada. 

    SignIn.aspx.cs: Code-behind de SignIn.aspx.

    CADSoporte.cs y ENSoporte.cs: Clases orientadas a la creacion de preguntas por usuarios.

    Soporte.aspx: Pagina donde un usuario, independientemente de que haya iniciado sesion o no, puede enviar sus preguntas a los administradores de la pagina, introduciendo el asunto y la pregunta.

    Soporte.aspx.cs: Code-behind de Soporte.aspx.

    FAQs.aspx: Pagina donde se mostraran las preguntas enviadas desde soporte y que hayan sido respondidas por los administradores. Todo el mundo puede acceder a esta caracteristica en cualquier momento.

    FAQs.aspx.cs: Code-behind de FAQs.aspx.

    CADVentaUsu.cs y ENVentaUsu.cs (En colaboracion con Emilio): Clases orientadas a la compraventa de libros de segunda mano entre usuarios. Representan ofertas creadas por usuarios.

    VentaEntreUsuarios.aspx: En esta pagina un usuario con sesion iniciada podra crear ofertas de libros de segunda mano de libros en la pagina web, asi como borrar ofertas que el mismo ha creado o añadirlas al carrito para su posterior compra. La pagina tendra un grid donde se muestran las ofertas, y el usuario tendra que escribir la ID de la oferta en la que esta interesado.

    VentaEntreUsuarios.aspx.cs: Code-behind de VentaEntreUsuarios.aspx.

    CrearOfertaUsu.aspx: Pagina a la que se le redirige el usuario si en VentaEntreUsuarios.aspx el usuario ha pulsado el boton de crear una nueva oferta. Aqui se pedira al usuario que introduzca el isbn del libro que se quiere vender y el precio al que quiere venderlo. El usuario tiene que haber iniciado sesión.

    CrearOfertaUsu.aspx.cs: Code-behind de CrearOfertaUsu.aspx.

    Site1.Master: La pagina maestra de nuestor proyecto web. Tiene un menu con las caracteristicas que ofrece nuestra web, e ira borrando o añadiendo items dependiendo de si el usuario ha iniciado sesion o no. Si has iniciado sesion en la pagina, tienes la opcion de desiniciar sesión y volver a la interfaz publica de la web, en la que podrias iniciar sesion con otra cuenta si asi se desea.

    Site1.Master.cs: Code-behind de Site1.Master.

Emilio: 

    ENListaDeseos, ENRecomendaciones, CADListaDeseos, CADRecomendaciones
    Ambas clases son accesibles desde el menú una vez se ha iniciado sesión. Sin inicia sesión no
    puedes acceder a ellas desde la interfaz.

    ENListaDeseos: Utiliza el ISBN de los libros que queremos marcar como deseados y el email
    de que usuario lo ha agregado. Esta clase implementa las funciones para añadir, borrar o
    comprobar los libros deseados. Se utiliza en el aspx.cs para llamar a los métodos en cuestión
    cuando sea necesario.

    CADListaDeseos: Se encarga utilizando las herramientas en modo conectado de comunicarse con
    la base de datos para añadir un libro, borrar un libro y comprobar si un libro está en la base
    de datos o no.

    ENRecomendaciones y CADRecomendaciones; no hay una tabla dentro de la base de datos como tal para
    agregar las recomendaciones. Por lo tanto estas dos clases se han utilizado como apoyo para
    que a la hora de recomendar los libros con mayor nota o de recomendar todos los libro de un género
    específico no haya ningún problema con los datos checkeando antes con el método Recomendado() que
    todo está bien y se encuentran los datos en la BBDDD.


Pablo: 

    ENUSUARIO, CADUSUARIO, ENSUGERENCIAS, CADSUGERENCIAS

    La clase usuario se accede mediante el perfil posteriormente al haber iniciado sesión. Si no se inicia sesión no se puede acceder al perfil. 

    La clase sugerencias se accede mediante soporte desde el menú.

    ENUSUARIO: Utiliza principalmente el email del usuario. Esta clase además implementa las funciones de modificar, mostrar datos y eliminar. Se utiliza principalmente para los datos del perfil.
    Se utiliza en el aspx.cs para llamar a los métodos.

    CADUSUARIO: El CAD, se comunicará con la base de datos para mostrar los datos, eliminarlos y/o modificarlos. Además también comprobará que dicho usuario existe o no. Principalemnte utilizaremos el email como CP, por lo que no se podrá modificar nunca cuando entremos al perfil. 
    En resumen, este CAD corresponde completamente al perfil del usuario.

    ENSUGERENCIAS Y CADSUGERENCIAS: Existe una tabla sugerencias para guardar los datos. Tanto el EN como el CAD es muy simple. Guardará la información que escriba el usuario. Esta clase además, se ve introducida por el soporte en el cual aparecerá si hacer una pregunta o una sugerencia. Cabe destacar que las sugerencias no se podrán eliminar o modificar posteriormente a darle al botón enviar.

Juan García Martínez 20085694R:

    ENRelato, CADRelato, ENMisRelato, CADMisRelato, ENCriticas, CADCriticas, ENCarrito, CADCarrito.


    EN/CAD Relato: Esta clase se utiliza para mostrar los relatos que no son del usuario que actualmente este logeado.

    EN/CAD MisRelatos: En esta clase el usuario podra crear, modifica y eliminar relatos. Y podrá ver todos los relatos escritos por él en un GridView.

    EN/CAD Carrito: En esta clase se añadirán los libros que un propio usuario quiera comprar. Podrá modificar la cantidad, eliminar el producto del carrito, y podrá visualizarlo en un asp:DataList.


    **Una de las funcionalidades era la compra, pero por falta de tiempo no lo he podido realizar, ya que necesitaba Libros.aspx**

    **Otra de las funcionalidades era VentaEntreUsuarios.aspx, pero al no tenerlo a tiempo no he podido añadir la funcionalidad de agregar al carrito y compra**

---------- Mejoras introducidas ----------

    Carrito de compra
    Interfaz entre la venta de usuarios
    
---------- Mejoras no introducidas ----------

    No hemos metido nada sobre Ajax
    Los controles de validacion son todos inline con (c#)
    No hemos podido realizar la compra/venta/alquiler, por falta de tiempo al entregar los .aspx necesarios
    
    



    
   
