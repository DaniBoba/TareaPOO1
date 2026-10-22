namespace TareaProgra1;

// Ejercicio 11. Positivo, negativo o cero
public class Ejercicio11
{
    public void Ejecutar()
    {
        int numero = LeerEntero("Ingrese un número entero: ");

        if (numero > 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else
        {
            Console.WriteLine("El número es cero");
        }

        // Operador ternario: par o impar
        string paridad = (numero % 2 == 0) ? "par" : "impar";
        Console.WriteLine($"El número es {paridad}");
    }
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
