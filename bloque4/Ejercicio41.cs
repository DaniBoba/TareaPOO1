namespace TareaProgra1;

// Ejercicio 41. Arreglo de temperaturas
public class Ejercicio41
{
    public void Ejecutar()
    {
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        double[] temperaturas = new double[7];

        for (int i = 0; i < temperaturas.Length; i++)
        {
            temperaturas[i] = LeerNumero($"Ingrese la temperatura del {dias[i]} (°C): ");
        }

        // Promedio semanal, día más caluroso y día más frío
        double suma = 0;
        int diaCaluroso = 0;
        int diaFrio = 0;

        for (int i = 0; i < temperaturas.Length; i++)
        {
            suma = suma + temperaturas[i];

            if (temperaturas[i] > temperaturas[diaCaluroso])
            {
                diaCaluroso = i;
            }

            if (temperaturas[i] < temperaturas[diaFrio])
            {
                diaFrio = i;
            }
        }

        double promedio = suma / temperaturas.Length;

        Console.WriteLine($"Promedio semanal: {promedio:F2} °C");

        // Días con temperatura sobre el promedio
        Console.WriteLine("Días sobre el promedio:");
        int cantidadSobre = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > promedio)
            {
                Console.WriteLine($"- {dias[i]}: {temperaturas[i]:F2} °C");
                cantidadSobre++;
            }
        }

        if (cantidadSobre == 0)
        {
            Console.WriteLine("Ningún día estuvo sobre el promedio");
        }

        Console.WriteLine($"Día más caluroso: {dias[diaCaluroso]} ({temperaturas[diaCaluroso]:F2} °C)");
        Console.WriteLine($"Día más frío: {dias[diaFrio]} ({temperaturas[diaFrio]:F2} °C)");

        // Variación entre días consecutivos: temperatura de hoy menos la de ayer
        Console.WriteLine("Variación entre días consecutivos:");
        for (int i = 1; i < temperaturas.Length; i++)
        {
            double variacion = temperaturas[i] - temperaturas[i - 1];
            string signo = variacion > 0 ? "+" : "";
            Console.WriteLine($"{dias[i - 1]} a {dias[i]}: {signo}{variacion:F2} °C");
        }
    }

    // Pide un número decimal. Si no es válido devuelve 0
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
}
