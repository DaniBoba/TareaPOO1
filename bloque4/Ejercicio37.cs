namespace TareaProgra1;

// Ejercicio 37. Registro de números
public class Ejercicio37
{
    public void Ejecutar()
    {
        int n = LeerEnteroPositivo("¿Cuántos números desea ingresar?: ");
        int[] numeros = new int[n];

     
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = LeerEntero($"Ingrese el número {i + 1}: ");
        }

    
        long suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            suma = suma + numeros[i];
        }
        double promedio = (double)suma / numeros.Length;

        int mayor = numeros[0];
        int menor = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }

            if (numero < menor)
            {
                menor = numero;
            }
        }

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Valor mayor: {mayor}");
        Console.WriteLine($"Valor menor: {menor}");
    }

    private int LeerEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.TryParse(Console.ReadLine(), out int n) ? n : 0;
    }

    
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
