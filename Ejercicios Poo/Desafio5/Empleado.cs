using System;
namespace Desafio5
{
    public class Empleado
    {
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected int Salario { get; set; }

        public Empleado(){}

        public Empleado(string nombre, string apellido, int salario)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
        }
        public void Trabajar(){ Console.WriteLine("Estoy trabajando"); }

        public void Descansar(){ Console.WriteLine("Estoy descansando"); }
    }
}