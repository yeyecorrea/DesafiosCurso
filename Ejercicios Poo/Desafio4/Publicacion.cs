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
        protected DateTime fechaCreacion { get; set;}
        public string contenidoPost { get; set; }

        public Publicacion(string titulo = "Mi primera publicacion", string autor = "Anonimus", bool espublico = true, string contenidoPost = "...")
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.fechaCreacion = FechaCreacion();
            this.contenidoPost = contenidoPost;
        }

        // Metodo para aumentar el ID cada vez que se instancia un objeto
        protected int CrearID()
        {
            return ++publicacionID;
        }

        // Metodo que crea la fechas de creacion
        protected DateTime FechaCreacion()
        {
           return fechaCreacion = DateTime.Now;
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
            {this.contenidoPost}
            Creado por: {this.Autor} {this.fechaCreacion} ");
        }
    }
}