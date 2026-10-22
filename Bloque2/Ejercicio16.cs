namespace TareaProgra1;

// Ejercicio 16. Sistema de calificaciones UNAH
public class Ejercicio16
{
    public void Ejecutar()
    {
        double nota = LeerEnRango("Ingrese la nota (0-100): ", 0, 100);

        string letra;
        string descripcion;

        if (nota >= 90)
        {
            letra = "A";
            descripcion = "Sobresaliente";
        }
        else if (nota >= 80)
        {
            letra = "B";
            descripcion = "Muy bueno";
        }
        else if (nota >= 70)
        {
            letra = "C";
            descripcion = "Bueno";
        }
        else if (nota >= 65)
        {
            letra = "D";
            descripcion = "Regular";
        }
        else
        {
            letra = "F";
            descripcion = "Deficiente";
        }

        
        string resultado = (nota >= 65) ? "Aprobó" : "Reprobó";

        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Letra: {letra}");
        Console.WriteLine($"Descripción: {descripcion}");
        Console.WriteLine($"Resultado: {resultado}");
    }

    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
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
