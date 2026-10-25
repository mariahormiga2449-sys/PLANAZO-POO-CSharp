# PLANAZO - Sistema de Reservas de Eventos

## Descripción
PLANAZO es una aplicación de consola hecha en C# y .NET para consultar eventos, reservar entradas, cancelar reservas y controlar los cupos disponibles.

## Funcionalidades
- Consultar eventos y sus precios.
- Registrar usuarios.
- Reservar y cancelar entradas.
- Validar cantidades y cupos disponibles.
- Consultar reservas por usuario.
- Mostrar un resumen de las reservas activas, entradas y valor total.

## Tipos de eventos
- **Cine:** mantiene el precio base.
- **Concierto:** aumenta el precio un 15 %.
- **Taller:** aplica un descuento del 10 %.
- **Evento deportivo:** aumenta el precio un 10 %.

## Clases y conceptos de POO
- **Evento:** clase abstracta con los datos comunes de los eventos.
- **Cine, Concierto, Taller y EventoDeportivo:** heredan de `Evento` y calculan su precio final.
- **Usuario:** guarda los datos de las personas que reservan.
- **Reserva:** relaciona al usuario con el evento y guarda la cantidad, el valor total y el estado.
- **GestorReservas:** administra los eventos, usuarios y reservas.

En el proyecto utilicé **constructores** para inicializar objetos, **encapsulamiento** para controlar los datos, **abstracción** para definir las características comunes, **herencia** para reutilizar código y **polimorfismo** para calcular los precios según cada evento. También utilicé listas `List<T>` para almacenar la información y validaciones y excepciones para controlar errores.

## Diagrama UML
El diagrama de clases muestra los atributos, métodos y relaciones del sistema. Se encuentra en el archivo [diagrama-uml.md](diagrama-uml.md).

## Pregunta de sustentación
**¿Por qué utilicé una clase abstracta `Evento`?**

La utilicé porque todos los eventos comparten datos como el nombre, la fecha y el precio base. Así evito repetir código y cada tipo de evento puede calcular su precio de forma diferente. Por ejemplo, `Concierto` aumenta el precio un 15 % y `Taller` lo reduce un 10 %. Si necesito agregar otro tipo, puedo crear una clase que herede de `Evento`, como hice con `EventoDeportivo`, sin cambiar las clases existentes.

## Tecnologías y ejecución
Se utiliza C# y .NET. Para ejecutar el programa, abre una terminal en la carpeta del proyecto y escribe:

```bash
dotnet run
```

## Pruebas y capturas
Se probaron las reservas válidas, los cupos insuficientes, las cantidades incorrectas, la cancelación, las consultas y los precios de los eventos. Las capturas están en la carpeta `Capturas`.

## Almacenamiento
Los datos se guardan en memoria durante la ejecución. Al cerrar el programa, las reservas y los usuarios no se conservan.

## Autor
Maria Hormiga