namespace TareaProgra1;

// Ejercicio 50. Registro de estudiantes (listas paralelas)
public class Ejercicio50
{
    public void Ejecutar()
    {
        // Listas paralelas: el estudiante en la posición 0 de nombres
        // tiene su promedio en la posición 0 de promedios
        List<string> nombres = new List<string>();
        List<double> promedios = new List<double>();

        int opcion;
        string nombre;
        double promedio;
        int posicion;
        double mejor;

        do
        {
            Console.WriteLine();
            Console.WriteLine("----- Registro de estudiantes -----");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Buscar por nombre");
            Console.WriteLine("3. Mostrar el estudiante con mejor promedio");
            Console.WriteLine("4. Listado general");
            Console.WriteLine("5. Salir");
            opcion = LeerEntero("Elija una opción: ");

            switch (opcion)
            {
                case 1:
                    nombre = LeerTexto("Ingrese el nombre del estudiante: ");

                    if (nombres.Contains(nombre))
                    {
                        Console.WriteLine($"El estudiante {nombre} ya está registrado.");
                    }
                    else
                    {
                        promedio = LeerEnRango("Ingrese el promedio (0-100): ", 0, 100);

                        // Se agrega a las dos listas para que queden en la misma posición
                        nombres.Add(nombre);
                        promedios.Add(promedio);
                        Console.WriteLine($"Se registró a {nombre}");
                    }
                    break;
                case 2:
                    nombre = LeerTexto("Ingrese el nombre que desea buscar: ");

                    if (nombres.Contains(nombre))
                    {
                        posicion = nombres.IndexOf(nombre);
                        Console.WriteLine($"Estudiante: {nombres[posicion]}");
                        Console.WriteLine($"Promedio: {promedios[posicion]:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"El estudiante {nombre} no está registrado.");
                    }
                    break;
                case 3:
                    if (nombres.Count == 0)
                    {
                        Console.WriteLine("No hay estudiantes registrados.");
                    }
                    else
                    {
                        // Primero se busca el promedio más alto
                        mejor = promedios[0];
                        for (int i = 1; i < promedios.Count; i++)
                        {
                            if (promedios[i] > mejor)
                            {
                                mejor = promedios[i];
                            }
                        }

                        // Luego se muestran todos los que lo tengan (por si hay empate)
                        Console.WriteLine($"Mejor promedio: {mejor:F2}");
                        for (int i = 0; i < promedios.Count; i++)
                        {
                            if (promedios[i] == mejor)
                            {
                                Console.WriteLine($"- {nombres[i]}");
                            }
                        }
                    }
                    break;
                case 4:
                    if (nombres.Count == 0)
                    {
                        Console.WriteLine("No hay estudiantes registrados.");
                    }
                    else
                    {
                        Console.WriteLine("Listado general:");
                        for (int i = 0; i < nombres.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {nombres[i]} - Promedio: {promedios[i]:F2}");
                        }
                        Console.WriteLine($"Total de estudiantes: {nombres.Count}");
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

    // Pide un número decimal. Si no es válido devuelve 0
    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }

    // Pide un número entero. Si no es válido devuelve 0
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }

    // Pide un número y repite la pregunta hasta que esté entre el mínimo y el máximo
    private double LeerEnRango(string mensaje, double minimo, double maximo)
    {
        double valor;
        do
        {
            valor = LeerNumero(mensaje);
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
