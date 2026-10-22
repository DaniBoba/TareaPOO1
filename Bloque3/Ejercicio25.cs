namespace TareaProgra1;

// Ejercicio 25. Promedio con centinela (el centinela es -1)
public class Ejercicio25
{
    public void Ejecutar()
    {
        double suma = 0;
        int cantidad = 0;
        double maximo = 0;
        double minimo = 0;

        double numero = LeerNumero("Ingrese un número (-1 para terminar): ");

        while (numero != -1)
        {
            if (cantidad == 0)
            {
                maximo = numero;
                minimo = numero;
            }
            else
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }
            }

            suma = suma + numero;
            cantidad++;

            numero = LeerNumero("Ingrese un número (-1 para terminar): ");
        }

        if (cantidad == 0)
        {
            Console.WriteLine("No se ingresó ningún número.");
            return; 
        }

        double promedio = suma / cantidad;

        Console.WriteLine($"Cantidad de números: {cantidad}");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Máximo: {maximo}");
        Console.WriteLine($"Mínimo: {minimo}");
    }
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
}