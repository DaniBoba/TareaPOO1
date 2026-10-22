namespace TareaProgra1;

// Ejercicio 15. Vocal o consonante
public class Ejercicio15
{
    public void Ejecutar()
    {
        Console.WriteLine("Ingrese una letra: ");
        string texto = Console.ReadLine() ?? ""; 

       
        if (texto.Length != 1 || !char.IsLetter(texto[0]))
        {
            Console.WriteLine("Debe ingresar una sola letra (sin números ni símbolos).");
            return; 
        }

        char letra = char.ToLower(texto[0]);

        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'á':
            case 'é':
            case 'í':
            case 'ó':
            case 'ú':
            case 'ü':
                Console.WriteLine($"La letra {texto} es una vocal");
                break;
            default:
                Console.WriteLine($"La letra {texto} es una consonante");
                break;
        }
    }
}
