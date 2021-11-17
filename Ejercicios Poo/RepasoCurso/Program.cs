using System;

namespace RepasoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // finalizador/destructor ~ + nameClass()
            // limpia declaraciones de obj de las clases

            // Arrays

            string[]name = {"Juan", "Andres"};

            int[]number = new int[5];

            string[]lastName = new string[] {"correa", "soto"};

            // Arrays Multi-dimensionales

            // la coma , dice cuantas dimensiones va a tener ejemplo int[,,]numeros = new int[,,]
            // [filas,columnas]

            string[,]names2D = new string[,] 
            {
                {"Raul", "Jorge", "Ramiro"},
                {"Lucio", "Danilo", "Carlos"},
                {"Natalia", "Patricia", "Aracelly"}

            };

            // Arrays irregulares
            // es un Array con tres adentro
            int[][]num = new int[3][];
            // cada num[0] contendra un array de nelementos
            num[0] = new int[5];
            num[1] = new int[2];
            num[2]= new int[1];
        }

        // ejemplo de cracion de un metodo destructor
        ~Program()
        {

        }
    }
}
