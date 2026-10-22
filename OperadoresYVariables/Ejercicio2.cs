namespace TareaProgra1;

// Ejercicio 2. Calculadora de IMC
public class Ejercicio2
{
    public void Ejecutar()
    {
        double peso = LeerPositivo("Ingrese su peso en kg: ");
        double altura = LeerPositivo("Ingrese su altura en metros (ejemplo 1.70): ");
        double imc = peso / (altura * altura);
        string categoria;

        if (imc < 18.5)
        {
            categoria = "Bajo peso";
        }
        else if (imc < 25)
        {
            categoria = "Normal";
        }
        else if (imc < 30)
        {
            categoria = "Sobrepeso";
        }
        else
        {
            categoria = "Obesidad";
        }

        Console.WriteLine($"Su IMC es: {imc:F2}");
        Console.WriteLine($"Categoría: {categoria}");
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
