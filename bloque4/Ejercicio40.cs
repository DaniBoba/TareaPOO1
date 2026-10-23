namespace TareaProgra1;

// Ejercicio 40. Frecuencia de elementos
public class Ejercicio40
{
    public void Ejecutar()
    {
        Random aleatorio = new Random();
        int[] numeros = new int[20];

        // 20 números aleatorios entre 1 y 10
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = aleatorio.Next(1, 11);
        }

        Console.WriteLine("Números generados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]} ");
        }
        Console.WriteLine();

        // frecuencia[3] guarda cuántas veces salió el 3 (la posición 0 no se usa)
        int[] frecuencia = new int[11];
        foreach (int numero in numeros)
        {
            frecuencia[numero]++;
        }

        Console.WriteLine("----- Frecuencia de cada número -----");
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine($"El número {numero.ToString().PadLeft(2)} salió {frecuencia[numero]} vez/veces");
        }

        // Mayor y menor frecuencia
        int mayorFrecuencia = frecuencia[1];
        int menorFrecuencia = frecuencia[1];
        for (int numero = 2; numero <= 10; numero++)
        {
            if (frecuencia[numero] > mayorFrecuencia)
            {
                mayorFrecuencia = frecuencia[numero];
            }

            if (frecuencia[numero] < menorFrecuencia)
            {
                menorFrecuencia = frecuencia[numero];
            }
        }

        // Se muestran todos los números que tengan esa frecuencia (por si hay empates)
        Console.Write($"Más frecuente ({mayorFrecuencia} veces): ");
        for (int numero = 1; numero <= 10; numero++)
        {
            if (frecuencia[numero] == mayorFrecuencia)
            {
                Console.Write($"{numero} ");
            }
        }
        Console.WriteLine();

        Console.Write($"Menos frecuente ({menorFrecuencia} veces): ");
        for (int numero = 1; numero <= 10; numero++)
        {
            if (frecuencia[numero] == menorFrecuencia)
            {
                Console.Write($"{numero} ");
            }
        }
        Console.WriteLine();
    }
}
