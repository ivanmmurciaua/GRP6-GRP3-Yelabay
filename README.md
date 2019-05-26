# GRP6_GRP3_Yelabay

Descripción: Tienda Online denonimada Yelabay destinada a la venta de productos informáticos donde el usuario podrá comprar, visualizar productos y tener su propio menú como usuario registrado.

Parte pública: 
* Visualizar productos.
* Ver detalles del producto.
* Ver ofertas.
* Mostrar por categorias.
* Búsqueda de productos.
* Búsqueda por filtros tal como Marca, precio, caracterísitcas del mismo etc.
* Darse de alta como usuario.
* Iniciar sesión.

Listado EN Pública:
* UsuarioEN.
* ProductoEN.
* MarcaEN.
* OfertasEN.
* CategoriaEN.

Parte privada:
* Todo lo de la parte pública.
* Realizar reclamaciones.
* Añadir artículos al Carrito.
* Ver tu perfil.
* Editar el perfil.

Listado EN Privada:
* Toda lo de la parte públicaEN.
* DevolucionesEN.
* CarritoEN.
* ReclamacionesEN.
* AdminEN.
* PedidosEN.
* ServicioTécnicoEN.

Posibles mejoras:
* Chat en directo con uno de nuestros técnicos
* Importación de productos desde un CMS como Prestashop o Magento
* Comentarios de los usuarios (opiniones sobre los productos)

Asignación EN:
* UsuarioEN -> X7197828R
* ProductoEN -> X7197828R
* MarcaEN -> 51239910G
* OfertasEN -> 51239910G
* CategoriaEN -> 50386084F
* DevolucionesEN -> 50386084F
* CarritoEN -> 48766639S
* ReclamacionesEN -> 48766639S
* AdminEN -> 48729799K
* PedidosEN -> 48685367W
* ServicioTecnicoEN -> 48685367W

## Deadline2
### El pdf con el esquema UML se puede encontrar en Yelabay/Scheme/DiagramaClases.pdf
##### Anotaciones
-El UML es un borrador al igual que todo el código, a medida que avance el proyecto iremos modificando como creamos conveniente los métodos para conseguir que nuestro proyecto sea funcional.

## Deadline3
### Para compilar:
* Clonar repositorio
* Combinación desde develop a la rama correspondiente
* Establecer como proyecto de inicio webYelabay
* Establecer como página de inicio Home.aspx en el proyecto webYelabay
* Limpiar ambos proyectos y la solución, y a continuación compilar solución
* Ctrl + F5

### Incluido en la entrega:
- Interfaz web básica, junto a su menú correspondiente y enlaces a distintas páginas ya realizadas.
- Visualización de articulo, login y demás funcionalidades que serán operativos en la próxima entrega.
- Base de datos abierta a cambios en sus tablas

# Deadline 4 - Yelabay E-Shop - FINAL

