
namespace PLANAZO_POO_CSharp.Modelos;
public class Reserva
{
    public int Id { get; private set; }
    public Usuario Usuario { get; private set; }
    public Evento Evento { get; private set; }
    public int CantidadEntradas { get; private set; }
    public decimal ValorTotal { get; private set; }
    public bool Activa { get; private set; }
    public Reserva(int id, Usuario usuario, Evento evento, int cantidadEntradas)
    {
        if (usuario == null)
        {
            throw new ArgumentException("Debe seleccionar un usuario.");
        }

        if (evento == null)
        {
            throw new ArgumentException("Debe seleccionar un evento.");
        }

        if (cantidadEntradas <= 0)
        {
            throw new ArgumentException("Debes reservar al menos una entrada.");
        }
        Id = id;
        Usuario = usuario;
        Evento = evento;
        CantidadEntradas = cantidadEntradas;
        ValorTotal = evento.CalcularPrecioFinal() * cantidadEntradas;
        Activa = true;
    }
    public void Cancelar()
    {
        if (!Activa)
        {
            throw new InvalidOperationException("Esta reserva ya fue cancelada.");
        }
        Evento.DevolverCupos(CantidadEntradas);
        Activa = false;
    }
}