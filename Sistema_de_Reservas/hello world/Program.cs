using Sistema_de_Reservas.Modelos;
using SistemadeResverva.Modelos;


var gestor = new GestorReservas();

// Datos de prueba
var salonPrueba = new Salon(1, "Salón Esmeralda", 100);
var clientePrueba = new Cliente(1, "Juan Pérez", "809-555-0199");
var eventoPrueba = new Evento("Boda", 1500.00m);

DateTime fechaDeseada = DateTime.Now.AddDays(7).Date;

// Crear la reserva
var nuevaReserva = new Reserva(clientePrueba, salonPrueba, eventoPrueba, fechaDeseada, 80);

Console.WriteLine("--- SISTEMA DE RESERVAS ---");

//  Validar capacidad 
if (!nuevaReserva.ValidarCapacidad())
{
    Console.WriteLine("❌ Error: La cantidad de invitados supera la capacidad máxima del salón.");
}
else
{
    //  Intentar registrar en memoria y validar fecha duplicada
    bool guardadoExitoso = gestor.RegistrarReserva(nuevaReserva);

    if (guardadoExitoso)
    {
        Console.WriteLine(" -_- ¡Reserva registrada y guardada con éxito!");
        Console.WriteLine($"Cliente: {nuevaReserva.ClienteReserva.Nombre}");
        Console.WriteLine($"Salón: {nuevaReserva.SalonReservado.Nombre}");
        Console.WriteLine($"Fecha: {nuevaReserva.FechaReserva.ToShortDateString()}");
        Console.WriteLine($"Total a pagar: ${nuevaReserva.CalcularCostoTotal():N2}");
        Console.WriteLine($"Total de reservas en sistema: {gestor.ListaReservas.Count}");
    }
    else
    {
        Console.WriteLine("❌ Error: El salón ya se encuentra reservado para esta fecha.");
    }
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();