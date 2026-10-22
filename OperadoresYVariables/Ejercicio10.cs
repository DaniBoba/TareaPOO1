namespace TareaProgra1;

// Ejercicio 10. Calculadora de préstamo simple
public class Ejercicio10
{
    public void Ejecutar()
    {
        double monto = LeerPositivo("Ingrese el monto del préstamo: ");
        double tasaAnual = LeerPositivo("Ingrese la tasa de interés anual (%): ");
        int meses = LeerEnteroPositivo("Ingrese el plazo en meses: ");

        // Interés simple = monto x tasa x tiempo (el tiempo en años)
        double interesTotal = monto * (tasaAnual / 100) * (meses / 12.0);
        double totalPagar = monto + interesTotal;
        double cuota = totalPagar / meses;

        Console.WriteLine($"Interés total: L {interesTotal:F2}");
        Console.WriteLine($"Total a pagar: L {totalPagar:F2}");
        Console.WriteLine($"Cuota mensual fija: L {cuota:F2}");
    }

    // Pide un número decimal. Si no es válido devuelve 0
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }

    // Pide un número y repite la pregunta hasta que sea positivo (mayor que 0)
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

    // Pide un número entero y repite la pregunta hasta que sea positivo (mayor que 0)
    private int LeerEnteroPositivo(string mensaje)
    {
        int valor;
        do
        {
            valor = LeerEntero(mensaje);
            if (valor <= 0)
            {
                Console.WriteLine("El valor debe ser un número entero positivo, intente de nuevo.");
            }
        } while (valor <= 0);

        return valor;
    }
}
