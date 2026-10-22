namespace TareaProgra1;

// Ejercicio 8. Desglose de billetes
public class Ejercicio8
{
    public void Ejecutar()
    {
        int monto = LeerEnteroPositivo("Ingrese el monto en lempiras (número entero): ");
        int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
        int restante = monto;

        Console.WriteLine($"Desglose de L {monto}:");
        for (int i = 0; i < billetes.Length; i++)
        {
            int cantidad = restante / billetes[i];

            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} billete(s) de L {billetes[i]}");
                restante = restante % billetes[i];
            }
        }
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
