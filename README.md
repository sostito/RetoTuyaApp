# README.MD

## Contenido
Contiene 3 Apis, las cuales son: Pagos, Logistica y Facturar, las cuales obtienen los datos de un pedido, calcula el total del valor de todos los pedidos recibidos en la petición y registra un pedido enviado en base de datos

## Comentarios
- Por facilidad, se suben las 3 Apis al mismo repositorio.
- Se utilizó Linq para realizar calculos sobre los objetos
- La totalidad de los servicios fueron inyectados mediante inyección de pendencias para poder realizar Mockeo

## Consideraciones
- Aunque se podían compartir bibliotecas de clases entre Apis, se deja cada una con su propia lógica.
- Se utilizó NUnit para las pruebas unitarias, aunque también tuve en consideración XUnit
- Se utilizó el nugget Moq para el mockeo de respuesta al consumir a otras Apis en pruebas unitarias
- La conexión al base de datos fue mediante credenciales de Windows

## Prerequisitos
- Tener instalado el SDK para correr Net Core 3.1
- Tener creada la base de datos y tabla incluida en este repositorio con nombre "db.sql"
