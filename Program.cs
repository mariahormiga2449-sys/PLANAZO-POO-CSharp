
using PLANAZO_POO_CSharp.Modelos;
using PLANAZO_POO_CSharp.Servicios;
class Program
{
    static GestorReservas gestor = new GestorReservas();
    static void Main(string[] args)
    {
        RegistrarEventos();
        int opcion = -1;
        while (opcion != 0)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       PLANAZO - EVENTOS");
            Console.WriteLine("================================");
            Console.WriteLine("1. Ver eventos disponibles");
            Console.WriteLine("2. Consultar evento");
            Console.WriteLine("3. Registrar usuario");
            Console.WriteLine("4. Reservar entradas");
            Console.WriteLine("5. Ver reservas realizadas");
            Console.WriteLine("6. Cancelar una reserva");
            Console.WriteLine("7. Ver resumen de reservas");
            Console.WriteLine("8. Consultar reservas por usuario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");
            try
            {
                opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        VerEventos();
                        break;
                    case 2:
                        ConsultarEvento();
                        break;
                    case 3:
                        RegistrarUsuario();
                        break;
                    case 4:
                        ReservarEntradas();
                        break;
                    case 5:
                        VerReservas();
                        break;
                    case 6:
                        CancelarReserva();
                        break;
                    case 7:
                        VerResumen();
                        break;
                    case 8:
                        ConsultarReservasPorUsuario();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por utilizar PLANAZO.");
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe. Intenta nuevamente.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: debes ingresar un numero.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("No se pudo completar la operacion: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("No se pudo completar la operacion: " + ex.Message);
            }
        }
    }
    static void RegistrarEventos()
    {
        gestor.AgregarEvento(new Cine(1, "Como entrenar a tu dragon",
            new DateTime(2026, 11, 10), 15000m, 50));
        gestor.AgregarEvento(new Cine(2, "Lilo y Stitch",
            new DateTime(2026, 11, 12), 18000m, 40));
        gestor.AgregarEvento(new Concierto(3, "Concierto de Rock",
            new DateTime(2026, 11, 15), 50000m, 100));
        gestor.AgregarEvento(new Concierto(4, "Noche de Pop",
            new DateTime(2026, 11, 20), 80000m, 80));
        gestor.AgregarEvento(new Taller(5, "Taller de Pintura",
            new DateTime(2026, 11, 22), 40000m, 25));
        gestor.AgregarEvento(new Taller(6, "Taller de Fotografia",
            new DateTime(2026, 11, 25), 60000m, 20));
        gestor.AgregarEvento(new EventoDeportivo(7, "Partido de Futbol",
            new DateTime(2026, 11, 28), 30000m, 200));
    }
    static void VerEventos()
    {
        Console.WriteLine("\n--- EVENTOS DISPONIBLES ---");
        foreach (Evento evento in gestor.ObtenerEventos())
        {
            Console.WriteLine(
                $"ID: {evento.Id} | {evento.Nombre} | " +
                $"Fecha: {evento.Fecha.ToShortDateString()} | " +
                $"Precio: {evento.CalcularPrecioFinal():C0} | " +
                $"Cupos: {evento.CuposDisponibles}"
            );
        }
    }
    static void ConsultarEvento()
    {
        Console.Write("Ingrese el ID del evento: ");
        int id = int.Parse(Console.ReadLine()!);
        Evento evento = gestor.BuscarEvento(id);
        Console.WriteLine("\n--- INFORMACION DEL EVENTO ---");
        Console.WriteLine("Nombre: " + evento.Nombre);
        Console.WriteLine("Fecha: " + evento.Fecha.ToShortDateString());
        Console.WriteLine("Precio base: " + evento.PrecioBase);
        Console.WriteLine("Precio final: " + evento.CalcularPrecioFinal());
        Console.WriteLine("Capacidad maxima: " + evento.CapacidadMaxima);
        Console.WriteLine("Cupos disponibles: " + evento.CuposDisponibles);
    }
    static void RegistrarUsuario()
    {
        Console.Write("Nombre del usuario: ");
        string nombre = Console.ReadLine()!;
        Console.Write("Correo del usuario: ");
        string correo = Console.ReadLine()!;
        Usuario usuario = gestor.RegistrarUsuario(nombre, correo);
        Console.WriteLine("\nUsuario registrado correctamente.");
        Console.WriteLine("ID: " + usuario.Id);
        Console.WriteLine("Nombre: " + usuario.Nombre);
        Console.WriteLine("Correo: " + usuario.Correo);
    }
    static void ReservarEntradas()
    {
        Console.WriteLine("\n--- USUARIOS REGISTRADOS ---");
        foreach (Usuario usuario in gestor.ObtenerUsuarios())
        {
            Console.WriteLine(
                $"ID: {usuario.Id} | {usuario.Nombre} | {usuario.Correo}"
            );
        }
        Console.Write("ID del usuario: ");
        int idUsuario = int.Parse(Console.ReadLine()!);
        Console.Write("ID del evento: ");
        int idEvento = int.Parse(Console.ReadLine()!);
        Console.Write("Cantidad de entradas: ");
        int cantidad = int.Parse(Console.ReadLine()!);
        Reserva reserva = gestor.CrearReserva(idUsuario, idEvento, cantidad);
        Console.WriteLine("\nReserva realizada correctamente.");
        Console.WriteLine("ID de reserva: " + reserva.Id);
        Console.WriteLine("Usuario: " + reserva.Usuario.Nombre);
        Console.WriteLine("Evento: " + reserva.Evento.Nombre);
        Console.WriteLine("Cantidad: " + reserva.CantidadEntradas);
        Console.WriteLine("Valor total: " + reserva.ValorTotal.ToString("C0"));
    }
    static void VerReservas()
    {
        Console.WriteLine("\n--- RESERVAS REALIZADAS ---");
        foreach (Reserva reserva in gestor.ObtenerReservas())
        {
            Console.WriteLine(
                $"ID: {reserva.Id} | Usuario: {reserva.Usuario.Nombre} | " +
                $"Evento: {reserva.Evento.Nombre} | " +
                $"Entradas: {reserva.CantidadEntradas} | " +
                $"Total: {reserva.ValorTotal:C0} | " +
                $"Estado: {(reserva.Activa ? "Activa" : "Cancelada")}"
            );
        }
    }
    static void CancelarReserva()
    {
        Console.Write("Ingrese el ID de la reserva: ");
        int id = int.Parse(Console.ReadLine()!);
        gestor.CancelarReserva(id);
        Console.WriteLine("Reserva cancelada correctamente.");
        Console.WriteLine("Los cupos han sido devueltos.");
    }
    static void VerResumen()
    {
        Console.WriteLine("\n--- RESUMEN DE RESERVAS ---");
        Console.WriteLine("Reservas activas: " +
            gestor.ContarReservasActivas());
        Console.WriteLine("Entradas reservadas: " +
            gestor.ContarEntradasReservadas());
        Console.WriteLine("Valor total: " +
            gestor.CalcularValorReservasActivas().ToString("C0"));
    }
    static void ConsultarReservasPorUsuario()
    {
        Console.WriteLine("\n--- USUARIOS REGISTRADOS ---");
        foreach (Usuario usuario in gestor.ObtenerUsuarios())
        {
            Console.WriteLine(
                $"ID: {usuario.Id} | {usuario.Nombre} | {usuario.Correo}"
            );
        }
        Console.Write("Ingrese el ID del usuario: ");
        int idUsuario = int.Parse(Console.ReadLine()!);
        List<Reserva> reservas = gestor.ObtenerReservasPorUsuario(idUsuario);
        Console.WriteLine("\n--- RESERVAS DEL USUARIO ---");
        if (reservas.Count == 0)
        {
            Console.WriteLine("Este usuario no tiene reservas.");
            return;
        }
        foreach (Reserva reserva in reservas)
        {
            Console.WriteLine(
                $"Reserva: {reserva.Id} | Evento: {reserva.Evento.Nombre} | " +
                $"Entradas: {reserva.CantidadEntradas} | " +
                $"Total: {reserva.ValorTotal:C0} | " +
                $"Estado: {(reserva.Activa ? "Activa" : "Cancelada")}"
            );
        }
    }
}