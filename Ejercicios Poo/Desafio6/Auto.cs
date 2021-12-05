using System;

namespace Desafio6
{
    public class Auto
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"El HP: {this.HP}, Color: {this.Color}");
        }

        // Al ser virtual puede o no sobrescribir el metodo
        public virtual void Reparar()
        {
            Console.WriteLine("Auto reparado");
        }


    }
}