namespace TareaProgra1;

// Ejercicio 22. Cajero automático
public class Ejercicio22
{
    public void Ejecutar()
    {
        int saldo = 5000;

        Console.WriteLine($"Saldo disponible: L {saldo}");
        int monto = LeerEnteroPositivo("Ingrese el monto a retirar: ");

        if (monto % 20 != 0)
        {
            Console.WriteLine("El monto debe ser múltiplo de 20.");
            return; 
        }

        if (monto > saldo)
        {
            Console.WriteLine("Fondos insuficientes. El monto excede su saldo.");
            return; 
        }

        int[] billetes = { 500, 100, 20 };
        int restante = monto;

        Console.WriteLine($"Retiro de L {monto}. Billetes entregados:");
        for (int i = 0; i < billetes.Length; i++)
        {
            int cantidad = restante / billetes[i];

            if (cantidad > 0)
            {
                Console.WriteLine($"{cantidad} billete(s) de L {billetes[i]}");
                restante = restante % billetes[i];
            }
        }

        saldo = saldo - monto;
        Console.WriteLine($"Nuevo saldo: L {saldo}");
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