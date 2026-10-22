namespace TareaProgra1;

// Ejercicio 13. Día de la semana
public class Ejercicio13
{
    public void Ejecutar()
    {
        int numero = LeerEntero("Ingrese un número del 1 al 7: ");

        Console.WriteLine("--- Switch clásico ---");
        switch (numero)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Lunes");
                break;
            case 3:
                Console.WriteLine("Martes");
                break;
            case 4:
                Console.WriteLine("Miércoles");
                break;
            case 5:
                Console.WriteLine("Jueves");
                break;
            case 6:
                Console.WriteLine("Viernes");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Día inválido");
                break;
        }
        Console.WriteLine("--- Switch expression ---");
        string nombreDia = numero switch
        {
            1 => "Domingo",
            2 => "Lunes",
            3 => "Martes",
            4 => "Miércoles",
            5 => "Jueves",
            6 => "Viernes",
            7 => "Sábado",
            _ => "Día inválido"
        };
        Console.WriteLine(nombreDia);
    }
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
