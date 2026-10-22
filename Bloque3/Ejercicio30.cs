namespace TareaProgra1;

// Ejercicio 30. Factorial y combinaciones
public class Ejercicio30
{
    public void Ejecutar()
    {
        
        int n = LeerEnRango("Ingrese N para calcular el factorial (0-20): ", 0, 20);

        long factorialN = Factorial(n);
        Console.WriteLine($"{n}! = {factorialN}");

        int r = LeerEnRango($"Ingrese r para calcular C({n}, r) (0-{n}): ", 0, n);

        long combinaciones = factorialN / (Factorial(r) * Factorial(n - r));

        Console.WriteLine($"C({n}, {r}) = {combinaciones}");
    }

    private long Factorial(int n)
    {
        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado = resultado * i;
        }

        return resultado;
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
    private int LeerEnRango(string mensaje, int minimo, int maximo)
    {
        int valor;
        do
        {
            valor = LeerEntero(mensaje);
            if (valor < minimo || valor > maximo)
            {
                Console.WriteLine($"El valor debe estar entre {minimo} y {maximo}, intente de nuevo.");
            }
        } while (valor < minimo || valor > maximo);

        return valor;
    }
}
