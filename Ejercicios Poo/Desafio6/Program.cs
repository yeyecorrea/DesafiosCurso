using System.Collections.Generic;
using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>
            {
                new BMW("2021", 55, "Rojo"),
                new Audi("2022", 45, "Verde")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }

            Auto auto1 = new BMW ("2017", 56, "Negro");
            auto1.MostrarDetalles();

            Auto auto2 = new BMW ("2018", 48, "Gris");
            auto2.MostrarDetalles();

            // casteando un objecto a la clase base
            Auto autoBase = (Auto)auto2;

            /*
            Nota: la palabra clave sealed, es una palabra clave que encapsula la sobrescripcion
            de metodos en c#, solo se puede celdar los metodos overrider que son los que se sobrescriben
            no se pueden celdar los metodos virtuales
            tambien puede encapsular las clases para evitar la herencia
            */
            
        }
    }
}
