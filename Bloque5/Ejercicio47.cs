namespace TareaProgra1;

// Ejercicio 47. Registro de calificaciones
public class Ejercicio47
{
    public void Ejecutar()
    {
        List<double> notas = new List<double>();
        string respuesta;

        // Se piden notas hasta que el usuario decida parar
        do
        {
            double nuevaNota = LeerEnRango($"Ingrese la nota {notas.Count + 1} (0-100): ", 0, 100);
            notas.Add(nuevaNota);

            respuesta = LeerSiNo("¿Desea ingresar otra nota? (s/n): ");
        } while (respuesta == "s");

        // Promedio, nota máxima y nota mínima
        double promedio = CalcularPromedio(notas);
        double maxima = notas[0];
        double minima = notas[0];

        foreach (double valor in notas)
        {
            if (valor > maxima)
            {
                maxima = valor;
            }

            if (valor < minima)
            {
                minima = valor;
            }
        }

        Console.WriteLine($"Cantidad de notas: {notas.Count}");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Nota máxima: {maxima}");
        Console.WriteLine($"Nota mínima: {minima}");

        // Se elimina la nota más baja (si se repite, Remove quita solo la primera)
        notas.Remove(minima);
        Console.WriteLine($"Se eliminó la nota más baja: {minima}");

        if (notas.Count == 0)
        {
            Console.WriteLine("Ya no quedan notas para calcular el promedio.");
        }
        else
        {
            Console.WriteLine($"Nuevo promedio: {CalcularPromedio(notas):F2}");
        }
    }

    // Devuelve el promedio de las notas de la lista
    private double CalcularPromedio(List<double> notas)
    {
        double suma = 0;

        foreach (double valor in notas)
        {
            suma = suma + valor;
        }

        return suma / notas.Count;
    }

    // Pide un número decimal. Si no es válido devuelve 0
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
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

    // Pregunta y repite hasta que la respuesta sea "s" o "n"
    private string LeerSiNo(string mensaje)
    {
        string respuesta;
        do
        {
            Console.WriteLine(mensaje);
            respuesta = (Console.ReadLine() ?? "").Trim().ToLower();
            if (respuesta != "s" && respuesta != "n")
            {
                Console.WriteLine("Responda con s (sí) o n (no).");
            }
        } while (respuesta != "s" && respuesta != "n");

        return respuesta;
    }
}
