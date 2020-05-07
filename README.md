# Hotelera-ROBAL-MAR
Este es un pequeño proyecto donde hacemos ciertas funciones de la administracion de un hotel
para ello hacemos un registro de clientes, en el mismo registro se muestran es una tabla los clientes
que están en la habitación, y al seleccionar uno podemos modificarlos o finalizar su hospedaje

Tambien contamos con formulario de registro y actualización de de empleados, su función es similar 
como la de los clientes con respecto a la tabla.

Para su uso sin problemas se anexa el script de la base de datos hecha en SQLServer, tambien se tiene que 
cambiar en la cadena de conexión el nombre de usuario, para ello ingresen en 
Hotelera-ROBAL-MAR/view/src/DataBase/DataBase.cs
En la linea 16 solo tienen que cambiar el server

Los usuario por defecto son:
<pre>
  Gerente: 
    Nombre - Nicolas MOreno Durán
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
