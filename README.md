# Hotelera-ROBAL-MAR
Este es un pequeño proyecto donde hacemos ciertas funciones de la administracion de un hotel
para ello hacemos un registro de clientes, en el mismo registro se muestran es una tabla los clientes
que están en la habitación, y al seleccionar uno podemos modificarlos o finalizar su hospedaje

Tambien contamos con formulario de registro y actualización de de empleados, su función es similar 
como la de los clientes con respecto a la tabla.

Para su uso sin problemas se anexa el script de la base de datos hecha en SQLServer para que lo puedas ejecurtar.

Los usuario por defecto son:
<pre>
  Gerente: 
    Nombre - Nicolas Moreno Durán
    Usuario - niconi 
    clave - niconi    
</pre>
<pre>
  Personal: 
    Nombre - Francisco Enrique Alberto Cordova
    Usuario - francisco 
    clave - francisco
    
    Nombre - Josue Jared Camacho Rolon
    Usuario - josue 
    clave - josue
</pre>


Nicolas tiene nivel de acceso de gerente y, Enrique y Jared tienen nicel de acceso de personal comun

Se utilizó un hilo en la pagina de la grafica para poder actualizar esta cuando haya un cambio en los clientes,
es decir, cuando un cliente se retira y se almacena en el historial, el cambio se ve reflejado en la grafica en
tiempo real.
