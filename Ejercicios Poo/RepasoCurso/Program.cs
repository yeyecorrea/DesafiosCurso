using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Reflection.PortableExecutable;
using System;
using System.Collections;
using System.Collections.Generic;

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

            // ArrayList
            // los array list pueden ser de varios tipos de datos
            ArrayList miArrayList = new ArrayList();
            miArrayList.Add(5);
            miArrayList.Add("texto");
            miArrayList.Add(5.8);
            miArrayList.Add(true);

            // foma de recorrer un arraylist
            // ya que un arraylist contiene varios tipo de datos
            foreach (object x in miArrayList)
            {
                if (x is int)
                {
                    Console.WriteLine($"es un entero {x}");
                }
                if (x is string)
                {
                    Console.WriteLine($"es un string {x}");
                }
                
            }

            //Listas, las listasn son una clase entonces para poder empezar a agg obj se necesita instanciar
            // para usar listas de un solo tipo se usa el namespace Sytem.Colletions.Gener

            var numerosList = new List<int>();


            // Diferencia entre Array, ArrayLis y List

            //Array: Inmutable y limitado a 1 solo tipo de dato
            int[]Array = new int[]{4,3,2,1};

            //ArrayList: Es mutable y puede contener varios tipos de datos
            ArrayList arrayList = new ArrayList(){4,5,3,"nombre",true};

            


        }

        // ejemplo de cracion de un metodo destructor
        ~Program()
        {

        }
    }

    // INTERFACES

    // las interfaces son un contrato para una clase
    // que se le obliga a tener ciertos propiedades y metodos
    public interface IName
    {
        // metodo vacio
        void MostrarAlgo();
        // metodo que retorna un string
        string MostrarTexto();
    }

    // CLASE QUE IMPLEMENTA UNA INTERFAZ
    class ImplementacionInterfaz : IName
    {
        // metodos que se implementaron en la interfaz
        public void MostrarAlgo(){}

        public string MostrarTexto()
        {
            return null;
        }
    }


    // ENUMS

    // los enums son un tipo de array de constantes, son inmutables y se declaran al principio del namespace
    enum Dias { Lu, Ma, Mi, Ju, Vi }

    class EnumsExamples
    {
        Dia lunes = Dia.Lu;
        Dia = viernes Dia.Vi;
    }

    // para permitir null se usa ? int? num1 = null
    // para hacer una especie de verificacion se usa ?? int num1 = num2 ?? 80 -> si num2 es nulo el valor de num1 va se 80
}
