namespace TareaProgra1;

// Ejercicio 3. Intercambio de valores
public class Ejercicio3
{
   
    public void Ejecutar()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");

        int temporal = a;
        a = b;
        b = temporal;

        Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
    }

    public void EjecutarReto()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"Antes del intercambio: a = {a}, b = {b}");

        a = a + b;  
        b = a - b;  
        a = a - b; 

        Console.WriteLine($"Después del intercambio: a = {a}, b = {b}");
    }
}
