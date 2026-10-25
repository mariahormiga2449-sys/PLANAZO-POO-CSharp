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
## Clases y relaciones

La clase `Evento` contiene los datos comunes de los eventos. `Cine`, `Concierto`, `Taller` y `EventoDeportivo` heredan de ella y calculan el precio final según su tipo.

La clase `Usuario` guarda los datos de las personas que reservan. `Reserva` relaciona al usuario con el evento y registra las entradas, el valor total y el estado. `GestorReservas` administra los eventos, usuarios y reservas.

## Otros conceptos de POO

Los constructores permiten inicializar los objetos. El encapsulamiento ayuda a controlar la modificación de los datos. Las listas `List<T>` almacenan los eventos, usuarios y reservas, mientras que las validaciones y excepciones permiten controlar errores y entradas incorrectas.

## Pregunta de sustentación

**¿Por qué utilicé una clase abstracta `Evento`?**

La utilicé porque todos los eventos comparten características, como el nombre, la fecha y el precio base. Así evito repetir código y cada tipo puede calcular su precio de manera diferente. Por ejemplo, un concierto aumenta su precio un 15 % y un taller aplica un descuento del 10 %. Si necesito agregar otro tipo de evento, puedo crear una clase que herede de `Evento`, como hice con `EventoDeportivo`, sin cambiar las clases existentes.

## Pruebas realizadas

Se probaron las reservas válidas, las cantidades negativas o iguales a cero, los cupos insuficientes, la cancelación de reservas, las consultas de eventos inexistentes y los precios finales de los diferentes tipos de eventos.

Las capturas de estas pruebas están en la carpeta `Capturas`.