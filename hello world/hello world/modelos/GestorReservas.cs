using SistemadeResverva.Modelos;

namespace Sistema_de_Reservas.Modelos;

public class GestorReservas
{
    public List<Reserva> ListaReservas { get; set; } = [];

    // Método para agregar reserva validando que el salón no esté ocupado en la misma fecha
    public bool RegistrarReserva(Reserva nuevaReserva)
    {
        bool salonOcupado = ListaReservas.Any(r =>
            r.SalonReservado.Id == nuevaReserva.SalonReservado.Id &&
            r.FechaReserva.Date == nuevaReserva.FechaReserva.Date);

        if (salonOcupado)
        {
            return false; // Ya está reservado
        }

        ListaReservas.Add(nuevaReserva);
        return true;
    }
}}
