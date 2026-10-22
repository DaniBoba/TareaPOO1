namespace TareaProgra1;

// Ejercicio 34. Validación de contraseña
public class Ejercicio34
{
    public void Ejecutar()
    {
        bool esValida;

        do
        {
            Console.WriteLine("Ingrese una contraseña: ");
            string contrasena = Console.ReadLine() ?? "";

            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;


            foreach (char c in contrasena)
            {
                if (char.IsUpper(c))
                {
                    tieneMayuscula = true;
                }
                else if (char.IsLower(c))
                {
                    tieneMinuscula = true;
                }
                else if (char.IsDigit(c))
                {
                    tieneNumero = true;
                }
                else
                {
                    tieneEspecial = true; 
                }
            }

            bool tieneLargo = contrasena.Length >= 8;

            esValida = tieneLargo && tieneMayuscula && tieneMinuscula && tieneNumero && tieneEspecial;

            if (!esValida)
            {
                Console.WriteLine("La contraseña no es válida. Le falta:");

                if (!tieneLargo)
                {
                    Console.WriteLine("- Mínimo 8 caracteres");
                }

                if (!tieneMayuscula)
                {
                    Console.WriteLine("- Al menos una letra mayúscula");
                }

                if (!tieneMinuscula)
                {
                    Console.WriteLine("- Al menos una letra minúscula");
                }

                if (!tieneNumero)
                {
                    Console.WriteLine("- Al menos un número");
                }

                if (!tieneEspecial)
                {
                    Console.WriteLine("- Al menos un carácter especial (por ejemplo ! @ # $ %)");
                }
            }
        } while (!esValida);

        Console.WriteLine("¡Contraseña válida!");
    }
}
