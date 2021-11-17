using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Ingresa tu nombre: ");
            name = Console.ReadLine();

            Console.WriteLine($"Tu nombre en mayuscula: {name.ToUpper()}");
            Console.WriteLine($"Tu nombre en minusculas: {name.ToLower()}");
            Console.WriteLine($"Tu nombre sin espacios: {name.Trim()}");
            Console.WriteLine($"Primeras letras de tu nombre: {name.Substring(0,2)}");
        }
    }
}