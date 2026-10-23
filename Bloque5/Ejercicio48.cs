namespace TareaProgra1;

// Ejercicio 48. Números únicos
public class Ejercicio48
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("¿Cuántos números desea ingresar?: ");

        List<int> unicos = new List<int>();
        int descartados = 0;

        for (int i = 1; i <= n; i++)
        {
            int numero = LeerEntero($"Ingrese el número {i}: ");

            // Solo se agrega si todavía no está en la lista
            if (unicos.Contains(numero))
            {
                Console.WriteLine($"El número {numero} ya existe, se descartó.");
                descartados++;
            }
            else
            {
                unicos.Add(numero);
            }
        }

        Console.WriteLine("Lista resultante:");
        for (int i = 0; i < unicos.Count; i++)
        {
            Console.Write(unicos[i]);
            if (i < unicos.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        Console.WriteLine($"Números únicos: {unicos.Count}");
        Console.WriteLine($"Duplicados descartados: {descartados}");
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }

    // Pide un número entero y repite la pregunta hasta que sea positivo (mayor que 0)
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
}
