namespace TareaProgra1;

// Ejercicio 38. Arreglo de nombres
public class Ejercicio38
{
    public void Ejecutar()
    {
        string[] nombres = new string[5];

        // Se llena el arreglo con 5 nombres (no pueden estar vacíos)
        for (int i = 0; i < nombres.Length; i++)
        {
            nombres[i] = LeerTexto($"Ingrese el nombre {i + 1}: ");
        }

        // Nombres en orden inverso: del último índice al primero
        Console.WriteLine("----- Nombres en orden inverso -----");
        for (int i = nombres.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(nombres[i]);
        }

        // Nombre más largo
        string masLargo = nombres[0];
        for (int i = 1; i < nombres.Length; i++)
        {
            if (nombres[i].Length > masLargo.Length)
            {
                masLargo = nombres[i];
            }
        }
        Console.WriteLine($"El nombre más largo es: {masLargo} ({masLargo.Length} caracteres)");

        // Búsqueda de un nombre
        string buscado = LeerTexto("Ingrese el nombre que desea buscar: ");
        bool encontrado = false;

        for (int i = 0; i < nombres.Length; i++)
        {
            // Se pasa todo a minúscula para no distinguir entre mayúsculas y minúsculas
            if (nombres[i].ToLower() == buscado.ToLower())
            {
                Console.WriteLine($"El nombre {nombres[i]} se encontró en la posición {i + 1}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"El nombre {buscado} no se encontró en el arreglo");
        }
    }

    // Pide un texto y repite la pregunta hasta que no esté vacío
    private string LeerTexto(string mensaje)
    {
        string texto;
        do
        {
            Console.WriteLine(mensaje);
            texto = (Console.ReadLine() ?? "").Trim(); // Trim quita los espacios de los lados
            if (texto == "")
            {
                Console.WriteLine("El texto no puede estar vacío, intente de nuevo.");
            }
        } while (texto == "");

        return texto;
    }
}
