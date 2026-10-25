
namespace PLANAZO_POO_CSharp.Modelos;
public abstract class Evento
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public DateTime Fecha { get; private set; }
    public decimal PrecioBase { get; private set; }
    public int CapacidadMaxima { get; private set; }
    public int CuposDisponibles { get; private set; }
    public Evento(int id, string nombre, DateTime fecha, decimal precioBase, int capacidadMaxima)
    {
        if (precioBase < 0)
        {
            throw new ArgumentException("El precio debe ser mayor o igual a cero.");
        }
        if (capacidadMaxima <= 0)
        {
            throw new ArgumentException("La capacidad debe ser mayor que cero.");
        }
        Id = id;
        Nombre = nombre;
        Fecha = fecha;
        PrecioBase = precioBase;
        CapacidadMaxima = capacidadMaxima;
        CuposDisponibles = capacidadMaxima;
    }
    public abstract decimal CalcularPrecioFinal();
    public void ReservarCupos(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser mayor que cero.");
        }
        if (cantidad > CuposDisponibles)
        {
            throw new InvalidOperationException("No hay cupos suficientes para esa reserva.");
        }
        CuposDisponibles -= cantidad;
    }
    public void DevolverCupos(int cantidad)
    {
        if (cantidad <= 0)
        {
            throw new ArgumentException("La cantidad debe ser mayor que cero.");
        }
        if (CuposDisponibles + cantidad > CapacidadMaxima)
        {
            throw new InvalidOperationException("No se pueden devolver más cupos de los reservados.");
        }
        CuposDisponibles += cantidad;
    }
}
