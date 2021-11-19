using System;

namespace Desafio5
{
    public class Jefe:Empleado
    {
        private string AutoDeEmpresa { get; set; }

        public Jefe()
        {
            AutoDeEmpresa = "Mercedez";
        }

        public Jefe(string autoEmpresa, string nombre, string apellido, int salario):base(nombre, apellido, salario)
        {
            this.AutoDeEmpresa = autoEmpresa;
        }

        public void Dirigir()
        {
            Console.WriteLine("Soy el jefe");
        }
    }
}