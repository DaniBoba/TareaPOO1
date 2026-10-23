namespace TareaProgra1;

// Ejercicio 42. Búsqueda y ordenamiento
public class Ejercicio42
{
    public void Ejecutar()
    {
        int[] numeros = new int[10];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = LeerEntero($"Ingrese el número {i + 1}: ");
        }

        Console.Write("Arreglo original: ");
        Mostrar(numeros);

        // 1. Búsqueda lineal: se recorre el arreglo comparando uno por uno
        int buscado = LeerEntero("Ingrese el número que desea buscar: ");
        int veces = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
                Console.WriteLine($"El número {buscado} se encontró en la posición {i + 1}");
                veces++;
            }
        }

        if (veces == 0)
        {
            Console.WriteLine($"El número {buscado} no se encontró");
        }

        // 2. Segundo mayor (distinto del mayor)
        int mayor = numeros[0];
        int segundoMayor = 0;
        bool haySegundo = false;

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                segundoMayor = mayor;
                haySegundo = true;
                mayor = numeros[i];
            }
            else if (numeros[i] < mayor && (!haySegundo || numeros[i] > segundoMayor))
            {
                segundoMayor = numeros[i];
                haySegundo = true;
            }
        }

        if (haySegundo)
        {
            Console.WriteLine($"El mayor es {mayor} y el segundo mayor es {segundoMayor}");
        }
        else
        {
            Console.WriteLine("No hay segundo mayor: todos los números son iguales");
        }

        // 3. Ordenamiento burbuja ascendente (se ordena una copia para no perder el original)
        int[] ordenado = new int[numeros.Length];
        for (int i = 0; i < numeros.Length; i++)
        {
            ordenado[i] = numeros[i];
        }

        for (int i = 0; i < ordenado.Length - 1; i++)
        {
            for (int j = 0; j < ordenado.Length - 1 - i; j++)
            {
                // Si el de la izquierda es mayor que el de la derecha, se intercambian
                if (ordenado[j] > ordenado[j + 1])
                {
                    int temporal = ordenado[j];
                    ordenado[j] = ordenado[j + 1];
                    ordenado[j + 1] = temporal;
                }
            }
        }

        Console.Write("Arreglo ordenado (ascendente): ");
        Mostrar(ordenado);

        // 4. Elementos en posiciones pares (índices 0, 2, 4, 6 y 8 del arreglo original)
        Console.WriteLine("Elementos en posiciones pares (índices 0, 2, 4...):");
        for (int i = 0; i < numeros.Length; i += 2)
        {
            Console.WriteLine($"Posición {i}: {numeros[i]}");
        }
    }

    // Muestra los elementos del arreglo separados por comas
    private void Mostrar(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i]);
            if (i < arreglo.Length - 1)
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
