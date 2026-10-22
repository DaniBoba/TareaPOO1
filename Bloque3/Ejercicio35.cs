namespace TareaProgra1;

// Ejercicio 35. Patrones en consola
public class Ejercicio35
{
    public void Ejecutar()
    {
        Console.WriteLine("----- Patrones en consola -----");
        Console.WriteLine("1. Triángulo");
        Console.WriteLine("2. Triángulo invertido");
        Console.WriteLine("3. Rombo");
        Console.WriteLine("4. Cuadrado hueco");
        Console.WriteLine("5. Pirámide numérica");
        int opcion = LeerEntero("Elija una opción: ");

        if (opcion < 1 || opcion > 5)
        {
            Console.WriteLine("Opción inválida");
            return; 
        }

        int tamano = LeerEnteroPositivo("Ingrese el tamaño: ");

        switch (opcion)
        {
            case 1:
                Triangulo(tamano);
                break;
            case 2:
                TrianguloInvertido(tamano);
                break;
            case 3:
                Rombo(tamano);
                break;
            case 4:
                CuadradoHueco(tamano);
                break;
            case 5:
                PiramideNumerica(tamano);
                break;
        }
    }

    private void Triangulo(int n)
    {
        for (int fila = 1; fila <= n; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private void TrianguloInvertido(int n)
    {
        for (int fila = n; fila >= 1; fila--)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    private void Rombo(int n)
    {
        for (int fila = 1; fila <= n; fila++)
        {
            Linea(n - fila, 2 * fila - 1);
        }

        for (int fila = n - 1; fila >= 1; fila--)
        {
            Linea(n - fila, 2 * fila - 1);
        }
    }

    private void Linea(int espacios, int asteriscos)
    {
        for (int i = 1; i <= espacios; i++)
        {
            Console.Write(" ");
        }

        for (int i = 1; i <= asteriscos; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }

    private void CuadradoHueco(int n)
    {
        for (int fila = 1; fila <= n; fila++)
        {
            for (int columna = 1; columna <= n; columna++)
            {
                
                if (fila == 1 || fila == n || columna == 1 || columna == n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    private void PiramideNumerica(int n)
    {
        int digitos = n.ToString().Length;

        for (int fila = 1; fila <= n; fila++)
        {
            for (int espacio = 1; espacio <= n - fila; espacio++)
            {
                Console.Write(" ");
            }

            for (int numero = 1; numero <= fila; numero++)
            {
                Console.Write($"{numero.ToString().PadLeft(digitos, '0')}");
                if (numero < fila)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
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
