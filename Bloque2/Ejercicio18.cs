namespace TareaProgra1;

// Ejercicio 18. Tarifa de estacionamiento
public class Ejercicio18
{
    public void Ejecutar()
    {
        int horas = LeerEnteroPositivo("Ingrese las horas estacionado: ");
        int pago = 20 + (horas - 1) * 10;

        Console.WriteLine($"Horas estacionado: {horas}");
        Console.WriteLine($"Cálculo sin tope: L {pago}");
        if (pago > 100)
        {
            pago = 100;
            Console.WriteLine("Se aplicó el tope máximo diario de L 100");
        }

        Console.WriteLine($"Total a pagar: L {pago}");
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
