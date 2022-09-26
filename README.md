# DPRN3_U3_A1_JHRM
Programa que se conecta a una BD remota de MySQL, filtra datos y los vacia a una DB local 2 grids

## Interfaz gráfica
Consta de dos ventana, una que carga los datos de una base de datos remota MySQL y muestra todos los registros. En la segunda se hace un filtrado y se vacia a un BD local.

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/192294454-a6942015-3e2d-440b-b248-36c7ae618650.png"/>
</p>
![image](https://user-images.githubusercontent.com/38293508/192294454-a6942015-3e2d-440b-b248-36c7ae618650.png)


## Base de datos
La conexión con la base de datos local está configurada con MySQL. Al la base de datos encontrarse en un servidor que corre en MySQL el puerto de acceso siempre es el 3306.

Esto crea conflictos con otros manejadores con otro puerto por default. No se recomienda el uso de otro manejador de base de datos que no sea MySQL para evitar problemas de compatibilidad.

<p align="center">
  <img src="https://user-images.githubusercontent.com/38293508/190811025-08fdd93f-73fb-4e3f-9815-3553107e0ac5.png"/>
</p>


## Versiones y dependencias
* MySql.Data.MySqlClient
* Visual Studio Community 2019 16.11.19
