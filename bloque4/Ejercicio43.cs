namespace TareaProgra1;

// Ejercicio 43. Rotación de arreglo
public class Ejercicio43
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("Ingrese la cantidad de elementos del arreglo: ");
        int[] arreglo = new int[n];

        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = LeerEntero($"Ingrese el elemento {i + 1}: ");
        }

        int opcion;
        int k;

        do
        {
            Console.WriteLine();
            Console.Write("Arreglo actual: ");
            Mostrar(arreglo);
            Console.WriteLine("----- Menú -----");
            Console.WriteLine("1. Rotar K posiciones a la izquierda");
            Console.WriteLine("2. Rotar K posiciones a la derecha");
            Console.WriteLine("3. Invertir el arreglo");
            Console.WriteLine("4. Salir");
            opcion = LeerEntero("Elija una opción: ");

            switch (opcion)
            {
                case 1:
                    k = LeerEnteroPositivo("¿Cuántas posiciones (K)?: ");
                    RotarIzquierda(arreglo, k);
                    Console.Write("Resultado: ");
                    Mostrar(arreglo);
                    break;
                case 2:
                    k = LeerEnteroPositivo("¿Cuántas posiciones (K)?: ");
                    RotarDerecha(arreglo, k);
                    Console.Write("Resultado: ");
                    Mostrar(arreglo);
                    break;
                case 3:
                    Invertir(arreglo);
                    Console.Write("Resultado: ");
                    Mostrar(arreglo);
                    break;
                case 4:
                    Console.WriteLine("Hasta luego");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 4);
    }

    // Rota el arreglo K posiciones a la izquierda: el primero pasa al final, K veces
    private void RotarIzquierda(int[] arreglo, int k)
    {
        // Rotar el largo del arreglo da el mismo arreglo, por eso se usa el residuo
        int veces = k % arreglo.Length;

        for (int v = 1; v <= veces; v++)
        {
            int primero = arreglo[0];

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                arreglo[i] = arreglo[i + 1];
            }

            arreglo[arreglo.Length - 1] = primero;
        }
    }

    // Rota el arreglo K posiciones a la derecha: el último pasa al inicio, K veces
    private void RotarDerecha(int[] arreglo, int k)
    {
        int veces = k % arreglo.Length;

        for (int v = 1; v <= veces; v++)
        {
            int ultimo = arreglo[arreglo.Length - 1];

            for (int i = arreglo.Length - 1; i >= 1; i--)
            {
                arreglo[i] = arreglo[i - 1];
            }

            arreglo[0] = ultimo;
        }
    }

    // Invierte el arreglo intercambiando el primero con el último, el segundo con el penúltimo...
    private void Invertir(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length / 2; i++)
        {
            int temporal = arreglo[i];
            arreglo[i] = arreglo[arreglo.Length - 1 - i];
            arreglo[arreglo.Length - 1 - i] = temporal;
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
}
