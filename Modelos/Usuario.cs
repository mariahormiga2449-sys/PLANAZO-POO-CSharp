namespace PLANAZO_POO_CSharp.Modelos;

public class Usuario
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string Correo { get; private set; }

    public Usuario(int id, string nombre, string correo)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(correo))
        {
            throw new ArgumentException("El correo es obligatorio.");
        }

        Id = id;
        Nombre = nombre;
        Correo = correo;
    }
}
