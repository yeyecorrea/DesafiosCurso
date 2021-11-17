using System;

namespace aplicacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un texto: ");
            string text = Console.ReadLine();

            Console.WriteLine("Ingresa caracter a buscar en el texto ingresado: ");
            string letra = Console.ReadLine();

            int result = text.IndexOf(letra);
            try
            {
               Console.WriteLine($"el resultado de la busqueda es: {text[result]}");  
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"La letra {letra} que estas buscando no existe en el texto");
            }
        }
    }
}
