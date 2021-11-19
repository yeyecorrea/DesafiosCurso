using System;
namespace Desafio4
{
    public class Publicacion
    {
        private static int publicacionID;
        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool EsPublico { get; set; }
        protected DateTime FechaCreacion { get; set;}
        protected string ContenidoPost { get; set; }

        public Publicacion()
        {
            ID = CrearID();
            Titulo = "Mi primera publicacion";
            Autor = "Anonimos";
            EsPublico = true;
            ContenidoPost = "...";
            FechaCreacion = DateTime.Now;
        }

        public Publicacion(string titulo, string autor, bool espublico, string contenidoPost)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.FechaCreacion = DateTime.Now;
            this.ContenidoPost = contenidoPost;
        }

        // Metodo para aumentar el ID cada vez que se instancia un objeto
        protected int CrearID()
        {
            return ++publicacionID;
        }
        // Metodo para editar una publicacion
        public void Editar(string titulo, bool esPublico)
        {
            this.Titulo = titulo;
            this.EsPublico = esPublico;
        }

        // Metodo que sobre escribe el metodo ToString() de la clase Object
        public override string ToString()
        {
            return String.Format(@$"
            {this.ID} - {this.Titulo}
            {this.ContenidoPost}
            Creado por: {this.Autor} {this.FechaCreacion} ");
        }
    }
}