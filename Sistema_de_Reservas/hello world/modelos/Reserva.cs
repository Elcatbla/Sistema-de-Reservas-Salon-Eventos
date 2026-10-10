namespace SistemadeResverva.Modelos;

public class Reserva(Cliente cliente, Salon salon, Evento evento, DateTime fecha, int invitados)
{
    public Cliente ClienteReserva { get; set; } = cliente;
    public Salon SalonReservado { get; set; } = salon;
    public Evento EventoReservado { get; set; } = evento;
    public DateTime FechaReserva { get; set; } = fecha;
    public int CantidadInvitados { get; set; } = invitados;

    public bool ValidarCapacidad() => CantidadInvitados <= SalonReservado.CapacidadMaxima;

    public decimal CalcularCostoTotal()
    {
        decimal costoPorInvitado = 50.0m;
        return EventoReservado.CostoBase + (CantidadInvitados * costoPorInvitado);
    }
}