![picture](https://scontent-cdg2-1.cdninstagram.com/vp/561d449278e1e0670522a8576a4c45f1/5D1D43C0/t51.2885-19/s150x150/31310780_172083973505652_3530543656538734592_n.jpg?_nc_ht=scontent-cdg2-1.cdninstagram.com)

## Índice

* [Integrantes del grupo](#team-members)
* [Descripción](#description)
* [Parte Pública](#public-part)  
* [Listado EN Pública](#public-list)
* [Parte Privada](#private-part)
* [Lista Privada](#private-list)
* [Posibles mejoras](#posible-improvements)
* [Problemas Asociados](#asociated-problems)
* [Instrucciones para el funcionamiento de la aplicación](#Instrucctions)
* [Presentación](#presentation)
* [Tareas hechas por los miembros del grupo](#Team-Work)
* [Comentarios del director](#director)

## <a name="team-members"></a>Integrantes del grupo
* Samuel García López	
* Sergio Cortés Espinosa	
* Iván Mañús Murcia (Coordinador)
* Qiqi Zhou	
* Wilson Monta Vargas
* Andrés Tebar Moreno

## <a name="description"></a>Descripción
Tienda Online denonimada Yelabay destinada a la venta de productos informáticos donde el usuario podrá comprar, visualizar productos y tener su propio menú como usuario registrado. 

## <a name="public-part"></a>Parte Pública
Los clientes **no-registrados** podrán:
* Visualizar productos.
* Ver detalles del producto.
* Mostrar por categorias.
* Darse de alta como usuario.
* Iniciar sesión.

## <a name= "public-list"></a>Listado EN pública
* UsuarioEN.
* ProductoEN.
* MarcaEN.
* OfertasEN.
* CategoriaEN.

## <a name="private-part"></a>Parte Privada
Los clientes **registrados** podrán:
* Todo lo de la parte pública.
* Realizar reclamaciones.
* Ver sus reclamaciones
* Añadir artículos al carrito.
* Ver tu perfil.
* Editar el perfil.
- Y si eres **administrador** ver todo eso pero de todos los usuarios

## <a name="private-list"></a>Listado EN privada  
* Toda lo de la parte PúblicaEN.
* DevolucionesEN.
* CarritoEN.
* ReclamacionesEN.
* PedidosEN.

## <a name="posible-improvements"></a>Posibles mejoras:
  * Traducción idiomas.
  * ¿Donde estamos? (Google maps)
  * Verificación en dos pasos.
  * Recuérdame.
  * Version movil.
  * Chat en directo con uno de nuestros técnicos
  * Importación de productos desde un CMS como Prestashop o Magento
  * Comentarios de los usuarios (opiniones sobre los productos)

## <a name="asociated-problems"></a>Problemas asociados:

  -La mayoría de los cambios se han dado en el esquema que entregamos en la entrega 2, ya que en un primer momento debido a 
  no pensar mucho en la implementación cometimos fallos de concepto.

  -Los segundos y más graves, surgieron a causa de un mal entendimiento del IDE de Microsoft utilizado, Visual Studio 2017, ya que
  para que se quedaran los cambios en el proyecto, debiamos subir la caché relacionada a varios archivos, y eso nos retrasó bastante ya que,
  los cambios en la caché de una persona causaban algunos problemas al sincronizar con la rama develop en Github

## <a name="Instrucctions"></a> Instrucciones para el funcionamiento de la aplicación:
  * Clonar repositorio
  * Combinación desde develop a la rama correspondiente
  * Establecer como proyecto de inicio webYelabay
  * Establecer como página de inicio Home.aspx en el proyecto webYelabay
  * Limpiar ambos proyectos y la solución, y a continuación compilar solución
  * Ctrl + F5
  
  Para nuestra aplicación en concreto, como tenemos sistema de **inicio de sesión** y de **registro** aportamos dos _cuentas_ para pruebas en la correccion, una de administrador y otra de usuario:

### Administrador
  
  - Usuario : **raul**
  - Contraseña: **revision1**
  
### Cliente estándar

  - Usuario: **profesor**
  - Contraseña: **revision2**

## <a name="presentation"></a> Presentación realizada en clase se encuentra en la carpeta Yelabay/Presentation/Presentation.pdf

## <a name="Team-Work"></a> Trabajo realizado por cada miembro del grupo:

#### Sergio Cortés Espinosa

- ServicioTecnico CAD y EN
- Pedidos CAD y EN
- Creación página de inicio
- Creación menú
- Creación varios aspx
- Creación interfaz Master, Home, Usuario, Admin
- Actualización y corrección de errores de varios aspx
- Estilo de la web

### Wilson Monta Vargas

- Creación pedidos admim
- creación productos admin
- creacion de ver producto
- usuarios admin 
- confirmarpedido.aspx
- ver todos los productos
- los aspx de ver los productos por categoría
- Modificación de varios en y CAD
- Correcciones de algunos aspx

### Andrés Tebar Moreno

- Crear Entidad y Cad carrito
- Crear Entidad y Cad VerIncidencia
- Boceto diagrama de clases inicial
- Ayuda exposición
- Proceso desde comprar un producto hasta gestionar pedido, evitando incongruencias en carrito
- Actualización y corrección errores en algunos aspx

### Samuel García López

- Categoria EN y CAD.
- Devoluciones EN y CAD.
- Menu de Usuario.
- Slider.
- Logo Yelabay + Banners Ofertas.
- Interfaz usuario,mis pedidos, mis reclamaciones, etc.
- Interfaz Productos Administrador.
- Interfaz inicial Administrador.
- Actualización y corrección de errores de varios aspx

### Qiqi Zhou

- Creacion Reclamaciones Admin
- Creacion Register
- Login
- Encriptacion md5
- Ver reclamaciones
- Actualizacion de Usuarios
- Interfaces de login , reclamacionadmin y register.
- Usuario EN/ CAD y otras modificaciones como en reclamaciones EN /CAD
- Actualizacion y modificacion de errores en algunos apsx , EN y CAD.


### Iván Mañús Murcia

- Creación AdminEN
- Creación AdminCAD
- Ayuda con varios aspx
- Control de sesión en iconos v1
- Visualización de pedidos y reclamaciones por usuario
- Explendida coordinación del grupo


## <a name="director"></a> 

* Iván Mañús Murcia: 
-Bueno, como coordinador, director, líder de este proyecto, he decir varias cosas...
-Son unos compañeros fantásticos, unos trabajadores increibles y hemos logrado hacer una aplicación funcional a
pesar de dificultades, ya fuera por otras asignaturas o por el IDE ya mencionado.
-Al final hemos sabido aprovechar nuestras ventajas personales, e individuales y aprovecharlas al máximo para
trabajar lo más rápido posible, comunicandonos en todo momento, y sin perder la cabeza(a veces si pero no se nota).
-Hemos mantenido un ambiente perfecto para trabajar conjuntamente, sin malos rollos o recriminaciones hacia otras personas
del grupo, todo lo contrario, siempre ayudandonos entre todos.
-Y por mi parte no tengo más que decir, bueno si, el 10 quizá no...pero esto es un gran **TEAM-WORK**