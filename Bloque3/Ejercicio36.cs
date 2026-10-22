namespace TareaProgra1;
public class Ejercicio36
{
    public void Ejecutar()
    {
        double resultado = LeerNumero("Ingrese el número inicial: ");
        int opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("----- Calculadora -----");
            Console.WriteLine($"Resultado actual: {resultado}");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Porcentaje");
            Console.WriteLine("8. Cambiar el valor actual");
            Console.WriteLine("9. Salir");
            opcion = LeerEntero("Elija una opción: ");

            double numero;

            switch (opcion)
            {
                case 1:
                    numero = LeerNumero("Ingrese el número a sumar: ");
                    resultado = resultado + numero;
                    break;
                case 2:
                    numero = LeerNumero("Ingrese el número a restar: ");
                    resultado = resultado - numero;
                    break;
                case 3:
                    numero = LeerNumero("Ingrese el número por el que multiplica: ");
                    resultado = resultado * numero;
                    break;
                case 4:
                    numero = LeerNumero("Ingrese el número por el que divide: ");
                    if (numero == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    }
                    else
                    {
                        resultado = resultado / numero;
                    }
                    break;
                case 5:
                    numero = LeerNumero("Ingrese el exponente: ");
                    resultado = Math.Pow(resultado, numero);
                    break;
                case 6:
                    if (resultado < 0)
                    {
                        Console.WriteLine("Error: no se puede calcular la raíz de un número negativo.");
                    }
                    else
                    {
                        resultado = Math.Sqrt(resultado);
                    }
                    break;
                case 7:
                    numero = LeerNumero("Ingrese el porcentaje a calcular: ");
                    resultado = resultado * numero / 100;
                    break;
                case 8:
                    resultado = LeerNumero("Ingrese el nuevo valor: ");
                    break;
                case 9:
                    Console.WriteLine($"Resultado final: {resultado}");
                    Console.WriteLine("Hasta luego");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        } while (opcion != 9);
    }

    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }
}
