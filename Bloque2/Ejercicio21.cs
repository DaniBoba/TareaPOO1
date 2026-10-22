// Ejercicio 21. Validador de fecha
public class Ejercicio21
{
    public void Ejecutar()
    {
        int dia = LeerEntero("Ingrese el día: ");
        int mes = LeerEntero("Ingrese el mes: ");
        int anio = LeerEntero("Ingrese el año: ");

        bool esValida = anio >= 1 && mes >= 1 && mes <= 12 && dia >= 1 && dia <= DiasDelMes(mes, anio);

        if (esValida)
        {
            Console.WriteLine($"La fecha {dia}/{mes}/{anio} es válida");
        }
        else
        {
            Console.WriteLine($"La fecha {dia}/{mes}/{anio} NO es válida");
        }
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
}
