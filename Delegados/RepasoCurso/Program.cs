using System;

namespace RepasoCurso
{
    class Program
    {
        /*
        Los delegados se utilizan para pasar métodos como argumentos a otros métodos. 
        Los controladores de eventos no son más que métodos que se invocan a través de delegados
        */

        // creacion de un delegado
        public delegate double HacerAccion(double x, double y);

        static void Main(string[] args)
        {
            // instanciar un delegado
            HacerAccion miSuma = Suma;
            miSuma(5.0, 5.0);
        }

        public static double Suma(double a, double b)
        {
            return a + b;
        }
    }
}
