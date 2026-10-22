namespace TareaProgra1;

// Ejercicio 27. Inversión de número y palíndromo (capicúa)
public class Ejercicio27
{
    public void Ejecutar()
    {
        int numero = LeerEnteroPositivo("Ingrese un número entero positivo: ");

        int copia = numero;
        long invertido = 0;

        while (copia > 0)
        {
            int digito = copia % 10;                 
            invertido = invertido * 10 + digito;     
            copia = copia / 10;                   
        }

        Console.WriteLine($"Número original: {numero}");
        Console.WriteLine($"Número invertido: {invertido}");

        if (invertido == numero)
        {
            Console.WriteLine("El número es palíndromo (capicúa)");
        }
        else
        {
            Console.WriteLine("El número no es palíndromo");
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
