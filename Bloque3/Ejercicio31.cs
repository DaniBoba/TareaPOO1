namespace TareaProgra1;

// Ejercicio 31. MCD y MCM
public class Ejercicio31
{
    public void Ejecutar()
    {
        int numero1 = LeerEnteroPositivo("Ingrese el primer número: ");
        int numero2 = LeerEnteroPositivo("Ingrese el segundo número: ");

        int a = numero1;
        int b = numero2;

        while (b != 0)
        {
            int residuo = a % b;
            a = b;
            b = residuo;
        }

        int mcd = a;

        long mcm = (long)numero1 / mcd * numero2;

        Console.WriteLine($"MCD de {numero1} y {numero2} = {mcd}");
        Console.WriteLine($"MCM de {numero1} y {numero2} = {mcm}");
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
