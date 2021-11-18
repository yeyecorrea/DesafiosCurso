using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]clientes = new int[] {200, 300, 400};
            Creditos(clientes);

            foreach (var i in clientes)
            {
                Console.WriteLine($"El estado actual de las cuentas: {i}");
            }
        }

        public static void Creditos(int[] saldos)
        {
            int aumento = 200;
            for (int i = 0; i < saldos.Length; i++)
            {
                saldos[i] += aumento;
            }
        }
    }
}
