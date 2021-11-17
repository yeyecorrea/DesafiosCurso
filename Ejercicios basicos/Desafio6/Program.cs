using System;

namespace Desafio6
{
    class Program
    {
        static string nameUser = "Nanatsu";
        static int points = 5000;
        static void Main(string[] args)
        {
            PointsUser("yeferson",5000);
        }

        static void PointsUser(string user, int points)
        {
            if (points > Program.points)
            {
                Console.WriteLine($"La nueva puntuación más alta es: {points}");
                Console.WriteLine($"La puntuación más alta fue lograda por: {user}");
            }
            if (points == Program.points)
            {
                Console.WriteLine($"Las puntuaciones son igulaes: user: {user} : {points} y user: {Program.nameUser} : {Program.points}");
            }
            else
            {
                Console.WriteLine($"La puntuación más alta es: {Program.points}");
                Console.WriteLine($"La puntuación más alta sigue siendo lograda por: {Program.nameUser}");
            }

        }
    }
}
