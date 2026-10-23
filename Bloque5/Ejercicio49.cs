namespace TareaProgra1;

// Ejercicio 49. Separar pares e impares
public class Ejercicio49
{
    public void Ejecutar()
    {
        List<int> numeros = new List<int>();

        // Se llena la lista con 15 números enteros
        for (int i = 1; i <= 15; i++)
        {
            numeros.Add(LeerEntero($"Ingrese el número {i}: "));
        }

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        // Se recorre la lista y cada número va a la lista que le corresponde
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                pares.Add(numero);
            }
            else
            {
                impares.Add(numero);
            }
        }

        // Se ordenan de menor a mayor
        pares.Sort();
        impares.Sort();

        Console.Write($"Pares ordenados ({pares.Count}): ");
        Mostrar(pares);

        Console.Write($"Impares ordenados ({impares.Count}): ");
        Mostrar(impares);
    }

    // Muestra los elementos de la lista separados por comas
    private void Mostrar(List<int> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("(ninguno)");
            return; // Sale del método
        }

        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i]);
            if (i < lista.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
