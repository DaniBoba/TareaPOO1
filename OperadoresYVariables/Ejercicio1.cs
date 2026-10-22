namespace TareaProgra1;

// Ejercicio 1. Conversor de moneda
public class Ejercicio1
{
    public void Ejecutar()
    {
        double lempiras = LeerPositivo("Ingrese el monto en lempiras: ");
        double tasaDolar = LeerPositivo("Ingrese la tasa del día (lempiras por 1 dólar): ");
        double tasaEuro = LeerPositivo("Ingrese la tasa del día (lempiras por 1 euro): ");

        double dolares = lempiras / tasaDolar;
        double euros = lempiras / tasaEuro;

        Console.WriteLine($"{lempiras:F2} lempiras son {dolares:F2} dólares");
        Console.WriteLine($"{lempiras:F2} lempiras son {euros:F2} euros");
    }

    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
    private double LeerPositivo(string mensaje)
    {
        double valor;
        do
        {
            valor = LeerNumero(mensaje);
            if (valor <= 0)
            {
                Console.WriteLine("El valor debe ser un número positivo, intente de nuevo.");
            }
        } while (valor <= 0);

        return valor;
    }
}
