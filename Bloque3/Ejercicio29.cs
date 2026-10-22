namespace TareaProgra1;

// Ejercicio 29. Serie Fibonacci
public class Ejercicio29
{
    public void Ejecutar()
    {
        int n = LeerEnRango("¿Cuántos términos desea? (1-90): ", 1, 90);

        long anterior = 0;
        long actual = 1;
        long suma = 0;

        Console.WriteLine($"Los primeros {n} términos de Fibonacci:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(anterior);
            if (i < n)
            {
                Console.Write(", ");
            }

            suma = suma + anterior;

            long siguiente = anterior + actual;
            anterior = actual;
            actual = siguiente;
        }
        Console.WriteLine();

        double promedio = (double)suma / n;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio:F2}");
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
