namespace TareaProgra1;

// Ejercicio 12. Mayor de tres números
public class Ejercicio12
{
    public void Ejecutar()
    {
        double n1 = LeerNumero("Ingrese el primer número: ");
        double n2 = LeerNumero("Ingrese el segundo número: ");
        double n3 = LeerNumero("Ingrese el tercer número: ");

        
        if (n1 == n2 || n1 == n3 || n2 == n3)
        {
            Console.WriteLine("Los tres números deben ser diferentes.");
            return; 
        }

        double mayor;
        double menor;

        
        if (n1 > n2 && n1 > n3)
        {
            mayor = n1;
        }
        else if (n2 > n1 && n2 > n3)
        {
            mayor = n2;
        }
        else
        {
            mayor = n3;
        }

        if (n1 < n2 && n1 < n3)
        {
            menor = n1;
        }
        else if (n2 < n1 && n2 < n3)
        {
            menor = n2;
        }
        else
        {
            menor = n3;
        }

        Console.WriteLine($"El mayor es: {mayor}");
        Console.WriteLine($"El menor es: {menor}");
    }
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
}

