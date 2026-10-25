
using PLANAZO_POO_CSharp.Modelos;
namespace PLANAZO_POO_CSharp.Servicios;
public class GestorReservas
{
    private List<Evento> eventos;
    private List<Reserva> reservas;
    private List<Usuario> usuarios;
    private int siguienteIdReserva;
    private int siguienteIdUsuario;
    public GestorReservas()
    {
        eventos = new List<Evento>();
        reservas = new List<Reserva>();
        usuarios = new List<Usuario>();
        siguienteIdReserva = 1;
        siguienteIdUsuario = 1;
    }
    public void AgregarEvento(Evento evento)
    {
        eventos.Add(evento);
    }
    public List<Evento> ObtenerEventos()
    {
        return eventos;
    }
    public Evento BuscarEvento(int id)
    {
        foreach (Evento evento in eventos)
        {
            if (evento.Id == id)
            {
                return evento;
            }
        }
        throw new InvalidOperationException("El evento no existe.");
    }
    public Usuario RegistrarUsuario(string nombre, string correo)
    {
        Usuario usuario = new Usuario(siguienteIdUsuario, nombre, correo);
        usuarios.Add(usuario);
        siguienteIdUsuario++;
        return usuario;
    }
    public List<Usuario> ObtenerUsuarios()
    {
        return usuarios;
    }
    public Usuario BuscarUsuario(int id)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.Id == id)
            {
                return usuario;
            }
        }
        throw new InvalidOperationException("El usuario no existe.");
    }
    public Reserva CrearReserva(int idUsuario, int idEvento, int cantidadEntradas)
    {
        Usuario usuario = BuscarUsuario(idUsuario);
        Evento evento = BuscarEvento(idEvento);
        Reserva reserva = new Reserva(siguienteIdReserva,usuario, evento, cantidadEntradas );
        evento.ReservarCupos(cantidadEntradas);
        reservas.Add(reserva);
        siguienteIdReserva++;
        return reserva;
    }
    public List<Reserva> ObtenerReservas()
    {
        return reservas;
    }
    public Reserva BuscarReserva(int id)
    {
        foreach (Reserva reserva in reservas)
        {
            if (reserva.Id == id)
            {
                return reserva;
            }
        }
        throw new InvalidOperationException("La reserva no existe.");
    }
    public void CancelarReserva(int id)
    {
        Reserva reserva = BuscarReserva(id);
        reserva.Cancelar();
    }
    public List<Reserva> ObtenerReservasPorUsuario(int idUsuario)
    {
        BuscarUsuario(idUsuario);
        List<Reserva> resultado = new List<Reserva>();
        foreach (Reserva reserva in reservas)
        {
            if (reserva.Usuario.Id == idUsuario)
            {
                resultado.Add(reserva);
            }
        }
        return resultado;
    }
    public int ContarReservasActivas()
    {
        int total = 0;
        foreach (Reserva reserva in reservas)
        {
            if (reserva.Activa)
            {
                total++;
            }
        }
        return total;
    }
    public int ContarEntradasReservadas()
    {
        int total = 0;

        foreach (Reserva reserva in reservas)
        {
            if (reserva.Activa)
            {
                total += reserva.CantidadEntradas;
            }
        }
        return total;
    }
    public decimal CalcularValorReservasActivas()
    {
        decimal total = 0;
        foreach (Reserva reserva in reservas)
        {
            if (reserva.Activa)
            {
                total += reserva.ValorTotal;
            }
        }
        return total;
    }
}
