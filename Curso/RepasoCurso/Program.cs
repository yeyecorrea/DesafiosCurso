using System;

namespace RepasoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS DE DATOS
            /*
            int
            log
            bool
            string
            float
            double
            char
            */

            // ESTANDARES DE PROGRAMACION
            /*
            Clases: deben tener la notacion Pascal, NombreClass
            Metodos: deben teenr la notancion Pascal, NombreMethod
            Propiedades: deben tener la notacion camelCase, nombrePropiedad
            Costantes: deben tener la notacion Pascal, NombreConstante
            */

            // TIPOS DE CONVERSION

            // conversion explicita de mayo a menor de los mismos tipos de datos
            double temperatura = 70.5;
            int temperaturaMadrid;
            temperaturaMadrid = (int)temperatura;

            // conversion implicita de menor a mayor de los mismos tipos de datos
            int habitantesCiudad2010 = 10000000;
            long habitantesCiudad2018 = habitantesCiudad2010;

            // conversion de tipos no compatibles
            string edadString = "22";
            int edad = int.Parse(edadString);

            string pesoString = "70.5";
            double peso = Convert.ToDouble(pesoString);

            // OPERADORES

            // --: restar
            // ++: adiccion
            // !: cambia la exprexion
            // !=: diferente 
            // &&: y
            // ||: o

            // METODO TryParse

            // devule true si el parseo es posible, false si no es posible

        }
    }
}
