namespace TareaProgra1;

// Ejercicio 23. Tabla de multiplicar extendida
public class Ejercicio23
{
    public void Ejecutar()
    {
        int numero = LeerEntero("Ingrese un número: ");
        int ancho = (numero * 12).ToString().Length;

        Console.WriteLine($"----- Tabla del {numero} -----");
        for (int i = 1; i <= 12; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i.ToString().PadLeft(2)} = {resultado.ToString().PadLeft(ancho)}");
        }
    }
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
    }
