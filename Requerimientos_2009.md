# Introduction #

Adriana Lima, Miguel Girala, Fernando Sosa


# Detailles #

1 – INSTALACION Y COSTOS DEL SISTEMA

**El usuario baja el instalador de internet**	Al instalar puede:
**Seleccionar el modo demo por 30 días**	Activar la aplicación con un código que incluye la fecha de caducidad. ( a razon de $ 20 por mes )
**Periodicamente puede volver a comprar un código de activacion por otro período**	Junto con el instalador recibe un manual completo de ayuda sobre las funciones del sistema

2 – ARTICULOS

**Codificacion del usuario**	Nombre del articulo
**Codificacion proveedor**	Caracteríticas que se solicitan al momento de facturacion
**Una o más listas de valores. Ejemplos**	Color
**Sabor**	Talle
Al momento de incluir el artículo en una factura o pedido, se puede agregar opcionalmente una cantidad a la opcion seleccionada. Ejemplo: si se incluye la carácterística sabor, y se selecciona CHOCOLATE, se puede agregar la cantidad deseada.
**Un valor fijo: permite ingresar un valor**	Numerico
**Alfanumerico  (Texto y numeros)**	Fecha
**Sin valor: permite asignar la característica. Ejemplo: 2da selección.**	Grupo de artículos: poder indicar a que grupo de artículos pertenece. Ejemplo: Pastas, Bebidas


3 – ARTICULOS COMPUESTOS

Se pueden crear articulos que se componen de otros artículos:

**Codificacion del usuario**	Nombre del articulo
**Codificacion proveedor**	Conjunto de artículos que lo componen
**Cantidad de ocurrencias para cada artículo**

Ejemplo: el artículo “COMBO I” se compone de los artículos “Pizza” (1), “Gaseosa” (2) y “Papas Fritas” (1).

Un artículo componente puede estar asociado una o más veces a un artículo compuesto. En el ejemplo anterior, se podria describir el  “COMBO I” como “Pizza” (1), “Gaseosa” (1), “Gaseosa” (1)  y “Papas Fritas” (1).



4 – LISTAS DE PRECIOS

Se pueden crear diferentes listas de precios, para luego asignar un precio a cada artículo en cada lista.

**Codigo de usuario**	Nombre de la lista de precios


5 – PRECIOS POR ARTÍCULO

Un artículo puede relacionarse a más de una lista de precios. Tambien es posible dentro de la misma lista asignar diferentes precios para diferentes características. Finalmente se pueden crear ofertas por rango de fechas para cada caso.

•	Artículo
•	Lista de precio
•	Características (Opcional)
•	Precio

Ejemplo:

Articulo	Lista	Talle	Tipo	Color	Precio
FALDA	Publico	 	 	 	45.00
FALDA	Publico	 	2da Selección	 	40.00
FALDA	Publico	40	1ra Selección	 	60.00
FALDA	Publico	40	2da Selección	 	50.00

**Ofertas: por cada lista y articulo (incluyendo los precios por características) se puede definir un precio (oferta) vigente para un rango de fechas**

Ejemplo: para la lista “Publico” el artículo “Falda” de “2da Selección” tiene un precio de $40. Se puede crear una oferta indicando que desde el 01/02/2009 hasta el 15/03/2009 el precio a considerar es $30. Pasado el 15/03/2009 el valor vuelve a ser $40.
6 – CLIENTES


7 - MOZOS

**Agregar administracion de Mozos  (los mozos no siempre son usuarios del sistema)**

8 – FACTURACION


SEGUIMIENTO DE PEDIDOS

**Mantener ultimas fechas y horas ingresadas**	Mantener la ultima selección de estados (Pendiente, Cerrado, Activo y Anulado)
**No preseleccionar ningun otro filtro**

PEDIDOS

**Configurar por defecto**	Cliente
**Lista de precios**

**Habilitar búsqueda de artículos
A medida que se ingresan caracteres el sistema intenta encontrar esos caracteres en el Código de Usuario, Nombre o Codigo de Proveedor del artículo. Presenta en una lista emergente los resultados de la búsqueda, desde la cual puede ser seleccionado.**

**Si el artículo seleccionado tiene características, se muestra una ventana que permite su ingreso. Todas las caracteríticas son opcionales.**

•	Actualizar busqueda de precios para que tenga en cuenta características y ofertas.

**Cuando se carga un importe de pago el pedido pasa a “Cerrado”**

**Poder imprimir el pedido**

**Sacar la opción de impresión por línea**




> MODULO RESTAURANT




9 – REPORTES

**Reporte de ventas por artículo y rango de fechas**	Fecha Desde
**Fecha Hasta**	Artículo
**Detallado por características**


ARTICULO	 	 	TOTAL
PANTALON	 	 	50
> COLOR
> > Rojo	20
> > Azul	30


> TALLE
> > 30	8
> > 32	10
> > 34	12
> > 36	10
> > 38	6
> > 40	4









