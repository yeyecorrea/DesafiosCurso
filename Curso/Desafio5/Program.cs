using System;

namespace Desafio5
{
    class Program
    {
        static string name = "Admin";
        static string password = "123456789y";
        static void Main(string[] args)
        {
            StateAcoount();
            RegisterUser();

        }
        static bool StateAcoount()
        {
            Console.WriteLine("Ingresa el estado de tu cunta True: si esta activa y False: si esta desactivada");
            bool state = Convert.ToBoolean(Console.ReadLine());
            return state;
        }

        static void RegisterUser()
        {
            var stado = StateAcoount();
            if (stado == false)
            {
                Console.WriteLine("Ingresa nombre usuario: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa contraseña: ");
                string contra = Console.ReadLine();

                Console.WriteLine($"Bienvenido {nombre}, has sido registrado correctamente");
            }
            else
            {
                IniciarSesion();
            }
        }

        static void IniciarSesion()
        {
            Console.WriteLine("Ingresa nombre usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa contraseña: ");
            string contra = Console.ReadLine();

            if (nombre == Program.name && contra == Program.password)
            {
                Console.WriteLine($"Bienvenido nuevamente {Program.name}");
            }
            else
            {
                Console.WriteLine($"El usuario o contraseñas incorrectas");
            }
        }
    }
}