namespace TareaProgra1;

// Ejercicio 26. Potencia con ciclo (sin Math.Pow)
public class Ejercicio26
{
    public void Ejecutar()
    {
        double baseNumero = LeerNumero("Ingrese la base: ");
        int exponente = LeerEntero("Ingrese el exponente (entero, puede ser negativo): ");

        if (baseNumero == 0 && exponente < 0)
        {
            Console.WriteLine("Error: cero elevado a un exponente negativo no está definido.");
            return; 
        }

        int veces = exponente < 0 ? -exponente : exponente;
        double resultado = 1; 

        for (int i = 1; i <= veces; i++)
        {
            resultado = resultado * baseNumero;
        }

        if (exponente < 0)
        {
            resultado = 1 / resultado;
        }

        Console.WriteLine($"{baseNumero} elevado a {exponente} = {resultado}");
    }

    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
