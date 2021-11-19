using System;
using System.Threading;

namespace Desafio4
{
    public class PublicacionVideo : Publicacion
    {

        protected bool seReproduce = false;
        protected int duracionActual = 0;
        Timer relog;

        public string UrlVideo { get; set; }
        public double Duracion { get; set; }

        public PublicacionVideo() { }
        public PublicacionVideo(string titulo, string autor, bool espublico, string urlvideo, double duracion)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.FechaCreacion = DateTime.Now;
            this.UrlVideo = urlvideo;
            this.Duracion = duracion;
        }

        // Metodo que sobre escribe el metodo ToString() de la clase Object
        public override string ToString()
        {
            return String.Format(@$"
            {this.ID} - {this.Titulo}
            {this.ContenidoPost}
            {this.UrlVideo} Duracion :{this.Duracion} min
            Creado por: {this.Autor} {this.FechaCreacion} ");
        }

        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo");
                relog = new Timer(Reproduccion, null, 0, 1000);
            }
        }
        public void Stop()
        {
            if (seReproduce)
            {
                Console.WriteLine($"\nDetenido en {duracionActual}");
                duracionActual = 0;
                relog.Dispose();
            }
        }

        private void Reproduccion(Object o)
        {
            if (duracionActual < Duracion)
            {
                seReproduce = false;
                duracionActual++;
                Console.WriteLine($"Video en {duracionActual}");
                GC.Collect();
            }
            else
            {
                Stop();
            }

        }

    }
}