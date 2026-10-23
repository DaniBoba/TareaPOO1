namespace TareaProgra1;

// Ejercicio 39. Estadísticas de calificaciones
public class Ejercicio39
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("¿Cuántas calificaciones desea ingresar?: ");
        double[] notas = new double[n];

        // Se llena el arreglo con notas entre 0 y 100
        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LeerEnRango($"Ingrese la calificación {i + 1} (0-100): ", 0, 100);
        }

        double suma = 0;
        double maxima = notas[0];
        double minima = notas[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma = suma + notas[i];

            if (notas[i] > maxima)
            {
                maxima = notas[i];
            }

            if (notas[i] < minima)
            {
                minima = notas[i];
            }

            // En la UNAH se aprueba con 65 o más
            if (notas[i] >= 65)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / notas.Length;

        // Desviación estándar: raíz cuadrada del promedio de las diferencias al cuadrado
        double sumaDiferencias = 0;
        foreach (double nota in notas)
        {
            double diferencia = nota - promedio;
            sumaDiferencias = sumaDiferencias + diferencia * diferencia;
        }
        double desviacion = Math.Sqrt(sumaDiferencias / notas.Length);

        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Calificación máxima: {maxima}");
        Console.WriteLine($"Calificación mínima: {minima}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
        Console.WriteLine($"Desviación estándar: {desviacion:F2}");
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
