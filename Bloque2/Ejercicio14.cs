namespace TareaProgra1;

// Ejercicio 14. Calculadora con switch
public class Ejercicio14
{
    public void Ejecutar()
    {
        double numero1 = LeerNumero("Ingrese el primer número: ");
        double numero2 = LeerNumero("Ingrese el segundo número: ");

        Console.WriteLine("----- Operaciones -----");
        Console.WriteLine("+  Suma");
        Console.WriteLine("-  Resta");
        Console.WriteLine("*  Multiplicación");
        Console.WriteLine("/  División");
        Console.WriteLine("%  Módulo");
        Console.WriteLine("Ingrese la operación: ");
        string operacion = Console.ReadLine() ?? ""; 

        switch (operacion)
        {
            case "+":
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                break;
            case "-":
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                break;
            case "*":
                Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
                break;
            case "/":
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: no se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                }
                break;
            case "%":
                if (numero2 == 0)
                {
                    Console.WriteLine("Error: no se puede calcular el módulo entre cero.");
                }
                else
                {
                    Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");
                }
                break;
            default:
                Console.WriteLine("Operación inválida");
                break;
        }
    }

   
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }
}
