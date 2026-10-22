namespace TareaProgra1;

// Ejercicio 4. Área y perímetro
public class Ejercicio4
{
    public void Ejecutar()
    {
        Console.WriteLine("----- Área y perímetro -----");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Triángulo");
        Console.WriteLine("3. Rectángulo");
        Console.WriteLine("4. Trapecio");
        int opcion = LeerEntero("Elija una opción: ");

        switch (opcion)
        {
            case 1:
                Circulo();
                break;
            case 2:
                Triangulo();
                break;
            case 3:
                Rectangulo();
                break;
            case 4:
                Trapecio();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    private void Circulo()
    {
        double radio = LeerPositivo("Ingrese el radio: ");

        double area = Math.PI * radio * radio;
        double perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Área del círculo: {area:F2}");
        Console.WriteLine($"Perímetro del círculo: {perimetro:F2}");
    }

    private void Triangulo()
    {
        double baseTriangulo = LeerPositivo("Ingrese la base: ");
        double altura = LeerPositivo("Ingrese la altura: ");
        double lado2 = LeerPositivo("Ingrese el segundo lado: ");
        double lado3 = LeerPositivo("Ingrese el tercer lado: ");

        double area = (baseTriangulo * altura) / 2;
        double perimetro = baseTriangulo + lado2 + lado3;

        Console.WriteLine($"Área del triángulo: {area:F2}");
        Console.WriteLine($"Perímetro del triángulo: {perimetro:F2}");
    }

    private void Rectangulo()
    {
        double baseRectangulo = LeerPositivo("Ingrese la base: ");
        double altura = LeerPositivo("Ingrese la altura: ");

        double area = baseRectangulo * altura;
        double perimetro = 2 * (baseRectangulo + altura);

        Console.WriteLine($"Área del rectángulo: {area:F2}");
        Console.WriteLine($"Perímetro del rectángulo: {perimetro:F2}");
    }

    private void Trapecio()
    {
        double baseMayor = LeerPositivo("Ingrese la base mayor: ");
        double baseMenor = LeerPositivo("Ingrese la base menor: ");
        double altura = LeerPositivo("Ingrese la altura: ");
        double lado1 = LeerPositivo("Ingrese el primer lado no paralelo: ");
        double lado2 = LeerPositivo("Ingrese el segundo lado no paralelo: ");

        double area = ((baseMayor + baseMenor) * altura) / 2;
        double perimetro = baseMayor + baseMenor + lado1 + lado2;

        Console.WriteLine($"Área del trapecio: {area:F2}");
        Console.WriteLine($"Perímetro del trapecio: {perimetro:F2}");
    }

    
    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
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
