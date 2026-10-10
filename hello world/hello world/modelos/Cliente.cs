namespace SistemadeResverva.Modelos;

public class Cliente(int id, string nombre, string telefono)
{
    public int Id { get; set; } = id;
    public string Nombre { get; set; } = nombre;
    public string Telefono { get; set; } = telefono;
}