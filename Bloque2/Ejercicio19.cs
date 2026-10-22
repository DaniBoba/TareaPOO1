namespace TareaProgra1;

// Ejercicio 19. Clasificación de triángulos
public class Ejercicio19
{
    public void Ejecutar()
    {
        double lado1 = LeerPositivo("Ingrese el primer lado: ");
        double lado2 = LeerPositivo("Ingrese el segundo lado: ");
        double lado3 = LeerPositivo("Ingrese el tercer lado: ");

       
        bool esValido = lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;

        if (!esValido)
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo válido.");
            return; 
        }
        string porLados;

        if (lado1 == lado2 && lado2 == lado3)
        {
            porLados = "Equilátero";
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            porLados = "Isósceles";
        }
        else
        {
            porLados = "Escaleno";
        }
        double mayor;
        double otro1;
        double otro2;

        if (lado1 >= lado2 && lado1 >= lado3)
        {
            mayor = lado1;
            otro1 = lado2;
            otro2 = lado3;
        }
        else if (lado2 >= lado1 && lado2 >= lado3)
        {
            mayor = lado2;
            otro1 = lado1;
            otro2 = lado3;
        }
        else
        {
            mayor = lado3;
            otro1 = lado1;
            otro2 = lado2;
        }

        double diferencia = (mayor * mayor) - (otro1 * otro1 + otro2 * otro2);
        string porAngulos;

        if (Math.Abs(diferencia) < 0.0001)
        {
            porAngulos = "Rectángulo";
        }
        else if (diferencia < 0)
        {
            porAngulos = "Acutángulo";
        }
        else
        {
            porAngulos = "Obtusángulo";
        }

        Console.WriteLine($"Por sus lados: {porLados}");
        Console.WriteLine($"Por sus ángulos: {porAngulos}");
    }

    private double LeerNumero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return double.TryParse(Console.ReadLine(), out double n) ? n : 0;
    }

    private double LeerPositivo(string mensaje)
    {
        double valor;
        do
        {
            valor = LeerNumero(mensaje);
            if (valor <= 0)
            {
                Console.WriteLine("El valor debe ser un número positivo, intente de nuevo.");
            }
        } while (valor <= 0);

        return valor;
    }
}
