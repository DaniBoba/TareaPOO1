namespace TareaProgra1;

// Ejercicio 32. Números primos en un rango
public class Ejercicio32
{
    public void Ejecutar()
    {
        int inicio = LeerEnteroPositivo("Ingrese el inicio del rango: ");
        int fin = LeerEnteroPositivo("Ingrese el fin del rango: ");

        if (inicio > fin)
        {
            Console.WriteLine("El inicio no puede ser mayor que el fin.");
            return; 
        }

        int contador = 0;

        Console.WriteLine($"Números primos entre {inicio} y {fin}:");
        for (int numero = inicio; numero <= fin; numero++)
        {
            if (EsPrimo(numero))
            {
                Console.Write($"{numero} ");
                contador++;
            }
        }
        Console.WriteLine();

        Console.WriteLine($"Total de números primos: {contador}");
    }

    private bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= numero / divisor; divisor++)
        {
            if (numero % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
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
