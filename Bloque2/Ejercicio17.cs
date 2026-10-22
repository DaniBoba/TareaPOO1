namespace TareaProgra1;

// Ejercicio 17. Calculadora de descuentos
public class Ejercicio17
{
    public void Ejecutar()
    {
        double monto = LeerPositivo("Ingrese el monto de la compra en lempiras: ");

        double porcentaje;

        if (monto >= 2500)
        {
            porcentaje = 15;
        }
        else if (monto >= 1000)
        {
            porcentaje = 10;
        }
        else if (monto >= 500)
        {
            porcentaje = 5;
        }
        else
        {
            porcentaje = 0;
        }

        double descuento = monto * porcentaje / 100;
        double precioFinal = monto - descuento;

        Console.WriteLine($"Precio original: L {monto:F2}");
        Console.WriteLine($"Descuento ({porcentaje}%): L {descuento:F2}");
        Console.WriteLine($"Precio final: L {precioFinal:F2}");
    }
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
    private double LeerPositivo(string mensaje)
    {
        double valor;
        do
        {
            valor = LeerNumero(mensaje);
            if (valor <= 0)
            {
                Console.WriteLine("El valor debe ser un número positivo, intente de nuevo.");
            }
        } while (valor <= 0);

        return valor;
    }
}