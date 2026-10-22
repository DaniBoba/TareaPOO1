namespace TareaProgra1;

// Ejercicio 9. Cálculo de salario semanal
public class Ejercicio9
{
    public void Ejecutar()
    {
        double horas = LeerPositivo("Ingrese las horas trabajadas: ");
        double tarifa = LeerPositivo("Ingrese la tarifa por hora: ");

        // Las primeras 44 horas son normales, el resto son horas extras
        double horasNormales = horas > 44 ? 44 : horas;
        double horasExtras = horas > 44 ? horas - 44 : 0;

        double pagoNormal = horasNormales * tarifa;
        double pagoExtra = horasExtras * tarifa * 1.5;   // 150%
        double total = pagoNormal + pagoExtra;

        Console.WriteLine($"Horas normales: {horasNormales:F2} x L {tarifa:F2} = L {pagoNormal:F2}");
        Console.WriteLine($"Horas extras: {horasExtras:F2} x L {tarifa * 1.5:F2} = L {pagoExtra:F2}");
        Console.WriteLine($"Salario total de la semana: L {total:F2}");
    }

    // Pide un número decimal. Si no es válido devuelve 0
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
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
}
