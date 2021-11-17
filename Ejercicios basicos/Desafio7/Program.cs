using System;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            string mensajeTemperatura;
            string temperaturaIngresada;

            Console.WriteLine("Ingrese la temperatura actual: ");
            temperaturaIngresada = Console.ReadLine();

            bool validationParsing = int.TryParse(temperaturaIngresada, out temperatura);
            
            if (validationParsing)
            {
                mensajeTemperatura = temperatura <= 15 ? "hace mucho frio" : (temperatura >= 16 && temperatura <= 28) ? "hace un clima agradable" : temperatura > 28 ? "hace mucho calor" : "";
            }
        }
    }
}
