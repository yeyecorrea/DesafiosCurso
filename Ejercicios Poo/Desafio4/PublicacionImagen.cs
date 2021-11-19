using System;
namespace Desafio4
{
    public class PublicacionImagen : Publicacion
    {
        public string UrlImagen { get; set; }

        public PublicacionImagen(){}

        public PublicacionImagen(string titulo, string autor, bool espublico, string urlimagen)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.EsPublico = espublico;
            this.FechaCreacion = DateTime.Now;
            this.UrlImagen = urlimagen;
        }

        
        // Metodo que sobre escribe el metodo ToString() de la clase Object
        public override string ToString()
        {
            return String.Format(@$"
            {this.ID} - {this.Titulo}
            {this.ContenidoPost}
            {this.UrlImagen}
            Creado por: {this.Autor} {this.FechaCreacion} ");
        }

    }
}