
Console.WriteLine("=== SISTEMA DE TRADING ===");

decimal capital = 10000m;

Console.WriteLine($"Capital inicial: ${capital:N2}");

Console.Write("Introduce el resultado de tu operación: ");

if (decimal.TryParse(Console.ReadLine(), out decimal resultado))
{
    capital += resultado;

    Console.WriteLine($"\nNuevo balance: ${capital:N2}");

    if (resultado > 0)
    {
        Console.WriteLine("Operación ganadora.");
    }
    else if (resultado < 0)
    {
        Console.WriteLine("Operación perdedora.");
    }
    else
    {
        Console.WriteLine("Operación en breakeven.");
    }
}
else
{
    Console.WriteLine("Error: introduce un número válido.");
}