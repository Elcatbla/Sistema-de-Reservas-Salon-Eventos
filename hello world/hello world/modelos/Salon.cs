namespace SistemadeResverva.Modelos;

public class Salon(int id, string nombre, int capacidadMaxima)
{
    public int Id { get; set; } = id;
    public string Nombre { get; set; } = nombre;
    public int CapacidadMaxima { get; set; } = capacidadMaxima;
}