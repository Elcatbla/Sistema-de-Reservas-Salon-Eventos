namespace SistemadeResverva.Modelos;

public class Evento(string tipoEvento, decimal costoBase)
{
    public string TipoEvento { get; set; } = tipoEvento;
    public decimal CostoBase { get; set; } = costoBase;
}