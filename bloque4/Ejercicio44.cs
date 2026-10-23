namespace TareaProgra1;

// Ejercicio 44. Histograma de calificaciones
public class Ejercicio44
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("¿Cuántas calificaciones desea ingresar?: ");
        double[] notas = new double[n];

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LeerEnRango($"Ingrese la calificación {i + 1} (0-100): ", 0, 100);
        }

        // conteo[0] cuenta el rango 0-59, conteo[1] el rango 60-69 y así sucesivamente
        string[] rangos = { "0-59", "60-69", "70-79", "80-89", "90-100" };
        int[] conteo = new int[5];

        foreach (double nota in notas)
        {
            if (nota < 60)
            {
                conteo[0]++;
            }
            else if (nota < 70)
            {
                conteo[1]++;
            }
            else if (nota < 80)
            {
                conteo[2]++;
            }
            else if (nota < 90)
            {
                conteo[3]++;
            }
            else
            {
                conteo[4]++;
            }
        }

        // Histograma: una barra de asteriscos por cada rango
        Console.WriteLine("----- Histograma de calificaciones -----");
        for (int i = 0; i < rangos.Length; i++)
        {
            Console.Write($"{rangos[i].PadRight(7)}| ");

            for (int j = 1; j <= conteo[i]; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine($" ({conteo[i]})");
        }
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

    // Pide un número y repite la pregunta hasta que esté entre el mínimo y el máximo
    private double LeerEnRango(string mensaje, double minimo, double maximo)
    {
        double valor;
        do
        {
            valor = LeerNumero(mensaje);
            if (valor < minimo || valor > maximo)
            {
                Console.WriteLine($"El valor debe estar entre {minimo} y {maximo}, intente de nuevo.");
            }
        } while (valor < minimo || valor > maximo);

        return valor;
    }
}
