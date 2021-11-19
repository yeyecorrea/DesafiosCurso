using System;

namespace Desafio5
{
    public class Pasante:Empleado
    {
        private int HorasDeTrabajo { get; set; }
        private int HorasDeEscuela { get; set; }

        public Pasante()
        {
            HorasDeEscuela = 0;
            HorasDeTrabajo = 0;
        }

        public Pasante(int horasDeTrabajo, int horasDeEscuela, string nombre, string apellido, int salario):base(nombre,apellido,salario)
        {
            this.HorasDeTrabajo = horasDeTrabajo;
            this.HorasDeEscuela = horasDeEscuela;
        }

        public void  Aprender(){ Console.WriteLine("Estoy aprendiendo durante X cantidad de horas"); }

        public void Trabajar()
        {
            Console.WriteLine($"Horas tabajadas: {this.HorasDeTrabajo}");
        }

    }
}