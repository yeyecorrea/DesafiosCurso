using System;

namespace Desafio5
{
    public class Home
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Yeferson", "Correa", 2000000);
            Console.WriteLine(empleado1);
            Jefe jefe1 = new Jefe("Audi","Martin","Gimenez",5000000);
            jefe1.Dirigir();
            Pasante pasante1 = new Pasante(240, 300, "Guillermo", "Diaz", 500000);
            pasante1.Trabajar();
        }

    }
}