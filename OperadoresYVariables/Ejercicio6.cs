namespace TareaProgra1;

// Ejercicio 6. Suma de dígitos (número de tres dígitos)
public class Ejercicio6
{
    public void Ejecutar()
    {
        int numero = LeerEntero("Ingrese un número entero positivo de tres dígitos: ");

        if (numero < 100 || numero > 999)
        {
            Console.WriteLine("El número debe tener exactamente tres dígitos (100 a 999).");
            return; // Sale del método
        }

        int centenas = numero / 100;          // División entera
        int decenas = (numero / 10) % 10;     // División entera y módulo
        int unidades = numero % 10;           // Módulo
        int suma = centenas + decenas + unidades;

        Console.WriteLine($"Los dígitos de {numero} son: {centenas}, {decenas} y {unidades}");
        Console.WriteLine($"La suma de los dígitos es: {suma}");
    }
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
