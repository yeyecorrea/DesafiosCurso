using System;

namespace aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine($"Hola tu nombre es: {nombre} {apellido}");
        }
    }
}
