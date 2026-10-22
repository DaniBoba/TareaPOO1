namespace TareaProgra1;

// Ejercicio 5. Conversión de temperatura
public class Ejercicio5
{
    public void Ejecutar()
    {
        Console.WriteLine("----- Conversión de temperatura -----");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Celsius a Kelvin");
        Console.WriteLine("3. Fahrenheit a Celsius");
        Console.WriteLine("4. Fahrenheit a Kelvin");
        Console.WriteLine("5. Kelvin a Celsius");
        Console.WriteLine("6. Kelvin a Fahrenheit");
        int opcion = LeerEntero("Elija la conversión: ");

        if (opcion < 1 || opcion > 6)
        {
            Console.WriteLine("Opción inválida");
            return; // Sale del método
        }

        double temperatura = LeerNumero("Ingrese la temperatura: ");
        double resultado;

        switch (opcion)
        {
            case 1:
                resultado = temperatura * 9 / 5 + 32;
                Console.WriteLine($"{temperatura:F2} °C = {resultado:F2} °F");
                break;
            case 2:
                resultado = temperatura + 273.15;
                Console.WriteLine($"{temperatura:F2} °C = {resultado:F2} K");
                break;
            case 3:
                resultado = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura:F2} °F = {resultado:F2} °C");
                break;
            case 4:
                resultado = (temperatura - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{temperatura:F2} °F = {resultado:F2} K");
                break;
            case 5:
                resultado = temperatura - 273.15;
                Console.WriteLine($"{temperatura:F2} K = {resultado:F2} °C");
                break;
            case 6:
                resultado = (temperatura - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{temperatura:F2} K = {resultado:F2} °F");
                break;
        }
    }
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
}
