using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = "";
            int notaEstudianta;
            string notaIngresada;
            int contador = 0;
            int sumNota = 0;
            int promedioNota;
            int mensajeParsing;

            while (final != "terminar")
            {
                Console.WriteLine("Ingresa nota estudiante: ");
                notaIngresada = Console.ReadLine();
                final = notaIngresada;
                
                bool verificarParsing = int.TryParse(notaIngresada, out notaEstudianta);
                if (verificarParsing)
                {
                    sumNota += notaEstudianta;
                    contador += 1;
                }
                else if (final == "fin")
                {
                    promedioNota = sumNota / contador;
                    Console.WriteLine($"Promedio de estudiante es: {promedioNota}");
                }
                else{ Console.WriteLine("Tipo de dato no admitido"); }
    
            }
        }
    }
}
