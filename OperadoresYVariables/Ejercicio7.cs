namespace TareaProgra1;

// Ejercicio 7. Tiempo transcurrido entre dos horas (formato 24h)
public class Ejercicio7
{
    public void Ejecutar()
    {
        Console.WriteLine("----- Primera hora -----");
        int hora1 = LeerEnRango("Hora (0-23): ", 0, 23);
        int minuto1 = LeerEnRango("Minuto (0-59): ", 0, 59);
        int segundo1 = LeerEnRango("Segundo (0-59): ", 0, 59);

        Console.WriteLine("----- Segunda hora -----");
        int hora2 = LeerEnRango("Hora (0-23): ", 0, 23);
        int minuto2 = LeerEnRango("Minuto (0-59): ", 0, 59);
        int segundo2 = LeerEnRango("Segundo (0-59): ", 0, 59);

        // Convertimos cada hora a segundos totales
        int total1 = hora1 * 3600 + minuto1 * 60 + segundo1;
        int total2 = hora2 * 3600 + minuto2 * 60 + segundo2;

        // Diferencia siempre positiva
        int diferencia = total2 - total1;
        if (diferencia < 0)
        {
            diferencia = -diferencia;
        }

        int horas = diferencia / 3600;
        int minutos = (diferencia % 3600) / 60;
        int segundos = diferencia % 60;

        Console.WriteLine($"Primera hora: {hora1:D2}:{minuto1:D2}:{segundo1:D2}");
        Console.WriteLine($"Segunda hora: {hora2:D2}:{minuto2:D2}:{segundo2:D2}");
        Console.WriteLine($"Diferencia: {horas} hora(s), {minutos} minuto(s) y {segundos} segundo(s)");
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }

    // Pide un número entero y repite la pregunta hasta que esté entre el mínimo y el máximo
    private int LeerEnRango(string mensaje, int minimo, int maximo)
    {
        int valor;
        do
        {
            valor = LeerEntero(mensaje);
            if (valor < minimo || valor > maximo)
            {
                Console.WriteLine($"El valor debe estar entre {minimo} y {maximo}, intente de nuevo.");
            }
        } while (valor < minimo || valor > maximo);

        return valor;
    }
}
