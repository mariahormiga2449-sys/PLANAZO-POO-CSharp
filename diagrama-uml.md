```mermaid
classDiagram
    class Evento {
        <<abstract>>
        +Id int
        +Nombre string
        +Fecha DateTime
        +PrecioBase decimal
        +CapacidadMaxima int
        +CuposDisponibles int
        +CalcularPrecioFinal() decimal
        +ReservarCupos(cantidad)
        +DevolverCupos(cantidad)
    }

    class Cine {
        +CalcularPrecioFinal() decimal
    }

    class Concierto {
        +CalcularPrecioFinal() decimal
    }

    class Taller {
        +CalcularPrecioFinal() decimal
    }

    class EventoDeportivo {
        +CalcularPrecioFinal() decimal
    }

    class Usuario {
        +Id int
        +Nombre string
        +Correo string
    }

    class Reserva {
        +Id int
        +CantidadEntradas int
        +ValorTotal decimal
        +Activa bool
        +Cancelar()
    }

    class GestorReservas {
        +RegistrarUsuario()
        +CrearReserva()
        +CancelarReserva()
        +ObtenerReservasPorUsuario()
    }

    Evento <|-- Cine
    Evento <|-- Concierto
    Evento <|-- Taller
    Evento <|-- EventoDeportivo
    Usuario "1" --> "0..*" Reserva : realiza
    Evento "1" --> "0..*" Reserva : recibe
    GestorReservas ..> Usuario : administra
    GestorReservas ..> Reserva : administra
    GestorReservas ..> Evento : administra
```
