using System;

namespace Desafio6
{
    public class BMW : Auto
    {
        public string Modelo { get; set; }
        string marca = "Mercedez";
        public BMW(string modelo, int hp, string color) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        public  void MostrarDetalles()
        {
            Console.WriteLine($"El HP: {this.HP}, Color: {this.Color}, Marca: {marca}, Modelo: {this.Modelo}");
        }
        public override void Reparar()
        {
            Console.WriteLine($"El Auto {marca} reparado");
        }
    }
}