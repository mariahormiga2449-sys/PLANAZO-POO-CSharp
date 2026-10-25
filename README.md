# PLANAZO - Sistema de Reservas de Eventos

## Descripcion
PLANAZO es una aplicacion de consola desarrollada en C# que permite administrar eventos y realizar reservas de entradas.

## Funcionalidades
- Consultar los eventos disponibles.
- Consultar la informacion de un evento.
- Registrar usuarios con nombre y correo.
- Reservar entradas para cine, conciertos, talleres y eventos deportivos.
- Validar la cantidad de cupos disponibles.
- Consultar las reservas realizadas.
- Cancelar reservas y devolver los cupos.
- Consultar las reservas de un usuario.
- Mostrar un resumen de reservas activas, entradas y valor total.

## Tipos de eventos
- Cine: conserva el precio base.
- Concierto: aplica un recargo del 15%.
- Taller: aplica un descuento del 10%.
- Evento deportivo: aplica un recargo del 10%.

## Conceptos de Programacion Orientada a Objetos
- Abstraccion: la clase Evento define las caracteristicas comunes.
- Herencia: los tipos de eventos heredan de Evento.
- Polimorfismo: cada tipo de evento implementa su propio calculo del precio final.
- Encapsulamiento: las propiedades protegen la modificacion directa de los datos.
- Asociacion: las reservas relacionan usuarios con eventos.

## Tecnologias
- C#
- .NET
- Aplicacion de consola

## Requisitos
Tener instalado el SDK de .NET.

## Como ejecutar el proyecto
1. Abrir una terminal en la carpeta del proyecto.
2. Ejecutar el comando:

   dotnet run

3. Utilizar el menu para seleccionar las opciones disponibles.

## Diagrama UML
El archivo diagrama-uml.md contiene el diagrama de clases en formato Mermaid.

## Almacenamiento
Los datos se mantienen en memoria mientras se ejecuta el programa. Al cerrar la aplicacion, los usuarios y las reservas no se guardan permanentemente.

## Autor
Maria Hormiga.

