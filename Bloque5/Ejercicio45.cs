namespace TareaProgra1;

// Ejercicio 45. Lista de tareas pendientes
public class Ejercicio45
{
    public void Ejecutar()
    {
        List<string> tareas = new List<string>();
        int opcion;
        string tarea;
        string eliminada;
        int numero;

        do
        {
            Console.WriteLine();
            Console.WriteLine("----- Tareas pendientes -----");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Mostrar todas las tareas");
            Console.WriteLine("3. Eliminar una tarea por su número");
            Console.WriteLine("4. Mostrar el total de tareas pendientes");
            Console.WriteLine("5. Salir");
            opcion = LeerEntero("Elija una opción: ");

            switch (opcion)
            {
                case 1:
                    tarea = LeerTexto("Ingrese la tarea: ");
                    tareas.Add(tarea);
                    Console.WriteLine("Tarea agregada");
                    break;
                case 2:
                    Mostrar(tareas);
                    break;
                case 3:
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas para eliminar.");
                    }
                    else
                    {
                        Mostrar(tareas);
                        numero = LeerEnRango($"Ingrese el número de la tarea a eliminar (1-{tareas.Count}): ", 1, tareas.Count);
                        eliminada = tareas[numero - 1];
                        tareas.RemoveAt(numero - 1); // La tarea número 1 está en la posición 0
                        Console.WriteLine($"Se eliminó la tarea: {eliminada}");
                    }
                    break;
                case 4:
                    Console.WriteLine($"Total de tareas pendientes: {tareas.Count}");
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

    // Muestra las tareas numeradas empezando en 1
    private void Mostrar(List<string> tareas)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas pendientes.");
            return; // Sale del método
        }

        Console.WriteLine("Tareas pendientes:");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
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
