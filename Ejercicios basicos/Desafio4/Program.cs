using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero a dividir: ");
            int numero = int.Parse(Console.ReadLine());
            try
            {
                int operacion = numero / 0;  
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"No se puede dividir {numero} x 0");
            }
            
        }
    }
}
