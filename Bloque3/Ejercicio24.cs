namespace TareaProgra1;

// Ejercicio 24. Suma de pares e impares
public class Ejercicio24
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("Ingrese el valor de N: ");

        long sumaPares = 0;
        long sumaImpares = 0;
        int cantidadPares = 0;
        int cantidadImpares = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sumaPares = sumaPares + i;
                cantidadPares++;
            }
            else
            {
                sumaImpares = sumaImpares + i;
                cantidadImpares++;
            }
        }

        Console.WriteLine($"Números del 1 al {n}");
        Console.WriteLine($"Pares: {cantidadPares} números, suma = {sumaPares}");
        Console.WriteLine($"Impares: {cantidadImpares} números, suma = {sumaImpares}");
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
