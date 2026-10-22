namespace TareaProgra1;

// Ejercicio 28. Decimal a binario
public class Ejercicio28
{
    public void Ejecutar()
    {
        int numero = LeerEnteroPositivo("Ingrese un número entero positivo: ");

        int copia = numero;
        string binario = "";

        while (copia > 0)
        {
            int residuo = copia % 2;
            binario = $"{residuo}{binario}";
            copia = copia / 2;
        }

        Console.WriteLine($"El número {numero} en binario es: {binario}");
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
