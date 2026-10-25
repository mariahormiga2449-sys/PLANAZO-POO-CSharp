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
- **Cine, Concierto, Taller y EventoDeportivo:**