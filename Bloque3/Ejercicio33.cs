namespace TareaProgra1;

// Ejercicio 33. Juego de adivinanza
public class Ejercicio33
{
    public void Ejecutar()
    {
        Random aleatorio = new Random();
        int secreto = aleatorio.Next(1, 101); 

        int maximoIntentos = 7;
        int intentos = 0;
        int pistasMayor = 0;
        int pistasMenor = 0;
        bool adivino = false;

        Console.WriteLine("Adivine el número entre 1 y 100. Tiene 7 intentos.");

        while (intentos < maximoIntentos && !adivino)
        {
            intentos++;
            int numero = LeerEnRango($"Intento {intentos} de {maximoIntentos}. Ingrese un número (1-100): ", 1, 100);

            if (numero == secreto)
            {
                adivino = true;
            }
            else if (numero < secreto)
            {
                Console.WriteLine("Pista: el número secreto es MAYOR.");
                pistasMayor++;
            }
            else
            {
                Console.WriteLine("Pista: el número secreto es MENOR.");
                pistasMenor++;
            }
        }

        Console.WriteLine("----- Estadísticas -----");
        if (adivino)
        {
            Console.WriteLine("¡Felicidades, adivinó el número!");
        }
        else
        {
            Console.WriteLine("Se acabaron los intentos, perdió.");
        }

        Console.WriteLine($"Número secreto: {secreto}");
        Console.WriteLine($"Intentos usados: {intentos}");
        Console.WriteLine($"Intentos restantes: {maximoIntentos - intentos}");
        Console.WriteLine($"Pistas de \"mayor\": {pistasMayor}");
        Console.WriteLine($"Pistas de \"menor\": {pistasMenor}");
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
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
