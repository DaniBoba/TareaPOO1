namespace TareaProgra1;

// Ejercicio 20. Año bisiesto y días del mes
public class Ejercicio20
{
    public void Ejecutar()
    {
        int anio = LeerEnteroPositivo("Ingrese el año: ");
        int mes = LeerEnRango("Ingrese el mes (1-12): ", 1, 12);

        bool esBisiesto = EsBisiesto(anio);
        int dias = DiasDelMes(mes, anio);

        string textoBisiesto = esBisiesto ? "es bisiesto" : "no es bisiesto";

        Console.WriteLine($"El año {anio} {textoBisiesto}");
        Console.WriteLine($"El mes {mes} del año {anio} tiene {dias} días");
    }
    private bool EsBisiesto(int anio)
    {
        return (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;
    }
    private int DiasDelMes(int mes, int anio)
    {
        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return EsBisiesto(anio) ? 29 : 28;
            default:
                return 0;
        }
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
