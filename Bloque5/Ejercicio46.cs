namespace TareaProgra1;

// Ejercicio 46. Lista de compras
public class Ejercicio46
{
    public void Ejecutar()
    {
        List<string> compras = new List<string>();
        int opcion;
        string producto;
        int posicion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("----- Lista de compras -----");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Mostrar lista ordenada alfabéticamente");
            Console.WriteLine("5. Salir");
            opcion = LeerEntero("Elija una opción: ");

            switch (opcion)
            {
                case 1:
                    producto = LeerTexto("Ingrese el producto: ");

                    // Contains revisa si el producto ya está en la lista
                    if (compras.Contains(producto))
                    {
                        Console.WriteLine($"El producto {producto} ya está en la lista, no se agregó.");
                    }
                    else
                    {
                        compras.Add(producto);
                        Console.WriteLine($"Se agregó {producto}");
                    }
                    break;
                case 2:
                    producto = LeerTexto("Ingrese el producto que desea eliminar: ");

                    if (compras.Contains(producto))
                    {
                        compras.Remove(producto);
                        Console.WriteLine($"Se eliminó {producto}");
                    }
                    else
                    {
                        Console.WriteLine($"El producto {producto} no está en la lista.");
                    }
                    break;
                case 3:
                    producto = LeerTexto("Ingrese el producto que desea buscar: ");

                    if (compras.Contains(producto))
                    {
                        posicion = compras.IndexOf(producto) + 1; // IndexOf empieza en 0
                        Console.WriteLine($"El producto {producto} está en la lista, en la posición {posicion}");
                    }
                    else
                    {
                        Console.WriteLine($"El producto {producto} no está en la lista.");
                    }
                    break;
                case 4:
                    if (compras.Count == 0)
                    {
                        Console.WriteLine("La lista está vacía.");
                    }
                    else
                    {
                        compras.Sort(); // Ordena de la A a la Z
                        Console.WriteLine("Lista ordenada alfabéticamente:");
                        foreach (string item in compras)
                        {
                            Console.WriteLine($"- {item}");
                        }
                        Console.WriteLine($"Total de productos: {compras.Count}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Hasta luego");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 5);
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
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
